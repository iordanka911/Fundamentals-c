using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
          {"Peter", "Michael", "George", "Victor", "John"};
            names.Sort();
            Console.WriteLine(string.Join(", ",names));
             
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
          {"Peter", "Michael", "George", "Victor", "John"};
            names.Sort();
            names.Reverse();
            Console.WriteLine(string.Join(", ",names));
             
        }
    }
}
