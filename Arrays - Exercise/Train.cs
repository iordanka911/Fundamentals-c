using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
            //  Console.WriteLine(wagons.Sum());
          
        }
    }
}

