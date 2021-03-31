using System;
using System.Collections.Generic;

namespace sortNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float currentBalance = float.Parse(Console.ReadLine());
            float priceOfTheGame = 0;
            string command = "";
            float spendMoney = 0;
            while (command!="Game Time")
            {

                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }

                    Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${currentBalance:f2}");
                    break;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }



                switch (game)
                {
                    case "OutFall 4":
                       
                        priceOfTheGame = 39.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        break;
                       
                    case "CS: OG":
                       
                        priceOfTheGame = 15.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        
                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        
                        break;
                    case "Zplinter Zell":
                        
                        priceOfTheGame = 19.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        
                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        
                        break;
                    case "Honored 2":
                        
                        priceOfTheGame = 59.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        
                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        
                        break;
                    case "RoverWatch":
                       
                        priceOfTheGame = 29.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        

                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        

                        break;
                    case "RoverWatch Origins Edition":
                        
                        priceOfTheGame = 39.99F;
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                        
                        if (currentBalance >= priceOfTheGame)
                        {
                            Console.WriteLine($"Bought {game}");
                        }
                        if (currentBalance < priceOfTheGame)
                        {
                            Console.WriteLine("Too Expensive");
                            priceOfTheGame = 0;
                        }
                        
                        break;
                    default: Console.WriteLine("Not Found");
                          break;

                      


                }
                currentBalance -= priceOfTheGame;
                spendMoney += priceOfTheGame;
            }
           

        }
    }
}
