using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 11_System.Object Class
    {
        
    }
}
------------------------------------------------------------
System.Object Class in C# 🔥
System.Object class C# ki sabse base class hai. Har ek class, struct, aur enum direct ya indirect tarike se System.Object ko inherit karti hai.

📌 Agar aap ek class banate hain aur koi parent class specify nahi karte, toh woh automatically System.Object se inherit hoti hai.

📌 1. System.Object Class Kya Hai?
✅ System.Object class C# ke har ek type ka parent hai.
✅ Yeh 4 important methods provide karti hai jo har ek object ke saath aate hain:

Method	Description
ToString()	Object ko string me convert karta hai.
Equals(object obj)	Do objects ko compare karta hai.
GetHashCode()	Unique integer hash code return karta hai.
GetType()	Object ka actual type return karta hai.
📌 Chalo ek example dekhte hain jo yeh sab methods use karega. 👇
----------------------------------------------
📌 2. Example: System.Object Methods in Action
using System;

class Person
{
    public string Name { get; set; }
    
    public override string ToString()
    {
        return $"Person: {Name}";
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "Ali" };
        Person p2 = new Person { Name = "Ali" };
        
        Console.WriteLine(p1.ToString());    // Person: Ali
        Console.WriteLine(p1.GetType());     // Person
        
        Console.WriteLine(p1.Equals(p2));    // False (Default reference comparison)
        Console.WriteLine(p1.GetHashCode()); // Unique Hash Code
    }
}
✔ ToString() method ko override karne se Person object ka readable format mil gaya.
✔ GetType() method se actual type Person mila.
✔ Equals() method ne reference compare kiya (not values).
✔ GetHashCode() har object ke liye unique value di.
---------------------------------------------------------
📌 3. System.Object Methods in Detail
1️⃣ ToString() - Object ko String me Convert Karna

int num = 10;
Console.WriteLine(num.ToString()); // "10"
✅ ToString() default implementation class ka naam return karti hai unless override kiya jaye.

2️⃣ Equals() - Object Comparison
✔ Default behavior me reference compare hota hai.
✔ Agar aap chaho to isko override karke value-based comparison bhi kar sakte ho.

Person p1 = new Person { Name = "Ravi" };
Person p2 = new Person { Name = "Ravi" };
Console.WriteLine(p1.Equals(p2)); // False (Different references)
🔹 Agar value-based comparison chahiye toh Equals() ko override karna padega.

class Person
{
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person p)
            return this.Name == p.Name;  // Value comparison
        
        return false;
    }
}
✔ Ab yeh Name ki values ko compare karega instead of reference.

3️⃣ GetHashCode() - Object ka Unique Identifier
✔ GetHashCode() object ka unique integer hash generate karta hai.
✔ Iska use hash tables aur dictionaries me hota hai.

Person p1 = new Person { Name = "Ravi" };
Console.WriteLine(p1.GetHashCode()); // Unique Hash Code
----------------------------------
✔ Agar Equals() override karein toh GetHashCode() bhi override karna best practice hai.

public override int GetHashCode()
{
    return Name.GetHashCode(); // Hash based on Name
}
4️⃣ GetType() - Object ka Actual Type Check Karna

Person p = new Person();
Console.WriteLine(p.GetType()); // Output: Person

✔ GetType() runtime pe object ka type return karta hai.

Agar kisi variable ka dynamic type check karna ho toh yeh useful hai:

object obj = 100;
Console.WriteLine(obj.GetType()); // Output: System.Int32
------------------------------------------
📌 4. System.Object Se Inheritance Ka Fayda
✔ Polymorphism aur runtime type handling ke liye useful hai.
✔ Agar kisi class ko specify nahi karte toh woh default System.Object se inherit hoti hai.

class Animal {} // Automatically inherits from System.Object
----------------------------------------------------
📌 5. Practical Scenario: Why System.Object is Important?
🔹 Scenario: Logging System
Ek generic log system jo kisi bhi type ka object accept kar sake.


class Logger
{
    public void Log(object message)
    {
        Console.WriteLine($"Log: {message.ToString()}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.Log("Application started");  // Log: Application started
        logger.Log(404);                    // Log: 404
        logger.Log(new Person { Name = "Ali" }); // Log: Person: Ali
    }
}
✔ Har tareeke ke objects ko accept karne ke liye object type ka fayda uthaya gaya.
-------------------------
📌 6. Summary Table
Method	Purpose	Default Behavior	Override Possible?
ToString()	Converts object to string	Returns class name	✅ Yes
Equals()	Compares two objects	Compares references	✅ Yes
GetHashCode()	Returns unique hash	Random integer	✅ Yes
GetType()	Returns object type	Actual class type	❌ No
--------------------------------------------
🔥 Final Thoughts
✔ System.Object har ek class ka base parent hai.
✔ Isme important methods hote hain jo har object ke liye common hote hain.
✔ Real-world applications me ToString(), Equals(), aur GetType() bohot kaam aate hain.
✔ Agar kisi class me custom comparison ya string representation chahiye ho toh override karna best practice hai.