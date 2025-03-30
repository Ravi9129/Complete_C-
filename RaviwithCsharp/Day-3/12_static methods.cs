using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 12_static methods
    {
        
    }
}
-----------------------------------------------------------------
static methods woh methods hote hain jo kisi specific object (instance) ke saath bind nahi hote.
🔹 Yeh class ke saath directly associated hote hain aur bina kisi object banaye call kiye ja sakte hain.
🔹 Yeh mostly utility functions, helper methods, aur shared behavior implement karne ke liye use hote hain.
🔹 Static methods class ke static fields aur other static methods ko access kar sakte hain.
🔹 Lekin yeh non-static (instance) members ko access nahi kar sakte.
---------------------------------------------------------------------------
🚀 1. Basic Example of Static Method
✅ Scenario: Ek class MathHelper jo addition ka function provide kare

using System;

class MathHelper  
{  
    public static int Add(int a, int b)  
    {  
        return a + b;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        int sum = MathHelper.Add(10, 20);  // ✅ Static method ko bina object banaye call kar rahe hain
        Console.WriteLine("Sum: " + sum);  
    }  
}
📌 Yahan Add() ek static method hai jo bina kisi object ke class ke saath directly call ho raha hai.
📌 Hum MathHelper ka object nahi banaye, bas MathHelper.Add() call kiya.
--------------------------------------------------------------------------
🚀 2. Static Method with Static Fields
✅ Scenario: Ek Counter class jo sabhi objects ka count track kare using static method

using System;

class Counter  
{  
    private static int count = 0;  // ✅ Static Field

    public Counter()  
    {  
        count++;  // ✅ Har naye object ke sath count badhta hai  
    }  

    public static int GetCount()  
    {  
        return count;  // ✅ Static Method static field ko access kar raha hai  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Counter c1 = new Counter();  
        Counter c2 = new Counter();  
        Counter c3 = new Counter();  

        Console.WriteLine("Total Objects Created: " + Counter.GetCount());  
    }  
}
📌 count ek static field hai jo sabhi objects ke liye shared hai.
📌 GetCount() ek static method hai jo bina object ke call ho sakta hai.
📌 Jab bhi naya object create hota hai, count++ ho jata hai.
-----------------------------------------------------------------------
🚀 3. Static Method for Utility Functions
✅ Scenario: Ek StringHelper class jo utility functions provide kare

using System;

class StringHelper  
{  
    public static string ToUpperCase(string str)  
    {  
        return str.ToUpper();  
    }  
}

class Program  
{  
    static void Main()  
    {  
        string result = StringHelper.ToUpperCase("hello world");  
        Console.WriteLine(result);  
    }  
}
📌 Yahan ToUpperCase() ek utility method hai jo kisi bhi string ko uppercase me convert karta hai.
📌 Is method ko bina object ke directly call kiya StringHelper.ToUpperCase("hello world").
-------------------------------------------------------------------------------------------
🚀 4. Static Method with Non-Static Members (Error Case)
✅ Scenario: Agar static method ek non-static member ko access karne ki koshish kare

using System;

class Demo  
{  
    private int x = 10;  

    public static void Show()  
    {  
        // ❌ ERROR: Static method non-static field ko directly access nahi kar sakta
        Console.WriteLine("Value of x: " + x);  
    }  
}
📌 Yeh error dega kyunki Show() ek static method hai jo x (non-static field) ko access kar raha hai.
📌 Static methods sirf static members ko access kar sakte hain.
--------------------------------------------------
✔ Correct Version:

class Demo  
{  
    private static int x = 10;  // ✅ Static bana diya

    public static void Show()  
    {  
        Console.WriteLine("Value of x: " + x);  // ✅ Ab koi error nahi aayega
    }  
}
---------------------------------------------------------------------------
🚀 5. static Methods in Static Classes
✅ Scenario: Ek Logger class jo sirf static methods ko allow kare

using System;

static class Logger  
{  
    public static void Log(string message)  
    {  
        Console.WriteLine("[LOG]: " + message);  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Logger.Log("Application started.");  
    }  
}
📌 Agar class static hai to uske sare methods bhi static hone chahiye.
📌 Is tarah ki classes mostly utility aur helper functions ke liye use hoti hain.
---------------------------------------------------------------
🚀 6. Static Method for Factory Design Pattern
✅ Scenario: Ek DatabaseConnection class jo ek singleton instance return kare

using System;

class DatabaseConnection  
{  
    private static DatabaseConnection instance;  

    private DatabaseConnection()  
    {  
        Console.WriteLine("Database Connected!");  
    }  

    public static DatabaseConnection GetInstance()  
    {  
        if (instance == null)  
        {  
            instance = new DatabaseConnection();  
        }  
        return instance;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        DatabaseConnection db1 = DatabaseConnection.GetInstance();  
        DatabaseConnection db2 = DatabaseConnection.GetInstance();  

        Console.WriteLine(db1 == db2);  // ✅ True (Same instance return hoga)
    }  
}
📌 Yeh singleton pattern ka example hai jisme GetInstance() method ek hi instance return karta hai.
📌 Yeh ensure karta hai ki DatabaseConnection ka sirf ek object bane pure program me.

🚀 Summary: Jab static Methods Use Karte Hain
Use Case	Example
Utility functions ya helper methods	MathHelper.Add(10, 20);
Static fields access karne ke liye	Counter.GetCount();
Object creation control karne ke liye (Singleton)	DatabaseConnection.GetInstance();
Factory Design Pattern implement karne ke liye	SomeFactory.CreateObject();
Pure utility classes me (static class)	Logger.Log("Message");
🚀 Conclusion
🔹 static methods bina kisi object ke class ke saath directly call kiye ja sakte hain.
🔹 Yeh mostly utility functions, shared resources, aur singleton pattern implement karne ke liye use hote hain.
🔹 Static methods sirf static fields aur methods ko access kar sakte hain, instance members ko nahi.
🔹 Static classes sirf static methods aur properties rakh sakti hain.