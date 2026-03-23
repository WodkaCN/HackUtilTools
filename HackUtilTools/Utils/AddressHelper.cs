using System;

namespace UtilCrackTools.Utils
{
    static class AddressHelper
    {
        public enum Operations
        {
            Add = '+',
            Subtract = '-'
        }

        public static string CalculateAddress(string address, Operations operation, string offset)
        {
            long addressHex = Convert.ToInt64(address, 16);
            long offsetHex = Convert.ToInt64(offset, 16);

            switch (operation)
            {
                case Operations.Add:
                    return (addressHex + offsetHex).ToString("X");
                case Operations.Subtract:
                    return (addressHex - offsetHex).ToString("X");
                default:
                    return "00000000000";
            }

        }

        public static string CalculateOffset(string address1, string address2)
        {
            string result = String.Empty;

            long addressHex1 = Convert.ToInt64(address1, 16);
            long addressHex2 = Convert.ToInt64(address2, 16);

            if (addressHex1 < addressHex2)
            {
                result = "-" + (addressHex2 - addressHex1).ToString("X2");
            }
            else
            {
                result = (addressHex1 - addressHex2).ToString("X2");
            }

            return result;
        }
    }
}
