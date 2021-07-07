using System;
using System.Threading.Channels;

namespace ConsoleApp94
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();
            while (input!="Complete")
            {
                if (input=="Make Upper")
                {
                    email = email.ToUpper();
                }
                if (input == "Make Lower")
                {
                    email = email.ToLower();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(email);
        }
        
    }
}
