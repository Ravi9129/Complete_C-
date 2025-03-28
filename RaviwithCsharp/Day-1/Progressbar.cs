using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class Progressbar
    {
        static void Main()
    {
        Console.WriteLine("Downloading file...");

        for (int i = 0; i <= 100; i += 5)
        {
            Console.Write("\rProgress: {0}% ", i);
            Thread.Sleep(200); // Simulate delay
        }

        Console.WriteLine("\nDownload Complete!");
    }
    }
}