using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'b';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'A';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'щ';  // Cyrillic letter 'sht'
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);



        }
    }
}
