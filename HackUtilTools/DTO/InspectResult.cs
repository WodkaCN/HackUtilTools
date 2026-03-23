using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackUtilTools.DTO
{
    public class InspectResult
    {
        public enum ResultType
        {
            Default = 0,
            Transposed = 1,
            NotValidValue = 99
        }

        public ResultType Type { get; set; }
        public string Text { get; set; }
    }
}
