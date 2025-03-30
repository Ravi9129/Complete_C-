using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 6_Object Initializer
    {
        
    }
}
--------------------------------------------------------------
Object Initializer Kya Hai?
✅ Object initializer ek shorthand technique hai jisme hum bina constructor call kiye object ke properties ko directly initialize kar sakte hain.
✅ Yeh syntax readability aur maintainability improve karta hai.
✅ Constructor overload likhne ki zaroorat nahi hoti, direct values assign kar sakte hain.
---------------------------------------------------
🔹 Example: Object Initializer in C#
using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        // ✅ Object Initialization using Constructor
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Model = "Corolla";
        car1.Year = 2022;

        // ✅ Object Initialization using Object Initializer (Shorter & Cleaner)
        Car car2 = new Car
        {
            Brand = "Honda",
            Model = "Civic",
            Year = 2023
        };

        Console.WriteLine($"{car1.Brand} {car1.Model} - {car1.Year}");
        Console.WriteLine($"{car2.Brand} {car2.Model} - {car2.Year}");
    }
}
🔹 Output:
Toyota Corolla - 2022
Honda Civic - 2023
---------------------------------------------------
🔹 Object Initializer with Different Data Types
Agar ek nested class ho ya list of objects ho, tab bhi hum object initializer ka use kar sakte hain.

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address HomeAddress { get; set; }
}

class Address
{
    public string City { get; set; }
    public string Country { get; set; }
}

class Program
{
    static void Main()
    {
        // ✅ Nested Object Initialization
        Person person = new Person
        {
            Name = "Ravi",
            Age = 25,
            HomeAddress = new Address
            {
                City = "Delhi",
                Country = "India"
            }
        };

        Console.WriteLine($"{person.Name}, {person.Age} years old, Lives in {person.HomeAddress.City}, {person.HomeAddress.Country}");
    }
}
📌 Output:
Ravi, 25 years old, Lives in Delhi, India
-----------------------------------
🔹 Object Initializer with Collections
Hum object initializer ko Lists aur Arrays ke sath bhi use kar sakte hain.

using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // ✅ List Initialization with Object Initializer
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ahmed", Age = 21 },
            new Student { Name = "Sara", Age = 23 },
            new Student { Name = "Ali", Age = 22 }
        };

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}, {student.Age} years old");
        }
    }
}
📌 Output:
Ahmed, 21 years old
Sara, 23 years old
Ali, 22 years old
🔹 Object Initializer with Readonly & Private Fields
Agar kisi class me readonly ya private fields hain to unhe object initializer me direct initialize nahi kar sakte.
class Test
{
    public readonly int Id;
    public string Name { get; set; }

    public Test(int id)
    {
        Id = id; // ✅ Readonly field can only be initialized in Constructor
    }
}

class Program
{
    static void Main()
    {
        Test obj = new Test(101) { Name = "Readonly Example" };

        Console.WriteLine($"ID: {obj.Id}, Name: {obj.Name}");
    }
}
🔴 ⚠ Readonly field ko sirf constructor me initialize kar sakte hain, object initializer me nahi.
----------------------------------------------
🔥 Advantages of Object Initializer
Feature	Benefit
Shorter Code=	Constructors likhne ki zaroorat nahi
Improved Readability=	Property values clearly visible hoti hain
Easy to Maintain=	Agar naya property add karna ho, easily object me update ho sakti hai
Useful for Collections=	List of Objects ko easily initialize kar sakte hain
-------------------------------
🔥 Conclusion
✅ Object Initializer ek shorthand technique hai jo constructor call ki zaroorat ko eliminate karta hai.
✅ Yeh especially useful hai jab hume multiple properties ko ek saath initialize karna ho.
✅ Isse code readable, clean aur maintainable banta hai!