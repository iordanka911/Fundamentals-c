using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 20;
            string result = "";
            while (NUM>0)
            {
                int d = NUM % 2;
                result = d + result;
                NUM = NUM / 2;

            }
            Console.WriteLine(result);
        }
    }
   
}


