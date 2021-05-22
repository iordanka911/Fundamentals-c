using System;
using System.Collections.Generic;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);

            }
           

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "Georgi", "Maria", "Petar" };
            myList.Reverse();
            myList.Sort();
            myList.Add("Ivan");
            myList.Remove("Maria");
            Console.WriteLine(myList.Count);
            Console.WriteLine(string.Join(" ", myList));
            

        }
    }
}


using System;
using System.Collections.Generic;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(9);
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(1);

            numbers.RemoveAll(x => x == 5).ToString();

            //while (numbers.Contains(5))
            //{
            //    numbers.Remove(5);
            //}
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int currentNumber = numbers[i];
            //    if (currentNumber == 5)
            //    {
            //        numbers.Remove(currentNumber);
            //        i--;
            //    }
            //}
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
