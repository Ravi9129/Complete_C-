using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 8_Multiple Inheritance with Interface
    {
        
    }
}
------------------------------------------------
What is Multiple Inheritance?
✅ Multiple Inheritance ka matlab hai ki ek class do ya zyada classes se inherit kare.
✅ C# me multiple inheritance directly support nahi hoti classes ke sath, lekin hum interface ka use karke achieve kar sakte hain.
✅ Iska fayda ye hai ki ek class multiple behaviors implement kar sakti hai bina complexity badhaye.

🎯 Why Use Multiple Inheritance with Interfaces?
1️⃣ Code Reusability – Ek class multiple interfaces implement karke reusable code likh sakti hai.
2️⃣ Flexibility – Different functionalities ko alag alag interfaces me rakh sakte hain.
3️⃣ No Diamond Problem – C++ jaisa "diamond problem" C# me nahi hota kyunki interfaces me implementation nahi hoti.
4️⃣ Loosely Coupled System – System independent aur easily extendable hota hai.
-----------------------------------------------------------------------------
📌 Example 1: Implementing Multiple Inheritance with Interfaces
using System;

// ✅ First Interface
interface IAnimal
{
    void Eat();
}

// ✅ Second Interface
interface IPet
{
    void Play();
}

// ✅ Class inheriting multiple interfaces
class Dog : IAnimal, IPet
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating...");
    }

    public void Play()
    {
        Console.WriteLine("Dog is playing...");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();  // 🔥 Output: Dog is eating...
        myDog.Play(); // 🔥 Output: Dog is playing...
    }
}
📌 Output:
Dog is eating...
Dog is playing...
✅ Dog class ek saath IAnimal aur IPet dono ko implement kar rahi hai.
✅ Method overriding se Dog apna behavior define kar raha hai.
---------------------------------------------------------------------------
📌 Example 2: Real-World Scenario (Employee Management System 🏢)
Ek employee system jisme ek class Manager multiple roles ko handle karti hai jaise ki IWorker (jo kaam karta hai) aur ILeader (jo team lead karta hai).

using System;

// ✅ Worker Interface
interface IWorker
{
    void Work();
}

// ✅ Leader Interface
interface ILeader
{
    void Lead();
}

// ✅ Manager class implementing multiple interfaces
class Manager : IWorker, ILeader
{
    public void Work()
    {
        Console.WriteLine("Manager is working on the project.");
    }

    public void Lead()
    {
        Console.WriteLine("Manager is leading the team.");
    }
}

class Program
{
    static void Main()
    {
        Manager mgr = new Manager();
        mgr.Work();  // 🔥 Output: Manager is working on the project.
        mgr.Lead();  // 🔥 Output: Manager is leading the team.
    }
}
📌 Output:
Manager is working on the project.
Manager is leading the team.
✅ Manager class IWorker aur ILeader dono ka kaam kar sakti hai.
✅ Run-time par decide hota hai kaunsa method call hoga.
-----------------------------------------------------------------------
📌 Example 3: Interface Reference Se Multiple Inheritance
Agar hume interface reference se method call karna ho:

using System;

// ✅ Interface 1
interface IDrive
{
    void Start();
}

// ✅ Interface 2
interface IFly
{
    void Fly();
}

// ✅ Class implementing both interfaces
class FlyingCar : IDrive, IFly
{
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }

    public void Fly()
    {
        Console.WriteLine("Car is flying in the sky!");
    }
}

class Program
{
    static void Main()
    {
        IDrive car = new FlyingCar();
        car.Start(); // 🔥 Output: Car is starting...

        IFly airplane = new FlyingCar();
        airplane.Fly(); // 🔥 Output: Car is flying in the sky!
    }
}
✅ FlyingCar class ek saath IDrive aur IFly dono interfaces implement kar rahi hai.
✅ Ek object ke through alag alag behavior access kar sakte hain.
----------------------------------------------------------------
📌 Example 4: Explicit Interface Implementation (Avoiding Conflicts)
Agar do interfaces me same method name ho, to explicit interface implementation use karte hain.
using System;

// ✅ First Interface
interface IPrinter
{
    void Print();
}

// ✅ Second Interface
interface IScanner
{
    void Print();
}

// ✅ Class implementing both interfaces
class MultiFunctionDevice : IPrinter, IScanner
{
    // ✅ Explicitly implementing IPrinter's Print
    void IPrinter.Print()
    {
        Console.WriteLine("Printing from Printer...");
    }

    // ✅ Explicitly implementing IScanner's Print
    void IScanner.Print()
    {
        Console.WriteLine("Scanning from Scanner...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionDevice device = new MultiFunctionDevice();

        // 🔥 Correct way to call explicit interface methods
        ((IPrinter)device).Print(); // Output: Printing from Printer...
        ((IScanner)device).Print(); // Output: Scanning from Scanner...
    }
}
✅ Agar IPrinter aur IScanner dono me Print() method ho, to MultiFunctionDevice me dono ko explicitly define karna padega.
✅ Explicit interface implementation se conflict avoid hota hai.
-------------------------------------------------------------------------------
📌 Key Takeaways 🔥
✔ C# me multiple inheritance directly supported nahi hai, but interfaces ka use karke achieve hoti hai.
✔ Ek class ek se zyada interfaces implement kar sakti hai, but ek se zyada base classes inherit nahi kar sakti.
✔ Interfaces se loosely coupled architecture banta hai jo scalable aur maintainable hota hai.
✔ Explicit interface implementation use karne se conflicts avoid kiye ja sakte hain.

📌 Interview Questions on Multiple Inheritance with Interface
🔹 Q: Why does C# not support multiple inheritance but supports multiple interface implementation?
✅ A: C# multiple inheritance support nahi karta taake "Diamond Problem" avoid ho sake, lekin multiple interfaces implement karne ki facility deta hai taake flexibility mile.

🔹 Q: Can we create an object of an interface in C#?
✅ A: Nahi, interface ka object nahi bana sakte, kyunki usme koi implementation nahi hoti.

🔹 Q: What happens if two interfaces have the same method name?
✅ A: Agar do interfaces me same method ho, to class explicit interface implementation use karegi.