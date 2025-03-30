using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 12_Parse 
    {
        
    }
}
----------------------------------------------
Parse Kya Hai?
✅ Parse ek built-in method hai jo string ko kisi numeric ya date type me convert karta hai.
✅ int.Parse(), double.Parse(), DateTime.Parse(), etc., commonly use hote hain.
✅ Agar string invalid ho ya null ho, to Parse exception throw karta hai.
✅ TryParse() iska safer alternative hai, jo exception throw nahi karta.
-------------------------------------------------------------------
🚀 1. Basic Example of int.Parse()
✅ Scenario: User input string me hota hai, usko int me convert karna.

using System;

class Program
{
    static void Main()
    {
        string numberString = "100"; // ✅ String format me number
        int number = int.Parse(numberString); // ✅ Convert string to int

        Console.WriteLine($"Converted Number: {number}");
    }
}
📌 Output:
Converted Number: 100
📌 Yahan "100" string ko int.Parse() se integer me convert kiya.
------------------------------------------------------
🚀 2. Handling Invalid Input (Exception Issue)
✅ Scenario: Agar invalid string ho, to Parse exception throw karega.

using System;

class Program
{
    static void Main()
    {
        string invalidString = "Hello"; // ❌ Invalid number

        int result = int.Parse(invalidString); // ❌ Exception aayegi!
        
        Console.WriteLine($"Result: {result}");
    }
}
📌 Output (Exception):

Unhandled Exception: System.FormatException: Input string was not in a correct format.
📌 Agar input valid number na ho, to FormatException aayegi.
----------------------------------------------------------
🚀 3. Using TryParse() to Avoid Exception
✅ Scenario: Exception se bachne ke liye TryParse() ka use karein.

using System;

class Program
{
    static void Main()
    {
        string input = "Hello"; // ❌ Invalid string
        int number;

        bool success = int.TryParse(input, out number); // ✅ Safe parsing

        if (success)
            Console.WriteLine($"Converted: {number}");
        else
            Console.WriteLine("Invalid number format.");
    }
}
📌 Output:
Invalid number format.
📌 TryParse() exception throw nahi karta, balki false return karta hai agar conversion fail ho.
---------------------------------------------------
🚀 4. double.Parse() for Decimal Numbers
✅ Scenario: Floating-point string ko double me convert karna.

using System;

class Program
{
    static void Main()
    {
        string decimalString = "45.78"; // ✅ Decimal string
        double value = double.Parse(decimalString); // ✅ Convert to double

        Console.WriteLine($"Converted Value: {value}");
    }
}
📌 Output:
Converted Value: 45.78
📌 Yahan "45.78" string ko double.Parse() se double me convert kiya.
----------------------------------------------
🚀 5. DateTime.Parse() for Date Conversion
✅ Scenario: User input se date string ko DateTime me convert karna.

using System;

class Program
{
    static void Main()
    {
        string dateString = "2024-03-29"; // ✅ Date in string format
        DateTime date = DateTime.Parse(dateString); // ✅ Convert to DateTime

        Console.WriteLine($"Converted Date: {date.ToShortDateString()}");
    }
}
📌 Output:
Converted Date: 3/29/2024
📌 Yahan string "2024-03-29" ko DateTime.Parse() se DateTime object me convert kiya.
----------------------------------------------------
🚀 6. Real-World Example (User Input Validation)
✅ Scenario: Ek ATM machine user se PIN input leti hai, Parse use karke validate karna hai.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your 4-digit PIN: ");
        string pinInput = Console.ReadLine();

        try
        {
            int pin = int.Parse(pinInput); // ✅ Convert string to int

            if (pinInput.Length == 4)
                Console.WriteLine("PIN Accepted!");
            else
                Console.WriteLine("Invalid PIN! Must be 4 digits.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter only numbers.");
        }
    }
}
📌 Output (Valid PIN)

Enter your 4-digit PIN: 1234
PIN Accepted!
-------------------------
📌 Output (Invalid Input)

Enter your 4-digit PIN: ABCD
Invalid input! Please enter only numbers.
📌 ATM system user ke PIN ko int.Parse() se integer me convert karta hai.
------------------------------------------------------
🚀 7. Handling null Values with Nullable<int>.Parse()
✅ Scenario: Agar input null ho, to Parse() exception throw karega.

using System;

class Program
{
    static void Main()
    {
        string? input = null; // ❌ Null string
        int number = int.Parse(input!); // ❌ Throws NullReferenceException

        Console.WriteLine($"Converted: {number}");
    }
}
📌 Output (Exception)
Unhandled Exception: System.ArgumentNullException: Value cannot be null.
📌 Agar null ho, to ArgumentNullException throw hogi.
-------------------------------
🚀 Conclusion
✅ Parse() method string ko numeric ya date type me convert karta hai.
✅ Agar input invalid ya null ho, to Parse() exception throw karega.
✅ Exception avoid karne ke liye TryParse() best practice hai.
✅ Commonly used: int.Parse(), double.Parse(), DateTime.Parse() etc.