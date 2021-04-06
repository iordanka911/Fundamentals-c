using System;

namespace ConvertDecimalToBinarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 500;
            string result = "";
            while (NUM>0)
            {
                int d = NUM % 16;
                result = GetHexDigit(d) + result;
                NUM = NUM / 16;

            }
            Console.WriteLine(result);
        }

        private static string GetHexDigit(int d)
        {
            if (d<10)
            {
                return "" + d;
            }
            else if (d==10)
            {
                return "A";
            }
            else if (d == 11)
            {
                return "B";
            }
            else if (d == 12)
            {
                return "C";
            }
            else if (d == 13)
            {
                return "D";
            }
            else if (d == 14)
            {
                return "E";
            }
            else if (d == 15)
            {
                return "F";
            }
            else
            {
                throw new Exception("Invalid digit");
            }
        }
    }
   
}
