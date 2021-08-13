using System;
 
namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
 
            string[] command = Console.ReadLine().Split(">>>");
            while (command[0] != "Generate")
            {
                string action = command[0];
                if (action == "Contains")
                {
                    string substring = command[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
 
                if (action == "Flip")
                {
                    string upperOrLower = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string substringFlip = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
 
                    if (upperOrLower == "Upper")
                    {
                       activationKey = activationKey.Replace(substringFlip, substringFlip.ToUpper());
                    }
                    else
                    {
                        activationKey = activationKey.Replace(substringFlip, substringFlip.ToLower());
                    }
 
                    Console.WriteLine(activationKey);                    
                }
 
                if (action == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
 
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
 
                    Console.WriteLine(activationKey);
                }                
 
                command = Console.ReadLine().Split(">>>");
            }
 
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
