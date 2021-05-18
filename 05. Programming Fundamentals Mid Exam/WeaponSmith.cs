using System;

namespace WeaponSmith

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] partinclsWeapon = Console.ReadLine().Split('|');

            string input = Console.ReadLine();
            while (input!="Done")
            {
                string[] splitted = input.Split();
                if (splitted[0]=="Check")
                {
                    int isOdd = 0;
                    if (splitted[1]=="Odd")
                    {
                        isOdd = 1;
                    }

                    for (int i = 0; i < partinclsWeapon.Length; i++)
                    {
                        if (i%2==isOdd)
                        {
                            Console.Write(partinclsWeapon[i]+" ");
                        }
                    }

                }
                if (splitted[0]=="Move")
                {
                    int index = int.Parse(splitted[2]);
                    if (splitted[1]=="Left")
                    {
                        
                        if (index > 0 && index < partinclsWeapon.Length)
                        {
                            string temp = partinclsWeapon[index];
                            partinclsWeapon[index] = partinclsWeapon[index - 1];
                            partinclsWeapon[index - 1] = temp;
                        }
                      
                    }
                    if (splitted[1] == "Right")
                    {
                        if (index >= 0 && index < partinclsWeapon.Length-1)
                        {
                            string temp = partinclsWeapon[index];
                            partinclsWeapon[index] = partinclsWeapon[index + 1];
                            partinclsWeapon[index + 1] = temp;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You crafted {String.Join("",partinclsWeapon)}!");
            
        }
    }
}
