using System;

namespace beerKeg
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustFactor = int.Parse(Console.ReadLine());

            int count = 0;
            double tempPower = power * 0.5;

            while (power>=distance)
            {
                count++;
                power -= distance;

                if (power==tempPower&&exaustFactor!=0)
                {
                    power /= exaustFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}



using System;
using System.Linq;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int halfOfN = n / 2;

            int target = 0;

            while(n>=m)
            {
                target++;
                n -= m;
                if (halfOfN==n&&y>0)
                {
                    n /= y;
                }
                
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
