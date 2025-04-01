using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 11_Garbage Collection
    {
        
    }
}
--------------------------------------------
What is Garbage Collection?
✅ Garbage Collection (GC) in C# automatically frees memory by removing unused objects.
✅ It prevents memory leaks and optimizes performance by reclaiming memory occupied by objects no longer in use.
✅ GC works in the .NET CLR (Common Language Runtime) and runs periodically.

📌 How Garbage Collection Works?
🔹 The GC automatically runs when memory is low or when explicitly called.
🔹 It removes objects that are no longer reachable.
🔹 It compacts memory after collection, reducing fragmentation.
-----------------------------------------------------
📌 Example: How GC Works
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Creating objects...");
        
        for (int i = 0; i < 5; i++)
        {
            MyClass obj = new MyClass(i); // ✅ Creating objects inside loop
        }
        
        Console.WriteLine("Forcing garbage collection...");
        GC.Collect();  // ✅ Explicitly calling Garbage Collector
        
        Console.ReadLine();
    }
}

class MyClass
{
    int id;

    public MyClass(int id)
    {
        this.id = id;
        Console.WriteLine($"Object {id} Created");
    }

    ~MyClass() // Destructor (Finalizer)
    {
        Console.WriteLine($"Object {id} Destroyed");
    }
}
✅ Output (May Vary)
Creating objects...
Object 0 Created
Object 1 Created
Object 2 Created
Object 3 Created
Object 4 Created
Forcing garbage collection...
Object 4 Destroyed
Object 3 Destroyed
Object 2 Destroyed
Object 1 Destroyed
Object 0 Destroyed
✔ GC collects objects that go out of scope
✔ Finalizer (~MyClass) runs when GC destroys the object
----------------------------------------------------------
📌 Generations in Garbage Collection
🔹 GC uses a generational model to improve performance.
🔹 Objects are divided into three generations:

Generation 0 (Gen 0) → Newly created, short-lived objects

Generation 1 (Gen 1) → Medium lifespan objects

Generation 2 (Gen 2) → Long-lived objects
---------------------------------------------
📌 Why Generations?
✅ GC focuses on collecting short-lived objects first to optimize performance.
✅ Objects that survive multiple GC cycles move to higher generations.
✅ Gen 2 is collected less frequently because it contains critical, long-lived objects.
-------------------------------------------------
📌 How Generations Work?
using System;

class Program
{
    static void Main()
    {
        // ✅ Creating a short-lived object (Gen 0)
        for (int i = 0; i < 1000; i++)
        {
            var obj = new MyClass();
        }

        // ✅ Forcing Garbage Collection
        Console.WriteLine($"GC Generation of obj: {GC.GetGeneration(new MyClass())}");
        GC.Collect();  

        // ✅ Creating a long-lived object (Gen 2)
        var longLivedObj = new MyClass();
        GC.Collect();
        Console.WriteLine($"Long-lived object is in Generation: {GC.GetGeneration(longLivedObj)}");

        Console.ReadLine();
    }
}

class MyClass { }
✅ Output (May Vary)

GC Generation of obj: 0
Long-lived object is in Generation: 2
✔ Short-lived objects stay in Gen 0.
✔ Long-lived objects move to Gen 2 after surviving multiple collections.
-----------------------------------------------
📌 GC Generation Breakdown
Generation  	Description	Example Objects
Gen 0	      Newly created objects	Temporary variables, method-scoped objects
Gen 1	      Objects that survive 1st GC cycle	Objects used in loops or reused for some time
Gen 2	      Long-lived objects	Global/static objects, database connections
-----------------------------------------------------------------
📌 Forcing Garbage Collection (Not Recommended)

GC.Collect(); // Forces GC (not recommended)
GC.WaitForPendingFinalizers(); // Waits for finalizers to execute
✔ Avoid manual GC calls unless absolutely necessary.
✔ Let the runtime handle memory efficiently.
--------------------------------------------------
📌 When Does GC Run Automatically?
✅ When memory is low
✅ When an object goes out of scope
✅ When the system needs memory optimization