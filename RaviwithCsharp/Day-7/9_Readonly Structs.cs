using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 9_Readonly Structs
    {
        
    }
}
---------------------------------------------------
Readonly struct ek special type ka struct hota hai jo immutable hota hai, yani ek baar values assign hone ke baad unko change nahi kiya ja sakta.
🔹 Yeh performance optimize karta hai aur unnecessary memory allocation ko prevent karta hai.
----------------------------------------------------------
📌 1. Readonly Struct Syntax
readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
✅ readonly struct ka matlab hai ki saare fields aur properties bhi readonly hone chahiye.

📌 2. Why Use Readonly Structs?
🔹 Better Performance – Readonly structs copying ko optimize karte hain.
🔹 Thread-Safety – Immutable hone ki wajah se multithreading me safer hain.
🔹 Less Memory Allocation – Stack memory use hoti hai, jo faster execution provide karta hai.

📌 3. Example: Readonly Struct in Action
using System;

readonly struct Rectangle
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetArea() => Width * Height;
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine($"Area: {rect.GetArea()}");

        // ❌ rect.Width = 20; // Error: Cannot modify readonly property
    }
}
📌 Output:
Area: 50
✅ Values immutable hain, inko modify nahi kiya ja sakta.

-------------------------------------------------
📌 5. Readonly Fields in Normal Struct
Agar aap pura struct readonly nahi rakhna chahte, par kuch specific fields ko immutable banana chahte hain, toh readonly fields ka use kar sakte hain.

struct Car
{
    public readonly int Wheels; // Immutable field
    public string Model; // Mutable field

    public Car(int wheels, string model)
    {
        Wheels = wheels;
        Model = model;
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car(4, "Tesla");
        Console.WriteLine($"Car Model: {car.Model}");

        // ✅ Allowed: Model change ho sakta hai
        car.Model = "Ford";
        
        // ❌ Not Allowed: Readonly field change nahi ho sakta
        // car.Wheels = 6; // Error: Cannot assign to readonly field
    }
}
✅ Readonly field (Wheels) modify nahi ho sakta, par Model change ho sakta hai.
-----------------------------------------------
📌 6. When to Use Readonly Structs?
✅ Jab immutable data structure banana ho, jaise:

Points (X, Y coordinates)

Colors (R, G, B values)

Configurations
✅ Jab aapko high-performance, stack-based object banana ho.
✅ Jab thread-safe struct use karna ho jo accidental modifications se bacha sake.
--------------------------------------------
🔥 Final Thoughts
✔ Readonly structs ka use performance optimize karne aur immutable data store karne ke liye kiya jata hai.
✔ Agar aapko immutable aur safe struct chahiye toh readonly struct use karna best practice hai. 🚀