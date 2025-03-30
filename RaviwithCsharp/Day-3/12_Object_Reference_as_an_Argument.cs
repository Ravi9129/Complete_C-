using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 12_Object_Reference_as_an_Argument
    {
        
    }
}
--------------------------------------------------------
C# me jab hum kisi object ko method ke argument me pass karte hain, to wo reference type hota hai.
🔹 Matlab method ke andar jo bhi changes honge, wo original object par apply ho jayenge.
🔹 Agar hum ref ya out keywords use karein, to hum usi memory location ko modify kar sakte hain.
🔹 Yeh mostly data manipulation, object modification, aur memory optimization ke liye use hota hai.
------------------------------------------------------
🚀 1. Passing Object as an Argument (Reference Behavior)
✅ Scenario: Ek Person object pass karke uske name ko change karna

using System;

class Person  
{  
    public string Name;  
}

class Program  
{  
    static void ChangeName(Person p)  
    {  
        p.Name = "Rahul";  // ✅ Object modify ho jayega
    }  

    static void Main()  
    {  
        Person person = new Person();  
        person.Name = "Amit";  

        Console.WriteLine("Before: " + person.Name);  
        ChangeName(person);  
        Console.WriteLine("After: " + person.Name);  
    }  
}
📌 Output:
Before: Amit
After: Rahul
📌 Yahan ChangeName() method me person ka reference pass hua, isliye change reflect hua.
📌 Agar hum primitive type (int, string) pass karte to change reflect nahi hota.
--------------------------------------------------
🚀 2. Object Reference with ref Keyword
✅ Scenario: Agar hum pura object hi change karna chahein to ref use kar sakte hain.

using System;

class Car  
{  
    public string Model;  
}

class Program  
{  
    static void ChangeCar(ref Car car)  
    {  
        car = new Car();  // ✅ Naya object assign kar diya  
        car.Model = "Tesla";  
    }  

    static void Main()  
    {  
        Car myCar = new Car();  
        myCar.Model = "BMW";  

        Console.WriteLine("Before: " + myCar.Model);  
        ChangeCar(ref myCar);  
        Console.WriteLine("After: " + myCar.Model);  
    }  
}
📌 Output:
Before: BMW
After: Tesla

📌 Agar ref na use karein to ChangeCar() sirf local copy modify karega, original object nahi.
📌 ref use karne se original reference change hota hai.
------------------------------------------------------------
🚀 3. Object Reference with out Keyword
✅ Scenario: Agar method me object ko initialize karna ho, to out use karte hain.

using System;

class Laptop  
{  
    public string Brand;  
}

class Program  
{  
    static void CreateLaptop(out Laptop l)  
    {  
        l = new Laptop();  // ✅ Out ka use hai to object initialize karna padega  
        l.Brand = "Apple";  
    }  

    static void Main()  
    {  
        Laptop myLaptop;  // ✅ Initialize nahi karna pada  
        CreateLaptop(out myLaptop);  

        Console.WriteLine("Brand: " + myLaptop.Brand);  
    }  
}
📌 Output:
Brand: Apple
📌 out ka use mostly tab hota hai jab hume function ke andar hi object initialize karna ho.
-----------------------------------------------
🚀 4. Passing Object as Argument in Real-World Scenario
✅ Scenario: Ek BankAccount object ko method me pass karke uska balance update karna

using System;

class BankAccount  
{  
    public double Balance;  

    public BankAccount(double balance)  
    {  
        Balance = balance;  
    }  
}

class Program  
{  
    static void Deposit(BankAccount account, double amount)  
    {  
        account.Balance += amount;  // ✅ Object reference modify ho raha hai  
    }  

    static void Main()  
    {  
        BankAccount myAccount = new BankAccount(5000);  
        Console.WriteLine("Before Deposit: " + myAccount.Balance);  

        Deposit(myAccount, 2000);  
        Console.WriteLine("After Deposit: " + myAccount.Balance);  
    }  
}
📌 Output:
Before Deposit: 5000
After Deposit: 7000

📌 Deposit() function original object ka Balance update kar raha hai.
📌 Reference pass hone ki wajah se modification directly reflect ho raha hai.
-----------------------------------------------------------------
🚀 5. Difference Between Value Type and Reference Type in Arguments
🔹 Agar primitive type (int, double, bool) pass karein to copy pass hoti hai.
🔹 Agar class object pass karein to reference pass hota hai, aur original modify ho sakta hai.

using System;

class Demo  
{  
    static void ModifyValue(int x)  
    {  
        x = 100;  // ❌ Value change nahi hogi, kyunki copy pass hui hai  
    }  

    static void ModifyObject(Person p)  
    {  
        p.Name = "Rahul";  // ✅ Name change ho jayega  
    }  

    static void Main()  
    {  
        int num = 10;  
        ModifyValue(num);  
        Console.WriteLine("Number: " + num);  // ❌ 10 hi rahega  

        Person person = new Person { Name = "Amit" };  
        ModifyObject(person);  
        Console.WriteLine("Person Name: " + person.Name);  // ✅ "Rahul" ho jayega  
    }  
}

class Person  
{  
    public string Name;  
}
📌 Output:
Number: 10
Person Name: Rahul
📌 Primitive type (int) ka copy pass hua, isliye change reflect nahi hua.
📌 Class ka reference pass hua, isliye original modify ho gaya.
------------------------------------

🚀 Conclusion
🔹 Agar method me object pass karein to wo reference pass hota hai, isliye original modify ho sakta hai.
🔹 Agar pura object replace karna ho to ref use karein.
🔹 Agar method ke andar hi object initialize karna ho to out use karein.
🔹 Yeh feature real-world applications jaise banking, ecommerce, aur data manipulation me kaafi useful hota hai.