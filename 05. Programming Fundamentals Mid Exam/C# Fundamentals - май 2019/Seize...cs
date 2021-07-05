using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace theSeize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine()
                .Split("#");

            List<int> fireCells = new List<int>();

            int water = int.Parse(Console.ReadLine());

            double efforts = 0;

            for (int i = 0; i < fires.Length; i++)
            {
                string[] fireArg = fires[i]
                    .Split(" = ");

                string type = fireArg[0];
                int fireValue = int.Parse(fireArg[1]);

                bool isCellValid = IsCellValid(type, fireValue);

                if (isCellValid && water - fireValue >= 0)
                {
                    efforts += fireValue * 0.25;
                    water -= fireValue;
                    fireCells.Add(fireValue);

                }
            }

            int totalFire = fireCells.Sum();

            Console.WriteLine($"Cells:");

            if (fireCells.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, fireCells.Select(cell => $" - {cell}")));
            }

            //foreach (var cell in fireCells)
            //{
            //    Console.WriteLine($" - {cell}");
            //}

            Console.WriteLine($"Effort: {efforts:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }

        private static bool IsCellValid(string type, int fireValue)
        {
            if (type == "High")
            {
                return fireValue >= 81 && fireValue <= 125;
            }

            if (type == "Medium")
            {
                return fireValue >= 51 && fireValue <= 80;
            }

            if (type == "Low")
            {
                return fireValue >= 1 && fireValue <= 50;
            }

            return false;
        }
    }
    
}
