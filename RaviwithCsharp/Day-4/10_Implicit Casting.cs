using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 10_Implicit Casting
    {
        
    }
}
--------------------------------------------------
Implicit Casting Kya Hai?
✅ Implicit Casting (Type Promotion) ek automatic type conversion hai jo compiler khud karta hai bina kisi explicit conversion ke.
✅ Ye tab hota hai jab ek smaller data type ko larger data type me convert kiya jaye.
✅ Koi data loss nahi hoti, isliye compiler khud ye conversion kar leta hai.
✅ Syntax:

largerType variable = smallerTypeValue;
-------------------------------------------------------
🚀 1. Implicit Casting ka Basic Example
✅ Scenario: Ek integer value ko double me convert karna (int → double)

using System;

class Program
{
    static void Main()
    {
        int num = 10; // ✅ Smaller Type
        double result = num; // ✅ Implicit Casting (int → double)

        Console.WriteLine("Integer: " + num);
        Console.WriteLine("Double: " + result);
    }
}
📌 Output:
Integer: 10
Double: 10
📌 Yahan int value double me convert ho gayi bina kisi explicit conversion ke.
------------------------------------------------
🚀 2. Implicit Casting Between Numeric Types
✅ Scenario: Chhoti range ka data type (byte, short, int) larger range wale type (long, float, double) me convert ho sakta hai.

using System;

class Program
{
    static void Main()
    {
        byte smallNum = 25;  // ✅ Smallest Type
        int intNum = smallNum; // ✅ byte → int
        long longNum = intNum; // ✅ int → long
        float floatNum = longNum; // ✅ long → float
        double doubleNum = floatNum; // ✅ float → double

        Console.WriteLine($"Byte: {smallNum}, Int: {intNum}, Long: {longNum}, Float: {floatNum}, Double: {doubleNum}");
    }
}
📌 Output:
Byte: 25, Int: 25, Long: 25, Float: 25, Double: 25
📌 Yahan byte → int → long → float → double automatically convert ho gaya kyunki koi data loss nahi ho rahi.
---------------------------------------------
🚀 3. Implicit Casting with Char to Int
✅ Scenario: Ek char ko int me convert karna (ASCII value use hoti hai).

using System;

class Program
{
    static void Main()
    {
        char letter = 'A'; // ✅ 'A' ka ASCII = 65
        int asciiValue = letter; // ✅ char → int

        Console.WriteLine($"Character: {letter}, ASCII Value: {asciiValue}");
    }
}
📌 Output:
Character: A, ASCII Value: 65
📌 Yahan char ko int me convert karne par ASCII value store ho gayi.
------------------------------------------------------
🚀 4. Implicit Casting in Real-World Scenario (Banking System)
✅ Scenario: Ek banking system me hum transactions ko accurate store karne ke liye int ko double me convert karte hain.

using System;

class Program
{
    static void Main()
    {
        int balance = 5000; // ✅ Integer balance
        double finalBalance = balance; // ✅ Implicit Casting (int → double)

        Console.WriteLine($"Account Balance: {finalBalance:C}"); // ✅ Currency Format
    }
}
📌 Output:

Account Balance: $5,000.00
📌 Yahan int balance ko double me convert kiya taaki decimal precision maintain rahe.
----------------------------------------------
🚀 5. Implicit Casting in OOP (Base Class to Derived Class)
✅ Scenario: Ek parent class (base class) ko child class (derived class) me implicitly cast kiya ja sakta hai.

using System;

class Animal // ✅ Base Class
{
    public string Name = "Unknown Animal";
}

class Dog : Animal // ✅ Derived Class
{
    public string Breed = "Labrador";
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Animal animal = dog; // ✅ Implicit Casting (Derived → Base)

        Console.WriteLine($"Animal Name: {animal.Name}");
        // Console.WriteLine(animal.Breed); ❌ ERROR: Base class ko Derived properties nahi milengi
    }
}
📌 Output:
Animal Name: Unknown Animal
📌 Yahan Dog class ka ek object Animal me implicitly cast ho gaya, lekin Breed property accessible nahi hai.
🚀 Conclusion
✅ Implicit Casting automatically hota hai jab koi data loss nahi hoti.
✅ Chhoti range wale data types ko badi range wale types me convert kiya ja sakta hai (e.g., int → double).
✅ Char ASCII values ke hisaab se int me convert ho sakta hai.
✅ Base class reference ek derived class object ko hold kar sakta hai (OOP concept).