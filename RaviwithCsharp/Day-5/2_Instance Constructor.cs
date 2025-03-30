using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 2_Instance Constructor
    {
        
    }
}
---------------------------------------------
Instance Constructor ek normal constructor hota hai jo tabhi run hota hai jab ek naya instance (object) create hota hai.
✅ Yeh instance-specific values initialize karta hai.
✅ Har object ke liye alag-alag call hota hai.
✅ Agar hum manually constructor na banayein, to C# ek default constructor provide karta hai.
----------------------------------------
🚀 Example: Instance Constructor with Default Values

class Car
{
    public string Model;
    
    // Instance Constructor (Same Name as Class)
    public Car()
    {
        Model = "Toyota"; // Default value set
        Console.WriteLine("Instance Constructor Called!");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car(); // ✅ Instance Constructor Call
        Car car2 = new Car(); // ✅ Instance Constructor Call
    }
}
📌 Output:

Instance Constructor Called!
Instance Constructor Called!
✅ Har object ke liye constructor call hota hai, aur alag instances initialize hote hain.
------------------------------------------------
🚀 Example: Instance Constructor with Parameters (Custom Initialization)
class Person
{
    public string Name;
    public int Age;

    // Instance Constructor with Parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Person Created: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Ali", 25);
        Person p2 = new Person("Sara", 30);
    }
}
📌 Output:
Person Created: Ali, Age: 25
Person Created: Sara, Age: 30
✅ Har object ke liye values different hain, kyunki constructor har instance ke liye alag run hota hai.
---------------------------
Example:
class Demo
{
    public static int StaticValue;
    public int InstanceValue;

    // Static Constructor
    static Demo()
    {
        StaticValue = 100;
        Console.WriteLine("Static Constructor Called!");
    }

    // Instance Constructor
    public Demo(int value)
    {
        InstanceValue = value;
        Console.WriteLine($"Instance Constructor Called! Value: {InstanceValue}");
    }
}

class Program
{
    static void Main()
    {
        Demo d1 = new Demo(10);
        Demo d2 = new Demo(20);
    }
}
📌 Output:
Static Constructor Called!
Instance Constructor Called! Value: 10
Instance Constructor Called! Value: 20
✅ Static Constructor sirf ek baar chala, par Instance Constructor har object ke liye chala.
--------------------------------------------------
🚀 Real-World Example: Bank Account System

class BankAccount
{
    public string AccountHolder;
    public double Balance;

    // Instance Constructor
    public BankAccount(string holder, double initialBalance)
    {
        AccountHolder = holder;
        Balance = initialBalance;
        Console.WriteLine($"Account created for {AccountHolder} with balance {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("John", 5000);
        BankAccount acc2 = new BankAccount("Sarah", 10000);
    }
}
📌 Output:
Account created for John with balance 5000
Account created for Sarah with balance 10000
✅ Instance Constructor har account ke liye run ho raha hai, isliye dono ka balance alag hai.
----------------------------------
🚀 Conclusion
✅ Instance Constructor har object create hone par call hota hai.
✅ Yeh object-specific values initialize karta hai.
✅ Agar hum manually constructor na likhein, to C# ek default constructor provide karta hai.
✅ Yeh static constructor se different hai, jo sirf ek baar call hota hai.