using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 7_Dynamic Polymorphism with Interface
    {
        
    }
}
--------------------------------------------------
What is Dynamic Polymorphism?
✅ Polymorphism means "many forms," jisme ek method ya function different classes me different behavior show karta hai.
✅ Dynamic Polymorphism runtime par decide hota hai ki kaunsa method execute hoga.
✅ Ye Method Overriding se achieve hota hai, jo interface ya abstract class ke through hota hai.
✅ Run-time polymorphism ke liye virtual, override, aur interface ka use hota hai.

🎯 Why Use Dynamic Polymorphism?
1️⃣ Loose coupling (System independent banta hai)
2️⃣ Scalability (Easily extendable code)
3️⃣ Code reusability
4️⃣ Multiple behaviors ek hi interface ke through handle karna
-----------------------------------------------------------------------
📌 Example 1: Implementing Dynamic Polymorphism with Interface
using System;

// ✅ Interface declaration
interface IAnimal  
{
    void Speak();  // Method signature only
}

// ✅ Class 1 implementing the interface
class Dog : IAnimal  
{
    public void Speak()  
    {
        Console.WriteLine("Dog says: Woof Woof!");
    }
}

// ✅ Class 2 implementing the interface
class Cat : IAnimal  
{
    public void Speak()  
    {
        Console.WriteLine("Cat says: Meow Meow!");
    }
}

// ✅ Class 3 implementing the interface
class Cow : IAnimal  
{
    public void Speak()  
    {
        Console.WriteLine("Cow says: Moo Moo!");
    }
}

class Program
{
    static void MakeAnimalSpeak(IAnimal animal)  // 🔥 Dynamic polymorphism (runtime method execution)
    {
        animal.Speak();
    }

    static void Main()
    {
        IAnimal myDog = new Dog();
        IAnimal myCat = new Cat();
        IAnimal myCow = new Cow();

        MakeAnimalSpeak(myDog);  // 🔥 Output: Dog says: Woof Woof!
        MakeAnimalSpeak(myCat);  // 🔥 Output: Cat says: Meow Meow!
        MakeAnimalSpeak(myCow);  // 🔥 Output: Cow says: Moo Moo!
    }
}
📌 Output:
Dog says: Woof Woof!
Cat says: Meow Meow!
Cow says: Moo Moo!
✅ Interface IAnimal define karta hai Speak() method ka contract.
✅ Different classes (Dog, Cat, Cow) apni apni implementation provide karti hain.
✅ Method MakeAnimalSpeak() run-time par decide karta hai ki kaunsa Speak() method call hoga.
-----------------------------------------------------------------------
📌 Example 2: Real-World Example (Payment System 💳)
Imagine ek payment system jo CreditCard, PayPal, aur Bitcoin ko support karta hai.
using System;

// ✅ Interface for Payment Processing
interface IPaymentProcessor  
{
    void ProcessPayment(decimal amount);
}

// ✅ CreditCard class implementing IPaymentProcessor
class CreditCard : IPaymentProcessor  
{
    public void ProcessPayment(decimal amount)  
    {
        Console.WriteLine($"Credit Card Payment of ${amount} processed.");
    }
}

// ✅ PayPal class implementing IPaymentProcessor
class PayPal : IPaymentProcessor  
{
    public void ProcessPayment(decimal amount)  
    {
        Console.WriteLine($"PayPal Payment of ${amount} processed.");
    }
}

// ✅ Bitcoin class implementing IPaymentProcessor
class Bitcoin : IPaymentProcessor  
{
    public void ProcessPayment(decimal amount)  
    {
        Console.WriteLine($"Bitcoin Payment of ${amount} processed.");
    }
}

class Program
{
    static void MakePayment(IPaymentProcessor paymentMethod, decimal amount)  
    {
        paymentMethod.ProcessPayment(amount);
    }

    static void Main()
    {
        IPaymentProcessor creditCard = new CreditCard();
        IPaymentProcessor payPal = new PayPal();
        IPaymentProcessor bitcoin = new Bitcoin();

        MakePayment(creditCard, 100.50m);  // 🔥 Output: Credit Card Payment of $100.50 processed.
        MakePayment(payPal, 200.75m);     // 🔥 Output: PayPal Payment of $200.75 processed.
        MakePayment(bitcoin, 300.00m);    // 🔥 Output: Bitcoin Payment of $300.00 processed.
    }
}
📌 Output:
Credit Card Payment of $100.50 processed.
PayPal Payment of $200.75 processed.
Bitcoin Payment of $300.00 processed.
✅ Interface IPaymentProcessor define karta hai ProcessPayment() method.
✅ Different payment methods (CreditCard, PayPal, Bitcoin) apni apni implementation provide karte hain.
✅ Run-time par decide hota hai kaunsa ProcessPayment() method call hoga.
-------------------------------------------------------------------
📌 Example 3: Using Dynamic Polymorphism with List of Interfaces
Agar hume ek list me different objects store karne hain jo same interface implement karte hain, to hum List<IInterface> ka use kar sakte hain.
using System;
using System.Collections.Generic;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle...");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle...");
    }
}

class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Triangle...");
    }
}

class Program
{
    static void Main()
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };

        foreach (IShape shape in shapes)
        {
            shape.Draw();  // 🔥 Run-time par decide hoga kaunsa Draw method call hoga
        }
    }
}
📌 Output:
Drawing Circle...
Drawing Rectangle...
Drawing Triangle...
✅ Interface IShape define karta hai Draw() method ka contract.
✅ List<IShape> ek dynamic collection hai jo runtime par decide karta hai kaunsa Draw() method execute hoga.
-----------------------------------------------------
📌 Key Takeaways 🔥
✔ Dynamic Polymorphism runtime par decide karta hai kaunsa method execute hoga.
✔ Interface ek contract provide karta hai jo multiple classes implement karti hain.
✔ virtual, override, aur interface ka use dynamic polymorphism me hota hai.
✔ Dependency Injection aur loosely coupled architecture implement karne ke liye interfaces useful hain.
✔ Run-time polymorphism se system flexible aur scalable banta hai.

📌 Interview Question on Dynamic Polymorphism
🔹 Q: What is the main advantage of using interfaces for dynamic polymorphism?
✅ A: Interfaces loosely coupled architecture provide karte hain jo code ko flexible aur scalable banata hai.

🔹 Q: Can an interface have a constructor?
✅ A: Nahi, interfaces me constructor nahi hote, kyunki wo sirf behavior define karte hain, state nahi.

🔹 Q: How does C# decide which method to call in dynamic polymorphism?
✅ A: C# runtime par object ki actual type check karta hai aur phir uska method execute karta hai.