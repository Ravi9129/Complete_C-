using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 5_static_fields
    {
        
    }
}
------------------------------------------------------------------------------------------
static fields wo fields hoti hain jo class level par exist karti hain, na ki kisi specific object ke liye.
Matlab jitne bhi objects create hoon, unke liye static field ek hi rahti hai.

🔹 Static fields ko object se nahi, balki class se access karte hain.
🔹 Static memory me ek hi baar allocate hoti hain, isliye ye performance optimize karti hain.
🔹 Common values store karne ke liye best hoti hain, jo har object ke liye same honi chahiye.
-------------------------------------------


🚀 Real-World Example 1: Total Employees Count in a Company
✅ Scenario: Ek company me employees hire ho rahe hain aur hume total employees ka count maintain karna hai.

using System;

class Employee  
{  
    public string Name;  
    public int Salary;  
    public static int TotalEmployees = 0; // Static Field  

    public Employee(string name, int salary)  
    {  
        Name = name;  
        Salary = salary;  
        TotalEmployees++; // Har naya employee par count badhega
    }  

    public void DisplayEmployeeInfo()  
    {  
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee e1 = new Employee("Ali", 50000);  
        Employee e2 = new Employee("Sara", 60000);  

        e1.DisplayEmployeeInfo();  
        e2.DisplayEmployeeInfo();  

        Console.WriteLine($"Total Employees: {Employee.TotalEmployees}"); // Static field ko class se access kiya
    }  
}
📌 Har naye employee ke create hone par TotalEmployees badhta rahega, lekin yeh field har object ke liye same hai.
------------------------------------------------------------------------------
🚀 Real-World Example 2: Bank Interest Rate (Common for All Accounts)
✅ Scenario: Ek bank system jisme har account ke liye same interest rate apply hota hai.

using System;

class BankAccount  
{  
    public string AccountHolder;  
    public double Balance;  
    public static double InterestRate = 4.5; // Static field (common for all accounts)  

    public BankAccount(string holder, double balance)  
    {  
        AccountHolder = holder;  
        Balance = balance;  
    }  

    public void DisplayAccountInfo()  
    {  
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        BankAccount acc1 = new BankAccount("Arjun", 50000);  
        BankAccount acc2 = new BankAccount("Riya", 70000);  

        acc1.DisplayAccountInfo();  
        acc2.DisplayAccountInfo();  

        // Interest Rate update karne ke baad sabhi accounts par apply hoga  
        BankAccount.InterestRate = 5.0;  

        Console.WriteLine("\nAfter Interest Rate Update:");  
        acc1.DisplayAccountInfo();  
        acc2.DisplayAccountInfo();  
    }  
}
📌 Har account ka balance alag hai, par InterestRate static field hone ki wajah se common hai.
----------------------------------------------------------------------------------------------
🚀 Real-World Example 3: Car Showroom with Static Inventory Count
✅ Scenario: Car showroom me har nayi car add hone par inventory count update hota hai.


class Car  
{  
    public string Model;  
    public int Price;  
    public static int TotalCars = 0; // Static field  

    public Car(string model, int price)  
    {  
        Model = model;  
        Price = price;  
        TotalCars++;  // Har naya object banne par count badhega
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
📌 Yaha TotalCars ek static field hai jo har object ke create hone par update hoti hai.
-------------------------------------------------------------------------------------------------
🚀 Real-World Example 4: User Login Session in a Website
✅ Scenario: Ek website jisme sirf ek active user session ho sakta hai.

class User  
{  
    public string UserName;  
    public static string ActiveSessionUser; // Static field  

    public User(string userName)  
    {  
        UserName = userName;  
        ActiveSessionUser = userName; // Jo last login karega, wahi active hoga  
    }  

    public void DisplayActiveUser()  
    {  
        Console.WriteLine($"Currently Logged-in User: {ActiveSessionUser}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        User user1 = new User("Ali");  
        user1.DisplayActiveUser();  

        User user2 = new User("Sara");  
        user2.DisplayActiveUser();  

        Console.WriteLine($"Final Active User: {User.ActiveSessionUser}");  
    }  
}
📌 Jo bhi last login karega wahi ActiveSessionUser banega, kyunki ActiveSessionUser static hai.
----------------------------------------------------------------------
🚀 Conclusion

🔹 Static fields class level par hoti hain aur sab objects ke liye common hoti hain.

🔹 Common values jaise InterestRate, TotalEmployees, ActiveSessionUser store karne ke liye best hain.

🔹 Memory efficient hain kyunki ek hi baar allocate hoti hain.

🔹 Performance optimize karti hain jab ek hi value multiple objects ke liye use ho.
---------------------------------

🚀 Kab Kya Use Karna Chahiye?

1️⃣ Agar har object ke liye alag value chahiye → Instance Field (Non-Static)

2️⃣ Agar ek hi value har object ke liye maintain karni ho → Static Field

3️⃣ Agar kisi resource ko ek hi jagah store karna ho (e.g., configuration settings, count tracking) → Static Field