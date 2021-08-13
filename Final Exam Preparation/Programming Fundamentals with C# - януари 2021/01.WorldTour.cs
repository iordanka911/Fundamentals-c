using System;
using System.Text;
using System.Linq;
class Program
{
    static void Main()
    {

        string input = Console.ReadLine();

        string commands = Console.ReadLine();
        while (commands != "Travel")
        {

            if (commands.Contains("Add"))
            {
                string[] info = commands.Split(" ");
                string[] details = info[1].Split(":");
                int index = int.Parse(details[1]);
                string str = details[2];
                if (index >= 0 && index < input.Length)
                {
                    input = input.Insert(index, str);
                    Console.WriteLine(input);
                }

            }
            else if (commands.Contains("Remove"))
            {
                string[] info = commands.Split(" ");
                string[] details = info[1].Split(":");
                int startIndex = int.Parse(details[1]);
                int endIndex = int.Parse(details[2]);
                if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                {
                    int lengthOfRemoved = endIndex - startIndex + 1;
                    input = input.Remove(startIndex, lengthOfRemoved);
                    
                }
                Console.WriteLine(input);
            }
            else if (commands.Contains("Switch"))
            {
                string[] details = commands.Split(":");
                string oldString = details[1];
                string newString = details[2];
                if (input.Contains(oldString))
                {
                    input = input.Replace(oldString, newString);
                    
                }
                Console.WriteLine(input);
            }


            commands = Console.ReadLine();
        }


        Console.WriteLine($"Ready for world tour! Planned stops: {input}");
    }
}
