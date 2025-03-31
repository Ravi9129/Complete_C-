using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 12_Nested Namespace
    {
        
    }
}
----------------------------------------------------------
What is a Nested Namespace?
Jab ek namespace ke andar doosra namespace define kiya jata hai, to usse nested namespace kehte hain.
Ye hierarchical structure banane aur code ko aur better organize karne ke liye use hota hai.

🎯 Why Use Nested Namespaces?
✅ Better Code Organization – Related components ko aur achhe se group karne ke liye.
✅ Avoid Naming Conflicts – Different teams ke kaam ko modular rakhne ke liye.
✅ Maintainability – Large projects me modularity aur readability badhane ke liye.
--------------------------------------------------------------
📌 Basic Syntax of Nested Namespace
namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class MyClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from InnerNamespace!");
            }
        }
    }
}
OuterNamespace ke andar InnerNamespace define kiya.

InnerNamespace ke andar MyClass define kiya.

📌 Example 1: Accessing Nested Namespace
using System;

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class MyClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from InnerNamespace!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // ✅ Using fully qualified name
        OuterNamespace.InnerNamespace.MyClass obj = new OuterNamespace.InnerNamespace.MyClass();
        obj.ShowMessage(); // 🔥 Output: Hello from InnerNamespace!
    }
}
📌 Output:
Hello from InnerNamespace!
✅ Explanation:
OuterNamespace ke andar ek InnerNamespace create kiya.

MyClass ko fully qualified name (OuterNamespace.InnerNamespace.MyClass) se access kiya.

📌 Example 2: Using using Directive for Nested Namespace
Agar baar baar fully qualified name likhna nahi chahte, to using directive ka use kar sakte hain.

using System;
using OuterNamespace.InnerNamespace; // ✅ Importing Nested Namespace

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class MyClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from InnerNamespace!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass(); // ✅ Direct access
        obj.ShowMessage(); // 🔥 Output: Hello from InnerNamespace!
    }
}
📌 Output:
Hello from InnerNamespace!
✅ Explanation:
using OuterNamespace.InnerNamespace; ka use karke nested namespace ko import kar liya.

Ab MyClass ko direct use kar sakte hain.
--------------------------------------------------------------
📌 Example 3: Multiple Classes in Nested Namespace
Agar ek nested namespace ke andar multiple classes hain, to unko bhi access kar sakte hain.

using System;

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class ClassA
        {
            public void ShowA()
            {
                Console.WriteLine("Hello from ClassA!");
            }
        }

        class ClassB
        {
            public void ShowB()
            {
                Console.WriteLine("Hello from ClassB!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        OuterNamespace.InnerNamespace.ClassA objA = new OuterNamespace.InnerNamespace.ClassA();
        objA.ShowA(); // 🔥 Output: Hello from ClassA!

        OuterNamespace.InnerNamespace.ClassB objB = new OuterNamespace.InnerNamespace.ClassB();
        objB.ShowB(); // 🔥 Output: Hello from ClassB!
    }
}
📌 Output:
Hello from ClassA!
Hello from ClassB!
✅ Explanation:
InnerNamespace ke andar ClassA aur ClassB dono define kiye.

Dono classes ko fully qualified name se access kiya.
--------------------------------------------------------------------
📌 Example 4: Using Alias for Nested Namespace
Agar nested namespace ka naam bada ho ya conflict ho raha ho, to alias ka use kar sakte hain.

using System;
using MyAlias = OuterNamespace.InnerNamespace; // ✅ Creating an alias

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class MyClass
        {
            public void ShowMessage()
            {
                Console.WriteLine("Hello from MyClass using alias!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MyAlias.MyClass obj = new MyAlias.MyClass();
        obj.ShowMessage(); // 🔥 Output: Hello from MyClass using alias!
    }
}
📌 Output:
Hello from MyClass using alias!
✅ Explanation:
using MyAlias = OuterNamespace.InnerNamespace; ka use karke short name define kiya.

Ab MyClass ko MyAlias.MyClass se access kiya.
----------------------------------------------------
📌 Example 5: Namespace Conflict Resolution
Agar same class name do nested namespaces me ho, to fully qualified name ka use karna hoga.

using System;

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
        CompanyA.HR.Employee empA = new CompanyA.HR.Employee();
        empA.GetDetails(); // 🔥 Output: Employee from CompanyA HR Department.

        CompanyB.HR.Employee empB = new CompanyB.HR.Employee();
        empB.GetDetails(); // 🔥 Output: Employee from CompanyB HR Department.
    }
}
📌 Output:
Employee from CompanyA HR Department.
Employee from CompanyB HR Department.
✅ Explanation:
CompanyA.HR aur CompanyB.HR dono me same Employee class hai.

Dono ko fully qualified name se access kiya.

📌 Key Points on Nested Namespaces in C#
🔹 Nested namespaces ek namespace ke andar doosre namespace ko define karne ke liye use hote hain.
🔹 Fully qualified name ka use karke nested namespaces ke members ko access kiya jata hai.
🔹 using directive ka use karke nested namespace ko import kiya ja sakta hai.
🔹 Agar namespace ka naam bada ho, to alias (using alias = namespace;) ka use kiya jata hai.
🔹 Agar multiple namespaces me same naam wali classes ho, to fully qualified name ka use karna zaroori hota hai.
----------------------------------------------------------------
📌 Interview Questions on Nested Namespaces
🔹 Q: What is a nested namespace in C#?
✅ A: Jab ek namespace ke andar doosra namespace define hota hai, to usse nested namespace kehte hain. Ye better code organization aur naming conflict avoid karne ke liye use hota hai.

🔹 Q: How can we access a class inside a nested namespace?
✅ A: Fully qualified name (OuterNamespace.InnerNamespace.ClassName) ka use karke ya using directive ka use karke access kar sakte hain.

🔹 Q: How can we shorten the nested namespace name?
✅ A: using alias = namespace; ka use karke ek short alias bana sakte hain.

🔹 Q: Can we have multiple levels of nested namespaces?
✅ A: Haan, ek namespace ke andar multiple levels tak nested namespaces bana sakte hain.