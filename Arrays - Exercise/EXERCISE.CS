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
