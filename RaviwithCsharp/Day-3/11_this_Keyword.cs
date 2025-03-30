using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 11_this_Keyword
    {
        
    }
}

--------------------------------------------------
this keyword C# me ek implicit reference hota hai jo current object ko refer karta hai.
🔹 Yeh tab use hota hai jab class ke andar kisi instance member ko explicitly refer karna ho.
🔹 Mostly this ka use tab hota hai jab method ya constructor ke parameters aur class ke fields ka naam same ho.
🔹 Yeh ek constructor se doosre constructor ko call karne ke liye bhi use hota hai.
-------------------------------------------------------------------------------
🚀 1. this for Field & Parameter Name Conflict Resolution
✅ Scenario: Employee class ka constructor name parameter ko correctly assign kare

using System;

class Employee  
{  
    private string name;  // ✅ Private Field

    public Employee(string name)  
    {  
        this.name = name;  // ✅ `this` keyword field `name` ko refer kar raha hai
    }  

    public void Show()  
    {  
        Console.WriteLine("Employee Name: " + name);  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp = new Employee("Aman");  
        emp.Show();  
    }  
}
📌 Yahan this.name = name; ka use isliye kiya hai kyunki parameter aur field dono ka naam same hai.
📌 Agar this use nahi karenge, to compiler ko nahi pata chalega ki name field hai ya parameter.
-------------------------------------------------------------------------------------------------
🚀 2. this to Call Another Constructor (Constructor Chaining)
✅ Scenario: Ek employee class jisme overloaded constructors hon jo this ka use karein

using System;

class Employee  
{  
    private string name;  
    private int age;  

    // ✅ Default Constructor
    public Employee()  
    {  
        name = "Unknown";  
        age = 0;  
    }  

    // ✅ Parameterized Constructor (calls default constructor)
    public Employee(string name) : this()  
    {  
        this.name = name;  
    }  

    // ✅ Another Parameterized Constructor (calls previous constructor)
    public Employee(string name, int age) : this(name)  
    {  
        this.age = age;  
    }  

    public void Show()  
    {  
        Console.WriteLine($"Name: {name}, Age: {age}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Employee emp1 = new Employee();  
        emp1.Show();  

        Employee emp2 = new Employee("Aman");  
        emp2.Show();  

        Employee emp3 = new Employee("Rahul", 25);  
        emp3.Show();  
    }  
}
📌 Yahan this() ka use kiya gaya hai ek constructor se doosre constructor ko call karne ke liye.
📌 Agar ek constructor ke andar dusre constructor ka kaam repeat na karna ho to this ka use hota hai.
--------------------------------------------------------------------------------------
🚀 3. this to Pass Current Object as a Parameter
✅ Scenario: Ek student class jo current object ko ek method me pass kare

using System;

class Student  
{  
    public string Name { get; set; }  

    public Student(string name)  
    {  
        this.Name = name;  
    }  

    public void Display(Student obj)  
    {  
        Console.WriteLine("Student Name: " + obj.Name);  
    }  

    public void Show()  
    {  
        Display(this);  // ✅ Current Object ko method me pass kar rahe hain
    }  
}

class Program  
{  
    static void Main()  
    {  
        Student s1 = new Student("Aryan");  
        s1.Show();  
    }  
}
📌 Yahan Display(this); ka use kiya gaya hai jisme hum this ko pass karke current object ko refer kar rahe hain.
📌 Isse object ka data easily kisi dusre method ko diya ja sakta hai.
-----------------------------------------------------------------
🚀 4. this to Return Current Object (Method Chaining)
✅ Scenario: Fluent API design jisme ek method khud object return kare

using System;

class Car  
{  
    private string brand;  
    private string model;  

    public Car SetBrand(string brand)  
    {  
        this.brand = brand;  
        return this;  
    }  

    public Car SetModel(string model)  
    {  
        this.model = model;  
        return this;  
    }  

    public void Show()  
    {  
        Console.WriteLine($"Car Brand: {brand}, Model: {model}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        Car car = new Car();  
        car.SetBrand("Toyota").SetModel("Corolla").Show();  // ✅ Method Chaining  
    }  
}
📌 Yahan return this; ka use method chaining ke liye kiya gaya hai.
📌 Isse ek hi line me multiple method calls kar sakte hain (SetBrand().SetModel().Show()).
----------------------------------------------------------------------------
🚀 5. this in Extension Methods
✅ Scenario: Ek extension method jo kisi string object par kaam kare

using System;

static class StringExtensions  
{  
    public static void PrintWithStars(this string str)  
    {  
        Console.WriteLine("*** " + str + " ***");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        string message = "Hello World";  
        message.PrintWithStars();  // ✅ `this` keyword se method string pe apply ho sakta hai  
    }  
}
📌 Yahan this string str ka use ek extension method banane ke liye kiya gaya hai jo kisi bhi string pe apply ho sakta hai.
📌 Is tarah se hum existing types ko extend kar sakte hain bina unka code modify kiye.
------------------------------------------------------------------------
🚀 Summary: Jab this Use Karte Hain
Use Case	Example
Field aur parameter ke beech conflict resolve karna	this.name = name;
Ek constructor se doosre constructor ko call karna	: this()
Current object ko parameter me pass karna	Display(this);
Current object return karna (method chaining)	return this;
Extension methods likhne ke liye	this string str
🚀 Conclusion
🔹 this keyword current object ko refer karta hai aur uska scope sirf instance members tak hota hai.
🔹 Yeh mostly field aur parameter ke conflict ko solve karne, constructor chaining aur method chaining ke liye use hota hai.
🔹 Iska use this ko method parameters me pass karne aur extension methods likhne me bhi hota hai.