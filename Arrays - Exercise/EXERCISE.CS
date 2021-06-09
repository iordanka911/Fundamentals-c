using System;

namespace aRRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[6];
            Console.WriteLine(myArray[0]);

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = $"my {i} element";

            }
            Console.WriteLine(string.Join(Environment.NewLine,myArray));
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[myArray.Length-1]);

        }
    }
}


using System;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = "test";

            int[] arrayOfIntegers = new int[10];

            arrayOfIntegers[0] = 45;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = i + 1;
            }

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.WriteLine(arrayOfIntegers[i]+" ");
            }

            Console.WriteLine(string.Join(" ",arrayOfIntegers));
        }
    }
}



using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4] { "Daniel", "John", "Jane", "Tobi" };


            names[0] = "Daniel";
            names[1] = "John";
            names[2] = "Jane";
            names[3] = "Tobi";

            Console.WriteLine(string.Join(" ", names));
        }
    }
}



using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 6, 14, 56, 67, 77, 77, 77 };

            luckyNumbers[1] = 900;

            string[] friends = new string[10];

            friends[0] = "Jim";
            Console.WriteLine(luckyNumbers[0]);

            Console.ReadLine();
        }
    }
}
