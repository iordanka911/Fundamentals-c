using System;

namespace WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentQuantity = 0;

            for (int i = 0; i < n; i++)
            {
                int quantityOfWater = int.Parse(Console.ReadLine());
                bool isFull = quantityOfWater > 255;
                bool isOverFlow = currentQuantity + quantityOfWater > 255;

                if (isFull || isOverFlow)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                currentQuantity += quantityOfWater;
            }
            Console.WriteLine(currentQuantity);

        }
    }
}
      
