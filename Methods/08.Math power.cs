using System;
using System.Linq;


namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = int.Parse(Console.ReadLine());

            double result = raiseToPower(number, power);
            Console.WriteLine(result);
        }
        private static double raiseToPower(double number,double power)
        {
            return Math.Pow(number, power);
        }
       
    }
}
