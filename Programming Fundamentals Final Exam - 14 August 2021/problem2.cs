using System;
using System.Text.RegularExpressions;
using System.Linq;
 
namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            string messagePatern = @"\A\!([A-Z][a-z]{2,})\!\:\[([a-zA-z]{8,})\]\Z";
 
            Regex regex = new Regex(messagePatern);
 
            for (int i = 1; i <= n; i++)
            {
                string message = Console.ReadLine();
 
                var match = regex.Match(message);
 
                if (match.Success)
                {
                    string command = match.Groups[1].Value;
                    string secondPart = match.Groups[2].Value;
                    Console.Write(command + ":" + " ");
 
                    foreach (var ch in secondPart)
                    {
                        int result = ch;
                        Console.Write($"{result} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
