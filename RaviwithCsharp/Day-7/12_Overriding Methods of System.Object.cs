using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 12_Overriding Methods of System.Object
    {
        
    }
}
-------------------------------------------------
Overriding Methods of System.Object in C# 🔥
📌 System.Object Methods Ko Override Karna Kyun Zaroori Hai?
C# me har ek class System.Object se inherit hoti hai aur uske 4 important methods ko override karna best practice hoti hai jab:
✅ Custom String Representation chahiye (ToString())
✅ Objects ki value-based comparison chahiye (Equals())
✅ Hash tables ya collections me object ka unique identity chahiye (GetHashCode())



📌 2. Overriding ToString() - Custom String Representation
🔹 By Default: ToString() class ka naam return karta hai.
🔹 Override karne se meaningful output milega.

✅ Example: Custom ToString()
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Person [Name: {Name}, Age: {Age}]";
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "Ali", Age = 25 };
        Console.WriteLine(p1.ToString()); // Person [Name: Ali, Age: 25]
    }
}
✔ Now instead of Person, hume ek readable output mil raha hai.
----------------------------------------------------------------------
📌 3. Overriding Equals(object obj) - Value-Based Comparison
🔹 Default Behavior: Equals() reference ko compare karta hai.
🔹 Agar objects ka data compare karna ho toh isko override karna zaroori hai.

✅ Example: Value-Based Comparison
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person p)
            return this.Name == p.Name && this.Age == p.Age;

        return false;
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "Ali", Age = 25 };
        Person p2 = new Person { Name = "Ali", Age = 25 };

        Console.WriteLine(p1.Equals(p2)); // ✅ True (Value-based comparison)
    }
}
✔ Ab yeh object ki values compare karega, na ke memory references.
----------------------------------------------------------
📌 4. Overriding GetHashCode() - Unique Hash for Collections
🔹 Default Behavior: Har object ka random integer hash generate hota hai.
🔹 Agar Equals() override karein toh GetHashCode() bhi override karna best practice hai.

✅ Example: Hash Code Based on Name
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode(); // XOR operation
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "Ali", Age = 25 };
        Console.WriteLine(p1.GetHashCode()); // Unique hash based on Name and Age
    }
}
✔ Ab Dictionary ya HashSet me Person ka hash predictable hoga.
---------------------------------------------------
📌 5. Overriding Finalize() - Destructor for Cleanup
🔹 Finalize method C# me Destructor ka alternative hai jo memory cleanup karta hai.
🔹 Yeh method tabhi chalta hai jab Garbage Collector (GC) object destroy karta hai.
🔹 Recommended: Agar manual cleanup karna hai toh IDisposable use karein instead of Finalize().

✅ Example: Cleaning Up Resources
using System;

class Resource
{
    public Resource()
    {
        Console.WriteLine("Resource Created");
    }

    ~Resource()
    {
        Console.WriteLine("Resource Destroyed");
    }
}

class Program
{
    static void Main()
    {
        Resource r = new Resource();
    } // Jab GC run karega, destructor chalega
}
✔ Yeh destructor automatic memory cleanup karta hai jab object destroy hota hai.
✔ But Dispose() method recommended hai manual cleanup ke liye.
----------------------------------------------------------------------------
📌 6. Practical Example: Overriding Multiple Methods
✅ Scenario: Comparing Products in an E-Commerce App
✔ Each product ka unique ID, Name aur Price hota hai.
✔ Comparison Equals() override karke value-based banayenge.
✔ Hash table ke liye GetHashCode() customize karenge.
✔ Meaningful string representation ke liye ToString() override karenge.

using System;

class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price:C}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Product p)
            return this.ProductID == p.ProductID;

        return false;
    }

    public override int GetHashCode()
    {
        return ProductID.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product { ProductID = 101, Name = "Laptop", Price = 50000 };
        Product p2 = new Product { ProductID = 101, Name = "Laptop", Price = 50000 };

        Console.WriteLine(p1.ToString());  // Product: Laptop, Price: ₹50,000.00
        Console.WriteLine(p1.Equals(p2));  // ✅ True (ID-based comparison)
        Console.WriteLine(p1.GetHashCode());  // Unique Hash Code
    }
}
✔ Ab Equals() sirf ProductID ko compare karega, na ki references.
✔ GetHashCode() predictably same hash return karega for same IDs.

-------------------------------------------------
🔥 Final Thoughts
✔ Agar aap custom objects use kar rahe hain (Products, Employees, Orders, etc.), toh Equals(), ToString(), aur GetHashCode() override karna zaroori hai.
✔ Override ToString() for better readability.
✔ Override Equals() for meaningful object comparison.
✔ Override GetHashCode() for efficient dictionary/hashset usage.
✔ Use Finalize() only if absolutely necessary; prefer Dispose() instead.