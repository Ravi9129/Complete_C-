using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 12_Parent Class Constructor
    {
        
    }
}
-----------------------------------------------------------
What is a Parent Class Constructor?
✅ Parent class ka constructor ek special method hota hai jo child class ke object create hone par automatically execute hota hai.
✅ Jab bhi ek child class ka object create hota hai, tab sabse pehle parent class ka constructor call hota hai.
✅ Agar koi child class explicit base() use nahi karti, to bhi default constructor parent ka call hota hai.

🎯 Why Use a Parent Class Constructor?
1️⃣ Parent class ke data members initialize karne ke liye.
2️⃣ Child class ko default ya specific values dene ke liye.
3️⃣ Parent class ke kuch important setup execute karne ke liye.
-------------------------------------------------
📌 Example 1: Default Parent Constructor
using System;

class Parent
{
    public Parent() // ✅ Parent class ka constructor
    {
        Console.WriteLine("Parent class constructor called!");
    }
}

class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child class constructor called!");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
    }
}
📌 Output:
Parent class constructor called!
Child class constructor called!
✅ Parent class ka constructor sabse pehle execute hota hai.
✅ Uske baad child class ka constructor execute hota hai.
-----------------------------------------------
📌 Example 2: Parent Class with Parameterized Constructor
using System;

class Parent
{
    public Parent(string message) // ✅ Parameterized constructor
    {
        Console.WriteLine($"Parent Constructor: {message}");
    }
}

class Child : Parent
{
    public Child(string message) : base(message)  // ✅ Parent constructor call ho raha hai
    {
        Console.WriteLine("Child Constructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child("Hello from Parent");
    }
}
📌 Output:
Parent Constructor: Hello from Parent
Child Constructor Executed
✅ base(message) ka use karke parent class ka parameterized constructor call kiya.
--------------------------------------------------------------
📌 Example 3: Parent and Child Both Have Parameterized Constructors
using System;

class Parent
{
    public int Age;
    
    public Parent(int age)
    {
        Age = age;
        Console.WriteLine($"Parent Constructor: Age set to {Age}");
    }
}

class Child : Parent
{
    public string Name;

    public Child(string name, int age) : base(age)  // ✅ Parent constructor call ho raha hai
    {
        Name = name;
        Console.WriteLine($"Child Constructor: Name set to {Name}");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child("Ali", 25);
    }
}
📌 Output:
Parent Constructor: Age set to 25
Child Constructor: Name set to Ali
✅ Parent class ka constructor sabse pehle execute hota hai, phir child class ka.
✅ Child class ka constructor base(age) ka use karke parent constructor ko call karta hai.
----------------------------------------------------------
📌 Example 4: Parent Class Constructor with Default Value
using System;

class Parent
{
    public Parent(string name = "Default Parent") // ✅ Default value ka use
    {
        Console.WriteLine($"Parent Constructor: {name}");
    }
}

class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child Constructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child(); // ✅ Default value pass ho jayegi
    }
}
📌 Output:
Parent Constructor: Default Parent
Child Constructor Executed
✅ Agar child class base() ka use nahi karti, to default value wala parent constructor execute ho jata hai.
-------------------------------------------------------------------------------
📌 Example 5: Multiple Inheritance Scenario (Grandparent → Parent → Child)
using System;

class Grandparent
{
    public Grandparent()
    {
        Console.WriteLine("Grandparent Constructor Executed");
    }
}

class Parent : Grandparent
{
    public Parent()
    {
        Console.WriteLine("Parent Constructor Executed");
    }
}

class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child Constructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
    }
}
📌 Output:
Grandparent Constructor Executed
Parent Constructor Executed
Child Constructor Executed
✅ Jab multiple levels of inheritance hoti hain, to constructor calls top-to-bottom hoti hain.
✅ Sabse pehle grandparent, phir parent, aur last me child constructor execute hota hai.
--------------------------------------------------------------------------------------------
🔥 Summary
✔ Parent class ka constructor child class ke object create hone par sabse pehle execute hota hai.
✔ Agar child class parameterized constructor use kar rahi hai, to base(parameter) ka use karke parent constructor call kar sakti hai.
✔ Agar parent class ka parameterized constructor hai, aur child usko explicitly call nahi karti, to error aayega.
✔ Parent → Child → Grandchild inheritance me constructor execution top-to-bottom hota hai.