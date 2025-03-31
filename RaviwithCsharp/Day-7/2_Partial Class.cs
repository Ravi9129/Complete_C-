using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 2_Partial Class
    {
        
    }
}
---------------------------------------------------------
What is a Partial Class?
partial class ek feature hai jo ek single class ko multiple files me todne ki permission deta hai. Yeh code organization, large projects, aur team collaboration ke liye useful hota hai.

✅ Ek hi class ko multiple files me define kar sakte hain.
✅ Compile hone ke time pe sari partial parts ek saath merge ho jate hain.
✅ Useful jab ek badi class ko logically alag-alag files me divide karna ho.

📌 Why Use Partial Class?
🔹 Large Projects: Jab ek class ka code bohot bada ho, usko multiple files me tod sakte hain.
🔹 Team Collaboration: Different developers ek hi class ke alag-alag parts pe kaam kar sakte hain.
🔹 Auto-generated Code: Visual Studio ya tools (like Entity Framework, Windows Forms Designer) kuch code auto-generate karte hain jo partial classes ka use karte hain.
-----------------------------------------------------------------------
📌 Example 1: Basic Partial Class Implementation
Maan lo hume ek Person class banani hai jisme data members aur methods hain.
Hum ek file me fields aur dusri file me methods likh sakte hain.

📄 File 1: Person_Part1.cs
public partial class Person  // ✅ Partial class ka pehla part
{
    public string Name;
    public int Age;
}
📄 File 2: Person_Part2.cs
public partial class Person  // ✅ Partial class ka doosra part
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
📌 Usage in Main Program:
using System;

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Ali";
        p.Age = 25;
        p.DisplayInfo(); // ✅ Methods bhi available hain
    }
}
📌 Output:
Name: Ali, Age: 25
📌 Example 2: Partial Class with Constructor
Agar kisi partial class me constructor define karna ho, to hum multiple files me constructor likh sakte hain.

📄 File 1: Employee_Part1.cs
public partial class Employee
{
    public string Name;
    public int Salary;

    public Employee(string name, int salary)  // ✅ Constructor
    {
        Name = name;
        Salary = salary;
    }
}
📄 File 2: Employee_Part2.cs
public partial class Employee
{
    public void ShowDetails()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
    }
}
📌 Usage in Main Program:
using System;

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Ahmed", 50000);
        emp.ShowDetails();
    }
}
📌 Output:
Employee: Ahmed, Salary: 50000
📌 Example 3: Partial Class with Auto-Generated Code
Agar Visual Studio me Windows Forms, WPF ya Entity Framework ka use kar rahe hain to auto-generated code partial classes me hota hai.

Example:
// Auto-generated file (Cannot be modified manually)
public partial class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Hum khud ka logic dusre file me likh sakte hain
public partial class Student
{
    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}
📌 Key Points About Partial Class
✅ Ek hi class ko multiple files me tod sakte hain.
✅ Compile hone ke time pe sari parts ek saath merge hote hain.
✅ Sirf class nahi, balki struct, interface aur method bhi partial ho sakte hain.
✅ Agar ek partial part me abstract, sealed ya base class define hai, to wo sare parts pe apply hoga.
----------------------------------------------------------------
📌 Interview Questions on Partial Class
🔹 Q: What is a Partial Class in C#?
✅ A: Partial class ek single class ko multiple files me todne ki permission deta hai. Compile hone pe sari files ek saath merge ho jati hain.

🔹 Q: When should you use Partial Classes?
✅ A: Jab ek large project ho, auto-generated code ho, ya multiple developers ek hi class pe kaam kar rahe ho.

🔹 Q: Can a partial class have different access modifiers in different files?
✅ Nahi, ek partial class ke sare parts ka access modifier same hona chahiye.

🔹 Q: Can a partial class be inherited?
✅ Haan, ek partial class doosri class se inherit ho sakti hai.

