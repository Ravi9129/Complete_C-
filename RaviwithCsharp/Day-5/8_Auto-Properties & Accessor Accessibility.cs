using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 8_Auto-Properties & Accessor Accessibility
    {
        
    }
}
-------------------------------------------
1️⃣ Auto-Properties (Auto-Implemented Properties)
✅ Auto-properties ek shorthand syntax hai jo properties ke liye getter aur setter define karta hai bina explicit private field likhne ke.
✅ Compiler internally ek private field create karta hai jo automatically manage hota hai.
✅ Iska use code ko concise aur readable banata hai.

📌 Example: Auto-Properties in C#
using System;

class Student
{
    // ✅ Auto-Properties (No need to define private field)
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new Student { Name = "Rajput", Age = 22 };
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
    }
}
📌 Output:
Name: Rajput, Age: 22
🎯 Benefits of Auto-Properties
✔ Less code, more readability
✔ No need to define private backing field
✔ Encapsulation is still maintained

2️⃣ Accessor Accessibility in C#
✅ Accessor accessibility ka matlab yeh hai ki getter ya setter ko alag-alag access modifiers de sakte hain.
✅ By default, dono (get & set) public hote hain, lekin hum unhe private, protected, ya internal bana sakte hain.
----------------------------------------------------------
📌 Example: Private Setter (Read-Only Property)
class Employee
{
    public string Name { get; private set; } // ✅ Setter is private (Can only be set inside the class)

    public Employee(string name)
    {
        Name = name; // ✅ Name can be set inside constructor
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("John");

        Console.WriteLine(emp.Name); // ✅ Allowed

        // ❌ emp.Name = "Smith"; // Error! Name ka setter private hai.
    }
}
📌 Output:
John
🛑 Private setter sirf class ke andar value change karne ki permission deta hai. Bahar se set nahi kar sakte.
---------------------------------------------
📌 Example: Protected Setter

class User
{
    public string Username { get; protected set; } // ✅ Setter is protected (Can only be set in derived class)

    public User(string username)
    {
        Username = username;
    }
}

class Admin : User
{
    public Admin(string username) : base(username)
    {
        Username = "Admin_" + username; // ✅ Can modify because setter is protected
    }
}

class Program
{
    static void Main()
    {
        Admin admin = new Admin("Rajput");

        Console.WriteLine(admin.Username); // ✅ Allowed
        // ❌ admin.Username = "NewAdmin"; // Error! Setter is protected
    }
}
📌 Output:
Admin_Rajput
-------------------------------------------
📌 Example: Internal Setter (Accessible within Same Assembly)
class Product
{
    public string ProductName { get; internal set; } // ✅ Setter accessible only within the same assembly
}

class Program
{
    static void Main()
    {
        Product product = new Product();
        product.ProductName = "Laptop"; // ✅ Allowed (Same assembly)

        Console.WriteLine(product.ProductName);
    }
}
📌 Output:

Laptop
🛑 Internal setter ka mtlb yeh hai ki yeh property sirf same project ke andar accessible hogi.
------------------------------------------------
🔥 Conclusion
✅ Auto-properties se code short aur readable banta hai.
✅ Accessor accessibility allow karta hai getter aur setter ke access ko control karna.
✅ Private setter properties ko immutable bana sakta hai.
✅ Protected aur Internal setter inheritance aur encapsulation ko better manage karne me madad karta hai.