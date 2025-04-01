using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 13_IDisposable 
    {
        
    }
}
--------------------------------------
What is IDisposable?
IDisposable is an interface in C# that provides a standard mechanism for releasing unmanaged resources (like file handles, database connections, network connections, etc.) and other non-memory resources before an object is garbage collected.

Interface Definition:

public interface IDisposable
{
    void Dispose();
}
The Dispose method is used to release or clean up resources explicitly. Unlike destructors (finalizers), which are called by the garbage collector, Dispose allows for deterministic resource management—meaning you can explicitly control when the resources are released.
------------------------------------------------------------------
📌 Why Use IDisposable?
In .NET, garbage collection automatically cleans up managed resources (like objects in memory), but it doesn’t handle unmanaged resources. Unmanaged resources are resources that the garbage collector doesn't manage (e.g., file handles, database connections, network sockets, etc.). If not released explicitly, these resources may cause memory leaks or other issues like excessive memory usage or resource starvation.

When to Implement IDisposable:
When your class uses unmanaged resources or wraps objects that do.

When your class needs to implement deterministic cleanup (i.e., explicitly freeing resources when you're done with them).

📌 Implementing IDisposable
To use IDisposable, your class must implement the Dispose method to release the resources it’s holding.
----------------------------------------------------------------
Example: Basic Implementation
using System;

class MyClass : IDisposable
{
    private bool disposed = false;  // Flag to track if the object has already been disposed

    // Managed resource (e.g., database connection)
    private System.IO.StreamReader reader;

    public MyClass()
    {
        reader = new System.IO.StreamReader("example.txt");
    }

    // Implement Dispose method from IDisposable interface
    public void Dispose()
    {
        // Call the Dispose method with the flag indicating we are disposing
        Dispose(true);
        // Suppress finalization (no need for the garbage collector to call the finalizer)
        GC.SuppressFinalize(this);
    }

    // Helper method to perform cleanup
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Dispose managed resources (e.g., reader)
                reader?.Dispose();
            }

            // Dispose unmanaged resources (if any)
            disposed = true;
        }
    }

    // Destructor (finalizer) - called by GC if Dispose wasn't called
    ~MyClass()
    {
        Dispose(false);
    }
}
Explanation:
Dispose method: Releases both managed and unmanaged resources.

Managed resources are resources that are managed by the .NET runtime (like StreamReader, database connections, etc.).

Unmanaged resources are resources that the .NET runtime doesn’t automatically handle (e.g., file handles, memory allocated via IntPtr, etc.).

Destructor (finalizer): Ensures cleanup if Dispose wasn't explicitly called. It only handles unmanaged resources and acts as a fallback mechanism.

SuppressFinalize: Prevents the garbage collector from calling the finalizer after Dispose is called, which improves performance by avoiding unnecessary finalization.

📌 Using IDisposable with the using Statement
In C#, the using statement provides a convenient way to ensure that Dispose is called automatically at the end of a block of code. This is particularly useful for deterministic cleanup.
-------------------------------------------------------------
Example: Using IDisposable with using
using System;

class Program
{
    static void Main()
    {
        // The Dispose method is called automatically at the end of the using block
        using (var obj = new MyClass())
        {
            // Use obj here (e.g., read file)
        }  // obj.Dispose() is automatically called here
    }
}
Explanation:
The using statement automatically calls the Dispose method when the block is finished executing, ensuring proper cleanup of resources.

Even if an exception occurs within the using block, Dispose will still be called, preventing resource leaks.
----------------------------------------------------------------
📌 Best Practices for Implementing IDisposable
Dispose Method Should Be Safe to Call Multiple Times:

Your Dispose method should check if the object has already been disposed to avoid attempting to dispose of resources multiple times.

Dispose Unmanaged Resources:

If your class holds unmanaged resources, be sure to free them in the Dispose method.

Implement a Destructor (Optional):

Implement a destructor (finalizer) to ensure cleanup if Dispose is not called, but always call GC.SuppressFinalize(this) in the Dispose method to prevent the finalizer from running if the object was disposed properly.

Use Dispose in a using Statement:

Use using wherever possible to make sure resources are automatically cleaned up.

Don't Override Dispose without a Reason:

If the base class already implements Dispose, override it only if you need to release additional resources or manage subclass-specific cleanup.
----------------------------------------------------------------
📌 Example with Multiple Resources
In more complex scenarios, your class may need to manage multiple resources, both managed and unmanaged.

using System;
using System.IO;

class ComplexClass : IDisposable
{
    private FileStream fileStream;
    private StreamWriter writer;
    private bool disposed = false;

    public ComplexClass(string fileName)
    {
        fileStream = new FileStream(fileName, FileMode.Create);
        writer = new StreamWriter(fileStream);
    }

    public void WriteData(string data)
    {
        if (disposed)
            throw new ObjectDisposedException(nameof(ComplexClass));

        writer.WriteLine(data);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Dispose managed resources
                writer?.Dispose();
                fileStream?.Dispose();
            }

            // Release unmanaged resources (if any)

            disposed = true;
        }
    }

    ~ComplexClass()
    {
        Dispose(false);
    }
}
Explanation:
FileStream and StreamWriter are managed resources, so they are disposed of when Dispose is called.

The finalizer ensures cleanup if Dispose is not called manually.