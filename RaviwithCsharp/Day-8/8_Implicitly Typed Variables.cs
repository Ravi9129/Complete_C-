using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 8_Implicitly Typed Variables
    {
        
    }
}
--------------------------------------------------
What is an Implicitly Typed Variable?
✅ In C#, an implicitly typed variable is declared using the var keyword.
✅ The compiler determines the type at compile time based on the assigned value.
✅ It improves readability and reduces redundancy in code.
-----------------------------------------------------------
📌 Syntax of var
var variableName = value;
✔ The data type is inferred from the assigned value.
---------------------------------------------------------------------
📌 Example: Implicit Typing in C#
var message = "Hello, C#!"; // Compiler infers as string
var number = 100;           // Compiler infers as int
var pi = 3.14;              // Compiler infers as double
var isAvailable = true;     // Compiler infers as bool

Console.WriteLine(message.GetType()); // ✅ Output: System.String
Console.WriteLine(number.GetType());  // ✅ Output: System.Int32
Console.WriteLine(pi.GetType());      // ✅ Output: System.Double
Console.WriteLine(isAvailable.GetType()); // ✅ Output: System.Boolean
📌 Rules for Using var
1️⃣ Must be initialized at declaration

var x; // ❌ ERROR: No assignment, compiler cannot infer type
-----------------------------------------------------------
2️⃣ Cannot be assigned null without explicit type

var data = null; // ❌ ERROR: Type cannot be determined
-----------------------------------------------------------------
3️⃣ Cannot be a method parameter or return type (before C# 10)

void Print(var x) { } // ❌ ERROR: Not allowed
---------------------------------------------------------
4️⃣ Not dynamically typed

var x = "Hello";
x = 10; // ❌ ERROR: Once inferred as string, it cannot change to int
------------------------------------------------
📌 Using var in Loops
var numbers = new List<int> { 1, 2, 3, 4, 5 };
foreach (var num in numbers)
{
    Console.WriteLine(num); // ✅ Output: 1 2 3 4 5
}
-----------------------------------------------------
📌 Using var with Anonymous Types
var person = new { Name = "Alice", Age = 25 };
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
// ✅ Output: Name: Alice, Age: 25
✔ var is required for anonymous types since they have no explicit name.
------------------------------------------------------------------
📌 When to Use var (Best Practices)
✅ Use var when the type is obvious

var items = new List<string>(); // ✅ Readable, avoids redundancy
List<string> items = new List<string>(); // ❌ Unnecessary repetition
-------------------------------------------
✅ Use var with LINQ

var result = items.Where(x => x.StartsWith("A")); // ✅ More readable
---------------------------------------------
🚫 Avoid var when it reduces readability

var db = new Dictionary<int, List<Tuple<string, int>>>(); // ❌ Hard to read
Dictionary<int, List<Tuple<string, int>>> db = new Dictionary<int, List<Tuple<string, int>>>(); /