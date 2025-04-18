using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class 10_dynamically_change_text_color
    {
        static Random random = new Random();
    static decimal previousPrice = 100.00m; // Initial price

    static void Main()
    {
        Console.WriteLine("Live Stock Price Monitor (Press ESC to exit)");

        while (true)
        {
            decimal newPrice = GetStockPrice();
            DisplayPrice(newPrice);
            previousPrice = newPrice;

            Thread.Sleep(1000); // Update every second

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\nExiting Live Stock Monitor...");
                break;
            }
        }
    }

    static decimal GetStockPrice()
    {
        decimal change = (decimal)(random.NextDouble() * 2 - 1); // -1 to +1 fluctuation
        return Math.Round(previousPrice + change, 2);
    }

    static void DisplayPrice(decimal price)
    {
        if (price > previousPrice)
            Console.ForegroundColor = ConsoleColor.Green; // Price Increased
        else if (price < previousPrice)
            Console.ForegroundColor = ConsoleColor.Red; // Price Decreased
        else
            Console.ForegroundColor = ConsoleColor.Yellow; // No Change

        Console.Write($"\rStock Price: ${price}  ");
        Console.ResetColor();
    }
    }
}