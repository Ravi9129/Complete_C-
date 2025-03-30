using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 3_out Parameter Modifier
    {
        
    }
}
--------------------------------------------
out Kya Hota Hai?
✅ out ek parameter modifier hai jo kisi variable ko method ke andar initialize karke return karne ke liye use hota hai.
✅ out parameter ko method ke andar assign karna mandatory hota hai.
✅ Ye mostly tab use hota hai jab hume ek method se multiple values return karni ho.
---------------------------------------------------------------------
🚀 1. Simple Example of out Parameter
✅ Scenario: Ek method jo do numbers ka sum aur product return kare using out.

using System;

class Program
{
    // ✅ Method jo sum aur product return kare using out parameters
    static void Calculate(int a, int b, out int sum, out int product)
    {
        sum = a + b;       // ✅ Mandatory initialization
        product = a * b;   // ✅ Mandatory initialization
    }

    static void Main()
    {
        int x = 5, y = 10;
        int sumResult, productResult;

        Calculate(x, y, out sumResult, out productResult); // ✅ Passing out parameters

        Console.WriteLine($"Sum: {sumResult}, Product: {productResult}");
    }
}
📌 Output:
Sum: 15, Product: 50
📌 Bina out ke method ek hi value return kar sakta, lekin out ke through hum multiple values return kar sakte hain.
----------------------------------------------------------------------
🚀 2. out Parameter Ke Bina Kya Hota Hai?
✅ Agar hum out na use karein, to ek hi value return karni padegi.

static int CalculateSum(int a, int b)
{
    return a + b;
}

static void Main()
{
    int result = CalculateSum(5, 10);
    Console.WriteLine($"Sum: {result}");
}
📌 Yahan sirf ek hi value return ho sakti hai, lekin agar hume multiple values return karni hain to out use karna padega.
----------------------------------------------------------------------------
🚀 3. out Parameter with TryParse (Real-World Example)
✅ Scenario: Agar user kisi invalid input ko number me convert karna chahta hai to TryParse method out parameter use karti hai.

using System;

class Program
{
    static void Main()
    {
        string input = "123";
        bool isConverted = int.TryParse(input, out int number);

        if (isConverted)
            Console.WriteLine($"Conversion Successful: {number}");
        else
            Console.WriteLine("Conversion Failed!");
    }
}
📌 Output:
Conversion Successful: 123
📌 Agar TryParse me conversion successful hoti hai to out parameter me value assign ho jati hai, warna default value (0) set hoti hai.
---------------------------------------------------------------
🚀 4. out vs ref
Feature	out	ref
Initialization before method call	❌ Required nahi hai	✅ Required hai
Initialization inside method	✅ Zaroori hai	❌ Zaroori nahi
Use Case	Jab ek method multiple values return kare	Jab method ke andar value modify karni ho
✅ Example of ref:

static void ModifyValue(ref int number)
{
    number = number * 2;
}
📌 ref use karne se method ke andar jo bhi changes honge, wo original variable me reflect honge.
-----------------------------------------------------
🚀 5. out with Objects
✅ Scenario: Ek method jo Person object ko initialize kare using out.

using System;

class Person
{
    public string Name;
}

class Program
{
    static void CreatePerson(out Person p)
    {
        p = new Person { Name = "Amit" }; // ✅ Mandatory initialization
    }

    static void Main()
    {
        Person person;  // ❌ Not initialized
        CreatePerson(out person); // ✅ Passing by out

        Console.WriteLine($"Person Name: {person.Name}");
    }
}
📌 Output:
Person Name: Amit
📌 out use karne se person ko method ke andar initialize karna zaroori ho gaya.
---------------------------------------------------------
🚀 6. Real-World Scenario: Finding the Maximum and Minimum of an Array
✅ Scenario: Ek method jo ek array ka minimum aur maximum number return kare using out.

using System;

class Program
{
    static void FindMinMax(int[] numbers, out int min, out int max)
    {
        min = numbers[0];
        max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
    }

    static void Main()
    {
        int[] values = { 12, 5, 7, 25, 8 };

        FindMinMax(values, out int minValue, out int maxValue);

        Console.WriteLine($"Minimum: {minValue}, Maximum: {maxValue}");
    }
}
📌 Output:
Minimum: 5, Maximum: 25
📌 out use karne se ek hi method se min aur max dono values return ho sakti hain.

🚀 Conclusion
✅ out use hota hai jab ek method multiple values return kare.
✅ Method ke andar out variable ko initialize karna mandatory hota hai.
✅ Ye ref se different hai kyunki out variable ko method call se pehle initialize karna zaroori nahi hota.