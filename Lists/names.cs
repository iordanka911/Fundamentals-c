using System;
using System.Collections.Generic;
using System.Text;



namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            foreach(var name in names)
            {
                Console.WriteLine(name);
                Console.WriteLine(string.Join(", ",names));
            }
            
        }

        
    }
}
