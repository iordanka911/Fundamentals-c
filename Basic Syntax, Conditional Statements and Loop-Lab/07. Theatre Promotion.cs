using System;

namespace Тheatre_promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if (day=="weekday")
            {
                if ((age>=0&&age<=18)||(age>64&&age<=122))
                {
                    price = 12;
                }
                else if (age>18&&age<=64)
                {
                    price = 18;
                }
            }
            else if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else  if (age > 64 && age <= 122)
                {
                    price = 15;
                }

            }
            if (price!=0)
            {
                Console.WriteLine(price+"$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
