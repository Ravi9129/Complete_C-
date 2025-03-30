using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 5_constructor overloading
    {
        
    }
}
-------------------------------------------------
Constructor Overloading Kya Hai?
✅ Ek class ke andar multiple constructors define karna, jisme parameters different hote hain, usko constructor overloading kehte hain.
✅ Ye ek example hai "Method Overloading" ka, but yeh methods ki jagah constructors pe apply hoti hai.
✅ Isse hume flexibility milti hai ki hum ek hi class ke multiple versions ke objects create kar sakein, different parameters ke sath.

🔹 Example: Constructor Overloading in C#
using System;

class Car
{
    public string Brand;
    public string Model;
    public int Year;

    // 🔹 Default Constructor
    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        Year = 0;
        Console.WriteLine("Default Constructor Called!");
    }

    // 🔹 Parameterized Constructor (1 Parameter)
    public Car(string brand)
    {
        Brand = brand;
        Model = "Unknown";
        Year = 0;
        Console.WriteLine($"Car Brand: {Brand}");
    }

    // 🔹 Parameterized Constructor (2 Parameters)
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Year = 0;
        Console.WriteLine($"Car Brand: {Brand}, Model: {Model}");
    }

    // 🔹 Parameterized Constructor (3 Parameters)
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Console.WriteLine($"Car Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car(); // ✅ Default Constructor Call
        Car car2 = new Car("Toyota"); // ✅ 1 Parameter Constructor Call
        Car car3 = new Car("Honda", "Civic"); // ✅ 2 Parameters Constructor Call
        Car car4 = new Car("Ford", "Mustang", 2024); // ✅ 3 Parameters Constructor Call
    }
}
🔹 Output:
Default Constructor Called!
Car Brand: Toyota
Car Brand: Honda, Model: Civic
Car Brand: Ford, Model: Mustang, Year: 2024
🔹 Constructor Overloading Use Cases (Real-World Scenarios)
------------------------------------------------------------------
✅ 1. Flexibility in Object Initialization
Agar kisi class ka object different tariko se initialize karna ho, to constructor overloading ka use hota hai.

Example: Bank Account create karte waqt:

Default constructor: Account bina kisi detail ke create karein

Parameterized constructor: Account number ya balance ke sath initialize karein

class BankAccount
{
    public int AccountNumber;
    public double Balance;

    // Default Constructor
    public BankAccount()
    {
        AccountNumber = 0;
        Balance = 0;
        Console.WriteLine("Default Bank Account Created!");
    }

    // Constructor with Account Number
    public BankAccount(int accNum)
    {
        AccountNumber = accNum;
        Balance = 0;
        Console.WriteLine($"Account {AccountNumber} Created!");
    }

    // Constructor with Account Number and Balance
    public BankAccount(int accNum, double initialBalance)
    {
        AccountNumber = accNum;
        Balance = initialBalance;
        Console.WriteLine($"Account {AccountNumber} Created with Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(); // Default
        BankAccount acc2 = new BankAccount(101); // Account with Number
        BankAccount acc3 = new BankAccount(102, 5000); // Account with Number & Balance
    }
}
-------------------------------------------------------
✅ 2. Code Reusability and Readability
Multiple constructors likhne se code modular, readable aur reusable ban jata hai.

🔹 Constructor Overloading with "this" Keyword
Agar ek constructor dusre constructor ko call karna chahta hai to this keyword ka use kar sakte hain.

class Student
{
    public string Name;
    public int Age;

    // Constructor with no parameters
    public Student() : this("Unknown", 0) // 🔥 Calls another constructor
    {
        Console.WriteLine("Default Constructor Called!");
    }

    // Constructor with parameters
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student(); // Calls the default constructor
        Student s2 = new Student("Ali", 20);
    }
}
📌 Output:

Student Name: Unknown, Age: 0
Default Constructor Called!
Student Name: Ali, Age: 20
✅ this("Unknown", 0) automatically ek parameterized constructor ko call kar raha hai!
----------------------------------------
🔥 Summary
Feature	Description
Definition=	Ek class ke multiple constructors hone ko constructor overloading kehte hain.
Benefit=	Object ko different ways se initialize karne ki flexibility milti hai.
Usage=	Real-world applications me jaise Cars, Bank Accounts, Students etc.
Best Practice=	Constructor chaining ke liye this keyword ka use karna.


🚀 Conclusion
✅ Constructor Overloading ka use karke hum ek class ke multiple objects alag-alag values ke sath bana sakte hain.
✅ Isse code reusability, readability aur flexibility increase hoti hai.
✅ "this" keyword ka use karke ek constructor dusre constructor ko call kar sakta hai, jo code ko aur optimize karta hai.