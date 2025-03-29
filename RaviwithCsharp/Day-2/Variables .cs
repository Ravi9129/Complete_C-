using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class Variables 
    {
        static void Main()
    {
        // Variables declaration
        int orderId = 101;          // Order ID (integer)
        string customerName = "Amit";  // Customer name (string)
        double totalAmount = 2599.75;  // Order total (double)

        // Output
        Console.WriteLine($"Order ID: {orderId}");
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Total Amount: ₹{totalAmount}");
    }
    }
}