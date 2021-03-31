using System;
using System.Linq;
using System.Numerics;


namespace ExactSumoRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCeturies = int.Parse(Console.ReadLine());
            int years = numOfCeturies * 100;
            int days =(int)(years * 365.2422);
            int hours = 24*days;
            int minutes = 60*hours;
            Console.WriteLine($"{numOfCeturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


        }


    }
}
