using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 2_Sealed Method
    {
        
    }
}
---------------------------------------------------
What is a Sealed Method?
✅ Sealed method ek aisi method hoti hai jo override nahi ki ja sakti.
✅ Agar kisi method ke aage sealed keyword laga diya jaye, to us method ko derived class me override nahi kiya ja sakta.
✅ Yeh tab use hoti hai jab hume kisi parent class ki method ko ek level tak override karne dena ho, lekin further modification se rokna ho.

🎯 Why Use Sealed Methods?
1️⃣ Method ka behavior fix rakhne ke liye – Kisi bhi method ki functionality ko further modify hone se prevent karne ke liye.
2️⃣ Security aur Control – Agar kisi method ko ek level tak override hone dena ho, lekin aage nahi.
3️⃣ Performance Optimization – Compiler sealed methods ko optimize karta hai, jo execution speed ko improve karti hain.
---------------------------------------------------------
📌 Example 1: Sealed Method in a Derived Class
using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class Show() method.");
    }
}

class Child : Parent
{
    public sealed override void Show() // ✅ Sealed method
    {
        Console.WriteLine("Child class Show() method.");
    }
}

// ❌ GrandChild cannot override the sealed method
class GrandChild : Child
{
    // public override void Show() { }  // ❌ ERROR: Cannot override sealed method
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show(); // ✅ Child class ka method call hoga
    }
}
📌 Output:
Child class Show() method.
✅ sealed method ko Child class me override kiya ja sakta hai, lekin GrandChild class me nahi.
---------------------------------------------------------------
📌 Example 2: Preventing Further Modification
Agar kisi method ka behavior fix rakhna ho taake koi usko modify na kar sake, to usse sealed method bana sakte hain.
using System;

class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}

class FileLogger : Logger
{
    public sealed override void Log(string message)  // ✅ Sealed method
    {
        Console.WriteLine($"Writing to file: {message}");
    }
}

// ❌ Further modification restricted
class SecureLogger : FileLogger
{
    // public override void Log(string message) { }  // ❌ ERROR: Cannot override sealed method
}

class Program
{
    static void Main()
    {
        FileLogger logger = new FileLogger();
        logger.Log("System started.");
    }
}
📌 Output:
Writing to file: System started.
✅ Sealed method ka behavior fix ho gaya, ab SecureLogger isko override nahi kar sakti.
----------------------------------------------------------------------------------------------
📌 Example 3: Performance Optimization
Sealed methods performance optimize karti hain kyunki compiler ko pata hota hai ki koi further overriding nahi hogi, is wajah se JIT (Just-In-Time) compiler efficiently optimize karta hai.

using System;

class Calculation
{
    public virtual int Add(int a, int b)
    {
        return a + b;
    }
}

class OptimizedCalculation : Calculation
{
    public sealed override int Add(int a, int b) // ✅ Sealed for optimization
    {
        return a + b;
    }
}

// ❌ Further override not possible
class AdvancedCalculation : OptimizedCalculation
{
    // public override int Add(int a, int b) { return a - b; }  // ❌ ERROR
}

class Program
{
    static void Main()
    {
        OptimizedCalculation obj = new OptimizedCalculation();
        Console.WriteLine($"Sum: {obj.Add(10, 5)}");
    }
}
📌 Output:
Sum: 15
✅ Sealed method compiler ko batati hai ki yeh final implementation hai, jo performance improve karti hai.
--------------------------------------------------
📌 Summary
✔ Sealed methods sirf override kiye gaye methods ke liye use hoti hain.
✔ Sealed method further override hone se rok deti hai.
✔ Security aur data integrity maintain karne ke liye useful hoti hai.
✔ Performance optimize karti hai kyunki compiler efficient code generate karta hai.