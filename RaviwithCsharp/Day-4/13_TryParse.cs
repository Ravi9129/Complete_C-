using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 13_TryParse
    {
        
    }
}
-----------------------------------------------------
TryParse() Kya Hai?
✅ TryParse() ek built-in method hai jo string ko safe tarike se numeric ya date type me convert karta hai.
✅ Parse() ki tarah ye bhi string ko integer, double, ya date me convert karta hai, lekin exception throw nahi karta.
✅ Agar conversion fail ho jaye, to TryParse() false return karta hai instead of crashing the program.
------------------------------------------------------
🚀 1. Basic Example of int.TryParse()
✅ Scenario: User se string input aata hai, humein safe integer conversion karna hai.

using System;

class Program
{
    static void Main()
    {
        string input = "123"; // ✅ Valid numeric string
        int number;

        bool success = int.TryParse(input, out number); // ✅ Safe conversion

        if (success)
            Console.WriteLine($"Converted Number: {number}");
        else
            Console.WriteLine("Invalid number format.");
    }
}
📌 Output:
Converted Number: 123
📌 Yahan "123" string ko int.TryParse() se safely integer me convert kiya.
---------------------------------------------------------
🚀 2. Handling Invalid Input (No Exception!)
✅ Scenario: Agar invalid string ho, to exception throw nahi hogi, balki false return hoga.

using System;

class Program
{
    static void Main()
    {
        string invalidString = "Hello"; // ❌ Invalid input
        int result;

        bool success = int.TryParse(invalidString, out result); // ✅ Safe parsing

        if (success)
            Console.WriteLine($"Converted: {result}");
        else
            Console.WriteLine("Invalid number format.");
    }
}
📌 Output:
Invalid number format.
📌 Agar input invalid ho, to exception throw hone ki jagah false return hoga.
----------------------------------------------------------
🚀 3. Using double.TryParse() for Decimal Numbers
✅ Scenario: Decimal string ko safely double me convert karna.

using System;

class Program
{
    static void Main()
    {
        string decimalString = "45.78"; // ✅ Decimal string
        double value;

        bool success = double.TryParse(decimalString, out value); // ✅ Safe conversion

        if (success)
            Console.WriteLine($"Converted Value: {value}");
        else
            Console.WriteLine("Invalid decimal format.");
    }
}
📌 Output:
Converted Value: 45.78
📌 Yahan "45.78" ko safely double me convert kiya bina exception ke.
-------------------------------------------------------------
🚀 4. DateTime.TryParse() for Safe Date Conversion
✅ Scenario: User input se date string ko safely DateTime me convert karna.

using System;

class Program
{
    static void Main()
    {
        string dateString = "2024-03-29"; // ✅ Valid date string
        DateTime date;

        bool success = DateTime.TryParse(dateString, out date); // ✅ Safe conversion

        if (success)
            Console.WriteLine($"Converted Date: {date.ToShortDateString()}");
        else
            Console.WriteLine("Invalid date format.");
    }
}
📌 Output:
Converted Date: 3/29/2024
📌 Agar valid date ho, to DateTime.TryParse() safely DateTime object me convert karega.
----------------------------------------------------
🚀 5. Real-World Example: User Input Validation in ATM PIN
✅ Scenario: ATM PIN validation ke liye TryParse() use karna.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your 4-digit PIN: ");
        string pinInput = Console.ReadLine();

        int pin;
        if (int.TryParse(pinInput, out pin) && pinInput.Length == 4)
            Console.WriteLine("PIN Accepted!");
        else
            Console.WriteLine("Invalid PIN! Must be 4 digits.");
    }
}
📌 Output (Valid PIN)

Enter your 4-digit PIN: 1234
PIN Accepted!
--------------------------
📌 Output (Invalid Input)
Enter your 4-digit PIN: ABCD
Invalid PIN! Must be 4 digits.
📌 ATM system user input ko safely integer me convert karta hai.
---------------------------------------------------------
🚀 6. Handling null Values with TryParse()
✅ Scenario: Agar input null ho, to exception nahi aayegi.

using System;

class Program
{
    static void Main()
    {
        string? input = null; // ❌ Null string
        int number;

        bool success = int.TryParse(input, out number); // ✅ No exception

        if (success)
            Console.WriteLine($"Converted: {number}");
        else
            Console.WriteLine("Invalid input.");
    }
}
📌 Output:
Invalid input.
📌 Agar null ho, to exception throw nahi hoti, bas false return hota hai.
--------------------------------------
🚀 Conclusion
✅ TryParse() safe conversion method hai jo exception throw nahi karta.
✅ Agar input invalid ho, to false return hota hai instead of crashing the program.
✅ Commonly used: int.TryParse(), double.TryParse(), DateTime.TryParse(), etc.
✅ Real-world usage: User input validation, form submissions, ATM PIN verification, etc.