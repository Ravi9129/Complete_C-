using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
  public class Employee  
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
}