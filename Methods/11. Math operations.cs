using System;
using System.Linq;


namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
             int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "+":
                    Add(a, b);
                    break;
                case "-":
                    Subtract(a, b);
                    break;
                case "*":
                    Multiply(a, b);
                    break;
                case "/":
                    Divide(a, b);
                    break;
                default:
                    break;
            }
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }


    }
}
