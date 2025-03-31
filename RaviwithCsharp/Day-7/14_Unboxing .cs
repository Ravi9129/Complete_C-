using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 14_Unboxing 
    {
        
    }
}
------------------------------------------------
Unboxing in C# – Deep Explanation with Examples 🔥
📌 What is Unboxing in C#?
🔹 Unboxing is the process of converting a reference type (object) back into a value type (int, double, char, etc.).
🔹 It is the reverse process of Boxing.
🔹 Unboxing requires explicit casting to extract the value from the object.
--------------------------------------------
📌 Simple Example of Unboxing
object obj = 10; // 🔥 Boxing (value type → object)
int num = (int)obj; // 🔥 Unboxing (object → value type)

Console.WriteLine(num); // Output: 10
✔ Here, obj (stored in heap) is explicitly cast back to int.
✔ Without explicit casting (int)obj, unboxing will fail.
----------------------------------------
📌 How Unboxing Works in Memory?
🛠 Before Unboxing:

Stack:                   Heap:
+---------+              +-----------+
| obj (ref) |  ----->   | Value: 10  |
+---------+              +-----------+
🛠 After Unboxing (object → int):
Stack:
+-------+
| num=10 |
+-------+
✔ The value 10 is moved back from heap to stack.
------------------------------------------------------
📌 Example: Without Explicit Casting (Error❌)
object obj = 20;
int num = obj; // ❌ Error: Cannot implicitly convert 'object' to 'int'
🔴 Unboxing requires explicit casting (int)obj, otherwise compilation fails.

✔ Fixed Version:
object obj = 20;
int num = (int)obj; // ✅ Explicit casting required
------------------------------------------------------
📌 Unboxing Different Data Types
object obj1 = 100;   // Boxing an int
object obj2 = 3.14;  // Boxing a double
object obj3 = 'A';   // Boxing a char

int num = (int)obj1;     // Unboxing int
double pi = (double)obj2; // Unboxing double
char ch = (char)obj3;     // Unboxing char

Console.WriteLine(num); // Output: 100
Console.WriteLine(pi);  // Output: 3.14
Console.WriteLine(ch);  // Output: A
✔ Explicit conversion is required for every type.
------------------------------------
📌 Unboxing with Null Value (Error❌)
⚠️ If you try to unbox null, it throws an exception:

object obj = null;
int num = (int)obj; // ❌ Throws NullReferenceException
✔ Always check for null before unboxing:

object obj = null;
if (obj != null)
{
    int num = (int)obj; // Safe unboxing
}
else
{
    Console.WriteLine("Cannot unbox a null value!");
}
-------------------------------------
📌 Performance Impact of Unboxing 🚀
🔴 Unboxing is costly because it:

Moves data from heap back to stack

Requires explicit casting

Causes performance issues in loops or large-scale applications

⚠️ Avoid frequent unboxing for better performance!
--------------------------------------------------
📌 Example: Avoiding Unboxing
🔹 Bad Example (Unnecessary Boxing/Unboxing)

object obj = 50; // Boxing
int num = (int)obj; // Unboxing
Console.WriteLine(num);
🔹 Better Alternative (Avoid Unboxing)


int num = 50;
Console.WriteLine(num); // ✅ No boxing/unboxing
✔ Using direct value types avoids unnecessary unboxing.

📌 Summary
Feature            	Unboxing
Definition       	Converting object → value type (int, double, etc.)
Memory           	Moves data from heap → stack
Performance      	Slow (heap access, explicit casting)
Implicit/Explicit?   	Explicit casting required (int)obj
Use Cases	When retrieving value types from collections (ArrayList, Hashtable, etc.)