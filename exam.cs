using System;
using System.Data;
using System.Linq;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Complete")
            {
                string[] cmdArgs = input.Split().ToArray();

                switch (cmdArgs[0])
                {
                    case "Make":

                        if (cmdArgs[1] == "Upper")
                        {
                            email = email.ToUpper();
                        }
                        else if (cmdArgs[1] == "Lower")
                        {
                            email = email.ToLower();
                        }
                        Console.WriteLine(email);
                        break;

                    case "GetDomain":
                        int count = int.Parse(cmdArgs[1]);

                        if (count < email.Length && count >= 0)
                        {
                            Console.WriteLine(email.Substring(email.Length - count));
                        }
                        else
                        {
                            Console.WriteLine(email);
                        }
                        break;

                    case "GetUsername":
                        if (email.Contains('@'))
                        {
                            int index = email.IndexOf('@');
                            string username = email.Substring(0, index);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;

                    case "Replace":
                        char currentChar = char.Parse(cmdArgs[1]);
                        email = email.Replace(currentChar, '-');
                        Console.WriteLine(email);
                        break;

                    case "Encrypt":
                        for (int i = 0; i < email.Length; i++)
                        {
                            char currentSumbol = email[i];
                            Console.Write((int)currentSumbol + " ");
                        }
                        Console.WriteLine();
                        break;
                };
                input = Console.ReadLine();
            }

            
        }
    }
    
}
