using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 11_Namespace
    {
        
    }
}
-----------------------------------------------
What is a Namespace?
C# me namespace ek logical grouping hoti hai classes, interfaces, enums, delegates, or structs ka.
Ye ek container ki tarah kaam karta hai jo similar functionalities wale code ko organize karta hai aur naming conflicts se bachata hai.

🎯 Why Use Namespaces?
✅ Code Organization – Related classes aur methods ko group karne ke liye.
✅ Avoid Naming Conflicts – Agar do classes ka same naam ho, to namespace se differentiate kar sakte hain.
✅ Modular Programming – Code ko structured aur maintainable banata hai.
✅ Reusability – Different projects me same namespaces ko reuse kar sakte hain.
------------------------------------------------------------
📌 Syntax of Namespace in C#
namespace MyNamespace
{
    class MyClass
    {
        public void Display()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}
namespace keyword ka use karke ek namespace define kiya jata hai.

Uske andar classes, interfaces, delegates, structs waghera define kiye jate hain.
-----------------------------------------------------
📌 Example 1: Using a Namespace
using System;

// ✅ Custom Namespace
namespace MyNamespace
{
    class Greeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}

// ✅ Using the Namespace
class Program
{
    static void Main()
    {
        MyNamespace.Greeting obj = new MyNamespace.Greeting();
        obj.SayHello(); // 🔥 Output: Hello from MyNamespace!
    }
}
📌 Output:
Hello from MyNamespace!
✅ Explanation:
MyNamespace ke andar Greeting class define ki hai.

Main() method me MyNamespace.Greeting ka use karke object create kiya aur uske method ko call kiya.
-------------------------------------------------------------
📌 Example 2: Importing a Namespace using using Keyword
using System;
using MyNamespace; // ✅ Importing Custom Namespace

namespace MyNamespace
{
    class Greeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}

class Program
{
    static void Main()
    {
        Greeting obj = new Greeting(); // ✅ Direct access (No need for MyNamespace.Greeting)
        obj.SayHello(); // 🔥 Output: Hello from MyNamespace!
    }
}
📌 Output:
Hello from MyNamespace!
✅ Explanation:
using MyNamespace; ka use karke namespace ko import kiya.

Ab Greeting ko direct use kar sakte hain (MyNamespace likhne ki zaroorat nahi hai).
------------------------------------------------
📌 Example 3: Nested Namespaces
Agar ek namespace ke andar dusra namespace ho, to usse nested namespace kehte hain.

using System;

namespace OuterNamespace
{
    namespace InnerNamespace
    {
        class InnerClass
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
        OuterNamespace.InnerNamespace.InnerClass obj = new OuterNamespace.InnerNamespace.InnerClass();
        obj.ShowMessage(); // 🔥 Output: Hello from InnerNamespace!
    }
}
📌 Output:
Hello from InnerNamespace!
✅ Explanation:
OuterNamespace ke andar ek InnerNamespace hai.

InnerClass ko access karne ke liye poora namespace likhna zaroori hai.
------------------------------------------------
📌 Example 4: Alias for Namespace
Agar ek namespace ka naam bada hai ya conflict ho raha hai, to alias (short name) bana sakte hain.
using System;
using MyAlias = MyNamespace; // ✅ Creating an alias for MyNamespace

namespace MyNamespace
{
    class Greeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyNamespace using alias!");
        }
    }
}

class Program
{
    static void Main()
    {
        MyAlias.Greeting obj = new MyAlias.Greeting();
        obj.SayHello(); // 🔥 Output: Hello from MyNamespace using alias!
    }
}
📌 Output:
Hello from MyNamespace using alias!
✅ Explanation:
using MyAlias = MyNamespace; ka use karke short name define kiya.

Ab MyNamespace.Greeting ki jagah MyAlias.Greeting ka use kar sakte hain.
-----------------------------------------------------------------
📌 Example 5: Namespace Conflict Resolution
Agar same class name do different namespaces me ho, to namespace specify karke differentiate kar sakte hain.

using System;

namespace NamespaceA
{
    class Test
    {
        public void Show()
        {
            Console.WriteLine("Hello from NamespaceA!");
        }
    }
}

namespace NamespaceB
{
    class Test
    {
        public void Show()
        {
            Console.WriteLine("Hello from NamespaceB!");
        }
    }
}

class Program
{
    static void Main()
    {
        NamespaceA.Test objA = new NamespaceA.Test();
        objA.Show(); // 🔥 Output: Hello from NamespaceA!

        NamespaceB.Test objB = new NamespaceB.Test();
        objB.Show(); // 🔥 Output: Hello from NamespaceB!
    }
}
📌 Output:

Hello from NamespaceA!
Hello from NamespaceB!
✅ Explanation:
NamespaceA aur NamespaceB dono me Test class hai.

Fully qualified name (NamespaceA.Test & NamespaceB.Test) ka use karke dono ko differentiate kiya.
-----------------------------------------
📌 Key Points on Namespaces in C#
🔹 Namespaces ka use classes, interfaces, and other types ko organize karne ke liye hota hai.
🔹 using keyword se namespace ko import karke uske classes ko directly access kar sakte hain.
🔹 Agar ek class ka naam multiple namespaces me same ho, to usko fully qualified name ke saath access karna hota hai.
🔹 using alias = namespace; ka use karke namespaces ka short name define kar sakte hain.
🔹 Namespaces ka use code organization aur naming conflicts resolve karne ke liye hota hai.
----------------------------------------------------
📌 Interview Questions on Namespaces
🔹 Q: What is a namespace in C#?
✅ A: Namespace ek logical container hai jo related classes, interfaces, enums, etc. ko group karta hai. Ye naming conflicts ko resolve karta hai aur code organization improve karta hai.

🔹 Q: How can we avoid class name conflicts using namespaces?
✅ A: Fully qualified names (Namespace.ClassName) ka use karke ya using alias = namespace; ka use karke conflicts resolve kar sakte hain.

🔹 Q: Can a namespace contain another namespace?
✅ A: Haan, C# me nested namespaces create kar sakte hain.

🔹 Q: How can we access a class inside a namespace without specifying the full namespace?
✅ A: using keyword ka use karke namespace import karke uske classes ko directly access kar sakte hain.

