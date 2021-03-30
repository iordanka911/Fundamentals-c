using System;
using System.Linq;


namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            switch (product)
            {
                case "coffee":
                    Coffee(coffeePrice, quantity);
                    break;
                case "water":
                    Water(waterPrice, quantity);
                    break;
                case "snacks":
                    Snacks(snacksPrice, quantity);
                    break;
                case "coke":
                    Coke(cokePrice, quantity);
                    break;
                default:
                    break;
            }
        }
        private static void Coffee(double coffeePrice, int quantity)
        {
            Console.WriteLine($"{coffeePrice * quantity:f2}");
        }
        private static void Water(double waterPrice, int quantity)
        {
            Console.WriteLine($"{waterPrice * quantity:f2}");
        }
        private static void Snacks(double snacksPrice, int quantity)
        {
            Console.WriteLine($"{snacksPrice * quantity:f2}");
        }
        private static void Coke(double cokePrice, int quantity)
        {
            Console.WriteLine($"{cokePrice * quantity:f2}");
        }
    }
}
