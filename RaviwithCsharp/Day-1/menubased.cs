using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class menubased
    {
        static void Main()
    {
        while (true)
        {
            Console.Clear();  // Clear console for a fresh menu display
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Your balance is $5000");
                    break;
                case "2":
                    Console.WriteLine("Enter deposit amount: ");
                    string amount = Console.ReadLine();
                    Console.WriteLine($"You deposited ${amount}");
                    break;
                case "3":
                    Console.WriteLine("Enter withdrawal amount: ");
                    string withdrawAmount = Console.ReadLine();
                    Console.WriteLine($"You withdrew ${withdrawAmount}");
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();  // Wait for user input before refreshing the menu
        }
    }
    }
}