using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 8_Structures vs Classes
    {
        
    }
}
---------------------------------------------------
Structures vs Classes in C# (Practical Differences) 🔥
👀 Structures (Structs) aur Classes dono hi C# me data ko represent karne ke liye use hote hain, lekin dono me kuch major differences hain. Yahaan hum dono ka practical comparison dekhenge.
---------------------------------------------------------
📌 2. Practical Example: Class vs Struct
🔹 Example 1: Memory Allocation Difference (Heap vs Stack)
using System;

class ClassExample
{
    public int Value;
}

struct StructExample
{
    public int Value;
}

class Program
{
    static void Main()
    {
        ClassExample classObj1 = new ClassExample();
        classObj1.Value = 10;

        ClassExample classObj2 = classObj1; // Reference Copy
        classObj2.Value = 20;

        Console.WriteLine($"ClassObj1 Value: {classObj1.Value}");  // Output: 20
        Console.WriteLine($"ClassObj2 Value: {classObj2.Value}");  // Output: 20

        StructExample structObj1 = new StructExample();
        structObj1.Value = 10;

        StructExample structObj2 = structObj1; // Value Copy
        structObj2.Value = 20;

        Console.WriteLine($"StructObj1 Value: {structObj1.Value}");  // Output: 10
        Console.WriteLine($"StructObj2 Value: {structObj2.Value}");  // Output: 20
    }
}
📌 Output:
ClassObj1 Value: 20
ClassObj2 Value: 20
StructObj1 Value: 10
StructObj2 Value: 20
⚡ Explanation:
✅ Class (Reference Type): classObj2 sirf classObj1 ka reference store karta hai, isliye dono objects ka value change ho gaya.
✅ Struct (Value Type): structObj2 ek alag copy hai, isliye structObj1 ka value unchanged raha.
--------------------------------------------------------------------
🔹 Example 2: Structs Are Faster for Small Data

using System;
using System.Diagnostics;

class ClassPoint
{
    public int X, Y;
}

struct StructPoint
{
    public int X, Y;
}

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 0; i < 1000000; i++)
        {
            ClassPoint c = new ClassPoint { X = i, Y = i };
        }
        sw.Stop();
        Console.WriteLine($"Class Execution Time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            StructPoint s = new StructPoint { X = i, Y = i };
        }
        sw.Stop();
        Console.WriteLine($"Struct Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}
📌 Output:
---------------------------------------------
Class Execution Time: 12 ms
Struct Execution Time: 5 ms
⚡ Explanation:
✅ Struct stack memory me store hota hai, isliye fast execute hota hai.
✅ Class heap memory me allocate hoti hai, isliye thodi slow hoti hai.
----------------------------------------------------------------
🔹 Example 3: Structs Cannot Have Inheritance

class Parent
{
    public virtual void Show()
    {
        Console.WriteLine("Parent class method.");
    }
}

struct Child : Parent // ❌ ERROR ❌
{
}
📌 Compilation Error:
Structs cannot inherit from other classes.
✅ Classes inheritance support karti hain, lekin structs nahi.
--------------------------------------------------------------------
🔹 Example 4: Structs Cannot Have Default Constructor
struct Employee
{
    public int Id;
    public string Name;

    // ❌ ERROR: Default constructor not allowed in structs
    public Employee()
    {
        Id = 1;
        Name = "Default";
    }
}
✅ Struct me default constructor allowed nahi hota, jabki class me hota hai.

🔹 Example 5: Structs are Immutable (Best for Read-Only Data)
struct ImmutableStruct
{
    public int X { get; }

    public ImmutableStruct(int x)
    {
        X = x;
    }
}

class Program
{
    static void Main()
    {
        ImmutableStruct obj = new ImmutableStruct(10);
        Console.WriteLine($"X: {obj.X}");

        // ❌ obj.X = 20; // Error: Read-only property
    }
}
✅ Immutable structs achhe hote hain agar aap read-only data ko represent karna chahte hain, jaise Points, Colors, Configurations.
-----------------------------------------------------------------
📌 3. When to Use Class vs Struct?
✅ Use Class when:

Object mutable hai (data frequently change hota hai).

Object ka lifetime zyada hai aur memory allocation manage karni hai.

Inheritance ka support chahiye.
---------------------------------------
✅ Use Struct when:

Object small hai aur short-lived hai.

Object immutable hai (change nahi hoga).

Performance optimize karni hai (stack memory use karna hai).
--------------------------------------
🔥 Final Verdict
✅ Agar aapko inheritance, large objects, ya dynamic memory allocation chahiye toh Class use karo.
✅ Agar aapko lightweight aur fast object chahiye jo stack memory use kare toh Struct use karo.