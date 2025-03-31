using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 1_Sealed Classes
    {
        
    }
}
---------------------------------------------------------
What is a Sealed Class?
✅ Sealed class ek aisi class hoti hai jo inherit nahi ho sakti.
✅ Agar kisi class ke aage sealed keyword lagaya jaye, to us class ko kisi aur class se extend nahi kiya ja sakta.
✅ Yeh mostly tab use hoti hai jab hume kisi class ki functionality ko restrict karna ho taake koi usme inheritance ke through changes na kar sake.

🎯 Why Use Sealed Classes?
1️⃣ Security aur Data Integrity – Agar kisi class ka behavior fix rakhna ho aur kisi ko usko modify nahi karne dena ho.
2️⃣ Performance Improvement – Sealed classes thodi fast hoti hain kyunki runtime optimization ke waqt compiler inhe efficiently handle karta hai.
3️⃣ Preventing Unintended Inheritance – Agar koi class inherit hone ke liye design nahi ki gayi hai, to usse sealed bana dena best practice hota hai.
4️⃣ Immutable Objects – Agar kisi class ki properties ya behavior immutable (unchangeable) ho, to usse sealed declare karna better hai.
---------------------------------------------------------------------------------
📌 Example 1: Basic Sealed Class
using System;

sealed class FinalClass  // ✅ Sealed class, cannot be inherited
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
}

// ❌ This will cause a compilation error
// class DerivedClass : FinalClass { }  // ❌ ERROR: Cannot inherit from sealed class

class Program
{
    static void Main()
    {
        FinalClass obj = new FinalClass();
        obj.Display(); // ✅ Allowed
    }
}
📌 Output:
This is a sealed class.
✅ Sealed class ka object toh bana sakte hain, lekin usse inherit nahi kar sakte.
---------------------------------------------------------------------------------
📌 Example 2: Sealed Method Inside a Normal Class
Agar ek class sealed nahi hai, lekin uske andar koi specific method ko override hone se rokna hai, to sealed keyword method ke saath use kar sakte hain.

using System;

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class Show() method.");
    }
}

class Child : Parent
{
    public sealed override void Show()  // ✅ Sealed method
    {
        Console.WriteLine("Child class Show() method.");
    }
}

// ❌ GrandChild cannot override Show() method
class GrandChild : Child
{
    // public override void Show() { }  // ❌ ERROR: Cannot override sealed method
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show(); // ✅ Child class ka method call hoga
    }
}
📌 Output:
Child class Show() method.
✅ sealed method ko further override nahi kiya ja sakta.
-------------------------------------------------------------------
📌 Example 3: Performance Optimization using Sealed Class
Jab koi class sealed hoti hai, to JIT (Just-In-Time) compiler usse efficiently optimize karta hai kyunki compiler ko pata hota hai ki koi bhi derived class override nahi karegi.

using System;

sealed class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        MathOperations obj = new MathOperations();
        Console.WriteLine($"Sum: {obj.Add(10, 5)}");
        Console.WriteLine($"Product: {obj.Multiply(10, 5)}");
    }
}
📌 Output:
Sum: 15
Product: 50
✅ Compiler optimized sealed class ka execution fast hota hai.
-----------------------------------------------------------------------
📌 Summary
✔ Sealed class inherit nahi ki ja sakti.
✔ Sealed method override nahi ki ja sakti.
✔ Sealed classes performance optimize karti hain kyunki compiler efficiently handle karta hai.
✔ Agar kisi class ka behavior fixed rakhna ho ya immutable object chahiye ho, to usse sealed bana sakte hain.
✔ Sealed classes new object bana sakti hain, lekin derived classes nahi bana sakti.