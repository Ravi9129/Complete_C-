using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 13_Method Hiding
    {
        
    }
}
------------------------------------------------------------
What is Method Hiding?
✅ Method Hiding ka matlab hai ki child class apni parent class ki method ko same name se override nahi, balki छुपा (hide) leti hai.
✅ Iske liye new keyword ka use hota hai, jisse child class ki method parent class ki method ko hide kar deti hai.
✅ Agar method hiding na ho, to child class ki method parent class ki method ko override karegi, lekin method hiding me parent class ki method accessible rehti hai (agar explicit call karein).

🎯 Why Use Method Hiding?
1️⃣ Parent class ki method ko override kiye bina naye behavior dene ke liye.
2️⃣ Parent class ki functionality ko hide karke naye functionality dene ke liye.
3️⃣ Multiple versions of method maintain karne ke liye, bina parent class ki method modify kiye.
---------------------------------------------------------------
📌 Example 1: Method Hiding using new Keyword
using System;

class Parent
{
    public void Show()  // ✅ Parent class ka method
    {
        Console.WriteLine("Parent class Show() method called.");
    }
}

class Child : Parent
{
    public new void Show()  // ✅ Child class me same method with 'new' keyword
    {
        Console.WriteLine("Child class Show() method called.");
    }
}

class Program
{
    static void Main()
    {
        Parent obj1 = new Parent();
        obj1.Show(); // ✅ Parent class ka method chalega

        Child obj2 = new Child();
        obj2.Show(); // ✅ Child class ka method chalega

        Parent obj3 = new Child(); // ✅ Reference Parent ka, object Child ka
        obj3.Show(); // ✅ Parent class ka method chalega (method hiding ho gayi)
    }
}
📌 Output:
Parent class Show() method called.
Child class Show() method called.
Parent class Show() method called.
✅ Jab parent class ka reference child object ko hold kar raha hai, tab bhi parent ki method hi call hoti hai.
✅ Is behavior ko method hiding kehte hain.
✅ Agar new keyword use na karein, to compiler warning dega, par method phir bhi hide ho jayegi.
-------------------------------------------------------
📌 Example 2: Method Hiding vs Method Overriding
using System;

class Parent
{
    public virtual void Display()  // ✅ Virtual method (overridable)
    {
        Console.WriteLine("Parent class Display() method called.");
    }
}

class Child : Parent
{
    public new void Display()  // ✅ Method hiding using 'new'
    {
        Console.WriteLine("Child class Display() method called.");
    }
}

class Program
{
    static void Main()
    {
        Parent obj1 = new Parent();
        obj1.Display(); // ✅ Parent method call

        Child obj2 = new Child();
        obj2.Display(); // ✅ Child method call

        Parent obj3 = new Child(); // ✅ Reference Parent ka, object Child ka
        obj3.Display(); // ✅ Parent method call due to method hiding
    }
}
📌 Output:
Parent class Display() method called.
Child class Display() method called.
Parent class Display() method called.
✅ Method hiding me agar parent class ka reference child object ko hold kare to parent ki method hi call hoti hai.
✅ Agar overriding hoti to obj3.Display(); child class ki method call karti.
---------------------------------------------------------------------------
📌 Example 3: Explicitly Calling Hidden Parent Method
Agar hume parent class ki hidden method call karni ho, to base keyword ka use kar sakte hain.

using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent class Show() method called.");
    }
}

class Child : Parent
{
    public new void Show()
    {
        Console.WriteLine("Child class Show() method called.");
        base.Show(); // ✅ Explicitly calling parent method
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show(); // ✅ Child class method ke andar se Parent method call ho rahi hai
    }
}
📌 Output:
Child class Show() method called.
Parent class Show() method called.
✅ Agar child class me base.Show(); likh diya jaye, to method hiding hone ke bawajood parent method ko explicitly call kar sakte hain.
---------------------------------------------------------------------
📌 Example 4: Method Hiding with Properties
Method hiding sirf methods tak limited nahi hai, ye properties ke sath bhi ho sakti hai.
using System;

class Parent
{
    public int Number { get; set; } = 10;  // ✅ Parent property
}

class Child : Parent
{
    public new string Number { get; set; } = "Hello";  // ✅ Property hiding using 'new'
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        Console.WriteLine(obj.Number);  // ✅ Child class ki property call hogi

        Parent obj2 = new Child();
        Console.WriteLine(obj2.Number); // ✅ Parent class ki property call hogi
    }
}
📌 Output:
Hello
10
✅ Method hiding properties ke sath bhi kaam karti hai.
✅ Agar child class me same naam ki property hai, to wo parent class ki property ko hide kar deti hai.
-----------------------------------------------------------------------
📌 Summary
✔ Method hiding tab hoti hai jab child class parent class ki method ka naam same rakh kar new keyword ka use kare.
✔ Method hiding aur method overriding me farq hai:

Method Overriding me override keyword ka use hota hai, aur parent method virtual hoti hai.

Method Hiding me new keyword ka use hota hai, aur parent method virtual nahi hoti. ✔ Method hiding me parent class ka reference agar child object hold kare to parent class ki method hi call hoti hai.
✔ base keyword ka use karke hidden parent method ko explicitly call kiya ja sakta hai.
✔ Method hiding properties ke sath bhi kaam karti hai.