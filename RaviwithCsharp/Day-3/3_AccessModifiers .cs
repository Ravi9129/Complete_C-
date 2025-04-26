using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 3_AccessModifiers 
    {
        
    }
}
------------------------------------------------------------------------
1. Public (Sab Jagah Accessible)
✅ Example: Ek utility method jo kisi bhi class se access ho sake.
 
public class Utility  
{  
    public void PrintMessage(string message)  
    {  
        Console.WriteLine(message);  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Utility util = new Utility();  
        util.PrintMessage("Hello, Public Modifier!");  // Accessible from anywhere
    }  
}

Kab Use Karein?

Jab kisi method ya property ko globally accessible banana ho.

API services ya helper classes ke liye.


----------------------------------------------------------------------------------
2. Private (Sirf Us Class Ke Andar)
✅ Example: Bank Account Balance ko private rakhna.

class BankAccount  
{  
    private double balance = 10000;  // Private property

    private void ShowBalance()  // Private method
    {  
        Console.WriteLine($"Balance: {balance}");  
    }  

    public void CheckBalance()  
    {  
        ShowBalance(); // Private method ko class ke andar call kar sakte hain  
    }  
}

class Program  
{  
    static void Main()  
    {  
        BankAccount account = new BankAccount();
        account.CheckBalance();  // Works because CheckBalance() is public
        // account.ShowBalance();  // ❌ Error: Cannot access private method
    }  
}

Kab Use Karein?

Jab sensitive data ko direct access se bachana ho.

Encapsulation maintain karna ho.

---------------------------------------------------------------

3. Protected (Sirf Parent & Child Classes Me)
✅ Example: Company Employee System (Base Class & Derived Class ke beech use)

class Employee  
{  
    protected int salary = 50000; // Protected variable  

    protected void ShowSalary()  
    {  
        Console.WriteLine($"Salary: {salary}");  
    }  
}  

class Manager : Employee  
{  
    public void DisplaySalary()  
    {  
        ShowSalary(); // Accessing protected method from derived class  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        Manager mgr = new Manager();
        mgr.DisplaySalary();  // Works because DisplaySalary() is public
        // mgr.ShowSalary();  // ❌ Error: Cannot access protected method directly
    }  
}

Kab Use Karein?

Jab child class ko parent class ki properties/methods ka access dena ho.

Jab kisi property/method ko public nahi karna ho lekin inheritance me use karna ho.
------------------------------------------

4. Internal (Sirf Same Project Ke Andar)
✅ Example: E-Commerce Application ka Order Management System

internal class Order  
{  
    internal int OrderID = 101;  

    internal void ProcessOrder()  
    {  
        Console.WriteLine($"Processing Order: {OrderID}");  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        Order order = new Order();
        order.ProcessOrder();  // Works because it's in the same project
    }  
}

Kab Use Karein?

Jab kisi functionality ko sirf ek particular module ya project tak limit rakhna ho.

Jab DLL (Class Library) ke andar kisi method/property ko bahar expose nahi karna ho.

--------------------------------------------

5. Protected Internal (Same Project + Derived Class)
✅ Example: School Management System

class Student  
{  
    protected internal string Name = "Amit";  
}  

class GraduateStudent : Student  
{  
    public void ShowStudentName()  
    {  
        Console.WriteLine($"Student Name: {Name}");  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        GraduateStudent gs = new GraduateStudent();
        gs.ShowStudentName();  // Accessible because it's protected internal
    }  
}

Kab Use Karein?

Jab same project aur inherited classes dono ko access dena ho.

----------------------------------------------------
6. Private Protected (Sirf Same Project Ke Derived Classes Me)
✅ Example: Office Management System

class Employee  
{  
    private protected int salary = 70000;  

    private protected void ShowSalary()  
    {  
        Console.WriteLine($"Salary: {salary}");  
    }  
}  

class Manager : Employee  
{  
    public void DisplaySalary()  
    {  
        ShowSalary();  // Works because it's in derived class
    }  
}  

class Program  
{  
    static void Main()  
    {  
        Manager mgr = new Manager();
        mgr.DisplaySalary();  
        // mgr.ShowSalary();  // ❌ Error: Cannot access private protected method directly
    }  
}

Kab Use Karein?

Jab derived classes ko access dena ho but sirf same project tak limit rakhna ho.

------------------------------------------------------------------------------------------


































