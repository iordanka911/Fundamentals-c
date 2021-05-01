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
