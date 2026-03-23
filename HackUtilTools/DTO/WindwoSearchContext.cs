using static UtilCrackTools.Utils.ViewMatrixHelper;

namespace HackUtilTools.DTO
{
    public class WindowSearchContext
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int MaxSearchRange { get; set; }
        public Corner Corner { get; set; }
        public double CurrentMinDistance { get; set; } = double.MaxValue;
        public string[] NearestPoint { get; set; }
    }
}
