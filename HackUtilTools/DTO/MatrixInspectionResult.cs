namespace HackUtilTools.DTO
{
    public class MatrixInspectionResult
    {
        public string CorrectWindow { get; set; } = string.Empty;
        public InspectResult ResultType { get; set; } = new InspectResult { Type = InspectResult.ResultType.NotValidValue, Text = "Not Valid View Point (Check Nearest [X, Y])"};
        public string[] Result { get; set; } = new[] { "0.0000", "0.0000", "0.0000" };
        public string[] NvResultTr { get; set; }
        public string[] NvResultDef { get; set; }
        public string[] NvResultNearest { get; set; }
    }
}
