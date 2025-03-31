using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 6_Structures 
    {
        
    }
}
----------------------------------------------------
What is a Structure (Struct) in C#?
👉 Structure (struct) ek value type data structure hai jo multiple variables ko ek single unit me group karne ke liye use hota hai. Structure classes ki tarah hota hai, lekin kuch key differences ke saath.

✅ Use Case:
Agar aapko small, lightweight objects chahiye jo memory-efficient ho aur less overhead create karein, toh struct best choice hota hai.

✅ Real-Life Example:

Point (X, Y) in a 2D Space

RGB Color (Red, Green, Blue values)

Employee Information (ID, Name, Salary)

📌 Syntax of Struct
struct StructName
{
    // Fields (Variables)
    // Methods
    // Properties
    // Constructors (Parameterless nahi hota)
}
--------------------------------------------------------
📌 Example 1: Basic Structure
using System;

struct Employee
{
    public int Id;
    public string Name;
    public double Salary;

    // Constructor
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        // Structure ka object create karna
        Employee emp1 = new Employee(101, "Rahul", 50000);
        emp1.Display();
    }
}
📌 Output:
ID: 101, Name: Rahul, Salary: 50000

--------------------------------------------------
📌 Example 2: Struct Without Constructor
using System;

struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point p;
        p.X = 10;
        p.Y = 20;
        Console.WriteLine($"Point: ({p.X}, {p.Y})");
    }
}
📌 Output:
Point: (10, 20)
----------------------------------------------------
📌 Example 3: Struct with Readonly Fields
using System;

struct Rectangle
{
    public readonly int Width;
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle Width: {Width}, Height: {Height}");
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(10, 20);
        rect.Display();
    }
}
📌 Output:
Rectangle Width: 10, Height: 20
-------------------------------------------------------
📌 Example 4: Passing Struct to a Method (By Value & By Reference)
using System;

struct Product
{
    public string Name;
    public double Price;

    public void Display()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}

class Program
{
    static void UpdatePrice(Product p)
    {
        p.Price = 999.99;
    }

    static void UpdatePriceByRef(ref Product p)
    {
        p.Price = 999.99;
    }

    static void Main()
    {
        Product product = new Product { Name = "Laptop", Price = 50000 };

        UpdatePrice(product);
        Console.WriteLine("After passing by value:");
        product.Display(); // Price remains unchanged

        UpdatePriceByRef(ref product);
        Console.WriteLine("After passing by reference:");
        product.Display(); // Price updates
    }
}
📌 Output:
After passing by value:
Product: Laptop, Price: 50000
After passing by reference:
Product: Laptop, Price: 999.99
--------------------------------------------------------
📌 When to Use Structs in C#?
✅ Jab aapko small data structures chahiye
✅ Jab aapko high-performance memory-efficient solution chahiye
✅ Jab aapko inheritance ki zaroorat nahi hai
✅ Jab aapko garbage collection overhead avoid karna hai

❌ Avoid Structs When:
❌ Object ka size bada ho (kyunki stack par load badhta hai)
❌ Inheritance ya polymorphism chahiye
-----------------------------------------------------------
📌 Interview Questions on Structs
🔹 Q: Struct aur Class me kya difference hai?
✅ A: Struct value type hoti hai jo stack me store hoti hai, whereas class reference type hoti hai jo heap me store hoti hai.

🔹 Q: Struct me constructor mandatory hai kya?
✅ A: Nahi, lekin agar aap custom constructor define karein to saare fields initialize karne chahiye.

🔹 Q: Kya Struct me methods hote hain?
✅ A: Haan, struct ke andar methods, properties, aur readonly fields ho sakte hain.

🔹 Q: Struct ko method me by reference kaise pass karte hain?
✅ A: ref keyword use karke pass kar sakte hain.