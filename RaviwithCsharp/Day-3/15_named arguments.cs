using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 15_named arguments
    {
        
    }
}
-----------------------------------------------
Named Arguments kya hain?
✅ C# me named arguments ka concept tab kaam aata hai jab hum kisi method ke parameters ko explicitly unke naam ke sath specify karte hain.
✅ Yeh readability badhata hai aur optional/default parameters ke sath kaafi useful hota hai.
✅ Named arguments kaafi helpful hote hain jab method ke multiple parameters hote hain aur unki order ya values flexible rakhni hoti hain.

🚀 1. Basic Example of Named Arguments
✅ Scenario: Ek method jo user ka naam aur city print kare.

using System;

class Program  
{  
    static void ShowUserInfo(string name, string city)  
    {  
        Console.WriteLine($"User: {name}, City: {city}");  
    }  

    static void Main()  
    {  
        // ✅ Normal Call (Ordered Arguments)
        ShowUserInfo("Amit", "Delhi");

        // ✅ Named Arguments (Order can be changed)
        ShowUserInfo(city: "Mumbai", name: "Ravi");
    }  
}
📌 Output:

User: Amit, City: Delhi
User: Ravi, City: Mumbai
📌 Pehli call me normal order me arguments pass kiye (name, city).
📌 Doosri call me named arguments use kiye aur order change kar diya, phir bhi sahi output aaya.
---------------------------------------------------------------
🚀 2. Named Arguments with Default Values
✅ Scenario: Ek method jo employee ka naam aur salary print kare, lekin agar salary pass na ho to default ₹30,000 ho.

using System;

class Program  
{  
    static void ShowEmployeeInfo(string name, double salary = 30000)  
    {  
        Console.WriteLine($"Employee: {name}, Salary: ₹{salary}");  
    }  

    static void Main()  
    {  
        ShowEmployeeInfo("Raj", 50000);  // ✅ Normal argument
        ShowEmployeeInfo(name: "Anil");  // ✅ Named argument with default salary  
    }  
}
📌 Output:
Employee: Raj, Salary: ₹50000
Employee: Anil, Salary: ₹30000
📌 Anil ke liye salary pass nahi ki to default salary ₹30,000 apply ho gayi.
---------------------------------------------------------------------
🚀 3. Named Arguments with Multiple Parameters
✅ Scenario: Ek method jo student ka naam, age, aur city print kare, lekin koi bhi order me arguments pass kar sake.

using System;

class Program  
{  
    static void ShowStudentInfo(string name, int age, string city)  
    {  
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");  
    }  

    static void Main()  
    {  
        // ✅ Normal Ordered Arguments
        ShowStudentInfo("Aryan", 20, "Bangalore");

        // ✅ Named Arguments (Order change kiya)
        ShowStudentInfo(city: "Pune", name: "Sneha", age: 22);
    }  
}
📌 Output:
Name: Aryan, Age: 20, City: Bangalore
Name: Sneha, Age: 22, City: Pune
📌 Agar named arguments use karein to hum kisi bhi order me values pass kar sakte hain.
--------------------------------------------------------------------
🚀 4. Mixing Named and Positional Arguments
✅ Scenario: Ek method jo customer details print kare, jisme kuch values named arguments se aur kuch ordered arguments se pass kar sakein.

using System;

class Program  
{  
    static void ShowCustomer(string name, int age, string country)  
    {  
        Console.WriteLine($"Customer: {name}, Age: {age}, Country: {country}");  
    }  

    static void Main()  
    {  
        // ✅ Mixing: First argument normal, baaki named arguments
        ShowCustomer("Rohit", country: "India", age: 25);
    }  
}
📌 Output:
yaml
Copy
Edit
Customer: Rohit, Age: 25, Country: India
📌 Hum pehla argument normal pass kar sakte hain aur baaki named arguments se.

⚠ Lekin positional arguments hamesha pehle hone chahiye, named arguments ke baad nahi aa sakte.
❌ Yeh galat hoga:

ShowCustomer(country: "India", "Rohit", age: 25);  // ❌ Error
----------------------------------------------------------
🚀 5. Named Arguments in Real-World Scenario
✅ Scenario: E-commerce website pe order place karne ka method, jisme kisi bhi order me values pass kar sakein.

using System;

class Order  
{  
    public static void PlaceOrder(string product, int quantity, string shippingMethod = "Standard")  
    {  
        Console.WriteLine($"Order placed for {product}, Quantity: {quantity}, Shipping: {shippingMethod}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        // ✅ Named arguments with default value
        Order.PlaceOrder(quantity: 2, product: "Laptop");  

        // ✅ Named arguments in any order
        Order.PlaceOrder(shippingMethod: "Express", product: "Mobile", quantity: 1);
    }  
}
📌 Output:
Order placed for Laptop, Quantity: 2, Shipping: Standard
Order placed for Mobile, Quantity: 1, Shipping: Express
📌 Hum named arguments use karke kisi bhi order me values pass kar sakte hain.
------------------------------------------------------
🚀 Conclusion
🔹 Named arguments se code readability aur flexibility improve hoti hai.
🔹 Method calls me argument ka order maintain karne ki zaroorat nahi hoti.
🔹 Default parameters ke sath named arguments aur bhi powerful ho jate hain.