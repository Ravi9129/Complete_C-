using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 1_Constructor 
    {
        
    }
}
------------------------------------------------------
Constructor ek special method hota hai jo automatically call hota hai jab object create hota hai. Yeh initialization ka kaam karta hai, taake object ke andar kuch default values ya dependencies set ki ja sakein.

🚀 Constructor Ka Basic Structure
class Car
{
    public string Model;
    
    // Constructor (Same Name as Class)
    public Car()
    {
        Model = "Tesla"; // Default value set
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car(); // ✅ Constructor automatically call hoga
        Console.WriteLine(myCar.Model); // Output: Tesla
    }
}
✅ Jaise hi Car class ka object create hoga, constructor automatically run ho jayega.

Types of Constructors in C#
------------------------------------------
1️⃣ Default Constructor (No Parameters)
✅ Jab koi constructor define nahi hota, tab C# automatically ek default constructor create kar deta hai.
✅ Agar hum manually likhein, to bhi woh bina parameter wala constructor hota hai.

Example:
class Bike
{
    public string Brand;

    // Default Constructor
    public Bike()
    {
        Brand = "Yamaha";
    }
}

class Program
{
    static void Main()
    {
        Bike b = new Bike();
        Console.WriteLine(b.Brand); // Output: Yamaha
    }
}
✅ Object create hote hi Brand variable me "Yamaha" set ho gaya.
------------------------------------------------------------
2️⃣ Parameterized Constructor (Custom Input)
✅ Agar hume constructor me koi value pass karni ho, to parameterized constructor use hota hai.

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
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Ali", 25);
        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");

        Person p2 = new Person("Ahmed", 30);
        Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");
    }
}
📌 Output:
Name: Ali, Age: 25
Name: Ahmed, Age: 30
✅ Jis bhi object ke saath values pass karenge, uske andar woh values set ho jayengi.
-----------------------------------------------------------
3️⃣ Constructor Overloading
✅ Agar ek class me multiple constructors ho sakte hain jo alag-alag parameters lete hain.
✅ Yeh different types of object initialization ke liye useful hota hai.

Example:

class Laptop
{
    public string Brand;
    public int RAM;

    // Default Constructor
    public Laptop()
    {
        Brand = "Dell";
        RAM = 8;
    }

    // Parameterized Constructor
    public Laptop(string brand, int ram)
    {
        Brand = brand;
        RAM = ram;
    }
}

class Program
{
    static void Main()
    {
        Laptop l1 = new Laptop(); // Default Constructor Call
        Console.WriteLine($"Brand: {l1.Brand}, RAM: {l1.RAM}GB");

        Laptop l2 = new Laptop("HP", 16); // Parameterized Constructor Call
        Console.WriteLine($"Brand: {l2.Brand}, RAM: {l2.RAM}GB");
    }
}
📌 Output:
Brand: Dell, RAM: 8GB
Brand: HP, RAM: 16GB
✅ Ek object bina parameters ke bana, aur dusra parameters ke saath. Dono ko alag constructors ne handle kiya.
--------------------------------------------------------------------------------
4️⃣ Copy Constructor (Duplicate Object Create Karna)
✅ Ek object ki values dusre object me copy karne ke liye use hota hai.

Example:
class Student
{
    public string Name;
    public int Age;

    // Parameterized Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Student(Student obj)
    {
        Name = obj.Name;
        Age = obj.Age;
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Sara", 22); // First Object
        Student s2 = new Student(s1); // Copy Constructor Call

        Console.WriteLine($"Original: {s1.Name}, Age: {s1.Age}");
        Console.WriteLine($"Copy: {s2.Name}, Age: {s2.Age}");
    }
}
📌 Output:
Original: Sara, Age: 22
Copy: Sara, Age: 22
✅ Copy constructor ne s1 ki values s2 me copy kar di.
-------------------------------------------------------------
5️⃣ Static Constructor (Runs Only Once for All Objects)
✅ Yeh sirf ek baar run hota hai jab class first time load hoti hai.
✅ Koi object chahe kitne bhi create ho, yeh dobara run nahi hota.
✅ Mostly static fields ko initialize karne ke liye use hota hai.

Example:
class Database
{
    public static string ConnectionString;

    // Static Constructor
    static Database()
    {
        ConnectionString = "Server=127.0.0.1;Database=MyDB;";
        Console.WriteLine("Static Constructor Called!");
    }
}

class Program
{
    static void Main()
    {
        Database db1 = new Database();
        Database db2 = new Database();
    }
}
📌 Output:
Static Constructor Called!
✅ Chahe db1 aur db2 dono create hue, static constructor sirf ek baar hi run hua.
--------------------------------------------------------------
🚀 Real-World Scenario: Bank Account System
using System;

class BankAccount
{
    public string AccountHolder;
    public double Balance;

    // Constructor
    public BankAccount(string holder, double initialBalance)
    {
        AccountHolder = holder;
        Balance = initialBalance;
        Console.WriteLine($"Account created for {AccountHolder} with balance {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("John", 5000);
        BankAccount acc2 = new BankAccount("Sarah", 10000);
    }
}
📌 Output:
Account created for John with balance 5000
Account created for Sarah with balance 10000
✅ Jaise hi object create hote hain, constructor automatically call hota hai aur balance set hota hai.
-------------------------------------------------
🚀 Conclusion
✅ Constructor automatically call hota hai jab object create hota hai.
✅ Different types of constructors alag-alag use cases ke liye hoti hain.
✅ Real-world applications me constructor se initialization aur dependency injection hota hai.