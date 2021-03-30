using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLifghtSabersSglSabre = double.Parse(Console.ReadLine());
            double priceOfRobesForSglRobe = double.Parse(Console.ReadLine());
            double priceOfBeltsForSglBelt = float.Parse(Console.ReadLine());
            
                     
              double  numBelts = countOfStudents / 6;
            
            double priceForNeededEqipment = priceOfLifghtSabersSglSabre * (Math.Ceiling(countOfStudents + 0.10 * countOfStudents)) +
                                 priceOfRobesForSglRobe * countOfStudents + priceOfBeltsForSglBelt * (countOfStudents - numBelts);
            if (priceForNeededEqipment>amountOfMoney)
            {
                Console.WriteLine($"John will need {priceForNeededEqipment - amountOfMoney:f2}lv more.");
            }
            else if (priceForNeededEqipment <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {priceForNeededEqipment:f2}lv.");
            }
        }
    }
}
