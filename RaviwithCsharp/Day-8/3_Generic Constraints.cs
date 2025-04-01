using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 3_Generic Constraints
    {
        
    }
}
-----------------------------------------
What are Generic Constraints?
✅ Generic constraints are rules that restrict what types can be used as a type parameter (T) in a generic class or method.
✅ Without constraints, any type (class, struct, interface, etc.) can be used for T.
✅ Constraints increase type safety and allow access to specific methods or properties of constrained types.

📌 Syntax of Generic Constraints
class ClassName<T> where T : ConstraintType
🚀 Common Constraints:

Constraint	Description
where T : struct	T must be a value type (like int, double, DateTime)
where T : class	T must be a reference type (like string, ArrayList, List<T>)
where T : new()	T must have a parameterless constructor
where T : BaseClass	T must be derived from a specific class
where T : InterfaceName	T must implement an interface
where T : U	T must be or inherit from U
-----------------------------------------------------------------
📌 Example 1: where T : struct (Only Value Types)
🚀 ✅ Restricts T to value types (like int, float, DateTime).

class ValueStore<T> where T : struct  // 🔥 Only value types allowed
{
    public T Value;
    public ValueStore(T value) { Value = value; }
    public void Display() => Console.WriteLine($"Value: {Value}");
}

class Program
{
    static void Main()
    {
        ValueStore<int> intStore = new ValueStore<int>(100);
        intStore.Display();  // ✅ Output: Value: 100

        ValueStore<double> doubleStore = new ValueStore<double>(99.99);
        doubleStore.Display();  // ✅ Output: Value: 99.99

        // ❌ Error: string is a reference type
        // ValueStore<string> strStore = new ValueStore<string>("Hello"); 
    }
}
✔ Prevents accidental use of reference types like string!
-----------------------------------------------------------------------------------
📌 Example 2: where T : class (Only Reference Types)
🚀 ✅ Restricts T to reference types (like string, List<T>, object).

class ReferenceStore<T> where T : class // 🔥 Only reference types allowed
{
    public T Data;
    public ReferenceStore(T data) { Data = data; }
    public void Display() => Console.WriteLine($"Data: {Data}");
}

class Program
{
    static void Main()
    {
        ReferenceStore<string> strStore = new ReferenceStore<string>("Hello C#");
        strStore.Display(); // ✅ Output: Data: Hello C#

        ReferenceStore<List<int>> listStore = new ReferenceStore<List<int>>(new List<int> { 1, 2, 3 });
        listStore.Display();  // ✅ Output: Data: System.Collections.Generic.List`1[System.Int32]

        // ❌ Error: int is a value type
        // ReferenceStore<int> intStore = new ReferenceStore<int>(100); 
    }
}
✔ Ensures T is always a reference type!
------------------------------------------------------------------------------
📌 Example 3: where T : new() (Must Have a Parameterless Constructor)
🚀 ✅ Allows creating new instances of T inside the generic class.

class Factory<T> where T : new() // 🔥 T must have a parameterless constructor
{
    public T CreateInstance()
    {
        return new T(); // ✅ Creates a new instance of T
    }
}

class Product { public string Name = "Laptop"; }

class Program
{
    static void Main()
    {
        Factory<Product> productFactory = new Factory<Product>();
        Product p = productFactory.CreateInstance();
        Console.WriteLine($"Product Name: {p.Name}"); // ✅ Output: Product Name: Laptop

        // ❌ Error: No parameterless constructor in int
        // Factory<int> intFactory = new Factory<int>(); 
    }
}
✔ Prevents errors when calling new T() inside a generic class!
--------------------------------------------------------------------------
📌 Example 4: where T : BaseClass (Must Inherit from a Specific Class)
🚀 ✅ Ensures T is a subclass of BaseClass, allowing access to base class properties.

class Animal { public string Name { get; set; } }
class Dog : Animal { public string Breed { get; set; } }

class AnimalShelter<T> where T : Animal // 🔥 Only subclasses of Animal allowed
{
    public T Pet { get; set; }
    public AnimalShelter(T pet) { Pet = pet; }
    public void ShowInfo() => Console.WriteLine($"Pet Name: {Pet.Name}");
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog { Name = "Buddy", Breed = "Labrador" };
        AnimalShelter<Dog> shelter = new AnimalShelter<Dog>(dog);
        shelter.ShowInfo();  // ✅ Output: Pet Name: Buddy

        // ❌ Error: int does not inherit from Animal
        // AnimalShelter<int> invalidShelter = new AnimalShelter<int>(100); 
    }
}
✔ Ensures T is always an Animal or a subclass!
----------------------------------------------------------------------------------
📌 Example 5: where T : InterfaceName (Must Implement an Interface)
🚀 ✅ Ensures T implements an interface, enforcing method requirements.

interface ILogger { void Log(string message); }

class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"Log: {message}");
}

class LoggerService<T> where T : ILogger // 🔥 Only classes that implement ILogger
{
    private T _logger;
    public LoggerService(T logger) { _logger = logger; }
    public void LogMessage(string msg) => _logger.Log(msg);
}

class Program
{
    static void Main()
    {
        LoggerService<ConsoleLogger> logger = new LoggerService<ConsoleLogger>(new ConsoleLogger());
        logger.LogMessage("Hello C#"); // ✅ Output: Log: Hello C#

        // ❌ Error: string does not implement ILogger
        // LoggerService<string> invalidLogger = new LoggerService<string>("Log");
    }
}
✔ Forces T to implement ILogger, preventing missing methods!
----------------------------------------------------------------
📌 Example 6: where T : U (T Must Inherit from U)
🚀 ✅ Ensures T is the same type or a derived type of U.

class Repository<T, U> where T : U // 🔥 T must be U or a subclass of U
{
    public void PrintType() => Console.WriteLine(typeof(T));
}

class Person { }
class Employee : Person { }

class Program
{
    static void Main()
    {
        Repository<Employee, Person> repo = new Repository<Employee, Person>();
        repo.PrintType(); // ✅ Output: Employee

        // ❌ Error: int is not a subclass of Person
        // Repository<int, Person> invalidRepo = new Repository<int, Person>();
    }
}
✔ Prevents unrelated types from being used!
-------------------------------------------------
