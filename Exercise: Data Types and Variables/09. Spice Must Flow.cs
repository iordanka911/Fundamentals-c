using System;

namespace SpiceMustFlw
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int consume = 0;
            if (startingYield>=100)
            {
                
                while (startingYield>=100)
                {
                    days++;
                    consume += startingYield;
                    startingYield -= 10;
                    
                }
                consume -= (days + 1) * 26;
                Console.WriteLine(days);
                Console.WriteLine(consume);


            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(consume);
            }
            


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
            int yield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days=0;
            while (yield>=100)
            {
                totalAmount += yield-26;
                days++;
                yield -= 10;
            }
            if (days>0)
            {
                totalAmount -= 26;
            }
           
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
           
        }
    }
}
