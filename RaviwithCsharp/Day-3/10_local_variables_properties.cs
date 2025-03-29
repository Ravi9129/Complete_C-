using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 10_local_variables_properties
    {
        
    }
}
--------------------------------------------------------------------------------
local variables aur properties dono important concepts hain, lekin dono ka kaam alag hota hai.
🔹 Local variables kisi specific method, loop ya block ke andar hi exist karte hain.
🔹 Properties kisi class ke fields ko control karne ke liye use hoti hain.

🚀 Local Variables in C#
🔹 Local variable ek method, loop, ya block ke andar declare hota hai aur sirf wahi access kar sakta hai.
🔹 Jab method execute hota hai to yeh create hota hai, aur method complete hone ke baad yeh destroy ho jata hai.
🔹 Local variable ko class ya dusre methods se direct access nahi kiya ja sakta.
---------------------------------------------------------------------------------------
🚀 Real-World Example 1: Using Local Variables in a Method
✅ Scenario: Employee ka monthly salary calculate karna

using System;

class SalaryCalculator  
{  
    public void CalculateSalary()  
    {  
        double basicSalary = 50000; // ✅ Local Variable
        double bonus = 5000;        // ✅ Local Variable
        double totalSalary = basicSalary + bonus; // ✅ Local Variable

        Console.WriteLine("Total Salary: " + totalSalary);  
    }  
}

class Program  
{  
    static void Main()  
    {  
        SalaryCalculator calc = new SalaryCalculator();  
        calc.CalculateSalary();  
    }  
}
📌 Yahan basicSalary, bonus aur totalSalary sirf CalculateSalary() method ke andar hi accessible hain.
📌 Method khatam hote hi yeh variables destroy ho jayenge.
------------------------------------------------------------------------------
🚀 Real-World Example 2: Using Local Variables in a Loop
✅ Scenario: Ek loop jo 1 se 5 tak numbers print kare

using System;

class Program  
{  
    static void Main()  
    {  
        for (int i = 1; i <= 5; i++) // ✅ Local Variable (i)
        {  
            Console.WriteLine("Number: " + i);  
        }  
        
        // ❌ Yeh error dega kyunki i loop ke bahar exist nahi karta
        // Console.WriteLine(i);  
    }  
}
📌 i ek local variable hai jo sirf loop ke andar hi access ho sakta hai.
📌 Loop khatam hone ke baad i destroy ho jayega.

🔹 Properties in C# (Encapsulation of Fields)
🔹 Properties ek field ke liye getter/setter methods provide karti hain.
🔹 Yeh class ke andar private fields ko control karne ke liye use hoti hain.
🔹 Agar kisi field ko direct access nahi karna chahte, to properties ka use karte hain.
----------------------------------------------------------------------------------------------
🚀 Real-World Example 3: Properties for Employee Data (Encapsulation)
✅ Scenario: Ek employee ka name aur salary set/get karne ke liye properties ka use karein

using System;

class Employee  
{  
    private string name;  // ✅ Private Field
    private double salary; // ✅ Private Field

    // ✅ Property for Name
    public string Name  
    {  
        get { return name; }  
        set { name = value; }  
    }  

    // ✅ Property for Salary with Validation
    public double Salary  
    {  
        get { return salary; }  
        set  
        {  
            if (value >= 0)  
                salary = value;  
            else  
                Console.WriteLine("Salary cannot be negative!");  
        }  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp = new Employee();  
        emp.Name = "Aman";  
        emp.Salary = 50000;  

        Console.WriteLine($"Employee Name: {emp.Name}, Salary: {emp.Salary}");  
    }  
}
📌 Properties Name aur Salary encapsulation provide kar rahi hain.
📌 Salary negative set nahi ho sakti kyunki setter me validation hai.
-----------------------------------------------------------------------------
🚀 Real-World Example 4: Auto-Implemented Properties (Shortcut)
✅ Scenario: Ek product class jo auto-properties ka use kare

using System;

class Product  
{  
    public string Name { get; set; }  // ✅ Auto-Implemented Property
    public double Price { get; set; } // ✅ Auto-Implemented Property
}

class Program  
{  
    static void Main()  
    {  
        Product p = new Product { Name = "Laptop", Price = 75000 };  
        Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");  
    }  
}
📌 Auto-implemented properties me explicit private field likhne ki zaroorat nahi hoti.

🚀 Read-Only Properties (Sirf Get, No Set)
------------------------------------------------
✅ Scenario: Ek class jo kisi object ka ID set hone ke baad change nahi hone deti

using System;

class User  
{  
    public int ID { get; }  // ✅ Read-Only Property
    public string Name { get; set; }  

    public User(int id, string name)  
    {  
        ID = id;  // ID sirf constructor ke andar set ho sakta hai
        Name = name;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        User u = new User(101, "Rahul");  
        Console.WriteLine($"User ID: {u.ID}, Name: {u.Name}");  

        // ❌ u.ID = 102;  // Yeh error dega kyunki ID read-only hai
    }  
}
📌 Yahan ID ek read-only property hai jo sirf constructor ke andar set ho sakti hai.

-------------------------------------------------------------------------------------------------------
🚀 Conclusion
🔹 Local variables sirf method/block ke andar kaam karte hain aur method ke baad destroy ho jate hain.
🔹 Properties encapsulation provide karti hain aur fields ko safely expose karti hain.
🔹 Read-only properties sirf constructor me set hoti hain.
🔹 Auto-properties short syntax provide karti hain.