using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split('|').Select(int.Parse).ToArray();
            int points = 0;
            string input = Console.ReadLine();
            while (input!="Game over")
            {
                string[] splitted = input.Split();
                if (splitted[0]=="Reverse")
                {
                   targets= targets.Reverse().ToArray();
                }
                if (splitted[0]=="Shoot")
                {
                    string[] shooting = splitted[1].Split('@');

                    if (shooting[0]=="Left")
                    {
                        int index = int.Parse(shooting[1]);
                        int count = int.Parse(shooting[2]);
                        if (index>=0&&index<targets.Length)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                index--;
                                if (index==-1)
                                {
                                    index = targets.Length - 1;
                                }
                            }

                            if (targets[index]>=5)
                            {
                                targets[index] -= 5;
                                points += 5;
                            }
                            else if (targets[index] > 0)
                            {
                                targets[index] = 0;
                                points += targets[index];
                            }

                        }
                    }


                    if (shooting[0] == "Right")
                    {
                        int index = int.Parse(shooting[1]);
                        int count = int.Parse(shooting[2]);
                        if (index >= 0 && index < targets.Length)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                index++;
                                if (index == targets.Length)
                                {
                                    index = 0;
                                }
                            }

                            if (targets[index] >= 5)
                            {
                                targets[index] -= 5;
                                points += 5;
                            }
                            else if(targets[index]>0)
                            {
                                targets[index] = 0;
                                points += targets[index];
                            }

                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points}!");
        }
    }
}


Tests

Input
20|30|40|50|60
Shoot Left@0@12
Shoot Right@4@15
Shoot Left@6@5
Reverse
Game over

Output

55 - 45 - 40 - 30 - 20
Iskren finished the archery tournament with 10!
    





