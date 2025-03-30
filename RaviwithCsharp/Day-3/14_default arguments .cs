using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 14_default arguments 
    {
        
    }
}
---------------------------------------------------------
C# me default arguments ka concept tab kaam aata hai jab kisi method ke parameters ke liye default values define karni ho.
🔹 Agar method call karte waqt koi argument pass nahi karte, to default value use hoti hai.
🔹 Yeh optional parameters ka ek tarika hai jo code readability aur flexibility badhata hai.
🔹 Mostly overload methods ki jagah use hota hai jahan same function ko different parameters ke sath call karna ho.
------------------------------------------------------------
🚀 1. Basic Example of Default Arguments
✅ Scenario: Ek method jo user ka naam greet kare, lekin agar naam pass na ho to default "Guest" ho.
using System;

class Program  
{  
    static void GreetUser(string name = "Guest")  
    {  
        Console.WriteLine("Welcome, " + name + "!");  
    }  

    static void Main()  
    {  
        GreetUser("Amit");  // ✅ Argument pass kiya  
        GreetUser();        // ✅ Default value use hogi  
    }  
}
📌 Output:
Welcome, Amit!
Welcome, Guest!
📌 Agar GreetUser("Amit") call kiya to "Amit" print hua.
📌 Agar GreetUser() call kiya bina argument ke, to "Guest" print hua.
----------------------------------------------------------
🚀 2. Multiple Default Parameters
✅ Scenario: Ek method jo product ka naam aur price print kare, lekin agar price pass na ho to default ₹100 ho.

using System;

class Program  
{  
    static void ShowProduct(string product = "Laptop", double price = 100.00)  
    {  
        Console.WriteLine("Product: " + product + ", Price: ₹" + price);  
    }  

    static void Main()  
    {  
        ShowProduct("Mobile", 50000);  // ✅ Custom values  
        ShowProduct("Tablet");         // ✅ Default price ₹100 use hoga  
        ShowProduct();                 // ✅ Dono default values use hongi  
    }  
}
📌 Output:
Product: Mobile, Price: ₹50000
Product: Tablet, Price: ₹100
Product: Laptop, Price: ₹100
📌 Agar dono arguments diye to wahi use honge.
📌 Agar sirf product diya to price ka default use hoga.
📌 Agar kuch na diya to dono default values aayengi.
-------------------------------------------------------------------------------
🚀 3. Default Arguments with Method Overloading
✅ Scenario: Ek method jo salary calculate kare, agar tax pass na ho to default 10% ka tax lagaye.

using System;

class Program  
{  
    static double CalculateSalary(double salary, double tax = 10)  
    {  
        return salary - (salary * tax / 100);  
    }  

    static void Main()  
    {  
        Console.WriteLine("Salary after Tax: ₹" + CalculateSalary(50000, 5));  // ✅ Custom tax  
        Console.WriteLine("Salary after Default Tax: ₹" + CalculateSalary(50000));  // ✅ Default tax 10%  
    }  
}
📌 Output:
Salary after Tax: ₹47500
Salary after Default Tax: ₹45000
📌 Agar 5% tax diya to wahi calculate hoga.
📌 Agar tax na diya to default 10% ka tax apply hoga.

🚀 4. Default Arguments with Named Parameters
✅ Scenario: Ek method jo student details print kare, lekin agar koi argument pass na ho to default value use ho.
---------------------------------------------------------
using System;

class Program  
{  
    static void ShowStudent(string name = "Unknown", int age = 18, string city = "Delhi")  
    {  
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");  
    }  

    static void Main()  
    {  
        ShowStudent();  // ✅ Sab default values  
        ShowStudent("Rahul");  // ✅ Age aur city default rahenge  
        ShowStudent(age: 22);  // ✅ Sirf age pass ki, baaki default  
        ShowStudent(city: "Mumbai");  // ✅ Sirf city pass ki  
    }  
}
📌 Output:

Name: Unknown, Age: 18, City: Delhi
Name: Rahul, Age: 18, City: Delhi
Name: Unknown, Age: 22, City: Delhi
Name: Unknown, Age: 18, City: Mumbai
📌 Yeh feature named parameters ke sath kaafi useful hota hai jisme hum kisi bhi argument ko selectively pass kar sakte hain.
-------------------------------------------------------------------------
🚀 5. Default Arguments in Real-World Scenario
✅ Scenario: E-commerce website me agar user shipping method select nahi kare to default 'Standard Shipping' apply ho.

using System;

class Order  
{  
    public static void PlaceOrder(string product, string shippingMethod = "Standard Shipping")  
    {  
        Console.WriteLine($"Order placed for {product} with {shippingMethod}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Order.PlaceOrder("Laptop", "Express Shipping");  // ✅ Custom shipping  
        Order.PlaceOrder("Mobile");  // ✅ Default shipping  
    }  
}
📌 Output:

Order placed for Laptop with Express Shipping
Order placed for Mobile with Standard Shipping
📌 Agar user shippingMethod specify kare to wahi use hoga.
📌 Agar user shippingMethod specify na kare to Standard Shipping apply hoga.

---------------------------------------
🚀 Conclusion
🔹 Agar kisi method ke parameters optional hone chahiye to default arguments ka use karna best practice hai.
🔹 Yeh overload methods ki jagah zyada readable aur maintainable code likhne me madad karta hai.
🔹 Default arguments ko named parameters ke sath combine karna ek powerful feature hai.