using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 4_Static Class
    {
        
    }
}
----------------------------------------
What is a Static Class?
static class ek special type ka class hota hai jo sirf static members ko contain karta hai. Iska object nahi banaya ja sakta aur yeh sirf static fields, properties, and methods ko allow karta hai.

✅ Ek baar memory me load hota hai aur pura program use kar sakta hai.
✅ Object creation allowed nahi hai.
✅ Sare members static hote hain.
✅ Inheritance allow nahi karta.

📌 Why Use a Static Class?
🔹 Utility Functions: Jab hume helper ya utility functions chahiye jo kisi specific object par dependent na ho.
🔹 Global State Management: Global constants ya configurations store karne ke liye.
🔹 Performance Optimization: Object creation ka overhead hatane ke liye.

📌 Syntax of Static Class

static class MyClass
{
    public static void ShowMessage()
    {
        Console.WriteLine("Hello from Static Class!");
    }
}
----------------------------
📌 Example 1: Static Helper Class
using System;

static class MathHelper
{
    public static double Pi = 3.14159;

    public static int Square(int num)
    {
        return num * num;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Value of Pi: " + MathHelper.Pi);
        Console.WriteLine("Square of 5: " + MathHelper.Square(5));
    }
}
📌 Output:
Value of Pi: 3.14159
Square of 5: 25
--------------------------------------
📌 Example 2: Global Configuration Class
static class Config
{
    public static string AppName = "My Application";
    public static string Version = "1.0.0";

    public static void ShowConfig()
    {
        Console.WriteLine($"App: {AppName}, Version: {Version}");
    }
}

class Program
{
    static void Main()
    {
        Config.ShowConfig();
    }
}
📌 Output:
App: My Application, Version: 1.0.0
📌 Can a Static Class Have a Constructor?
Haan, static class ka ek static constructor ho sakta hai, jo sirf ek baar execute hota hai.

static class Logger
{
    static Logger()
    {
        Console.WriteLine("Static Logger Initialized!");
    }

    public static void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main()
    {
        Logger.Log("Application started!");
    }
}
📌 Output:
Static Logger Initialized!
Log: Application started!
📌 Rules of Static Classes
✅ Sare members static hone chahiye.
✅ Object create nahi kar sakte (new keyword use nahi hota).
✅ Inheritance allow nahi hoti.
✅ Static constructor allowed hai, but manually call nahi kar sakte.

📌 When to Use Static Classes?
✅ Jab object creation ki zaroorat na ho (e.g., Math, Configuration, Logger).
✅ Jab utility functions ya helper methods define karne ho.
✅ Jab global constants ya settings maintain karni ho.

📌 Interview Questions on Static Classes
🔹 Q: What is a Static Class in C#?
✅ A: Static class ek special class hai jo sirf static members ko contain karti hai aur iska object nahi banaya ja sakta.

🔹 Q: Can a Static Class Have a Constructor?
✅ A: Haan, ek static constructor ho sakta hai jo sirf ek baar execute hota hai.

🔹 Q: Why Can't a Static Class Be Inherited?
✅ A: Kyunki static class ka koi instance nahi hota, isliye usko inherit nahi kiya ja sakta.