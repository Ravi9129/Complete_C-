using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 4_Generic Method
    {
        
    }
}
----------------------------------------------------
What are Generic Methods?
✅ Generic methods allow you to create type-safe methods that work with any data type.
✅ They are defined using type parameters (<T>) inside a method signature.
✅ They improve code reusability and performance by eliminating the need for multiple method overloads.

📌 Syntax of a Generic Method
returnType MethodName<T>(T param)  
{
    // Method implementation
}
🔹 T is a placeholder for any data type.
🔹 You can use multiple generic types like <T, U>.
🔹 Can be used in normal classes, generic classes, or static classes.
-----------------------------------------------------------------------
📌 Example 1: A Simple Generic Method
🚀 ✅ Works with any data type!

class Program
{
    static void PrintData<T>(T data)
    {
        Console.WriteLine($"Value: {data}, Type: {data.GetType()}");
    }

    static void Main()
    {
        PrintData(100);          // ✅ Output: Value: 100, Type: System.Int32
        PrintData("Hello");      // ✅ Output: Value: Hello, Type: System.String
        PrintData(99.99);        // ✅ Output: Value: 99.99, Type: System.Double
        PrintData(true);         // ✅ Output: Value: True, Type: System.Boolean
    }
}
✔ Same method works for int, string, double, bool!
-----------------------------------------------------------------------
📌 Example 2: Generic Method with Two Type Parameters (<T, U>)
🚀 ✅ Pass different types in the same method!

class Program
{
    static void ShowPair<T, U>(T first, U second)
    {
        Console.WriteLine($"First: {first} ({typeof(T)}), Second: {second} ({typeof(U)})");
    }

    static void Main()
    {
        ShowPair(10, "Hello");         // ✅ Output: First: 10 (System.Int32), Second: Hello (System.String)
        ShowPair(true, 99.9);          // ✅ Output: First: True (System.Boolean), Second: 99.9 (System.Double)
        ShowPair("C#", 'A');           // ✅ Output: First: C# (System.String), Second: A (System.Char)
    }
}
✔ Allows different data types for T and U in the same method!
------------------------------------------------------------------------------
📌 Example 3: Generic Method with Constraints (where T : class)
🚀 ✅ Restricts T to only reference types (classes).

class Program
{
    static void DisplayInfo<T>(T obj) where T : class
    {
        Console.WriteLine($"Object Info: {obj}");
    }

    static void Main()
    {
        DisplayInfo("Hello C#");     // ✅ Works (string is a class)
        DisplayInfo(new List<int>()); // ✅ Works (List<T> is a class)

        // ❌ Error: int is not a class
        // DisplayInfo(100);
    }
}
✔ Prevents passing structs like int, double, etc.!
---------------------------------------------------------------------------------
📌 Example 4: Generic Method with Constraints (where T : struct)
🚀 ✅ Restricts T to only value types (like int, double).

class Program
{
    static void PrintNumber<T>(T num) where T : struct
    {
        Console.WriteLine($"Number: {num}");
    }

    static void Main()
    {
        PrintNumber(42);       // ✅ Works (int is a struct)
        PrintNumber(3.14);     // ✅ Works (double is a struct)

        // ❌ Error: string is not a struct
        // PrintNumber("Hello");
    }
}
✔ Ensures T is always a value type!
------------------------------------------------------------
📌 Example 5: Generic Method in a Generic Class
🚀 ✅ Works inside a class that is also generic!

class Container<T>
{
    private T value;

    public void SetValue(T val) { value = val; }
    public void ShowValue() { Console.WriteLine($"Stored Value: {value}"); }

    // 🔥 Generic method inside a generic class
    public void CompareValues<U>(U val1, U val2)
    {
        Console.WriteLine($"Comparing: {val1} and {val2} -> Equal? {val1.Equals(val2)}");
    }
}

class Program
{
    static void Main()
    {
        Container<int> intContainer = new Container<int>();
        intContainer.SetValue(50);
        intContainer.ShowValue(); // ✅ Output: Stored Value: 50

        intContainer.CompareValues("C#", "C#"); // ✅ Output: Comparing: C# and C# -> Equal? True
        intContainer.CompareValues(100, 200);   // ✅ Output: Comparing: 100 and 200 -> Equal? False
    }
}
✔ Supports both generic classes and generic methods!
------------------------------------------------------------------------------
📌 Example 6: Generic Method for Swapping Two Values
🚀 ✅ Works for any type (int, string, etc.)!

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 10, y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}");  // ✅ Output: x: 20, y: 10

        string str1 = "A", str2 = "B";
        Swap(ref str1, ref str2);
        Console.WriteLine($"str1: {str1}, str2: {str2}");  // ✅ Output: str1: B, str2: A
    }
}
✔ Works for any data type, eliminating code duplication!
----------------------------------------------------------------
📌 Example 7: Generic Method with a Return Type
🚀 ✅ Returns the larger value of two generic parameters.

class Program
{
    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    static void Main()
    {
        Console.WriteLine(Max(10, 20));        // ✅ Output: 20
        Console.WriteLine(Max(3.5, 2.8));      // ✅ Output: 3.5
        Console.WriteLine(Max("Apple", "Banana")); // ✅ Output: Banana
    }
}
✔ Uses IComparable<T> to compare values dynamically!

