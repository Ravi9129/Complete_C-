using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 3_Static Constructor
    {
        
    }
}
------------------------------------- 
Static Constructor C# me ek special constructor hota hai jo class ka first use hone par sirf ek baar execute hota hai.
✅ Yeh static fields ko initialize karne ke liye use hota hai.
✅ Yeh automatically chalta hai, ise manually call nahi kar sakte.
✅ Isme koi parameters nahi hote.
----------------------------------------------
🚀 Syntax & Basic Example

class Demo
{
    public static int StaticValue;

    // Static Constructor
    static Demo()
    {
        StaticValue = 100;
        Console.WriteLine("Static Constructor Called!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Demo.StaticValue); // Static Constructor Call Hoga
    }
}
📌 Output:
Static Constructor Called!
100
✅ Jab class ka pehla use hua (Demo.StaticValue access karne par), tab static constructor run hua.
✅ Ye sirf ek baar chala, chahe kitne bhi objects banayein.

----------------------------------------------
🚀 Example: Static & Instance Constructor Together

class MyClass
{
    public static int StaticValue;
    public int InstanceValue;

    // Static Constructor
    static MyClass()
    {
        StaticValue = 100;
        Console.WriteLine("Static Constructor Called!");
    }

    // Instance Constructor
    public MyClass(int value)
    {
        InstanceValue = value;
        Console.WriteLine($"Instance Constructor Called! Value: {InstanceValue}");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass(10);  // Static + Instance Constructor chalega
        MyClass obj2 = new MyClass(20);  // Sirf Instance Constructor chalega
    }
}
📌 Output:
Static Constructor Called!
Instance Constructor Called! Value: 10
Instance Constructor Called! Value: 20
✅ Static Constructor sirf ek baar chala
✅ Instance Constructor har object ke liye chala
---------------------------------------------------------
🚀 Real-World Example: Database Connection

class Database
{
    public static string ConnectionString;

    // Static Constructor
    static Database()
    {
        ConnectionString = "Server=localhost;Database=MyDB;User Id=admin;Password=1234;";
        Console.WriteLine("Static Constructor: Connection string initialized.");
    }

    // Instance Method
    public void Connect()
    {
        Console.WriteLine($"Connecting using: {ConnectionString}");
    }
}

class Program
{
    static void Main()
    {
        Database db1 = new Database(); // Static Constructor chalega
        db1.Connect();

        Database db2 = new Database(); // Static constructor dobara nahi chalega
        db2.Connect();
    }
}
📌 Output:
Static Constructor: Connection string initialized.
Connecting using: Server=localhost;Database=MyDB;User Id=admin;Password=1234;
Connecting using: Server=localhost;Database=MyDB;User Id=admin;Password=1234;
✅ Static constructor sirf ek baar chala, chahe multiple objects banayein.

🔥 Key Points to Remember
✅ Static Constructor sirf ek baar class ke first use par execute hota hai.
✅ Isme parameters nahi ho sakte.
✅ Ye manually call nahi hota, automatically execute hota hai.
✅ Instance constructor ke contrast me, static constructor sirf class-level data ko initialize karta hai.