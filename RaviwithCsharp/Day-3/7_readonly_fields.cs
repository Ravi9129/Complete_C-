using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 7_readonly_fields
    {
        
    }
}
-------------------------------------------------------------
readonly fields wo fields hoti hain jin ki value runtime par set ki ja sakti hai, par sirf constructor ke andar.

🔹 Const (const) aur readonly me difference yeh hai ki const ki value compile-time par fix hoti hai, magar readonly ki value runtime par set ho sakti hai.
🔹 Readonly fields sirf constructor me initialize ho sakti hain, aur uske baad change nahi ho sakti.
🔹 Ye mostly objects ki configurations ya immutable values store karne ke liye use hoti hain.
---------------------------------------------------------------------
🚀 Real-World Example 1: Database Connection Settings
✅ Scenario: Ek application jisme database ka connection string runtime par decide hota hai.

class DatabaseConfig  
{  
    public readonly string ConnectionString;  

    public DatabaseConfig(string dbName)  
    {  
        ConnectionString = $"Server=localhost;Database={dbName};User Id=admin;Password=1234;";  
    }  

    public void DisplayConfig()  
    {  
        Console.WriteLine($"Database Connection: {ConnectionString}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        DatabaseConfig dbConfig1 = new DatabaseConfig("CustomerDB");  
        dbConfig1.DisplayConfig();  

        DatabaseConfig dbConfig2 = new DatabaseConfig("SalesDB");  
        dbConfig2.DisplayConfig();  

        // dbConfig1.ConnectionString = "New Connection"; ❌ Error: Readonly field modify nahi ho sakti  
    }  
}
📌 Yahan ConnectionString ki value runtime par decide ho rahi hai, magar sirf constructor me initialize ho sakti hai.
-------------------------------------------------------------------------------------------------
🚀 Real-World Example 2: Product ID in E-Commerce
✅ Scenario: Ek e-commerce application jisme product ka ID ek baar set ho, fir kabhi change na ho.

class Product  
{  
    public readonly int ProductID;  
    public string Name;  

    public Product(int id, string name)  
    {  
        ProductID = id;  
        Name = name;  
    }  

    public void Display()  
    {  
        Console.WriteLine($"Product: {ProductID} - {Name}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Product p1 = new Product(101, "Laptop");  
        p1.Display();  

        // p1.ProductID = 200; ❌ Error: Readonly field change nahi ho sakti  
    }  
}
📌 ProductID ek baar constructor me set ho rahi hai, lekin fir kabhi change nahi ki ja sakti.
---------------------------------------------------------------------
🚀 Real-World Example 3: Immutable Employee Data
✅ Scenario: Ek HR system jisme employee ka joining date ek baar set ho, magar badla na ja sake.

class Employee  
{  
    public readonly DateTime JoiningDate;  

    public Employee()  
    {  
        JoiningDate = DateTime.Now;  
    }  

    public void Display()  
    {  
        Console.WriteLine($"Employee Joining Date: {JoiningDate}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp1 = new Employee();  
        emp1.Display();  

        // emp1.JoiningDate = DateTime.Now.AddYears(1); ❌ Error: Readonly field change nahi ho sakti  
    }  
}
📌 JoiningDate ek baar constructor me set ho rahi hai aur change nahi ho sakti, jo logical bhi hai.
-------------------------------------------------------------
🚀 Conclusion
🔹 Readonly fields (readonly) runtime par constructor ke through initialize hoti hain, par uske baad change nahi hoti.
🔹 Agar kisi object ki ek value fix rakhni hai (par runtime par initialize karni hai), to readonly use karo.
🔹 Agar ek constant jo kabhi change nahi hogi, to const use karo.
🔹 Agar ek field har object ke liye same honi chahiye aur change ho sakti hai, to static use karo.