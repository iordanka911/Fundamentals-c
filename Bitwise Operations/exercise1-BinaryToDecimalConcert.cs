using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "1000111";
            int sum = 0;
            int magnitude = 1;
            for (int i = num.Length-1; i >=0; i--)
            {
                int digit = num[i]-'0';
                sum = sum + digit * magnitude;
                magnitude=magnitude*2;
            }
            Console.WriteLine(sum);
        }
    }
   
}
