using System;
using System.Linq;


namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var type=Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();

            var result = GetMax(type,value1, value2);
            Console.WriteLine(result);
        }
        private static string GetMax(string type,string value1,string  value2)
        {
            var result1 = 0;
            var result2 = 0;

            if (type=="int")
            {
                result1 = int.Parse(value1);
                result2 = int.Parse(value2);

            }
            else if (type=="char")
            {
                result1 = char.Parse(value1);
                result2 = char.Parse(value2);
            }
            else if (type=="string")
            {
                int comparison = value1.CompareTo(value2);
                if (comparison>0)
                {
                    return value1;
                }
                else
                {
                    return value2;
                }

                
            }
            if (result1 > result2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
       
    }
}
