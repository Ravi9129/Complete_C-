using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 6_params Modifier
    {
        
    }
}
--------------------------------------------------------
params Kya Hota Hai?
✅ params ek parameter modifier hai jo method ko variable number of arguments accept karne ki ability deta hai.
✅ Matlab, ek hi method ko multiple arguments pass kar sakte hain bina overload likhne ki zaroorat.
✅ Yeh internally ek array create karta hai, jo sabhi values ko store karta hai.
✅ params argument list ka last parameter hona chahiye.
-----------------------------------------------------------
🚀 1. Simple Example of params
✅ Scenario: Ek method hai jo multiple numbers ka sum calculate karti hai, bina overloads likhne ke.

using System;

class Program
{
    static int AddNumbers(params int[] numbers) // ✅ `params` allows multiple values
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(AddNumbers(1, 2, 3, 4, 5)); // ✅ Output: 15
        Console.WriteLine(AddNumbers(10, 20, 30)); // ✅ Output: 60
    }
}
📌 Output:
15
60
📌 Yahan params ka use karke hum ek hi method me multiple arguments pass kar rahe hain, bina overload likhne ki zaroorat.
-----------------------------------------------------------------
🚀 2. params with Strings (Joining Words)
✅ Scenario: Ek method hai jo multiple words ko concatenate karke ek string banati hai.

using System;

class Program
{
    static string JoinWords(params string[] words)
    {
        return string.Join(" ", words);
    }

    static void Main()
    {
        Console.WriteLine(JoinWords("Hello", "World!")); // ✅ Output: "Hello World!"
        Console.WriteLine(JoinWords("I", "am", "learning", "C#")); // ✅ Output: "I am learning C#"
    }
}
📌 Output:
Hello World!
I am learning C#
📌 Yahan params ka use karke multiple words ko ek string me combine kar rahe hain.
----------------------------------------------------------------
🚀 3. params with Mixed Parameters
✅ Scenario: Ek method hai jo ek fixed argument ke saath multiple values accept karti hai.

using System;

class Program
{
    static void DisplayNames(string prefix, params string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine($"{prefix} {name}");
        }
    }

    static void Main()
    {
        DisplayNames("Mr.", "Ali", "Ahmed", "Sara");
    }
}
📌 Output:
Mr. Ali
Mr. Ahmed
Mr. Sara
📌 Yahan params ko ek normal argument ke saath use kiya gaya hai, lekin params hamesha last me hona chahiye.
----------------------------------------------------------
🚀 4. params with Objects (Different Data Types)
✅ Scenario: Ek method hai jo different types ke values ko print kar sakti hai.

using System;

class Program
{
    static void PrintValues(params object[] values)
    {
        foreach (var value in values)
        {
            Console.WriteLine($"Value: {value} (Type: {value.GetType()})");
        }
    }

    static void Main()
    {
        PrintValues(10, "Hello", 3.14, true);
    }
}
📌 Output:
Value: 10 (Type: System.Int32)
Value: Hello (Type: System.String)
Value: 3.14 (Type: System.Double)
Value: True (Type: System.Boolean)
📌 Yahan params object[] ka use karke different types ke values ko accept kiya gaya hai.
---------------------------------------------------------
🚀 5. params vs Normal Array Argument
📌 Example of Normal Array Argument:

static void PrintArray(int[] numbers)
{
    foreach (var num in numbers)
        Console.WriteLine(num);
}
-----------------------------
📌 Example of params:

static void PrintParams(params int[] numbers)
{
    foreach (var num in numbers)
        Console.WriteLine(num);
}
------------------------------------------------------
🚀 6. Real-World Scenario: Logging System
✅ Scenario: Ek logger hai jo multiple messages accept karta hai aur unhe print karta hai.

using System;

class Logger
{
    public static void LogMessages(params string[] messages)
    {
        foreach (string msg in messages)
        {
            Console.WriteLine($"[LOG]: {msg}");
        }
    }
}

class Program
{
    static void Main()
    {
        Logger.LogMessages("System started", "User logged in", "Database connected");
    }
}
📌 Output:
[LOG]: System started
[LOG]: User logged in
[LOG]: Database connected
📌 Yahan params ka use karke ek logging system banaya gaya hai jo multiple messages accept kar sakta hai.
------------------------------------------------------------
🚀 Conclusion
✅ params ka use tab hota hai jab method ko variable number of arguments accept karne chahiye.
✅ Yeh array ki tarah kaam karta hai, lekin call karne ke time par hume array pass nahi karna padta.
✅ Common uses include mathematical operations, string joining, logging systems, and data printing.