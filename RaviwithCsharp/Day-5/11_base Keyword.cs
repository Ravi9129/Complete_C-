using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 11_base Keyword
    {
        
    }
}
---------------------------------------
What is base keyword?
✅ base ek special keyword hai jo child class ke andar parent class ke members ko access karne ke liye use hota hai.
✅ Iska use tab hota hai jab hume explicitly parent class ke constructor, method, ya properties ko call karna ho.

🎯 Use Cases of base Keyword
1️⃣ Parent class ke constructor ko call karne ke liye
2️⃣ Parent class ke method ko override karne ke baad bhi call karne ke liye
3️⃣ Parent class ke properties ya fields ko access karne ke liye
--------------------------------------------------
📌 Example 1: Using base to Call Parent Class Constructor
using System;

class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent class constructor called!");
    }
}

class Child : Parent
{
    public Child() : base()  // ✅ Parent constructor explicitly call ho raha hai
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
✅ base() ka use karke humne parent class ka constructor explicitly call kiya.
✅ Parent class ka constructor hamesha pehle execute hota hai.
-------------------------------------------------------------------------------
📌 Example 2: Using base to Call Parent Class Parameterized Constructor
using System;

class Parent
{
    public Parent(string name)
    {
        Console.WriteLine($"Parent Constructor: Hello {name}");
    }
}

class Child : Parent
{
    public Child(string name) : base(name) // ✅ Parent ka constructor call ho raha hai
    {
        Console.WriteLine("Child Constructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child("Ravi");
    }
}
📌 Output:
Parent Constructor: Hello Ravi
Child Constructor Executed
✅ Parent class ka parameterized constructor base(name) se call kiya.
✅ Child class ka constructor parent ke constructor ke baad execute hota hai.
-------------------------------------------------------------
📌 Example 3: Using base to Access Parent Class Method
using System;

class Parent
{
    public void Show()
    {
        Console.WriteLine("Parent class method");
    }
}

class Child : Parent
{
    public void Display()
    {
        base.Show();  // ✅ Parent class ka method call ho raha hai
        Console.WriteLine("Child class method");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Display();
    }
}
📌 Output:
Parent class method
Child class method
✅ base.Show() se parent class ka method child class me call ho gaya.
---------------------------------------------------------------
📌 Example 4: Using base in Method Overriding
using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class Show method");
    }
}

class Child : Parent
{
    public override void Show()
    {
        base.Show(); // ✅ Parent ka method bhi call hoga
        Console.WriteLine("Child class Show method");
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show();
    }
}
📌 Output:
Parent class Show method
Child class Show method
✅ Method overriding ke baad bhi base.Show() se parent class ka method call kiya ja sakta hai.
-------------------------------------------------------
📌 Example 5: Using base to Access Parent Class Property
using System;

class Parent
{
    public int Value = 10;
}

class Child : Parent
{
    public int Value = 20;

    public void ShowValues()
    {
        Console.WriteLine($"Child Value: {Value}");
        Console.WriteLine($"Parent Value: {base.Value}"); // ✅ Parent class ki property access ho rahi hai
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.ShowValues();
    }
}
📌 Output:
Child Value: 20
Parent Value: 10
✅ base.Value ka use karke parent class ka Value field access kiya.
------------------------------------------------------------
🔥 Conclusion
✔ base ka use parent class ke constructor, method, ya properties ko access karne ke liye hota hai.
✔ Method overriding me base.Method() ka use kar sakte hain taake parent method bhi execute ho.
✔ Agar child class me same naam ka variable ya property hai, to base ka use karke parent ka value access kar sakte hain.