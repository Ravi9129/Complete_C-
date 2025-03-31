using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 9_Interface Inheritance
    {
        
    }
}
--------------------------------------
What is Interface Inheritance?
Interface inheritance ka matlab hai ek interface doosre interface ko inherit kare.
C# me, ek interface doosre interface ko inherit kar sakta hai, jisse hume reuse aur code extension ka fayda milta hai.

Interface inheritance ka use karte hue hum ek interface me existing methods aur properties ko inherit karke naye functionality ko add kar sakte hain.

Interface ke through multiple inheritance achieve kiya ja sakta hai, kyunki interface me sirf method signatures hote hain, implementation nahi hota.

🎯 Why Use Interface Inheritance?
1️⃣ Code Reusability – Ek interface dusre interface se methods inherit kar sakta hai, jisse code reuse hota hai.
2️⃣ Extensibility – Interfaces ko extend karke hum naye methods add kar sakte hain without changing the existing implementation.
3️⃣ Multiple Inheritance – Ek class ko multiple interfaces implement karne ki flexibility milti hai.
4️⃣ Loose Coupling – Interface inheritance ke through hum apne code ko loosely couple karte hain, jisse system flexible aur maintainable banta hai.
-------------------------------------------------------
📌 Example 1: Basic Interface Inheritance
using System;

// ✅ Base Interface
interface IAnimal
{
    void Eat();
}

// ✅ Derived Interface inheriting from IAnimal
interface IDomesticAnimal : IAnimal
{
    void Play();
}

// ✅ Class implementing the derived interface
class Dog : IDomesticAnimal
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
Explanation:
IAnimal interface ko IDomesticAnimal inherit kar raha hai.

Dog class IDomesticAnimal ko implement karke IAnimal ke methods ko bhi inherit kar rahi hai.
------------------------------------------------------------------
📌 Example 2: Multiple Interface Inheritance
using System;

// ✅ First Interface
interface IAnimal
{
    void Eat();
}

// ✅ Second Interface
interface IFlyable
{
    void Fly();
}

// ✅ Derived Interface inheriting both IAnimal and IFlyable
interface IFlyingAnimal : IAnimal, IFlyable
{
    void Sleep();
}

// ✅ Class implementing the derived interface
class Eagle : IFlyingAnimal
{
    public void Eat()
    {
        Console.WriteLine("Eagle is eating...");
    }

    public void Fly()
    {
        Console.WriteLine("Eagle is flying...");
    }

    public void Sleep()
    {
        Console.WriteLine("Eagle is sleeping...");
    }
}

class Program
{
    static void Main()
    {
        Eagle eagle = new Eagle();
        eagle.Eat();   // 🔥 Output: Eagle is eating...
        eagle.Fly();   // 🔥 Output: Eagle is flying...
        eagle.Sleep(); // 🔥 Output: Eagle is sleeping...
    }
}
📌 Output:
Eagle is eating...
Eagle is flying...
Eagle is sleeping...
Explanation:
IFlyingAnimal interface IAnimal aur IFlyable dono ko inherit kar raha hai.

Eagle class IFlyingAnimal ko implement karte hue, Eat, Fly, aur Sleep methods define kar rahi hai.
-----------------------------------------------------------------------------------
📌 Example 3: Interface Inheritance with Explicit Implementation
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

// ✅ Derived Interface inheriting both IPrinter and IScanner
interface IMultiFunctionDevice : IPrinter, IScanner
{
    void Copy();
}

// ✅ Class implementing the derived interface
class MultiFunctionPrinter : IMultiFunctionDevice
{
    void IPrinter.Print()  // Explicit Interface Implementation
    {
        Console.WriteLine("Printing document...");
    }

    void IScanner.Print()  // Explicit Interface Implementation
    {
        Console.WriteLine("Scanning document...");
    }

    public void Copy()
    {
        Console.WriteLine("Copying document...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionPrinter printer = new MultiFunctionPrinter();
        printer.Copy(); // 🔥 Output: Copying document...

        // Explicit calls for Print methods
        ((IPrinter)printer).Print();  // 🔥 Output: Printing document...
        ((IScanner)printer).Print();  // 🔥 Output: Scanning document...
    }
}
📌 Output:
Copying document...
Printing document...
Scanning document...
Explanation:
IMultiFunctionDevice interface IPrinter aur IScanner ko inherit kar raha hai.

MultiFunctionPrinter class explicitly Print methods ko implement kar rahi hai, kyunki dono interfaces me Print method hai.

📌 Key Points 🔥
Interfaces can inherit other interfaces.
Ek interface doosre interface ko inherit kar sakta hai aur method signatures ko extend kar sakta hai.

A class can implement multiple interfaces.
Ek class multiple interfaces implement kar sakti hai, isse multiple behaviors ko ek class me combine kiya ja sakta hai.

No implementation in interfaces.
Interface me sirf method signatures hote hain, koi implementation nahi hoti. Interface inheritance sirf method signatures ko inherit karta hai.

Multiple inheritance without diamond problem.
Interface inheritance me diamond problem ka issue nahi hota, kyunki interfaces me implementation nahi hoti.

📌 Interview Questions on Interface Inheritance
🔹 Q: Can an interface inherit multiple interfaces in C#?
✅ A: Haan, C# me ek interface multiple interfaces ko inherit kar sakta hai.

🔹 Q: What happens when two interfaces have the same method name in C#?
✅ A: Agar do interfaces me same method name ho, to class explicit implementation kar sakti hai.

🔹 Q: What is the advantage of using interface inheritance in C#?
✅ A: Interface inheritance se code reusability, extensibility, aur multiple inheritance achieve hota hai bina diamond problem ke.

