using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 7_Interfaces 
    {
        
    }
}
-------------------------------------------------
What is an Interface?
✅ Interface ek contract hota hai jo classes ko force karta hai specific methods implement karne ke liye.
✅ Interface sirf method signatures (declaration) provide karta hai, implementation nahi deta.
✅ Ek class multiple interfaces ko implement kar sakti hai, lekin ek hi class se inherit kar sakti hai.

🎯 Why Use Interfaces?
1️⃣ Multiple Inheritance ko enable karna (Since C# me multiple class inheritance allow nahi hai)
2️⃣ Code ko loosely coupled banana (Interface-based programming support karta hai Dependency Injection)
3️⃣ Polymorphism ko implement karna
4️⃣ Testability improve karna (Unit testing me helpful)
5️⃣ Real-world system design me ek standard follow karna
----------------------------------------------------------------------
📌 Example 1: Defining and Implementing an Interface
using System;

// ✅ Interface declaration
interface IAnimal  
{
    void MakeSound();  // 🔥 Method signature only (No implementation)
}

// ✅ Implementing the interface
class Dog : IAnimal  
{
    public void MakeSound()  
    {
        Console.WriteLine("Dog says: Woof Woof!");
    }
}

class Cat : IAnimal  
{
    public void MakeSound()  
    {
        Console.WriteLine("Cat says: Meow Meow!");
    }
}

class Program
{
    static void Main()
    {
        IAnimal myDog = new Dog();
        myDog.MakeSound();  // 🔥 Output: Dog says: Woof Woof!

        IAnimal myCat = new Cat();
        myCat.MakeSound();  // 🔥 Output: Cat says: Meow Meow!
    }
}
📌 Output:
Dog says: Woof Woof!
Cat says: Meow Meow!
✅ Interface IAnimal ko Dog aur Cat classes implement karti hain.
✅ Har class ko interface ki methods ko define karna zaroori hai.
-----------------------------------------------------------
📌 Example 2: Multiple Interfaces in Action (Real-World Use Case: Vehicles 🚗🛵)
Ek vehicle system me Drive aur Fuel ka different behavior ho sakta hai.
using System;

// ✅ Interface 1
interface IDriveable  
{
    void Drive();
}

// ✅ Interface 2
interface IRefuelable  
{
    void Refuel();
}

// ✅ Implementing multiple interfaces
class Car : IDriveable, IRefuelable  
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }

    public void Refuel()
    {
        Console.WriteLine("Car is refueling...");
    }
}

class ElectricScooter : IDriveable  
{
    public void Drive()
    {
        Console.WriteLine("Electric scooter is driving...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Drive();   // 🔥 Output: Car is driving...
        myCar.Refuel();  // 🔥 Output: Car is refueling...

        ElectricScooter myScooter = new ElectricScooter();
        myScooter.Drive();  // 🔥 Output: Electric scooter is driving...
    }
}
📌 Output:
Car is driving...
Car is refueling...
Electric scooter is driving...
✅ Car ne IDriveable aur IRefuelable dono implement kiya, jabki ElectricScooter sirf IDriveable implement karta hai.
✅ Multiple inheritance ko achieve karne ka best tariqa interfaces hain.
---------------------------------------------------------------
📌 Example 3: Interface with Properties
Interface sirf methods nahi, properties bhi contain kar sakta hai.

interface IEmployee  
{
    string Name { get; set; }  // 🔥 Interface property
    void ShowDetails();
}

class Manager : IEmployee  
{
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Manager Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        IEmployee emp = new Manager { Name = "John Doe" };
        emp.ShowDetails();  // 🔥 Output: Manager Name: John Doe
    }
}
📌 Output:
Manager Name: John Doe
✅ Interface me Name property define ki gayi hai, jo Manager class implement karti hai.
---------------------------------------------------------------
📌 Explicit Interface Implementation
Agar do interfaces me same method name ho, to explicit interface implementation ka use kiya jata hai.

interface IPrinter  
{
    void Print();
}

interface IScanner  
{
    void Print();  // 🔥 Same method name in another interface
}

class MultiFunctionPrinter : IPrinter, IScanner  
{
    void IPrinter.Print()  
    {
        Console.WriteLine("Printing document...");
    }

    void IScanner.Print()  
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionPrinter mfp = new MultiFunctionPrinter();

        // ✅ Calling specific interface methods
        ((IPrinter)mfp).Print();  // 🔥 Output: Printing document...
        ((IScanner)mfp).Print();  // 🔥 Output: Scanning document...
    }
}
📌 Output:
Printing document...
Scanning document...
✅ Explicit interface implementation tab use hota hai jab ek class me multiple interfaces ke same method names ho.

--------------------------------------------------

📌 Summary
✔ Interface ek contract hai jo sirf method signatures provide karta hai.
✔ Interface ka koi implementation nahi hota, sirf declare kiya jata hai.
✔ Ek class multiple interfaces implement kar sakti hai.
✔ Interfaces polymorphism aur loosely coupled architecture ko support karte hain.
✔ Interface properties bhi define kar sakte hain.
✔ Explicit interface implementation use hoti hai jab multiple interfaces me same method name ho.