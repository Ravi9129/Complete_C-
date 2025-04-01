using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 7_Pattern Matching
    {
        
    }
}
---------------------------------------
What is Pattern Matching in C#?
✅ Pattern Matching allows us to check the structure of an object and extract values in a clean, readable way.
✅ It helps replace complex if-else and switch statements with concise and type-safe code.
✅ Introduced in C# 7 and enhanced in C# 8, 9, 10, and later.

📌 Types of Pattern Matching in C#
1️⃣ Type Pattern
2️⃣ Constant Pattern
3️⃣ Relational Pattern
4️⃣ Logical Pattern
5️⃣ Property Pattern
6️⃣ Tuple Pattern
7️⃣ Positional Pattern
----------------------------------------------------------------------
📌 1. Type Pattern (Checking Type and Casting)
🚀 Used to check the type of an object and safely cast it.

using System;

class Program
{
    static void PrintObject(object obj)
    {
        if (obj is string text)
        {
            Console.WriteLine($"It's a string: {text.ToUpper()}");
        }
        else if (obj is int number)
        {
            Console.WriteLine($"It's a number: {number * 2}");
        }
        else
        {
            Console.WriteLine("Unknown type");
        }
    }

    static void Main()
    {
        PrintObject("Hello");
        PrintObject(42);
        PrintObject(3.14);
    }
}
✅ Output:
It's a string: HELLO  
It's a number: 84  
Unknown type  
✔ Automatically casts (string text, int number) without explicit casting!
--------------------------------------------------------------
📌 2. Constant Pattern (Checking Fixed Values)
🚀 Checks if a value is equal to a constant

void CheckNumber(int number)
{
    if (number is 0)
        Console.WriteLine("Zero");
    else if (number is 1 or 2 or 3)
        Console.WriteLine("Small number");
    else
        Console.WriteLine("Big number");
}

CheckNumber(1);  // ✅ Output: Small number
CheckNumber(5);  // ✅ Output: Big number
CheckNumber(0);  // ✅ Output: Zero
---------------------------------------------------------------
📌 3. Relational Pattern (Comparisons in Pattern Matching)
🚀 Uses <, >, <=, >= inside switch expressions!

string GetGrade(int marks) => marks switch
{
    >= 90 => "A+",
    >= 80 => "A",
    >= 70 => "B",
    >= 60 => "C",
    < 60 => "Fail"
};

Console.WriteLine(GetGrade(85)); // ✅ Output: A
Console.WriteLine(GetGrade(55)); // ✅ Output: Fail
✔ Eliminates if-else ladder!
-----------------------------------------------------------
📌 4. Logical Pattern (and, or, not)
🚀 Combines multiple conditions with and, or, not keywords

string Category(int age) => age switch
{
    >= 13 and <= 19 => "Teenager",
    < 13 => "Child",
    > 19 => "Adult"
};

Console.WriteLine(Category(15)); // ✅ Output: Teenager
Console.WriteLine(Category(10)); // ✅ Output: Child
✔ More readable than nested if-else!
-------------------------------------------------
📌 5. Property Pattern (Checking Object Properties)
🚀 Checks object properties in switch expressions

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

string GetPersonCategory(Person p) => p switch
{
    { Age: < 18 } => "Minor",
    { Age: >= 18 and <= 60 } => "Adult",
    { Age: > 60 } => "Senior Citizen"
};

Console.WriteLine(GetPersonCategory(new Person { Name = "John", Age = 25 })); // ✅ Output: Adult
✔ No need for if-else! Directly checks properties!
-------------------------------------------------------------
📌 6. Tuple Pattern (Matching Multiple Values)
🚀 Matches multiple values using tuples

string GetSeason(int month, bool isSouthernHemisphere) => (month, isSouthernHemisphere) switch
{
    (12 or 1 or 2, false) => "Winter",
    (3 or 4 or 5, false) => "Spring",
    (6 or 7 or 8, false) => "Summer",
    (9 or 10 or 11, false) => "Autumn",
    (_, true) => "Southern Hemisphere - Different Seasons"
};

Console.WriteLine(GetSeason(6, false)); // ✅ Output: Summer
✔ Matches multiple values at once!
-------------------------------------------------
📌 7. Positional Pattern (Decomposing Objects in Pattern Matching)
🚀 Works with deconstructor methods

class Point
{
    public int X { get; }
    public int Y { get; }
    
    public Point(int x, int y) => (X, Y) = (x, y);
    
    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}

string GetQuadrant(Point p) => p switch
{
    ( > 0, > 0) => "First Quadrant",
    ( < 0, > 0) => "Second Quadrant",
    ( < 0, < 0) => "Third Quadrant",
    ( > 0, < 0) => "Fourth Quadrant",
    _ => "On Axis"
};

Console.WriteLine(GetQuadrant(new Point(3, 4)));  // ✅ Output: First Quadrant
✔ Extracts values automatically!
 
-----------------------------------------------------
📌 Real-World Uses of Pattern Matching
✔ Replacing Long if-else Chains
✔ Building Dynamic switch Expressions
✔ Safely Extracting Data from Objects
✔ Simplifying Type Checking