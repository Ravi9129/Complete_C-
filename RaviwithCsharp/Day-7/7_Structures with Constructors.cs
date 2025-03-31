using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 7_Structures with Constructors
    {
        
    }
}
----------------------------------------------
Can Structures Have Constructors?
✅ Haan, C# me structures (structs) constructors support karte hain, lekin kuch restrictions ke saath.
✅ Aap parameterized constructors bana sakte ho, lekin default constructor (parameterless) nahi hota.
✅ Agar struct ka object bina constructor ke create hota hai, toh sabhi fields apni default values lete hain.

📌 Example 1: Structure with a Parameterized Constructor
using System;

struct Employee
{
    public int Id;
    public string Name;
    public double Salary;

    // Parameterized Constructor
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
        // Constructor ke saath object initialize karna
        Employee emp1 = new Employee(101, "Rahul", 50000);
        emp1.Display();
    }
}
📌 Output:
ID: 101, Name: Rahul, Salary: 50000
✅ Yahaan struct ke andar ek constructor define kiya gaya hai jo saari fields ko initialize karta hai.

📌 Restrictions in Struct Constructors
Struct ka default constructor nahi hota.

Har constructor ko saari fields ko initialize karna hota hai.

Struct constructors me this ka use nahi kar sakte bina initialization ke.

Struct me destructor nahi hota.
-----------------------------------------------------
📌 Example 2: Structure Without Constructor
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
        Point p; // No constructor called
        p.X = 10;
        p.Y = 20;
        Console.WriteLine($"Point: ({p.X}, {p.Y})");
    }
}
✅ Agar aap bina constructor ke struct ka object banate hain, toh uske fields manually initialize karne padenge.

📌 Output:
Point: (10, 20)
------------------------------------------------
📌 Example 3: Structure with Readonly Fields and Constructor
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
✅ Readonly fields ko constructor me initialize kiya ja sakta hai, lekin baad me modify nahi kiya ja sakta.
-------------------------------------------------
📌 Example 4: Structure with Default Values Without Constructor
using System;

struct Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine($"ID: {s.Id}, Name: {s.Name ?? "Default"}");
    }
}
📌 Output:
ID: 0, Name: Default
✅ Struct ka default constructor nahi hota, par jab object create hota hai toh fields ko default values milti hain (int = 0, string = null).
--------------------------------------------------------------------
📌 Example 5: Struct as a Return Type
using System;

struct Car
{
    public string Model;
    public double Price;

    public Car(string model, double price)
    {
        Model = model;
        Price = price;
    }
}

class Program
{
    static Car GetCar()
    {
        return new Car("Tesla", 75000);
    }

    static void Main()
    {
        Car myCar = GetCar();
        Console.WriteLine($"Model: {myCar.Model}, Price: {myCar.Price}");
    }
}
📌 Output:
Model: Tesla, Price: 75000
✅ Struct ko methods se return bhi kiya ja sakta hai.

📌 Important Interview Questions
🔹 Q: Struct ke andar constructor likhne ki kya zaroorat hai?
✅ A: Constructor structure ke fields ko initialize karne me madad karta hai, taki har baar manually initialize na karna pade.

🔹 Q: Struct ka default constructor kyu nahi hota?
✅ A: Struct ek value type hai jo stack memory me store hoti hai, aur default constructor ka koi fayda nahi hota kyunki fields automatic initialize ho jati hain.

🔹 Q: Struct me parameterless constructor kyun allow nahi hota?
✅ A: Kyunki struct ka object jab banega toh wo automatically sabhi fields ko unki default values dega.