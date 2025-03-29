using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class 2PrimitiveData
    {
        static void Main()
    {
        int accountNumber = 123456; 
        double balance = 25000.75; 
        char accountType = 'S'; // 'S' for Savings, 'C' for Current
        bool isActive = true; 

        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: ₹{balance}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Active: {isActive}");
    }
    }
}