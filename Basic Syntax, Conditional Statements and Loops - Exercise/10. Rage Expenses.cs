using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

           
            int headSetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            
           
            for (int i = 1; i <=lostGamesCount; i++)
            {
                bool isHeadsetTrashed = false;
                bool isMouseTrashed = false;
                if (i%2==0&&i!=0)
                {
                    isHeadsetTrashed = true;
                    headSetCount++;
                }
                if (i%3==0&&i!=0)
                {
                    isMouseTrashed = true;
                    mouseCount++;
                }
                if (isHeadsetTrashed&&isMouseTrashed)
                {
                    keyboardCount++;
                    if (keyboardCount%2==0)
                    {
                        displayCount++;
                    }
                }
                

            }
             float totalPrice = headSetCount* headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
