using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 10_Inner Classes
    {
        
    }
}
------------------------------------------
 What is an Inner Class?
✅ An inner class (or nested class) is a class defined inside another class.
✅ It helps encapsulate related logic inside a parent class.
✅ It can access private members of the outer class.
------------------------------------------------------
📌 Syntax of an Inner Class
class OuterClass  
{  
    class InnerClass  
    {  
        // Inner class members  
    }  
}  
✔ The inner class is a member of the outer class.
✔ It is not accessible directly from outside unless explicitly exposed.
--------------------------------------------------------
📌 Example 1: Creating and Using an Inner Class
class Outer
{
    private string message = "Hello from Outer Class!";

    public class Inner
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello from Inner Class!");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the inner class
        Outer.Inner innerObj = new Outer.Inner();
        innerObj.ShowMessage();
    }
}
✅ Output:

Hello from Inner Class!
✔ The inner class is accessed via Outer.Inner.
----------------------------------------------------------
📌 Example 2: Accessing Outer Class Members from Inner Class
class Outer
{
    private string message = "Hello from Outer Class!";

    public class Inner
    {
        public void ShowMessage(Outer outerObj)
        {
            Console.WriteLine(outerObj.message);
        }
    }
}

class Program
{
    static void Main()
    {
        Outer outer = new Outer();
        Outer.Inner inner = new Outer.Inner();
        inner.ShowMessage(outer);
    }
}
✅ Output:

Hello from Outer Class!
✔ The inner class can access private members of the outer class if an instance is passed.
----------------------------------------------------------
📌 Example 3: Private Inner Class
class Outer
{
    private class Inner
    {
        public void Display()
        {
            Console.WriteLine("Private Inner Class Method");
        }
    }

    public void AccessInner()
    {
        Inner obj = new Inner();
        obj.Display();
    }
}

class Program
{
    static void Main()
    {
        Outer outer = new Outer();
        outer.AccessInner();
    }
}
✅ Output:
Private Inner Class Method
✔ Since the inner class is private, it cannot be accessed directly from Main() but can be used within the outer class.
------------------------------------------------------------
📌 Example 4: Static Inner Class
class Outer
{
    public static class Inner
    {
        public static void Display()
        {
            Console.WriteLine("Static Inner Class Method");
        }
    }
}

class Program
{
    static void Main()
    {
        Outer.Inner.Display(); // ✅ Accessing static inner class
    }
}
✅ Output:

Static Inner Class Method
✔ No need to create an instance of the inner class since it is static.
---------------------------------------------------------------------------
📌 Real-World Scenario: Encapsulation Using Inner Classes
class Bank
{
    private class BankAccount
    {
        private double balance = 5000;

        public void ShowBalance()
        {
            Console.WriteLine($"Account Balance: {balance}");
        }
    }

    public void DisplayAccount()
    {
        BankAccount account = new BankAccount();
        account.ShowBalance();
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank();
        bank.DisplayAccount();  // ✅ Indirectly accessing the private inner class
    }
}
✅ Output:

Account Balance: 5000
✔ The BankAccount class is hidden from external access for security.
--------------------------------------------------------------
📌 Advantages of Inner Classes
✅ Encapsulation – Keeps related classes together.
✅ Security – Protects internal implementation details.
✅ Better Organization – Useful when one class is only relevant within another.