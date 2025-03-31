using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 3_Abstraction 
    {
        
    }
}
----------------------------------------------------------------
What is Abstraction?
✅ Abstraction ka matlab hai sirf essential details dikhana aur unnecessary details hide karna.
✅ C# me abstraction abstract class aur interface ke through implement ki jati hai.
✅ Iska use real-world applications me complex systems ko simple banane ke liye hota hai.

🎯 Why Use Abstraction?
1️⃣ Complexity ko reduce karta hai – Sirf important functionalities show hoti hain.
2️⃣ Code security aur encapsulation provide karta hai – User unnecessary details nahi dekh sakta.
3️⃣ Reusability – Ek abstract class ya interface multiple classes me reuse ho sakta hai.
4️⃣ Maintenance easy hoti hai – Code modular aur structured hota hai.
------------------------------------------------------------------------------
📌 Example 1: Abstract Class in C#
using System;

abstract class Vehicle  // ✅ Abstract class
{
    public abstract void Start();  // ✅ Abstract method (No implementation)
    
    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped.");
    }
}

class Car : Vehicle  // ✅ Derived class
{
    public override void Start()  // ✅ Abstract method implemented
    {
        Console.WriteLine("Car is starting with a key.");
    }
}

class Bike : Vehicle
{
    public override void Start()  // ✅ Abstract method implemented
    {
        Console.WriteLine("Bike is starting with a self-start.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.Start();  // 🔥 Output: Car is starting with a key.
        myCar.Stop();   // 🔥 Output: Vehicle Stopped.

        Vehicle myBike = new Bike();
        myBike.Start(); // 🔥 Output: Bike is starting with a self-start.
        myBike.Stop();  // 🔥 Output: Vehicle Stopped.
    }
}
📌 Output:
Car is starting with a key.
Vehicle Stopped.
Bike is starting with a self-start.
Vehicle Stopped.
✅ Abstract class Vehicle sirf structure define karti hai, implementation derived classes Car aur Bike me hoti hai.
--------------------------------------------------------------------------------------
📌 Example 2: Interface-Based Abstraction
Interface ka use hota hai pure abstraction ke liye, jisme sirf method signatures hoti hain.

using System;

interface IPayment  // ✅ Interface (Pure Abstraction)
{
    void Pay(int amount); // ✅ No implementation
}

class CreditCardPayment : IPayment
{
    public void Pay(int amount) // ✅ Implementation
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

class PayPalPayment : IPayment
{
    public void Pay(int amount) // ✅ Implementation
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment1 = new CreditCardPayment();
        payment1.Pay(500);  // 🔥 Output: Paid 500 using Credit Card.

        IPayment payment2 = new PayPalPayment();
        payment2.Pay(1000); // 🔥 Output: Paid 1000 using PayPal.
    }
}
📌 Output:
Paid 500 using Credit Card.
Paid 1000 using PayPal.
✅ Interface IPayment sirf methods define karti hai, implementation different payment classes me hoti hai.
---------------------------------------------------------------------------
📌 Example: Combined Use of Abstract Class and Interface
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
✅ Abstract class aur interface dono ko ek saath use karna flexibility aur reusability badhata hai.
-----------------------------------------------------------------------
📌 Summary
✔ Abstraction sirf essential details show karta hai aur unnecessary complexity hide karta hai.
✔ Abstract class aur interface abstraction achieve karne ke tareeke hain.
✔ Abstract class me partial abstraction hota hai, jabki interface me pure abstraction hoti hai.
✔ Abstraction real-world systems me security, maintainability aur modularity badhata hai.