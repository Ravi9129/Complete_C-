using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class Authentication
    {
        static void Main()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();  // Read user input

        Console.Write("Enter Password: ");
        string password = "";
        
        // Mask password input
        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) break;
            password += key.KeyChar;
            Console.Write("*"); // Display '*' instead of the actual character
        }

        Console.WriteLine("\n\nAuthenticating...");
        
        // Validate user credentials
        if (username == "admin" && password == "password123")
        {
            Console.ForegroundColor = ConsoleColor.Green;  // Change text color
            Console.WriteLine("Login Successful!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Username or Password!");
        }
        
        Console.ResetColor();  // Reset color to default
    }
    }
}