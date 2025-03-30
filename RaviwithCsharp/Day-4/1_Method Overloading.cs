using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 1_Method Overloading
    {
        
    }
}
------------------------------------------
Method Overloading kya hota hai?
✅ Jab ek hi class me multiple methods same naam se hote hain lekin unke parameters alag hote hain, to usko method overloading kehte hain.
✅ Yeh compile-time polymorphism ka ek example hai.
✅ Method overloading readability aur flexibility badhata hai, kyunki ek hi method ko different ways me call kiya ja sakta hai.
------------------------------------------------------------------
🚀 1. Simple Example of Method Overloading
✅ Scenario: Ek Add method jo numbers ko add kare, lekin alag-alag types aur count ke liye overloaded versions bane.
using System;

class Calculator  
{  
    // ✅ Overload 1: Add two integers
    public int Add(int a, int b)  
    {  
        return a + b;  
    }  

    // ✅ Overload 2: Add three integers
    public int Add(int a, int b, int c)  
    {  
        return a + b + c;  
    }  

    // ✅ Overload 3: Add two double numbers
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

        Console.WriteLine(calc.Add(5, 10));       // ✅ Calls first overload
        Console.WriteLine(calc.Add(5, 10, 15));   // ✅ Calls second overload
        Console.WriteLine(calc.Add(2.5, 3.7));    // ✅ Calls third overload
    }  
}
📌 Output:
15
30
6.2
📌 Ek hi Add naam ka method use kiya, lekin compiler automatically correct overload select kar raha hai.
-------------------------------------------------------
🚀 2. Method Overloading with Different Parameter Types
✅ Scenario: Ek method jo kisi value ko print kare, lekin alag-alag types ke liye overloaded ho.

using System;

class Printer  
{  
    public void Print(int number)  
    {  
        Console.WriteLine("Integer: " + number);  
    }  

    public void Print(string text)  
    {  
        Console.WriteLine("String: " + text);  
    }  

    public void Print(double value)  
    {  
        Console.WriteLine("Double: " + value);  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Printer printer = new Printer();

        printer.Print(100);      // ✅ Calls int overload
        printer.Print("Hello");  // ✅ Calls string overload
        printer.Print(10.5);     // ✅ Calls double overload
    }  
}
📌 Output:
Integer: 100
String: Hello
Double: 10.5
📌 Ek hi Print naam ka method use kiya, lekin different data types ke liye alag versions bana diye.
----------------------------------------------------
🚀 3. Method Overloading with Different Parameter Order
✅ Scenario: Ek method jo kisi user ka data print kare, lekin parameters ke order alag ho sake.

using System;

class UserInfo  
{  
    public void Show(string name, int age)  
    {  
        Console.WriteLine($"Name: {name}, Age: {age}");  
    }  

    public void Show(int age, string name)  
    {  
        Console.WriteLine($"Age: {age}, Name: {name}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        UserInfo user = new UserInfo();

        user.Show("Amit", 25);  // ✅ Calls first overload
        user.Show(30, "Ravi");  // ✅ Calls second overload
    }  
}
📌 Output:
Name: Amit, Age: 25
Age: 30, Name: Ravi
📌 Alag-alag order me parameters hone se compiler different overloads ko identify kar leta hai.
--------------------------------------------------------
🚀 4. Method Overloading with Optional Parameters
✅ Scenario: Ek method jo employee ka data print kare, lekin kuch optional parameters bhi allow kare.

using System;

class Employee  
{  
    public void Show(string name)  
    {  
        Console.WriteLine($"Employee Name: {name}");  
    }  

    public void Show(string name, string department = "General")  
    {  
        Console.WriteLine($"Employee Name: {name}, Department: {department}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp = new Employee();

        emp.Show("Rahul");             // ✅ Calls first overload
        emp.Show("Priya", "HR");       // ✅ Calls second overload
    }  
}
📌 Output:
Employee Name: Rahul
Employee Name: Priya, Department: HR
📌 Method Overloading aur Default Parameters ko combine karke flexible method design kiya.
-------------------------------------------------------------------------
🚀 5. Method Overloading in Real-World Scenario
✅ Scenario: E-commerce system me ek method jo product ka order place kare, lekin different input formats accept kare.

using System;

class Order  
{  
    // ✅ Overload 1: Order by Product Name
    public void PlaceOrder(string product)  
    {  
        Console.WriteLine($"Order placed for: {product}");  
    }  

    // ✅ Overload 2: Order by Product Name & Quantity
    public void PlaceOrder(string product, int quantity)  
    {  
        Console.WriteLine($"Order placed for: {product}, Quantity: {quantity}");  
    }  

    // ✅ Overload 3: Order by Product ID
    public void PlaceOrder(int productId)  
    {  
        Console.WriteLine($"Order placed for Product ID: {productId}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Order order = new Order();

        order.PlaceOrder("Laptop");      // ✅ Calls first overload
        order.PlaceOrder("Mobile", 2);   // ✅ Calls second overload
        order.PlaceOrder(101);           // ✅ Calls third overload
    }  
}
📌 Output:
Order placed for: Laptop
Order placed for: Mobile, Quantity: 2
Order placed for Product ID: 101
📌 Ek hi PlaceOrder method ko multiple ways se call kar sakte hain.
----------------------------------------------
🚀 Conclusion
🔹 Method Overloading ek powerful feature hai jo readability aur code reuse improve karta hai.
🔹 Isse hum ek hi naam wale multiple methods bana sakte hain jo different parameters accept karein.
🔹 Yeh real-world applications jaise E-commerce, Calculator, Printing, User Input Handling me kaafi use hota hai.