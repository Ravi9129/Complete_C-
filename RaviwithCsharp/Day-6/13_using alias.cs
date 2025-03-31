using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 13_using alias
    {
        
    }
}
-------------------------------------
What is using alias in C#?
Jab nested namespaces, long namespace names, ya naming conflicts aate hain, tab using alias ka use kiya jata hai. Ye ek short name (alias) provide karta hai, jo ki long namespace ko easily refer karne ke kaam aata hai.

🎯 Why Use using alias?
✅ Reduce Long Namespaces – Namespace ka naam bada ho to short alias use kar sakte hain.
✅ Avoid Naming Conflicts – Agar same class name multiple namespaces me ho, to alias se conflict solve kar sakte hain.
✅ Improve Code Readability – Namespace repeatedly likhne se bachne ke liye.

📌 Syntax of using alias
using AliasName = ActualNamespace;
AliasName – Short name jo hum assign karte hain.

ActualNamespace – Original namespace jise alias diya jata hai.
----------------------------------------------------
📌 Example 1: Using using alias to Shorten Namespace Name
Agar hum ek long namespace name baar-baar likhna nahi chahte, to alias ka use kar sakte hain.

using System;
using MyAlias = Company.Department.Team; // ✅ Alias created

namespace Company.Department.Team
{
    class Employee
    {
        public void Display()
        {
            Console.WriteLine("Hello from Employee of Company.Department.Team!");
        }
    }
}

class Program
{
    static void Main()
    {
        MyAlias.Employee emp = new MyAlias.Employee(); // ✅ Using alias
        emp.Display();
    }
}
📌 Output:
Hello from Employee of Company.Department.Team!
✅ Explanation:
using MyAlias = Company.Department.Team; ka use karke short alias banaya.

Ab MyAlias.Employee likhne se Company.Department.Team.Employee access ho gaya.
-----------------------------------------------------------------------------------
📌 Example 2: Resolving Naming Conflict with using alias
Agar multiple namespaces me same naam ki class ho, to using alias ka use naming conflict resolve karne ke liye kiya jata hai.
using System;
using HR_A = CompanyA.HR; // ✅ Alias for CompanyA.HR
using HR_B = CompanyB.HR; // ✅ Alias for CompanyB.HR

namespace CompanyA
{
    namespace HR
    {
        class Employee
        {
            public void GetDetails()
            {
                Console.WriteLine("Employee from CompanyA HR Department.");
            }
        }
    }
}

namespace CompanyB
{
    namespace HR
    {
        class Employee
        {
            public void GetDetails()
            {
                Console.WriteLine("Employee from CompanyB HR Department.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        HR_A.Employee empA = new HR_A.Employee(); // ✅ Using alias HR_A
        empA.GetDetails();

        HR_B.Employee empB = new HR_B.Employee(); // ✅ Using alias HR_B
        empB.GetDetails();
    }
}
📌 Output:
Employee from CompanyA HR Department.
Employee from CompanyB HR Department.
✅ Explanation:
HR_A aur HR_B alias ka use kiya taaki Employee class ke naming conflict ko resolve kar sakein.

HR_A.Employee se CompanyA.HR.Employee access kiya.

HR_B.Employee se CompanyB.HR.Employee access kiya.
----------------------------------------------------------------
📌 Example 3: Using using alias with Class Names
Agar same class name different namespaces me ho aur namespace likhna avoid karna ho, tab alias ka use kar sakte hain.
using System;
using Emp1 = Company1.Employee;
using Emp2 = Company2.Employee;

namespace Company1
{
    class Employee
    {
        public void Show()
        {
            Console.WriteLine("Company1 Employee");
        }
    }
}

namespace Company2
{
    class Employee
    {
        public void Show()
        {
            Console.WriteLine("Company2 Employee");
        }
    }
}

class Program
{
    static void Main()
    {
        Emp1 obj1 = new Emp1();
        obj1.Show(); // 🔥 Output: Company1 Employee

        Emp2 obj2 = new Emp2();
        obj2.Show(); // 🔥 Output: Company2 Employee
    }
}
📌 Output:
Company1 Employee
Company2 Employee
✅ Explanation:
Company1.Employee ka alias Emp1 diya.

Company2.Employee ka alias Emp2 diya.

Ab direct class naam likh sakte hain bina pura namespace likhne ke.
-----------------------------------------------------------------------
📌 Example 4: using alias with Static Classes
Agar static class ya static methods ka use karna ho, to alias ka use karke code short aur clean bana sakte hain.

using System;
using MathAlias = System.Math; // ✅ Alias for System.Math

class Program
{
    static void Main()
    {
        double result = MathAlias.Sqrt(25); // 🔥 Using alias
        Console.WriteLine($"Square root of 25 is: {result}");
    }
}
📌 Output:
Square root of 25 is: 5
✅ Explanation:
using MathAlias = System.Math; ka use karke Math class ka alias banaya.

Direct MathAlias.Sqrt(25) likhne se System.Math.Sqrt(25) call ho gaya.
-----------------------------------------------
📌 Key Points About using alias
🔹 using alias = namespace; ka use namespace ka short form banane ke liye hota hai.
🔹 Naming conflicts resolve karne ke liye alias ka use kiya jata hai.
🔹 Alias ka use static classes, nested namespaces, aur same class name wale namespaces ke saath bhi hota hai.
🔹 Alias sirf compile-time feature hota hai, runtime pe iska koi impact nahi hota.
-----------------------------------------------------------
📌 Interview Questions on using alias
🔹 Q: What is using alias in C#?
✅ A: using alias ek feature hai jo kisi long namespace ka short naam banane ke liye use hota hai. Isse naming conflict resolve karne aur code readability improve karne me madad milti hai.

🔹 Q: How can using alias help in resolving naming conflicts?
✅ Agar ek hi naam ki class do different namespaces me ho, to hum unka using alias ka use karke short aur unique reference bana sakte hain.

🔹 Q: Can we use using alias for static classes?
✅ Haan, hum using alias ka use System.Math jaise static classes ko short likhne ke liye bhi kar sakte hain.

🔹 Q: What is the difference between using alias and using directive?
✅ using directive (using System;) poore namespace ko import karta hai, jabki using alias (using MyAlias = System.Math;) sirf ek short reference provide karta hai.