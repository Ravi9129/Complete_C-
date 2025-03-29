using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 9_method 
    {
        
    }
}

------------------------------------------------------------------
method ek function hota hai jo kisi kaam ko complete karta hai.
🔹 Ye ek reusable code block hota hai jo bar-bar likhne ki zaroorat nahi padti.
🔹 Har method ka ek naam hota hai, parameters ho sakte hain, aur ye koi value return bhi kar sakta hai ya nahi bhi.
🔹 Method ko tabhi execute kiya jata hai jab usko call kiya jaye.

🚀 Types of Methods in C#
1️⃣ Instance Methods → Object ke saath call hote hain
2️⃣ Static Methods → Direct class ke saath call hote hain
3️⃣ Parameterized Methods → Jisme arguments pass kiye jate hain
4️⃣ Method Overloading → Ek hi naam ke multiple methods, different parameters ke saath
5️⃣ Return Type Methods → Jo kisi type ki value return karte hain
6️⃣ Void Methods → Jo sirf kaam karte hain, kuch return nahi karte
-----------------------------------------------------------------------------
🚀 Real-World Example 1: Bank Account (Instance Method)
✅ Scenario: Bank account me balance check karna aur deposit karna

using System;

class BankAccount  
{  
    private double balance; // Private field

    public BankAccount(double initialBalance)  
    {  
        balance = initialBalance;  
    }  

    // ✅ Instance Method - Deposit Amount
    public void Deposit(double amount)  
    {  
        if (amount > 0)  
        {  
            balance += amount;  
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");  
        }  
        else  
        {  
            Console.WriteLine("Invalid deposit amount!");  
        }  
    }  

    // ✅ Instance Method - Check Balance
    public double GetBalance()  
    {  
        return balance;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        BankAccount account = new BankAccount(5000); // 5000 ka initial balance
        account.Deposit(1500); // 1500 deposit karega
        Console.WriteLine("Current Balance: " + account.GetBalance());  
    }  
}
📌 Instance method Deposit() balance badhane ke liye use ho raha hai.
📌 Method GetBalance() current balance return kar raha hai.
-------------------------------------------------------------------------
🚀 Real-World Example 2: Utility Class (Static Method)
✅ Scenario: Ek utility class jo temperature Celsius se Fahrenheit me convert kare

using System;

class TemperatureConverter  
{  
    // ✅ Static Method - Convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)  
    {  
        return (celsius * 9 / 5) + 32;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(25);  
        Console.WriteLine($"25°C = {fahrenheit}°F");  
    }  
}
📌 Static method CelsiusToFahrenheit() ko bina object create kiye direct class se call kiya ja sakta hai.
----------------------------------------------------------------------------------
🚀 Real-World Example 3: Employee Salary Calculation (Parameterized Method)
✅ Scenario: Ek employee ka salary calculate karna, basic salary aur bonus ko method parameters me lena


using System;

class Employee  
{  
    // ✅ Method with Parameters
    public double CalculateSalary(double basicSalary, double bonus)  
    {  
        return basicSalary + bonus;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp = new Employee();  
        double totalSalary = emp.CalculateSalary(40000, 5000); // Basic 40k + Bonus 5k  
        Console.WriteLine("Total Salary: " + totalSalary);  
    }  
}
📌 Method CalculateSalary() salary calculate kar raha hai jo basic aur bonus le raha hai.
-----------------------------------------------------------------------
🚀 Real-World Example 4: Method Overloading (Same Method, Different Parameters)
✅ Scenario: Ek calculator jisme same method addition kare, lekin different data types handle kare

using System;

class Calculator  
{  
    // ✅ Method Overloading
    public int Add(int a, int b)  
    {  
        return a + b;  
    }  

    public double Add(double a, double b)  
    {  
        return a + b;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Calculator calc = new Calculator();  
        Console.WriteLine("Addition (int): " + calc.Add(5, 10));  
        Console.WriteLine("Addition (double): " + calc.Add(5.5, 10.2));  
    }  
}
📌 Yahan Add() method 2 tarike se overload ho raha hai – ek integers ke liye, aur ek doubles ke liye.
--------------------------------------------------------
🚀 Real-World Example 5: Using void Method for Displaying Data
✅ Scenario: Ek student ka data print karne ke liye ek method use karein jo sirf display kare, return kuch na kare

using System;

class Student  
{  
    public void DisplayDetails(string name, int age)  
    {  
        Console.WriteLine($"Student Name: {name}, Age: {age}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Student s1 = new Student();  
        s1.DisplayDetails("Aman", 20);  
    }  
}
📌 DisplayDetails() ek void method hai jo sirf print karega, koi value return nahi karega.

----------------------------------------------------------------------------------
🚀 Conclusion
🔹 Methods C# me reusable blocks hote hain jo specific kaam perform karte hain.
🔹 Instance methods objects ke saath call hote hain, jabke static methods direct class ke saath.
🔹 Methods parameters le sakte hain, return kar sakte hain, aur overload bhi ho sakte hain.
🔹 Methods se code modular banta hai aur reuse badhta hai.