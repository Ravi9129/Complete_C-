using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class 4SwitchCase
    {
         static void Main()
    {
        Console.WriteLine("Choose a food item: 1. Pizza  2. Burger  3. Pasta");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You ordered Pizza - ₹250");
                break;
            case 2:
                Console.WriteLine("You ordered Burger - ₹150");
                break;
            case 3:
                Console.WriteLine("You ordered Pasta - ₹200");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
    }
}