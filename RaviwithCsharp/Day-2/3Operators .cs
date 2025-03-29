using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class 3Operators 
    {
        static void Main()
    {
        double baseSalary = 50000;
        double taxRate = 0.1; // 10% tax

        double taxAmount = baseSalary * taxRate; // Tax calculation
        double netSalary = baseSalary - taxAmount; // Final salary after tax

        Console.WriteLine($"Base Salary: ₹{baseSalary}");
        Console.WriteLine($"Tax Deducted: ₹{taxAmount}");
        Console.WriteLine($"Net Salary: ₹{netSalary}");
    }
    }
}