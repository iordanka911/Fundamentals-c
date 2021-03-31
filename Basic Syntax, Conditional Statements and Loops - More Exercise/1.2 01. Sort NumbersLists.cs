using System;
using System.Collections.Generic;

namespace sortNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> listNum = new List<int>();
            int num1 = int.Parse(Console.ReadLine());
            listNum.Add(num1);
            int num2 = int.Parse(Console.ReadLine());
            listNum.Add(num2);
            int num3 = int.Parse(Console.ReadLine());
            listNum.Add(num3);


            listNum.Sort();
            listNum.Reverse();
            listNum.ForEach(Console.WriteLine);
        }
    }
}
