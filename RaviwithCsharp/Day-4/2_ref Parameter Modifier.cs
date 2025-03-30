using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 2_ref Parameter Modifier
    {
        
    }
}
----------------------------------------
ref Kya Hota Hai?
✅ ref ek parameter modifier hai jo kisi variable ko reference ke through method me pass karne ke liye use hota hai.
✅ Iska matlab hai ki method ke andar variable me jo bhi changes honge, wo original variable me reflect honge.
✅ By default, C# me arguments "pass by value" hote hain, lekin ref use karne se "pass by reference" ho jata hai.
------------------------------------------------------------------
🚀 1. Simple Example of ref Parameter
✅ Scenario: Ek method jo ek integer value ko modify kare using ref.

using System;

class Program
{
    // ✅ Method jo original variable ko modify karega
    static void ModifyValue(ref int number)
    {
        number = number * 2; // Original variable modify ho jayega
        Console.WriteLine($"Inside Method: {number}");
    }

    static void Main()
    {
        int num = 10;
        Console.WriteLine($"Before Method Call: {num}");

        ModifyValue(ref num); // ✅ Passing by reference

        Console.WriteLine($"After Method Call: {num}"); // ✅ Modified value reflect hogi
    }
}
📌 Output:
Before Method Call: 10
Inside Method: 20
After Method Call: 20
📌 Bina ref ke ye method sirf local copy par kaam karega, lekin ref use karne se num ki original value bhi change ho gayi.
------------------------------------------------------------------
🚀 2. ref Parameter ke Bina Kya Hota Hai?
✅ Agar hum ref nahi lagayenge, to method sirf variable ki ek copy pe kaam karega, aur original variable change nahi hoga.

static void ModifyValue(int number)  // ❌ `ref` use nahi kiya
{
    number = number * 2;
    Console.WriteLine($"Inside Method: {number}");
}

static void Main()
{
    int num = 10;
    Console.WriteLine($"Before Method Call: {num}");

    ModifyValue(num);  // ❌ Passing by value

    Console.WriteLine($"After Method Call: {num}");  // ❌ No change in original value
}
📌 Output:
Before Method Call: 10
Inside Method: 20
After Method Call: 10  ❌ (Original value change nahi hui)
📌 Yahan method sirf ek copy par kaam kar raha hai, lekin ref use karne se original variable modify hoga.
--------------------------------------------------------------------
🚀 3. ref Parameter with Multiple Arguments
✅ Scenario: Ek method jo do numbers ko swap kare using ref.

Edit
using System;

class Program
{
    // ✅ Swap two numbers using ref
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int num1 = 5, num2 = 10;
        Console.WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");

        Swap(ref num1, ref num2); // ✅ Passing by reference

        Console.WriteLine($"After Swap: num1 = {num1}, num2 = {num2}"); // ✅ Swapped values
    }
}
📌 Output:
Before Swap: num1 = 5, num2 = 10
After Swap: num1 = 10, num2 = 5
📌 ref use karne se method ke andar jo bhi changes ho rahe hain, wo directly original variables me reflect ho rahe hain.
---------------------------------------------------------------------
🚀 4. ref with Reference Types (Objects)
✅ Scenario: Ek method jo kisi Person object ka name change kare using ref.

using System;

class Person
{
    public string Name;
}

class Program
{
    // ✅ Change object reference
    static void ChangePerson(ref Person p)
    {
        p = new Person { Name = "Rahul" }; // New object assign ho raha hai
    }

    static void Main()
    {
        Person person = new Person { Name = "Amit" };
        Console.WriteLine($"Before Change: {person.Name}");

        ChangePerson(ref person);  // ✅ Passing object by reference

        Console.WriteLine($"After Change: {person.Name}"); // ✅ Changed value
    }
}
📌 Output:
Before Change: Amit
After Change: Rahul
📌 Bina ref ke agar hum p = new Person(...) likhenge, to original object change nahi hoga, sirf local reference change hoga.
-----------------------------------------------------------------------
🚀 5. ref vs out
Feature	ref	out
Initialization	Variable ko method call se pehle initialize karna zaroori hai	Initialization ki zaroorat nahi hoti
Usage	Value method ke andar change ho sakti hai	Method ke andar variable ko initialize karna zaroori hai
Use Case	Jab input value bhi pass karni ho aur modify bhi karna ho	Jab sirf output value chahiye
✅ Example of out:

static void GetValues(out int x, out int y)
{
    x = 100; // Required initialization
    y = 200;
}
📌 Jab method return multiple values kare, tab out use hota hai.
---------------------------------------------------
🚀 6. Real-World Scenario: Banking System
✅ Scenario: Banking system me ek method jo balance check kare aur update kare using ref.

using System;

class BankAccount
{
    public void UpdateBalance(ref double balance, double amount)
    {
        balance += amount;
        Console.WriteLine($"Updated Balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        double balance = 5000;
        Console.WriteLine($"Initial Balance: {balance}");

        BankAccount account = new BankAccount();
        account.UpdateBalance(ref balance, 1500); // ✅ Deposit

        Console.WriteLine($"Final Balance: {balance}"); // ✅ Updated balance reflected
    }
}
📌 Output:
Initial Balance: 5000
Updated Balance: 6500
Final Balance: 6500
📌 ref use karne se balance ki original value update ho gayi.
---------------------------------------------------------
🚀 Conclusion
✅ ref parameter original variable me changes karne ke liye use hota hai.
✅ Agar hum kisi variable ko reference ke through pass karna chahte hain, to ref modifier lagana zaroori hai.
✅ Real-world applications me ref banking systems, swapping, and updating objects ke liye kaafi useful hai.