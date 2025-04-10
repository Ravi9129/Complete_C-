using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class class
    {
        
    }
}
---------------------------------------
Class C# ka ek basic aur sabse important concept hai. Ye ek blueprint (template) hoti hai jo objects banane ke liye use hoti hai.
 Isme properties (data) aur methods (functions) hote hain jo kisi ek entity ka structure define karte hain.

Kab use hoti hai?
Jab real-world entities ko represent karna ho. (Jaise: Car, Employee, Product)

Code ko organized aur reusable banane ke liye.

Object-Oriented Programming (OOP) follow karne ke liye.

Kaha use hoti hai?
Enterprise Applications: (Banking System, HR Management, Inventory System)

Game Development: (Character Class, Enemy Class)

Web Applications: (Model Classes in ASP.NET)

API Development: (DTOs and Business Logic Classes)
-----------------------------------------------------------------

Example: Real-World Scenario
Soch, ek company hai jisme employees hain. Har employee ka naam, ID, 
aur salary hoti hai. Iss scenario ko represent karne ke liye hum Employee class banayenge:

using System;

class Employee  
{  
    // Properties (Data Members)
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    // Constructor (Object Banane Ke Liye)
    public Employee(int id, string name, double salary)  
    {  
        Id = id;  
        Name = name;  
        Salary = salary;  
    }  

    // Method (Function)
    public void DisplayEmployeeInfo()  
    {  
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        // Object Creation (Ek Employee Ka Object Bana Rahe Hain)
        Employee emp1 = new Employee(101, "Amit", 50000);
        Employee emp2 = new Employee(102, "Rahul", 60000);

        // Method Call
        emp1.DisplayEmployeeInfo();
        emp2.DisplayEmployeeInfo();
    }  
}
Ku Use Karein?
Reusability – Ek hi class se multiple employees bana sakte hain.

Encapsulation – Data aur methods ek entity (class) me bundled hain.

Maintainability – Code structured aur easy to manage ho jata hai.

Scalability – Naye features easily add ho sakte hain.

----------------------------------------------------------------------

Agar company ko naya feature add karna ho, 
jaise Bonus Calculate karna ho, toh Employee class me ek aur method add kar sakte hain.

public double CalculateBonus(double percentage) 
{
    return Salary * (percentage / 100);
}
Ab har employee ka bonus bhi easily calculate ho jayega.