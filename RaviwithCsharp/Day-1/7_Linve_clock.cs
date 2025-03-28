using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class 7_Linve_clock
    {
        static void Main()
    {
        Console.WriteLine("Live Clock (Press ESC to Exit)\n");

        while (true)
        {
            Console.Write("\rCurrent Time: " + DateTime.Now.ToString("hh:mm:ss tt"));
            Thread.Sleep(1000); // Updates every second

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\nExiting Live Clock...");
                break;
            }
        }
    }
    }
}