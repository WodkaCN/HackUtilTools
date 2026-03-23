using MathNet.Numerics.LinearAlgebra;
using System;
using System.Windows.Forms;

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

        public static void InspectMatrix(int screenWidth, int screenHeight, string memoryArea, string vectorString, int maxSearchRange, Corner corner,
                                         out string correctWindow, out string resultType, out string[] result, out string[] nvResultTr, out string[] nvResultDef)
        {
            correctWindow = String.Empty;
            resultType = String.Empty;
            result = null;
            nvResultTr = null;
            nvResultDef = null;

            string[] memoryAreaParts = memoryArea.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int matrixLength = 4 * 4;

            for (int i = 0; i <= memoryAreaParts.Length - matrixLength; i++)
            {
                bool IsCorrectWindow = false;

                string[] searchWindow = new string[matrixLength];
                Array.Copy(memoryAreaParts, i, searchWindow, 0, matrixLength);

                double[] matrixValues = Array.ConvertAll(searchWindow, double.Parse);
                double[] vectorValues = Array.ConvertAll(vectorString.Split(' '), double.Parse);

                var matrix = Matrix<double>.Build.DenseOfRowMajor(4, 4, matrixValues);
                var vector = Vector<double>.Build.Dense(vectorValues);

                var defaultResult = WorldToScreenPoint(vector, matrix, screenWidth, screenHeight);
                var transposedResult = WorldToScreenPoint(vector, matrix.Transpose(), screenWidth, screenHeight);

                nvResultDef = new string[] { defaultResult[0].ToString("F2"), defaultResult[1].ToString("F2") };
                nvResultTr = new string[] { transposedResult[0].ToString("F2"), transposedResult[1].ToString("F2") };

                double x = defaultResult[0];
                double y = defaultResult[1];

                switch (corner)
                {
                    case Corner.LeftDown:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, 0, 0, defaultResult, searchWindow, out correctWindow, out result);
                        resultType = "Default";
                        break;

                    case Corner.LeftUp:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, 0, screenHeight, defaultResult, searchWindow, out correctWindow, out result);
                        resultType = "Default";
                        break;

                    case Corner.RightUp:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, screenWidth, screenHeight, defaultResult, searchWindow, out correctWindow, out result);
                        resultType = "Default";
                        break;

                    case Corner.RightDown:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, screenWidth, 0, defaultResult, searchWindow, out correctWindow, out result);
                        resultType = "Default";
                        break;
                }

                if(IsCorrectWindow is true)
                {
                    break;
                }

                x = transposedResult[0];
                y = transposedResult[1];

                switch (corner)
                {
                    case Corner.LeftDown:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, 0, 0, transposedResult, searchWindow, out correctWindow, out result);
                        resultType = "Transposed";
                        break;

                    case Corner.LeftUp:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, 0, screenHeight, transposedResult, searchWindow, out correctWindow, out result);
                        resultType = "Transposed";
                        break;

                    case Corner.RightUp:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, screenWidth, screenHeight, transposedResult, searchWindow, out correctWindow, out result);
                        resultType = "Transposed";
                        break;

                    case Corner.RightDown:
                        IsCorrectWindow = CalculateCorner(x, y, maxSearchRange, screenWidth, 0, transposedResult, searchWindow, out correctWindow, out result);
                        resultType = "Transposed";
                        break;
                }

                if (IsCorrectWindow is true)
                {
                    break;
                }
            }
        }
    }
}
