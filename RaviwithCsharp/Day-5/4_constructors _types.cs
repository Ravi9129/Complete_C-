using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 4_constructors _types
    {
        
    }
}
---------------------------------------------------
C# me 5 types ke constructors hote hain:

1️⃣ Default Constructor
2️⃣ Parameterized Constructor
3️⃣ Copy Constructor
4️⃣ Static Constructor
5️⃣ Private Constructor
------------------------------------------------------
1️⃣ Default Constructor (No Parameters)
✅ Agar koi constructor define nahi kiya, to C# ek default constructor provide karta hai.
✅ Yeh automatically run hota hai jab object create hota hai.
✅ Instance variables ko default values assign karta hai.

Example:
class Car
{
    public string Model;
    
    // Default Constructor (No Parameters)
    public Car()
    {
        Model = "Toyota";
        Console.WriteLine("Default Constructor Called!");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car(); // ✅ Default Constructor Call
    }
}
📌 Output:
Default Constructor Called!
--------------------------------------------------------
2️⃣ Parameterized Constructor
✅ Object create karte waqt values assign karne ke liye use hota hai.
✅ Isme parameters pass kar sakte hain.

Example:
class Person
{
    public string Name;
    public int Age;

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Person Created: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Ali", 25);
        Person p2 = new Person("Sara", 30);
    }
}
📌 Output:
Person Created: Ali, Age: 25
Person Created: Sara, Age: 30
✅ Har object ke liye values alag hain, kyunki parameterized constructor run hota hai.
-------------------------------------------------------
3️⃣ Copy Constructor
✅ Ek object ki values ko dusre object me copy karne ke liye use hota hai.
✅ Ye ek constructor overload hota hai jo ek object ko parameter me leta hai.

Example:
class Laptop
{
    public string Brand;
    public int Price;

    // Parameterized Constructor
    public Laptop(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }

    // Copy Constructor
    public Laptop(Laptop oldLaptop)
    {
        Brand = oldLaptop.Brand;
        Price = oldLaptop.Price;
    }
}

class Program
{
    static void Main()
    {
        Laptop laptop1 = new Laptop("Dell", 50000);
        Laptop laptop2 = new Laptop(laptop1); // Copy Constructor Call

        Console.WriteLine($"Laptop2 Brand: {laptop2.Brand}, Price: {laptop2.Price}");
    }
}
📌 Output:
Laptop2 Brand: Dell, Price: 50000
✅ Laptop1 ka data Laptop2 me copy ho gaya!
------------------------------------------------------------------
4️⃣ Static Constructor
✅ Class ka first use hone par sirf ek baar execute hota hai.
✅ Static fields ko initialize karta hai.
✅ Isme parameters nahi ho sakte.

Example:
class Database
{
    public static string ConnectionString;

    // Static Constructor
    static Database()
    {
        ConnectionString = "Server=localhost;Database=MyDB;";
        Console.WriteLine("Static Constructor Called!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Database.ConnectionString); // Static Constructor Call
    }
}
📌 Output:
Static Constructor Called!
Server=localhost;Database=MyDB;
✅ Static Constructor sirf ek baar chala, chahe multiple objects banayein.
--------------------------------------------------------
5️⃣ Private Constructor
✅ Jab hume class ka object banana restrict karna ho tab use hota hai.
✅ Mostly Singleton Design Pattern implement karne ke liye use hota hai.

Example:
class Singleton
{
    private static Singleton _instance;

    // Private Constructor
    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created!");
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();
        return _instance;
    }
}

class Program
{
    static void Main()
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();
    }
}
📌 Output:
Singleton Instance Created!
✅ Sirf ek instance create hua, chahe multiple objects banane ki koshish ki ho.
------------------------------------------------------------
🚀 Conclusion
✅ C# me different types ke constructors hote hain jo alag-alag scenarios me kaam aate hain.
✅ Default aur Parameterized Constructors most commonly use hote hain.
✅ Static Constructor sirf ek baar class ke first use par call hota hai.
✅ Copy Constructor ek object ka data dusre object me copy karne ke liye use hota hai.
✅ Private Constructor object creation restrict karne ke liye useful hai, jaise Singleton pattern me.