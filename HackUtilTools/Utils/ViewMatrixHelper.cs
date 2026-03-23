using HackUtilTools.DTO;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;

namespace UtilCrackTools.Utils
{
    public static class ViewMatrixHelper
    {
        public enum Corner
        {
            LeftDown = 0,
            LeftUp = 1,
            RightUp = 2,
            RightDown = 3
        }

        private static double[] WorldToScreenPoint(Vector<double> worldPoint, Matrix<double> viewMatrix, int screenWidth, int screenHeight)
        {
            // Создаем вектор с дополнительной 1
            var extended_point = Vector<double>.Build.Dense(new double[] {
                worldPoint[0], worldPoint[1], worldPoint[2], 1
            });

            // Умножаем матрицу на вектор
            var clipPoint = viewMatrix * extended_point;

            // Проверяем на близость к нулю
            if (Math.Abs(clipPoint[3]) < 1e-6)
            {
                return new double[] { 0.0, 0.0, 0.0 };
            }
            else
            {
                double inv_w = 1.0 / clipPoint[3];
                double screen_x = (clipPoint[0] * inv_w + 1.0) * 0.5 * screenWidth;
                double screen_y = (clipPoint[1] * inv_w + 1.0) * 0.5 * screenHeight;

                return new double[] { screen_x, screen_y, clipPoint[2] };
            }
        }

        private static bool CalculateCorner(double x, double y, int range, int screenWidth, int screenHeight, double[] resultWTS, string[] searchWindow,
                                            out string correctWindow, out string[] result)
        {
            correctWindow = String.Empty;
            result = null;

            if ((x > screenWidth - range && x < screenWidth + range && y > screenHeight - range && y < screenHeight + range) && x != 0 && y != 0)
            {
                correctWindow = String.Join(" ", searchWindow);
                result = new string[] { resultWTS[0].ToString("F4"), resultWTS[1].ToString("F4"), resultWTS[2].ToString("F4") };

                return true;
            }

            return false;
        }

        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x1 - x2;
            double dy = y1 - y2;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private static int GetMatrixLength(int left, int right)
        {
            return left * right;
        }

        private static string[] ParseMemoryArea(string memoryArea)
        {
            return memoryArea.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static IEnumerable<string[]> ExtractWindows(string[] memoryAreaParts, int windowSize)
        {
            for (int i = 0; i <= memoryAreaParts.Length - windowSize; i++)
            {
                string[] window = new string[windowSize];
                Array.Copy(memoryAreaParts, i, window, 0, windowSize);
                yield return window;
            }
        }
        private static (Matrix<double> Matrix, Vector<double> Vector) ParseMatrixAndVector(string[] window, string vectorString)
        {
            double[] matrixValues = Array.ConvertAll(window, double.Parse);
            double[] vectorValues = Array.ConvertAll(vectorString.Split(' '), double.Parse);

            var matrix = Matrix<double>.Build.DenseOfRowMajor(4, 4, matrixValues);
            var vector = Vector<double>.Build.Dense(vectorValues);

            return (matrix, vector);
        }
        private static ScreenPoints CalculateScreenPoints(Matrix<double> matrix, Vector<double> vector, int screenWidth, int screenHeight)
        {
            return new ScreenPoints
            {
                Default = WorldToScreenPoint(vector, matrix, screenWidth, screenHeight),
                Transposed = WorldToScreenPoint(vector, matrix.Transpose(), screenWidth, screenHeight)
            };
        }

        private static CornerPoint GetCornerPoint(Corner corner, int screenWidth, int screenHeight)
        {
            switch (corner)
            {
                case Corner.LeftDown:
                    return new CornerPoint { X = 0, Y = 0 };
                case Corner.LeftUp:
                    return new CornerPoint { X = 0, Y = screenHeight };
                case Corner.RightUp:
                    return new CornerPoint { X = screenWidth, Y = screenHeight };
                case Corner.RightDown:
                    return new CornerPoint { X = screenWidth, Y = 0 };
                default:
                    throw new ArgumentException($"Unknown corner: {corner}");
            }
        }
        private static void UpdateNearestPoint(WindowSearchContext context, double distance, double[] screenPoint)
        {
            if (distance < context.CurrentMinDistance)
            {
                context.CurrentMinDistance = distance;

                context.NearestPoint = new[]
                {
                    screenPoint[0].ToString("F2"),
                    screenPoint[1].ToString("F2")
                };
            }
        }

        private static WindowProcessResult CheckAndProcessScreenPoint(string[] currentWindow, double[] screenPoint, int screenWidth, int screenHeight, Corner corner,
                                                                      WindowSearchContext context, ScreenPoints screenPoints, InspectResult resultType)
        {
            double x = screenPoint[0];
            double y = screenPoint[1];

            var cornerPoint = GetCornerPoint(corner, screenWidth, screenHeight);

            bool isCorrectWindow = CalculateCorner(
                x, y,
                context.MaxSearchRange,
                cornerPoint.X, cornerPoint.Y,
                screenPoint,
                currentWindow,
                out string correctWindow,
                out string[] result);

            double distance = CalculateDistance(x, y, cornerPoint.X, cornerPoint.Y);

            UpdateNearestPoint(context, distance, screenPoint);

            var processResult = new WindowProcessResult
            {
                IsWindowFound = isCorrectWindow,
                Result = isCorrectWindow ? CreateResult(correctWindow, resultType, result, context.NearestPoint, screenPoints) : null,
                ScreenPoints = screenPoints
            };

            return processResult;
        }

        private static WindowProcessResult ProcessWindow(string[] currentWindow, string vectorString, int screenWidth, int screenHeight,
                                                         Corner corner, WindowSearchContext context)
        {
            var (matrix, vector) = ParseMatrixAndVector(currentWindow, vectorString);
            var screenPoints = CalculateScreenPoints(matrix, vector, screenWidth, screenHeight);

            // Проверка Default результата
            var defaultCheck = CheckAndProcessScreenPoint(
                currentWindow,
                screenPoints.Default,
                screenWidth,
                screenHeight,
                corner,
                context,
                screenPoints, new InspectResult { Type = InspectResult.ResultType.Default, Text = "Default" });

            if (defaultCheck.IsWindowFound)
                return defaultCheck;

            // Проверка Transposed результата
            var transposedCheck = CheckAndProcessScreenPoint(
                currentWindow,
                screenPoints.Transposed,
                screenWidth,
                screenHeight,
                corner,
                context,
                screenPoints, new InspectResult { Type = InspectResult.ResultType.Default, Text = "Transposed" });

            return transposedCheck;
        }

        private static MatrixInspectionResult CreateResult(string correctWindow, InspectResult resultType, string[] result, string[] nearestResult, ScreenPoints screenPoints)
        {
            return new MatrixInspectionResult
            {
                CorrectWindow = correctWindow,
                ResultType = resultType,
                Result = result,
                NvResultDef = new[]
                {
                    screenPoints.Default[0].ToString("F2"),
                    screenPoints.Default[1].ToString("F2")
                },
                NvResultTr = new[]
                {
                    screenPoints.Transposed[0].ToString("F2"),
                    screenPoints.Transposed[1].ToString("F2")
                },
                NvResultNearest = new[]
                {
                    string.Format("{0:F2}", nearestResult[0]),
                    string.Format("{0:F2}", nearestResult[1]),
                }
            };
        }

        public static MatrixInspectionResult InspectMatrix(int screenWidth, int screenHeight, string memoryArea, string vectorString, int maxSearchRange, Corner corner)
        {
            var searchResult = new MatrixInspectionResult();
            var context = new WindowSearchContext
            {
                ScreenWidth = screenWidth,
                ScreenHeight = screenHeight,
                MaxSearchRange = maxSearchRange,
                Corner = corner,
                CurrentMinDistance = double.MaxValue
            };

            string[] memoryAreaParts = ParseMemoryArea(memoryArea);
            var currentWindows = ExtractWindows(memoryAreaParts, GetMatrixLength(4, 4));

            foreach (var window in currentWindows)
            {
                var processResult = ProcessWindow(window, vectorString, screenWidth, screenHeight, corner, context);

                if (processResult.IsWindowFound)
                {
                    searchResult = processResult.Result;
                    break;
                }
            }

            if (string.IsNullOrEmpty(searchResult.CorrectWindow))
            {
                searchResult.NvResultNearest = context.NearestPoint;
                searchResult.NvResultDef = new[] { "0.00", "0.00" };
                searchResult.NvResultTr = new[] { "0.00", "0.00" };
                searchResult.Result = new[] { "0.0000", "0.0000", "0.0000" };
            }

            return searchResult;
        }
    }
}
