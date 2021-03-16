using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeopleInGroup = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double priceForSinglePerson = 0;
            double totalPrice = 0;
            switch (dayOfTheWeek)
            {
                case "Friday":
                    if (typeOfTheGroup=="Students")
                    {
                        priceForSinglePerson = 8.45;
                    }
                    if (typeOfTheGroup == "Business")
                    {
                        priceForSinglePerson = 10.90;
                    }
                    if (typeOfTheGroup == "Regular")
                    {
                        priceForSinglePerson = 15;
                    }

                    break;
                case "Saturday":
                    if (typeOfTheGroup == "Students")
                    {
                        priceForSinglePerson = 9.80;
                    }
                    if (typeOfTheGroup == "Business")
                    {
                        priceForSinglePerson = 15.60;
                    }
                    if (typeOfTheGroup == "Regular")
                    {
                        priceForSinglePerson = 20;
                    }

                    break;

                case "Sunday":
                    if (typeOfTheGroup == "Students")
                    {
                        priceForSinglePerson = 10.46;
                    }
                    if (typeOfTheGroup == "Business")
                    {
                        priceForSinglePerson = 16;
                    }
                    if (typeOfTheGroup == "Regular")
                    {
                        priceForSinglePerson = 22.50;
                    }

                    break;
                default:
                    break;
            }
            totalPrice = priceForSinglePerson * numberPeopleInGroup;
            if (typeOfTheGroup=="Students"&&numberPeopleInGroup>=30)
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            if (typeOfTheGroup=="Business"&&numberPeopleInGroup>=100)
            {
                totalPrice = priceForSinglePerson * (numberPeopleInGroup - 10);
            }
            if (typeOfTheGroup=="Regular"&&numberPeopleInGroup>=10&&numberPeopleInGroup<=20)
            {
                totalPrice = totalPrice - 0.05 * totalPrice;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
