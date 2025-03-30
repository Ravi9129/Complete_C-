using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 11_Explicit Casting
    {
        
    }
}
----------------------------------------------------
Explicit Casting Kya Hai?
✅ Explicit Casting manually hoti hai jab ek larger data type ko smaller data type me convert karna ho.
✅ Explicit casting se data loss ho sakti hai, isliye programmer ko khud batana padta hai ki conversion karni hai.
✅ Syntax:

smallerType variable = (smallerType)largerTypeValue;
-------------------------------------------------------
🚀 1. Basic Example of Explicit Casting
✅ Scenario: Ek double value ko int me convert karna.

using System;

class Program
{
    static void Main()
    {
        double num = 10.75; // ✅ Larger Type
        int result = (int)num; // ✅ Explicit Casting (double → int)

        Console.WriteLine("Double: " + num);
        Console.WriteLine("Integer: " + result);
    }
}
📌 Output:
Double: 10.75
Integer: 10
📌 Yahan .75 ka data loss ho gaya kyunki int fractional part store nahi karta.
-------------------------------------------------------
🚀 2. Numeric Type Conversion with Explicit Casting
✅ Scenario: Bigger type ko smaller type me convert karna (data loss ho sakti hai).

using System;

class Program
{
    static void Main()
    {
        long largeNumber = 100000; // ✅ Large Type
        int smallNumber = (int)largeNumber; // ✅ Explicit Casting (long → int)

        Console.WriteLine($"Long: {largeNumber}, Int: {smallNumber}");
    }
}
📌 Output:
Long: 100000, Int: 100000
📌 Agar number int ki limit se bada hota, to data loss ya exception ho sakti thi.
-----------------------------------------------------------------
🚀 3. Explicit Casting with Overflow (Data Loss Issue)
✅ Scenario: Agar ek bada number ek chhoti range wale type me cast karein to data loss ho sakti hai.

using System;

class Program
{
    static void Main()
    {
        long largeValue = 2147483648; // ✅ Out of int range (int.MaxValue = 2147483647)
        int smallValue = (int)largeValue; // ✅ Explicit Casting

        Console.WriteLine($"Large Value: {largeValue}");
        Console.WriteLine($"Small Value: {smallValue}");
    }
}
📌 Output:
Large Value: 2147483648
Small Value: -2147483648
📌 Yahan value wrap ho gayi (integer overflow) kyunki int ka maximum range exceed ho gaya.
------------------------------------------------------------
🚀 4. Explicit Casting Between Character and Integer
✅ Scenario: char ko int me cast karna aur wapas char me convert karna.

using System;

class Program
{
    static void Main()
    {
        char letter = 'A'; // ✅ ASCII Value: 65
        int asciiValue = (int)letter; // ✅ Explicit Casting (char → int)

        Console.WriteLine($"Character: {letter}, ASCII Value: {asciiValue}");

        char newLetter = (char)asciiValue; // ✅ Explicit Casting (int → char)
        Console.WriteLine($"Converted Back: {newLetter}");
    }
}
📌 Output:
Character: A, ASCII Value: 65
Converted Back: A
📌 Yahan char → int → char conversion successfully hua bina kisi data loss ke.
-----------------------------------------------------------------
🚀 5. Explicit Casting in Real-World Scenario (Currency Conversion)
✅ Scenario: Ek banking app me hum floating-point currency values ko integer me convert kar sakte hain.

using System;

class Program
{
    static void Main()
    {
        double totalAmount = 7500.99; // ✅ Total amount with decimal
        int payableAmount = (int)totalAmount; // ✅ Explicit Casting (double → int)

        Console.WriteLine($"Total Amount: {totalAmount:C}");
        Console.WriteLine($"Payable Amount: {payableAmount:C}");
    }
}
📌 Output:
Total Amount: $7,500.99
Payable Amount: $7,500.00
📌 Decimal part loss ho gaya kyunki int fractional values store nahi karta.
--------------------------------------------------------
🚀 6. Explicit Casting with Classes (Downcasting in OOP)
✅ Scenario: Base class ko derived class me cast karna.

using System;

class Animal // ✅ Base Class
{
    public string Name = "Generic Animal";
}

class Dog : Animal // ✅ Derived Class
{
    public string Breed = "Labrador";
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog(); // ✅ Implicit Upcasting (Derived → Base)
        Dog dog = (Dog)animal; // ✅ Explicit Downcasting (Base → Derived)

        Console.WriteLine($"Animal Name: {dog.Name}");
        Console.WriteLine($"Dog Breed: {dog.Breed}");
    }
}
📌 Output:
Animal Name: Generic Animal
Dog Breed: Labrador
📌 Yahan Animal ko Dog me explicitly cast kiya taaki Breed property access kar sakein.

🚀 Conclusion
✅ Explicit Casting manually hoti hai jab ek larger type ko smaller type me convert karna ho.
✅ Data loss ya integer overflow ho sakta hai, isliye carefully use karna chahiye.
✅ OOP me upcasting aur downcasting ke liye bhi use hoti hai.
✅ Large numeric types ko smaller types me convert karne ke liye zaroori hoti hai.