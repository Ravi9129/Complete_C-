using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 5_Nullable Types
    {
        
    }
}
------------------------------------------
What are Nullable Types?
✅ Nullable types allow value types (int, double, bool, etc.) to hold null values.
✅ Syntax: int? x = null; (shorthand for Nullable<int>)
✅ Why? Because value types (int, double, bool) cannot normally be null, unlike reference types (string, object).

📌 How to Declare Nullable Types?
-------------------------------------------------
✅ 1️⃣ Using ? Operator (Shorthand)
int? age = null;  // ✅ Nullable int
double? price = 99.99;  // ✅ Can hold null or a double value
bool? isAvailable = null;  // ✅ Nullable bool
✅ 2️⃣ Using Nullable<T> (Full Syntax)

Nullable<int> age = null; // Same as int?
Nullable<double> price = 49.99; // Same as double?
✔ Both approaches work the same way!
---------------------------------------------------------------------------------
📌 Example 1: Checking for null Before Using a Nullable Type
🚀 Avoid NullReferenceException by checking HasValue

class Program
{
    static void Main()
    {
        int? number = null;

        if (number.HasValue)  // ✅ Checks if 'number' contains a value
            Console.WriteLine($"Number: {number.Value}");  
        else
            Console.WriteLine("Number is null");  // ✅ Output: Number is null
    }
}
✔ Use .HasValue to check if a nullable type contains a value.
✔ Use .Value to access the actual value.
---------------------------------------------------------
📌 Example 2: Using the ?? (Null Coalescing) Operator
🚀 ✅ Provides a default value if null

class Program
{
    static void Main()
    {
        int? num1 = null;
        int result = num1 ?? 100;  // ✅ If num1 is null, use 100

        Console.WriteLine(result); // ✅ Output: 100
    }
}
✔ If num1 is null, it assigns 100 instead.
-----------------------------------------------------------------------------
📌 Example 3: Using ??= (Null Coalescing Assignment)
🚀 ✅ Assigns a default value only if null

class Program
{
    static void Main()
    {
        int? x = null;
        x ??= 50;  // ✅ Assigns 50 if x is null

        Console.WriteLine(x);  // ✅ Output: 50
    }
}
✔ Works like x = x ?? 50; but shorter!
--------------------------------------------------------------
📌 Example 4: Nullable Types in Methods
🚀 ✅ Methods returning null for value types

class Program
{
    static int? GetAge()
    {
        return null; // ✅ Can return null
    }

    static void Main()
    {
        int? age = GetAge();
        Console.WriteLine(age ?? -1);  // ✅ Output: -1 (Default if null)
    }
}
✔ Great for optional values!
----------------------------------------------------------
📌 Example 5: Nullable Boolean
🚀 ✅ Handling true, false, and null states

class Program
{
    static void Main()
    {
        bool? isCompleted = null;

        if (isCompleted == true)
            Console.WriteLine("Task completed");
        else if (isCompleted == false)
            Console.WriteLine("Task not completed");
        else
            Console.WriteLine("Task status unknown"); // ✅ Output: Task status unknown
    }
}
✔ Useful for "yes/no/unknown" logic!
---------------------------------------------------------
📌 Example 6: Nullable Arithmetic Operations
🚀 ✅ If any operand is null, result is null

int? a = 5;
int? b = null;
int? sum = a + b;  // ✅ Result is null

Console.WriteLine(sum ?? 0);  // ✅ Output: 0 (Default if null)
✔ Any null in an operation makes the result null!
---------------------------------------------------------------------
📌 Example 7: Casting Nullable Types
🚀 ✅ Explicitly converting a nullable type

int? x = 100;
int y = (int)x; // ✅ Explicit conversion

Console.WriteLine(y); // ✅ Output: 100
✔ Safe because x has a value.
✔ Use ?? to prevent errors if null.
----------------------------------------------------------
📌 Example 8: Checking for null in LINQ Queries
🚀 ✅ Filtering out null values

List<int?> numbers = new List<int?> { 10, null, 20, null, 30 };
var validNumbers = numbers.Where(n => n.HasValue).Select(n => n.Value).ToList();

Console.WriteLine(string.Join(", ", validNumbers)); // ✅ Output: 10, 20, 30
✔ Removes null values efficiently!
------------------------------------------------------------------------
📌 Example 9: Nullable Structs
🚀 ✅ struct can be nullable
struct Employee
{
    public string Name;
    public int? Age;
}

class Program
{
    static void Main()
    {
        Employee? emp = null; // ✅ Nullable struct
        Console.WriteLine(emp.HasValue ? emp.Value.Name : "No Employee"); // ✅ Output: No Employee
    }
}
✔ Entire struct can be null.