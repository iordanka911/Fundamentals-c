using System;
using System.Collections.Generic;
using System.Linq;

namespace ImmitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            
            while (command!="Decode")
            {
                string[] tokens = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Move":
                        int characterCount = int.Parse(tokens[1]);
                        string characters = message.Substring(0, characterCount);
                        message = message.Substring(characterCount) + characters;
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        message = message.Insert(index, tokens[2]);
                        break;
                    case "ChangeAll":
                        while (message.Contains(tokens[1]))
                        {
                            message = message.Replace(tokens[1],tokens[2]);
                        }
                        break;
                   

                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
