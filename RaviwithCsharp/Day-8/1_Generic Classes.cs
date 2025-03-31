using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 1_Generic Classes
    {
        
    }
}
----------------------------------------
What is a Generic Class in C#?
🔹 A generic class is a class that can work with any data type.
🔹 Instead of specifying a fixed data type, we use type parameters (like <T>).
🔹 Generics improve code reusability, type safety, and performance.

📌 Why Use Generic Classes?
✅ Code Reusability – Write once, use with multiple data types.
✅ Type Safety – Prevents runtime type errors.
✅ Performance – Avoids unnecessary boxing/unboxing (for value types).
-----------------------------------------------
📌 Syntax of Generic Class

class MyClass<T> // 🔥 Generic class with type parameter T
{
    public T Value; // Generic field

    public MyClass(T val) // Constructor
    {
        Value = val;
    }

    public void Show()
    {
        Console.WriteLine($"Value: {Value}");
    }
}
✔ Now this class can store any data type!
-------------------------------------------------------------
📌 Example 1: Using Generic Class with Different Data Types

class Box<T> // Generic class
{
    public T Item; // Generic field

    public Box(T item)
    {
        Item = item;
    }

    public void Display()
    {
        Console.WriteLine($"Stored Item: {Item}");
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>(100); // 🔥 T = int
        intBox.Display(); // Output: Stored Item: 100

        Box<string> strBox = new Box<string>("Hello Generics!"); // 🔥 T = string
        strBox.Display(); // Output: Stored Item: Hello Generics!
    }
}
✔ Same class works for int and string, avoiding code duplication.
-------------------------------------
📌 Example 2: Generic Class for a Stack (Real-World Use Case)
class Stack<T> // 🔥 Generic Stack class
{
    private T[] items;
    private int top;

    public Stack(int size)
    {
        items = new T[size];
        top = -1;
    }

    public void Push(T item) // Push operation
    {
        if (top == items.Length - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        items[++top] = item;
    }

    public T Pop() // Pop operation
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack Underflow");
        }
        return items[top--];
    }
}

class Program
{
    static void Main()
    {
        Stack<int> intStack = new Stack<int>(3);
        intStack.Push(10);
        intStack.Push(20);
        Console.WriteLine(intStack.Pop()); // Output: 20

        Stack<string> strStack = new Stack<string>(2);
        strStack.Push("Hello");
        strStack.Push("World");
        Console.WriteLine(strStack.Pop()); // Output: World
    }
}
✔ A generic stack works for both int and string without extra code!
------------------------------------------
📌 Example 3: Multiple Generic Parameters (<T, U>)
class Pair<T, U> // 🔥 Generic class with two types
{
    public T First { get; set; }
    public U Second { get; set; }

    public Pair(T first, U second)
    {
        First = first;
        Second = second;
    }

    public void Display()
    {
        Console.WriteLine($"Pair: {First}, {Second}");
    }
}

class Program
{
    static void Main()
    {
        Pair<int, string> pair1 = new Pair<int, string>(1, "One");
        pair1.Display(); // Output: Pair: 1, One

        Pair<string, double> pair2 = new Pair<string, double>("Price", 99.99);
        pair2.Display(); // Output: Pair: Price, 99.99
    }
}
✔ Supports multiple types in the same class!
--------------------------------
📌 Constraints in Generic Classes (where T : <constraint>)
✅ Restrict types that can be used in a generic class.

🔹 Example: Restrict T to only class types
class MyClass<T> where T : class
{
    public T Data;
}
✅ Other Constraints:

Constraint	Description
where T : class	T must be a reference type
where T : struct	T must be a value type
where T : new()	T must have a parameterless constructor
where T : BaseClass	T must inherit from BaseClass
where T : IInterface	T must implement IInterface
--------------------------------------------
📌 Real-World Scenario: Repository Pattern with Generics
🔹 A repository class that works with any entity type (Product, Customer, etc.).

class Repository<T> where T : class, new() // 🔥 Generic Repository
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
        Console.WriteLine($"Added: {item}");
    }

    public List<T> GetAll() => items;
}

class Product { public string Name { get; set; } }

class Program
{
    static void Main()
    {
        Repository<Product> productRepo = new Repository<Product>();
        productRepo.Add(new Product { Name = "Laptop" });
    }
}
✔ One generic repository class works for multiple entity types!

📌 Summary
Feature       	Generics
Definition   	A class that works with multiple data types
Syntax	       class MyClass<T> {}
Advantages   	Code reusability, type safety, performance
Constraints 	where T : class, where T : struct, etc.
Real-World    	Generic Collections, Repository Pattern, Caching
