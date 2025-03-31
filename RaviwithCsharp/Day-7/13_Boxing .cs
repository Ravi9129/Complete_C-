using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 13_Boxing 
    {
        
    }
}
-------------------------------------------------
Boxing in C# – Deep Explanation with Examples 🔥
📌 What is Boxing in C#?
🔹 Boxing is the process of converting a value type (like int, double, char) into a reference type (object).
🔹 When a value type is boxed, it gets stored in the heap memory instead of the stack.
🔹 Boxing happens implicitly when assigning a value type to an object or an interface.

📌 Simple Example of Boxing
int num = 10;  // Value type (stored in stack)
object obj = num; // 🔥 Boxing happens here (value type → reference type)

Console.WriteLine(obj); // Output: 10
✔ Here, num (int) is automatically converted into an object.
✔ The integer value gets wrapped inside an object and moved to heap memory.
------------------------------------------
📌 How Boxing Works in Memory?
🛠 Before Boxing:
Stack:
+-------+
| num=10 |
+-------+
🛠 After Boxing (int → object):

Stack:                   Heap:
+---------+              +-----------+
| obj (ref) |  ----->   | Value: 10  |
+---------+              +-----------+
✔ The value 10 is moved to heap, and obj stores a reference to that heap object.
------------------------------------------------------
📌 Implicit Boxing Example
C# automatically boxes a value type when assigned to an object:

object obj1 = 20;  // Boxing of an int
object obj2 = 'A'; // Boxing of a char
object obj3 = 3.14; // Boxing of a double

Console.WriteLine(obj1); // Output: 20
Console.WriteLine(obj2); // Output: A
Console.WriteLine(obj3); // Output: 3.14
✔ No explicit conversion is needed.
✔ Boxing happens automatically when assigning a value type to an object.
---------------------------------------------
📌 Boxing with Interfaces
Boxing also happens when a value type is assigned to an interface variable:

interface IExample
{
    void Show();
}

struct Demo : IExample
{
    public void Show()
    {
        Console.WriteLine("Struct implementing Interface");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        IExample ie = d; // 🔥 Boxing occurs here
        ie.Show(); // Output: Struct implementing Interface
    }
}
✔ The struct Demo is boxed because ie is an interface (reference type).

📌 Performance Impact of Boxing 🚀
🔴 Boxing is costly because it:

Moves data from stack to heap (memory allocation needed).

Creates a new object in heap every time boxing happens.

Affects performance in loops or large-scale applications.

⚠️ Avoid frequent boxing to improve performance!
----------------------------------------
📌 Example: Avoiding Unnecessary Boxing
🔹 Bad Example (Unnecessary Boxing)

int num = 100;
object obj = num; // ❌ Boxing
Console.WriteLine(obj);
🔹 Better Alternative (Avoid Boxing)

int num = 100;
Console.WriteLine(num); // ✅ No boxing
✔ Directly using num avoids unnecessary boxing.
---------------------------------------------
📌 Summary
Feature        	Boxing
Definition       	Converting value type → reference type (object)
Memory	          Moves data from stack → heap
Performance      	Slow (creates new heap object)
Implicit/Explicit?  	Happens implicitly
Use Cases        	When storing value types in collections (ArrayList, Hashtable, etc.)