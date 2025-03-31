using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 14_Method Overriding
    {
        
    }
}
-------------------------------------------------------
What is Method Overriding?
✅ Method Overriding ka matlab hai ki child class parent class ki method ka same naam, return type aur signature rakh kar uska behavior change kar sakti hai.
✅ Iske liye virtual keyword parent class ki method ke liye aur override keyword child class ki method ke liye use hota hai.
✅ Method Overriding runtime polymorphism (dynamic dispatch) ka ek example hai.

🎯 Why Use Method Overriding?
1️⃣ Parent class ki existing functionality ko modify karne ke liye.
2️⃣ Derived (child) class me naye behavior add karne ke liye.
3️⃣ Runtime polymorphism implement karne ke liye.
4️⃣ Agar kisi base class ka method kisi aur tarike se kaam kare aur derived class me usse customize karna ho.
---------------------------------------------------------------
📌 Example 1: Basic Method Overriding
using System;

class Parent
{
    public virtual void Show()  // ✅ Virtual method in parent class
    {
        Console.WriteLine("Parent class Show() method called.");
    }
}

class Child : Parent
{
    public override void Show()  // ✅ Overriding in child class
    {
        Console.WriteLine("Child class Show() method called.");
    }
}

class Program
{
    static void Main()
    {
        Parent obj1 = new Parent();
        obj1.Show(); // ✅ Parent class method call

        Child obj2 = new Child();
        obj2.Show(); // ✅ Child class method call (overridden)

        Parent obj3 = new Child(); // ✅ Parent reference but Child object
        obj3.Show(); // ✅ Child class method call (runtime polymorphism)
    }
}
📌 Output:
Parent class Show() method called.
Child class Show() method called.
Child class Show() method called.
✅ Agar method override hui hai, to child class ka method parent reference se bhi call hoga (runtime polymorphism).
---------------------------------------------------------------------------------
📌 Example 2: Using base Keyword in Method Overriding
Agar hume overridden method ke andar parent class ka original method bhi call karna ho, to base keyword ka use kar sakte hain.

using System;

class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("Parent class Display() method called.");
    }
}

class Child : Parent
{
    public override void Display()
    {
        base.Display(); // ✅ Calling parent method
        Console.WriteLine("Child class Display() method called.");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Display(); // ✅ Both parent and child methods will execute
    }
}
📌 Output:
Parent class Display() method called.
Child class Display() method called.
✅ base.Display(); ke wajah se parent class ka method bhi call ho raha hai.
-------------------------------------------------------------------------------
📌 Example 3: Preventing Method Overriding using sealed Keyword
Agar hume kisi method ko override hone se rokna ho, to usko sealed keyword ke sath mark kar sakte hain.
using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class Show() method called.");
    }
}

class Child : Parent
{
    public sealed override void Show()  // ✅ Sealed method, cannot be overridden further
    {
        Console.WriteLine("Child class Show() method called.");
    }
}

class GrandChild : Child
{
    // ❌ Error: Cannot override sealed method
    // public override void Show() { }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show(); // ✅ Child class method chalega
    }
}
📌 Output:
Child class Show() method called.
✅ sealed keyword ka use karke hum kisi method ko override hone se rok sakte hain.
--------------------------------------------------------------------
📌 Example 4: Difference Between Method Overriding and Method Hiding
using System;

class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("Parent class Display() method called.");
    }
}

class Child : Parent
{
    public new void Display()  // ✅ Method hiding
    {
        Console.WriteLine("Child class Display() method called.");
    }
}

class GrandChild : Parent
{
    public override void Display()  // ✅ Method overriding
    {
        Console.WriteLine("GrandChild class Display() method called.");
    }
}

class Program
{
    static void Main()
    {
        Parent obj1 = new Child();
        obj1.Display(); // ✅ Parent class ka method call hoga (Method Hiding)

        Parent obj2 = new GrandChild();
        obj2.Display(); // ✅ GrandChild ka method call hoga (Method Overriding)
    }
}
📌 Output:
Parent class Display() method called.
GrandChild class Display() method called.
✅ Method Hiding me parent class ki method call hoti hai, agar reference parent ka ho.
✅ Method Overriding me child class ki method call hoti hai, even if reference parent ka ho (runtime polymorphism).
----------------------------------------------------------------------
📌 Summary
✔ Method Overriding tab hoti hai jab child class parent class ki method ka same naam, return type aur signature use kare aur override keyword ka use kare.
✔ Parent class me method virtual honi chahiye, tabhi wo override ho sakti hai.
✔ Overriding se runtime polymorphism implement hota hai.
✔ Agar parent class ki method ko override hone se rokna ho to sealed keyword ka use kar sakte hain.
✔ Method overriding aur method hiding me farq hai:

Method Overriding (override use hota hai, virtual method chahiye, runtime polymorphism).

Method Hiding (new use hota hai, reference parent ka ho to parent method hi chalegi).