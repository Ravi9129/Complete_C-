using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 12_Destructor
    {
        
    }
}
---------------------------------------
What is a Destructor?
A destructor is a special method in C# that is automatically called when an object is about to be destroyed or garbage collected. It allows you to release any resources (e.g., file handles, database connections, etc.) or clean up any memory that the object holds before it gets destroyed.

📌 Destructor Syntax
In C#, a destructor is defined using the tilde (~) symbol followed by the class name. You cannot pass parameters to a destructor, and it does not return a value.

Syntax:

class ClassName
{
    // Destructor
    ~ClassName()
    {
        // Cleanup code
    }
}
Example:
using System;

class Program
{
    static void Main()
    {
        // Creating objects inside a method
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass();
        
        // Explicitly forcing garbage collection
        GC.Collect();  
        Console.ReadLine();
    }
}

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor: Object created.");
    }

    // Destructor
    ~MyClass()
    {
        Console.WriteLine("Destructor: Object destroyed.");
    }
}
Output:
Constructor: Object created.
Constructor: Object created.
Destructor: Object destroyed.
Destructor: Object destroyed.
Explanation:
The constructor is called when the object is created.

The destructor is called when the object is about to be garbage collected.
-------------------------------------------------------------------------
📌 Key Points About Destructors
Automatic Invocation:
The C# runtime (CLR) automatically calls destructors when the object is no longer in use and is about to be garbage collected.

No Parameters or Return Values:
A destructor cannot accept parameters or return any value.

Finalizer and Destructor:

Destructor in C# is also known as a finalizer.

It is used to perform cleanup tasks before the object is destroyed.

Cannot Be Called Directly:
A destructor cannot be called explicitly like regular methods. The garbage collector calls it when an object is ready for collection.
--------------------------------------------------
📌 How Does Destructor Work?
The destructor is similar to a finalizer in C#. It provides a way to clean up resources before an object is deleted.

What Happens in the Destructor?
Memory Cleanup: Any allocated memory that is no longer needed can be cleaned up.

Release of Resources: Non-memory resources like database connections, file handles, etc., can be released.

CLR Finalization Queue: When an object is finalized, it is added to the finalization queue and the destructor runs during the next garbage collection cycle.
----------------------------------------------------
📌 Destructor vs. Finalizer
Destructor in C# is the same as finalizer.

The finalizer cleans up resources before an object is destroyed.

The destructor is non-deterministic, meaning you cannot predict exactly when it will be called, because it's up to the garbage collector to invoke it.
--------------------------------------------
📌 Why Destructors Are Important?
Resource Cleanup:
Destructors help in cleaning up non-memory resources (like file handles, database connections) that need to be manually released.

Prevent Memory Leaks:
They ensure that memory and other resources are properly cleaned up before objects are collected.

Automation:
The CLR handles when destructors are called, automating cleanup tasks.
-------------------------------------------------------
📌 Destructor and Dispose Pattern
In C#, if your class uses unmanaged resources (like file handles or database connections), it’s a good practice to implement the IDisposable interface for deterministic cleanup.

Deterministic Cleanup allows you to control when resources are released.

Destructor (finalizer) is non-deterministic because you can’t predict when it will be called.

Implementing IDisposable with Destructor
using System;

class MyClass : IDisposable
{
    private bool disposed = false;  // To detect redundant calls

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);  // Prevent finalizer from running
    }

    // Destructor (finalizer)
    ~MyClass()
    {
        Dispose(false);  // Finalizer calls Dispose with false
    }

    // Dispose method to release both managed and unmanaged resources
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Dispose of managed resources
                Console.WriteLine("Disposing managed resources");
            }

            // Dispose of unmanaged resources
            Console.WriteLine("Disposing unmanaged resources");

            disposed = true;
        }
    }
}
Usage:
class Program
{
    static void Main()
    {
        using (var obj = new MyClass())
        {
            // Use obj
        }  // Dispose is called automatically at the end of the 'using' block

        Console.ReadLine();
    }
}
Explanation:
The Dispose method provides deterministic resource cleanup (called explicitly).

The finalizer (~MyClass) is a fallback if Dispose is not called.
-----------------------------------------------------------
📌 When to Use Destructors
Use destructors when you have unmanaged resources (like memory, file handles, etc.) and need to release them before the object is collected.

Use IDisposable interface for deterministic cleanup and finalize only if needed.