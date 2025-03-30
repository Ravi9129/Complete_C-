using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 8_Static Local Function
    {
        
    }
}
-------------------------------
Static Local Function Kya Hai?
✅ Static Local Function ek local function hoti hai jo kisi bhi outer variable ko access nahi kar sakti.
✅ Ye C# 8.0 me introduce hui thi.
✅ Performance aur memory optimization ke liye useful hai.

📌 Normal Local Function outer variables ko access kar sakti hai, lekin Static Local Function nahi kar sakti.
-------------------------------------------------------
🚀 1. Normal vs Static Local Function Example
using System;

class Program
{
    static void NormalFunction()
    {
        int outerVariable = 10;

        void NormalLocalFunction() // ✅ Normal Local Function
        {
            Console.WriteLine(outerVariable); // ✅ Outer variable access kar sakti hai
        }

        NormalLocalFunction();
    }

    static void StaticFunction()
    {
        int outerVariable = 10;

        static void StaticLocalFunction() // ✅ Static Local Function
        {
            // ❌ Console.WriteLine(outerVariable); // Error: Outer variable ko access nahi kar sakti
            Console.WriteLine("This is a static local function.");
        }

        StaticLocalFunction();
    }

    static void Main()
    {
        NormalFunction();
        StaticFunction();
    }
}
📌 Output:
10
This is a static local function.
📌 Static local function outerVariable ko access karne ki koshish karegi to error aayega.

🚀 2. Why Use Static Local Function?
✅ Performance Improve Hoti Hai – Ye heap allocation avoid karti hai.
✅ Memory Efficient Hai – Ye unnecessary memory leaks se bachata hai.
✅ Predictability – Outer variables ko modify nahi karti, is wajah se predictable behavior hota hai.
---------------------------------------------------------
🚀 3. Real-World Example: Math Utility Function
✅ Scenario: Ek function hai jo factorial calculate karta hai. Static local function use karke performance optimize ki gayi hai.
using System;

class Program
{
    static int Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Number must be non-negative");

        static int ComputeFactorial(int num) // ✅ Static Local Function
        {
            return (num <= 1) ? 1 : num * ComputeFactorial(num - 1);
        }

        return ComputeFactorial(n);
    }

    static void Main()
    {
        Console.WriteLine(Factorial(5)); // ✅ Output: 120
    }
}
📌 Output:
120
📌 Static Local Function ComputeFactorial(num) kisi bhi outer variable ko access nahi kar rahi, is wajah se ye efficient hai.
----------------------------------------------------------
🚀 4. Static Local Function for Performance Optimization
✅ Scenario: Ek function hai jo ek array ka sum calculate karta hai, lekin optimization ke liye Static Local Function use karta hai.

using System;

class Program
{
    static int SumArray(int[] numbers)
    {
        static int Sum(int[] nums) // ✅ Static Local Function
        {
            int total = 0;
            foreach (int num in nums)
            {
                total += num;
            }
            return total;
        }

        return Sum(numbers);
    }

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        Console.WriteLine(SumArray(nums)); // ✅ Output: 15
    }
}
📌 Output:
15
📌 Yahan Sum(int[] nums) ek static local function hai jo direct array ko use karta hai, bina kisi outer variable ko access kiye.
-------------------------------------------------------
🚀 5. Static Local Function with Parameters
✅ Scenario: Ek function hai jo kisi bhi do numbers ka sum calculate karta hai, static local function ke through.

using System;

class Program
{
    static int AddNumbers(int a, int b)
    {
        static int Add(int x, int y) => x + y; // ✅ Static Local Function with Parameters

        return Add(a, b);
    }

    static void Main()
    {
        Console.WriteLine(AddNumbers(10, 20)); // ✅ Output: 30
    }
}
📌 Output:
30
📌 Yahan Add(x, y) ek static local function hai jo sirf given parameters ko use kar raha hai.
-----------------------------------------------
🚀 7. When to Use Static Local Function?
✅ Jab kisi bhi outer variable ki zaroorat nahi ho.
✅ Jab performance aur memory optimize karni ho.
✅ Jab function sirf usi method ke andar use hona ho.

🚀 Conclusion
✅ Static Local Function normal local function se faster hoti hai.
✅ Ye outer variables ko access nahi karti, jo memory allocation ko reduce karti hai.
✅ Agar function kisi bhi outer variable ko use nahi kar raha, to usko static bana do taaki performance improve ho.