using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 4_playing_withMultiplefields
    {
        
    }
}

---------------------------------------------------
"Playing with Fields of Multiple Objects" ka matlab hota hai ki multiple objects ke properties ya fields ko manipulate karna, unko compare karna ya unka relation establish karna.

C# me multiple objects ke fields ko interact karne ke liye hum different techniques use kar sakte hain:

Object Comparison (Do ya zyada objects ke fields compare karna)

Object Interaction (Ek object ke field ko dusre object ke field se update karna)

Static vs Instance Fields (Common ya unique data store karna)

Copying Data from One Object to Another

Object Lists & Iteration
-----------------------------------------------------------------------

1. Object Comparison (Real-World Example: Product Discount Check)
✅ Scenario: Ek e-commerce website me do products ka price compare karna aur jo sasta ho uska discount dena.

using System;

class Product  
{  
    public string Name;  
    public double Price;  

    public Product(string name, double price)  
    {  
        Name = name;  
        Price = price;  
    }  

    public void ComparePrice(Product otherProduct)  
    {  
        if (this.Price < otherProduct.Price)  
        {  
            Console.WriteLine($"{this.Name} is cheaper than {otherProduct.Name}. Giving discount!");  
        }  
        else  
        {  
            Console.WriteLine($"{otherProduct.Name} is cheaper than {this.Name}. Giving discount!");  
        }  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Product p1 = new Product("Laptop", 50000);  
        Product p2 = new Product("Tablet", 30000);  

        p1.ComparePrice(p2); // Compare laptop and tablet prices
    }  
}
📌 Yaha ComparePrice() method ek object ke price ko dusre object ke price se compare kar raha hai.
------------------------------------------------------------------------------------------------
2. Object Interaction (Real-World Example: Bank Account Transfer)
✅ Scenario: Ek bank system me do accounts ke beech paisa transfer karna.


using System;

class BankAccount  
{  
    public string AccountHolder;  
    public double Balance;  

    public BankAccount(string holder, double balance)  
    {  
        AccountHolder = holder;  
        Balance = balance;  
    }  

    public void TransferMoney(BankAccount receiver, double amount)  
    {  
        if (this.Balance >= amount)  
        {  
            this.Balance -= amount;  
            receiver.Balance += amount;  
            Console.WriteLine($"{this.AccountHolder} transferred {amount} to {receiver.AccountHolder}");
        }  
        else  
        {  
            Console.WriteLine("Insufficient funds for transfer!");  
        }  
    }  
}

class Program  
{  
    static void Main()  
    {  
        BankAccount acc1 = new BankAccount("Ali", 10000);  
        BankAccount acc2 = new BankAccount("Sara", 5000);  

        acc1.TransferMoney(acc2, 3000); // Ali sends 3000 to Sara  

        Console.WriteLine($"{acc1.AccountHolder} Balance: {acc1.Balance}");  
        Console.WriteLine($"{acc2.AccountHolder} Balance: {acc2.Balance}");  
    }  
}
📌 Yaha TransferMoney() method ek account ka paisa dusre account me transfer kar raha hai.
-----------------------------------------------------------------------------------------------
3. Static vs Instance Fields (Real-World Example: Car Showroom)
✅ Scenario: Har car ka model alag hota hai par showroom ka total cars ka count same hota hai.

class Car  
{  
    public string Model;  
    public int Price;  
    public static int TotalCars = 0;  

    public Car(string model, int price)  
    {  
        Model = model;  
        Price = price;  
        TotalCars++;  // Static field har object ke liye common hai
    }  

    public void DisplayCarInfo()  
    {  
        Console.WriteLine($"Model: {Model}, Price: {Price}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Car c1 = new Car("Tesla Model X", 80000);  
        Car c2 = new Car("BMW X5", 70000);  

        c1.DisplayCarInfo();  
        c2.DisplayCarInfo();  

        Console.WriteLine($"Total Cars in Showroom: {Car.TotalCars}"); // Static field access  
    }  
}
📌 Static field TotalCars har object ke liye same value rakhta hai, par instance fields alag-alag hoti hain.

4. Copying Data from One Object to Another (Deep Copy vs Shallow Copy)
✅ Scenario: Ek employee ki salary hike hone ke baad ek naya object create karna, bina purane object ko modify kiye.
----------------------------------------------------------------------------------------------------

class Employee  
{  
    public string Name;  
    public double Salary;  

    public Employee(string name, double salary)  
    {  
        Name = name;  
        Salary = salary;  
    }  

    public Employee(Employee existingEmployee)  
    {  
        Name = existingEmployee.Name;  
        Salary = existingEmployee.Salary + 5000; // Salary increment
    }  

    public void DisplayEmployeeInfo()  
    {  
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp1 = new Employee("Arjun", 50000);  
        Employee emp2 = new Employee(emp1);  // New object with updated salary  

        emp1.DisplayEmployeeInfo();  
        emp2.DisplayEmployeeInfo();  
    }  
}
📌 Yaha emp1 se emp2 ko copy kiya gaya aur salary increment ho gayi.
------------------------------------------------------------------------------------------------------
5. Object Lists & Iteration (Real-World Example: Student Data Handling)
✅ Scenario: Ek class me multiple students ka record store karna aur usko iterate karna.

using System;
using System.Collections.Generic;  

class Student  
{  
    public string Name;  
    public int Marks;  

    public Student(string name, int marks)  
    {  
        Name = name;  
        Marks = marks;  
    }  

    public void DisplayStudentInfo()  
    {  
        Console.WriteLine($"Student: {Name}, Marks: {Marks}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        List<Student> students = new List<Student>();  

        students.Add(new Student("Aman", 85));  
        students.Add(new Student("Rahul", 90));  
        students.Add(new Student("Priya", 78));  

        foreach (Student student in students)  
        {  
            student.DisplayStudentInfo();  
        }  
    }  
}
📌 Yaha ek List<Student> ka use kiya hai jo multiple objects ko store aur iterate kar raha hai.

