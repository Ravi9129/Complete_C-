using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 9_Dynamically Typed Variables
    {
        
    }
}
---------------------------------------------------------
What is a Dynamically Typed Variable?
✅ A dynamically typed variable in C# is declared using the dynamic keyword.
✅ The type is determined at runtime instead of compile time.
✅ It allows flexibility but can lead to runtime errors if misused.
-----------------------------------------------------
📌 Syntax of dynamic
dynamic variableName = value;
✔ Unlike var, the type is not determined at compile time but at runtime.
------------------------------------------------------------
📌 Example: Dynamic Typing in C#
dynamic data = "Hello, World!";
Console.WriteLine(data); // ✅ Output: Hello, World!

data = 100; 
Console.WriteLine(data); // ✅ Output: 100

data = 3.14;
Console.WriteLine(data); // ✅ Output: 3.14
✔ The variable changes type at runtime (string → int → double).

------------------------------------------
📌 Using dynamic for Method Calls
class Person
{
    public void SayHello()
    {
        Console.WriteLine("Hello from Person!");
    }
}

dynamic obj = new Person();
obj.SayHello(); // ✅ Output: Hello from Person!
✔ The method is resolved at runtime.

📌 Dynamic Objects in Real-World Scenarios
-------------------------------------------
1️⃣ Working with JSON or XML data

dynamic jsonData = Newtonsoft.Json.JsonConvert.DeserializeObject("{ \"Name\": \"Alice\", \"Age\": 25 }");
Console.WriteLine(jsonData.Name); // ✅ Output: Alice
-------------------------------------------------
2️⃣ Interacting with COM Objects (e.g., Excel, Word)
dynamic excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
excelApp.Visible = true;
---------------------------------------
3️⃣ Reflection (Invoking Methods Dynamically)

Type type = Type.GetType("System.Text.StringBuilder");
dynamic obj = Activator.CreateInstance(type);
obj.Append("Hello, Dynamic!");
Console.WriteLine(obj.ToString()); // ✅ Output: Hello, Dynamic!
--------------------------------------------------
📌 Limitations & Best Practices
🚫 Avoid dynamic when strong typing is possible (risk of runtime errors).
🚫 No IntelliSense support, making debugging harder.
🚫 Slower performance due to runtime type resolution.

✅ Use dynamic when working with unknown or external types (e.g., JSON, COM).