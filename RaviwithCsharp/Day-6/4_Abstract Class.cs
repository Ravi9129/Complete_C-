using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 4_Abstract Class
    {
        
    }
}
----------------------------------------------------------------------
What is an Abstract Class?
✅ Abstract class ek aisi class hoti hai jo sirf blueprint provide karti hai, lekin khud ka direct object nahi ban sakta.
✅ Isme abstract methods hote hain jo derived classes implement karti hain.
✅ Yeh code reusability aur encapsulation ko improve karta hai.

🎯 Why Use Abstract Classes?
1️⃣ Reusability – Common functionalities ko ek jagah define karne ke liye.
2️⃣ Encapsulation – Derived classes ko sirf necessary functionalities dene ke liye.
3️⃣ Code Consistency – Har derived class ko ek specific pattern follow karne ke liye.
4️⃣ Polymorphism Support – Different implementations but same method signatures rakhne ke liye.
------------------------------------------------------------------------
📌 Example 1: Abstract Class and Method Implementation
using System;

abstract class Animal  // ✅ Abstract Class
{
    public abstract void MakeSound();  // ✅ Abstract Method (No implementation)

    public void Sleep()  // ✅ Concrete Method (With implementation)
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

class Dog : Animal  // ✅ Derived Class
{
    public override void MakeSound()  // ✅ Abstract method ka implementation
    {
        Console.WriteLine("Dog barks: Woof Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()  // ✅ Abstract method ka implementation
    {
        Console.WriteLine("Cat meows: Meow Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound();  // 🔥 Output: Dog barks: Woof Woof!
        myDog.Sleep();      // 🔥 Output: Animal is sleeping.

        Animal myCat = new Cat();
        myCat.MakeSound();  // 🔥 Output: Cat meows: Meow Meow!
        myCat.Sleep();      // 🔥 Output: Animal is sleeping.
    }
}
📌 Output:
Dog barks: Woof Woof!
Animal is sleeping.
Cat meows: Meow Meow!
Animal is sleeping.
✅ Abstract class Animal sirf ek structure provide karti hai, actual implementation derived classes Dog aur Cat me hoti hai.
-------------------------------------------------------------------------------
📌 Example 2: Real-World Use Case – Payment System
Agar ek application me different payment methods hain (CreditCard, PayPal, BankTransfer), toh abstract class ka use kar sakte hain.

using System;

abstract class Payment  // ✅ Abstract Class
{
    public abstract void ProcessPayment(double amount);  // ✅ Abstract Method

    public void ShowReceipt(double amount)
    {
        Console.WriteLine($"Receipt: Payment of ${amount} completed.");
    }
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing Credit Card Payment of ${amount}.");
    }
}

class PayPalPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal Payment of ${amount}.");
    }
}

class Program
{
    static void Main()
    {
        Payment payment1 = new CreditCardPayment();
        payment1.ProcessPayment(500);  // 🔥 Output: Processing Credit Card Payment of $500.
        payment1.ShowReceipt(500);    // 🔥 Output: Receipt: Payment of $500 completed.

        Payment payment2 = new PayPalPayment();
        payment2.ProcessPayment(1000); // 🔥 Output: Processing PayPal Payment of $1000.
        payment2.ShowReceipt(1000);   // 🔥 Output: Receipt: Payment of $1000 completed.
    }
}
📌 Output:
Processing Credit Card Payment of $500.
Receipt: Payment of $500 completed.
Processing PayPal Payment of $1000.
Receipt: Payment of $1000 completed.
✅ Abstract class Payment common functionality ShowReceipt() provide karti hai, lekin ProcessPayment() ko har payment method apne tarike se implement karta hai.
---------------------------------------------------
📌 Rules for Abstract Classes
🔹 Abstract class ka object create nahi ho sakta.
🔹 Ek abstract class me abstract aur non-abstract dono methods ho sakte hain.
🔹 Jo class kisi abstract class ko inherit karti hai, usko sare abstract methods implement karne padenge.
🔹 Ek class ek hi abstract class inherit kar sakti hai (Single Inheritance).
-----------------------------------------------------------------
📌 Example 3: Abstract Properties in C#
Abstract properties ko bhi derived classes me implement karna hota hai.
using System;

abstract class Employee
{
    public abstract string Designation { get; set; }  // ✅ Abstract Property

    public void DisplayInfo()
    {
        Console.WriteLine($"Designation: {Designation}");
    }
}

class Manager : Employee
{
    public override string Designation { get; set; } = "Manager";
}

class Developer : Employee
{
    public override string Designation { get; set; } = "Software Developer";
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Manager();
        emp1.DisplayInfo();  // 🔥 Output: Designation: Manager

        Employee emp2 = new Developer();
        emp2.DisplayInfo();  // 🔥 Output: Designation: Software Developer
    }
}
✅ Abstract properties Designation ko Manager aur Developer apne tarike se implement karte hain.

-------------------------------------------------------
📌 Example: Combining Abstract Class and Interface

using System;

interface IVehicle
{
    void Drive();
}

abstract class Vehicle
{
    public abstract void Start();
}

class Car : Vehicle, IVehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Start();  // ✅ Output: Car started.
        myCar.Drive();  // ✅ Output: Car is driving.
    }
}
✅ Abstract class aur interface dono ko ek saath use karne se flexibility badhti hai.
---------------------------------------------------------------
📌 Summary
✔ Abstract class ek blueprint provide karti hai, jo sirf derived classes implement karti hain.
✔ Abstract methods ka koi implementation nahi hota, sirf signature hoti hai.
✔ Abstract properties bhi hoti hain jo derived class me implement hoti hain.
✔ Abstract class me non-abstract methods bhi ho sakte hain jo derived classes directly use kar sakti hain.
✔ Ek class ek hi abstract class inherit kar sakti hai, lekin multiple interfaces implement kar sakti hai.