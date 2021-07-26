using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace emojis
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"\d";
            string emojiPatern = @"(:{2}|\*{2})[A-Z][a-z]+\1";
            Regex numReg = new Regex(numberPattern);
            Regex emojiReg = new Regex(emojiPatern);
            string text = Console.ReadLine();
            long coolTreshhold = 1;
                numReg.Matches(text)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolTreshhold *= x);

            var matches = emojiReg.Matches(text);
            int totalEmojis = matches.Count;
            List<string> coolEmojis = new List<string>();

            foreach (Match item in matches)
            {
                item.Value.Substring(2,item.Value.Length-4)
            }

            Console.WriteLine(coolTreshhold );
        }
    }
}
