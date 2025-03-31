using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 10_inheritance 
    {
        
    }
}
-----------------------------------------------------
What is Inheritance?
✅ Inheritance ek OOP concept hai jo ek class ko doosri class ke features (properties, methods, fields) inherit karne ki permission deta hai.
✅ Yeh code reuse karne aur duplicate code ko avoid karne ke liye use hota hai.
✅ Parent/Base class ke saare members child/derived class me available hote hain (except private members).

🎯 Basic Syntax of Inheritance
class ParentClass  
{
    // Base class properties and methods  
}

class ChildClass : ParentClass  
{
    // Derived class inherits ParentClass  
}
📌 Example 1: Simple Inheritance
using System;

class Animal  // ✅ Base Class (Parent)
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal  // ✅ Derived Class (Child)
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();  // ✅ Parent class ka method use ho raha hai
        myDog.Bark(); // ✅ Child class ka method use ho raha hai
    }
}
📌 Output:
Eating...
Barking...
✅ Dog class ne Animal class ka method Eat() inherit kiya hai.
✅ Child class ke object se parent class ke public methods access ho sakte hain.
----------------------------------------------
📌 Example 2: Constructor in Inheritance
using System;

class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent Constructor Called!");
    }
}

class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child Constructor Called!");
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

Parent Constructor Called!
Child Constructor Called!
✅ Pehle parent class ka constructor call hota hai, fir child class ka.
----------------------------------------------------------
📌 Example 3: Method Overriding in Inheritance
using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class method");
    }
}

class Child : Parent
{
    public override void Show()
    {
        Console.WriteLine("Child class method (Overridden)");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show(); // ✅ Child class ka method execute hoga
    }
}
📌 Output:
Child class method (Overridden)
✅ override keyword se hum parent class ke method ko child class me modify kar sakte hain.

📌 Types of Inheritance in C#
1️⃣ Single Inheritance → Ek parent aur ek child class hoti hai.
2️⃣ Multilevel Inheritance → Ek class doosri class se inherit karti hai, jo ek aur class se inherit hoti hai.
3️⃣ Hierarchical Inheritance → Ek parent class se multiple child classes inherit karti hain.
4️⃣ Multiple Inheritance (via Interfaces) → Ek class multiple interfaces inherit kar sakti hai.
--------------------------------------------------------
📌 Example 4: Multilevel Inheritance
using System;

class GrandParent
{
    public void Show1() => Console.WriteLine("GrandParent method");
}

class Parent : GrandParent
{
    public void Show2() => Console.WriteLine("Parent method");
}

class Child : Parent
{
    public void Show3() => Console.WriteLine("Child method");
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show1(); // ✅ GrandParent method
        obj.Show2(); // ✅ Parent method
        obj.Show3(); // ✅ Child method
    }
}
📌 Output:
GrandParent method
Parent method
Child method
✅ Ek class doosri class se aur wo class teesri class se inherit ho rahi hai.
-----------------------------------------------------------
📌 Example 5: Multiple Inheritance via Interfaces
using System;

interface IOne
{
    void MethodOne();
}

interface ITwo
{
    void MethodTwo();
}

class MyClass : IOne, ITwo
{
    public void MethodOne() => Console.WriteLine("Method from Interface One");
    public void MethodTwo() => Console.WriteLine("Method from Interface Two");
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.MethodOne();
        obj.MethodTwo();
    }
}
📌 Output:
Method from Interface One
Method from Interface Two
✅ C# me direct multiple class inheritance possible nahi hai, lekin interfaces se achieve kar sakte hain.
---------------------------------------------------------
🔥 Conclusion
✔ Inheritance se code reuse hota hai aur structure maintain rehta hai.
✔ Private members inherit nahi hote, lekin protected members child class me accessible hote hain.
✔ Method Overriding ka use karke hum child class me parent class ka behavior modify kar sakte hain.
✔ Interfaces ka use multiple inheritance achieve karne ke liye hota hai.