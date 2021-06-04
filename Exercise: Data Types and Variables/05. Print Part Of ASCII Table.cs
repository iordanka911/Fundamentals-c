using System;
class Program
{
    static void Main()
    {

        int indexStart = int.Parse(Console.ReadLine());
        int indexEnd = int.Parse(Console.ReadLine());

        for (int i = indexStart; i <= indexEnd; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}


using System;
using System.Linq;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char i = (char)start; i <=(char)end; i++)
            {
                Console.Write(i+" ");
            }
           
        }
    }
}
