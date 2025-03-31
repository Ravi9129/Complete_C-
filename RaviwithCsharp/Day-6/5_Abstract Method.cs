using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 5_Abstract Method
    {
        
    }
}
--------------------------------------------------
What is an Abstract Method?
✅ Abstract method ek aisi method hoti hai jo sirf method signature define karti hai, lekin uska implementation nahi hota.
✅ Iska implementation sirf derived classes karti hain.
✅ Abstract method sirf abstract class ke andar hoti hai.

🎯 Why Use Abstract Methods?
1️⃣ Forces Derived Classes to Implement Important Behavior
2️⃣ Ensures Consistency in Derived Classes
3️⃣ Supports Polymorphism
4️⃣ Provides a Template for Common Behavior
-------------------------------------------------------------
📌 Example 1: Abstract Method with Different Implementations

using System;

abstract class Animal  
{
    public abstract void MakeSound();  // ✅ Abstract Method (No implementation)

    public void Sleep()  // ✅ Concrete Method
    {
        Console.WriteLine("Animal is sleeping...");
    }
}

class Dog : Animal  
{
    public override void MakeSound()  // ✅ Abstract method ka implementation
    {
        Console.WriteLine("Dog says: Woof Woof!");
    }
}

class Cat : Animal  
{
    public override void MakeSound()  // ✅ Abstract method ka implementation
    {
        Console.WriteLine("Cat says: Meow Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound();  // 🔥 Output: Dog says: Woof Woof!
        myDog.Sleep();      // 🔥 Output: Animal is sleeping...

        Animal myCat = new Cat();
        myCat.MakeSound();  // 🔥 Output: Cat says: Meow Meow!
        myCat.Sleep();      // 🔥 Output: Animal is sleeping...
    }
}
📌 Output:
Dog says: Woof Woof!
Animal is sleeping...
Cat says: Meow Meow!
Animal is sleeping...
✅ Abstract method MakeSound() ka implementation derived classes Dog aur Cat me hota hai.
-----------------------------------------------------------
📌 Example 2: Real-World Use Case – Payment System
Har payment method ka processing alag hota hai, lekin sabko ek ProcessPayment() method implement karni padegi.
using System;

abstract class Payment  
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
        Console.WriteLine($"Processing Credit Card Payment of ${amount}...");
    }
}

class PayPalPayment : Payment  
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal Payment of ${amount}...");
    }
}

class Program
{
    static void Main()
    {
        Payment payment1 = new CreditCardPayment();
        payment1.ProcessPayment(500);  // 🔥 Output: Processing Credit Card Payment of $500...
        payment1.ShowReceipt(500);    // 🔥 Output: Receipt: Payment of $500 completed.

        Payment payment2 = new PayPalPayment();
        payment2.ProcessPayment(1000); // 🔥 Output: Processing PayPal Payment of $1000...
        payment2.ShowReceipt(1000);   // 🔥 Output: Receipt: Payment of $1000 completed.
    }
}
📌 Output:
Processing Credit Card Payment of $500...
Receipt: Payment of $500 completed.
Processing PayPal Payment of $1000...
Receipt: Payment of $1000 completed.
✅ Abstract method ProcessPayment() ka implementation CreditCardPayment aur PayPalPayment classes me hota hai.
-------------------------------------------------
📌 Rules for Abstract Methods
🔹 Abstract method sirf abstract class ke andar hoti hai.
🔹 Abstract method ka koi body nahi hota, sirf method signature hoti hai.
🔹 Jo class kisi abstract class ko inherit karegi, usko sare abstract methods implement karne padenge.
🔹 Abstract methods ko override keyword se implement kiya jata hai.
🔹 Abstract methods static, private, ya sealed nahi ho sakti.
----------------------------------------------
📌 Example 3: Abstract Methods in Banking System
Ek bank system me different accounts hote hain, jisme har account ka interest calculation method alag hota hai.
using System;

abstract class BankAccount  
{
    public abstract void CalculateInterest();  // ✅ Abstract Method

    public void ShowBalance()
    {
        Console.WriteLine("Balance displayed.");
    }
}

class SavingsAccount : BankAccount  
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Savings Account Interest: 4% per annum.");
    }
}

class CurrentAccount : BankAccount  
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Current Account Interest: 0% (No Interest).");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new SavingsAccount();
        acc1.CalculateInterest();  // 🔥 Output: Savings Account Interest: 4% per annum.
        acc1.ShowBalance();       // 🔥 Output: Balance displayed.

        BankAccount acc2 = new CurrentAccount();
        acc2.CalculateInterest();  // 🔥 Output: Current Account Interest: 0% (No Interest).
        acc2.ShowBalance();       // 🔥 Output: Balance displayed.
    }
}
📌 Output:
Savings Account Interest: 4% per annum.
Balance displayed.
Current Account Interest: 0% (No Interest).
Balance displayed.
✅ Abstract method CalculateInterest() ka alag implementation har account type me diya gaya hai.
-------------------------------------------------------
📌 Example: Virtual Method vs Abstract Method
abstract class Vehicle
{
    public abstract void Start();  // ✅ Abstract Method
    public virtual void Stop()  // ✅ Virtual Method
    {
        Console.WriteLine("Vehicle is stopping.");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public override void Stop()  // ✅ Overriding Virtual Method
    {
        Console.WriteLine("Car is stopping.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.Start();  // 🔥 Output: Car is starting.
        myCar.Stop();   // 🔥 Output: Car is stopping.
    }
}
✅ Abstract method Start() ka implementation zaroori hai, lekin virtual method Stop() ka override optional hai.
-------------------------------------------------------------
📌 Summary
✔ Abstract method ek blueprint provide karti hai jo derived classes implement karti hain.
✔ Abstract method ka koi implementation nahi hota.
✔ Abstract class sirf abstract methods nahi, concrete methods bhi contain kar sakti hai.
✔ Har derived class ko abstract methods implement karni padti hain.
✔ Abstract methods ka use tab hota hai jab har derived class me ek method ka implementation alag ho.