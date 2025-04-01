using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 2_Multiple Generic Parameters
    {
        
    }
}
-----------------------------------------
What are Multiple Generic Parameters in C#?
🔹 A generic class or method can have multiple type parameters (<T, U, V, ...>).
🔹 This allows a single class or method to work with multiple data types.
🔹 Syntax:

class MyClass<T, U> // 🔥 Two generic parameters
{
    public T First;
    public U Second;
}
✔ Supports multiple data types in one class/method!
-------------------------------------------------------------------
📌 Example 1: Generic Class with Two Type Parameters

class Pair<T, U> // 🔥 Class with two type parameters
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
✔ Same class supports different data types without duplicating code!

📌 Example 2: Multiple Generic Parameters in a Method

class Utility
{
    public static void Print<T, U>(T value1, U value2) // 🔥 Method with two generics
    {
        Console.WriteLine($"Value 1: {value1}, Value 2: {value2}");
    }
}

class Program
{
    static void Main()
    {
        Utility.Print<int, string>(10, "Hello"); // Output: Value 1: 10, Value 2: Hello
        Utility.Print<string, double>("Temperature", 36.5); // Output: Value 1: Temperature, Value 2: 36.5
    }
}
✔ A single method works with multiple data types dynamically!
-----------------------------------------------------------------------------
📌 Example 3: Generic Dictionary (Real-World Use Case)
🔹 Dictionaries use multiple generics:

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Apple");
dict.Add(2, "Banana");

foreach (var item in dict)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
✔ Works with <Key, Value> pairs!
-------------------------------------------------------------------------
📌 Example 4: Generic Repository with Multiple Type Parameters
🔹 A generic repository class that works with multiple data models and primary key types.

class Repository<T, K> where T : class // 🔥 Generic Repository
{
    private Dictionary<K, T> data = new Dictionary<K, T>();

    public void Add(K key, T item)
    {
        data.Add(key, item);
        Console.WriteLine($"Added: {item}");
    }

    public T Get(K key)
    {
        return data.ContainsKey(key) ? data[key] : null;
    }
}

class Product { public string Name { get; set; } }

class Program
{
    static void Main()
    {
        Repository<Product, int> productRepo = new Repository<Product, int>();
        productRepo.Add(1, new Product { Name = "Laptop" });

        var product = productRepo.Get(1);
        Console.WriteLine($"Retrieved: {product?.Name}"); // Output: Retrieved: Laptop
    }
}
✔ Supports different key types (int, string, etc.) dynamically!
------------------------------------------------------------------------
📌 Example 5: Constraints with Multiple Generic Parameters
🔹 We can apply constraints (where T : constraint).

class DataStore<T, U>
    where T : class  // 🔥 T must be a reference type
    where U : struct // 🔥 U must be a value type
{
    public T Data;
    public U ID;
}

class Program
{
    static void Main()
    {
        DataStore<string, int> store = new DataStore<string, int>();
        store.Data = "Hello";
        store.ID = 123;

        Console.WriteLine($"Data: {store.Data}, ID: {store.ID}");
    }
}
✔ T is restricted to class, U to struct (value types).