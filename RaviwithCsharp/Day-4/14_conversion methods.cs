using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 14_conversion methods
    {
        
    }
}
----------------------------------------------------
C# me conversion methods kaafi important hote hain jab hume ek type ka data doosre type me convert karna ho. Isme implicit, explicit, Parse(), TryParse(), Convert methods aur type casting aati hain.

1️⃣ Implicit Conversion (Safe & Automatic)
✅ Jab data loss nahi hota, to C# automatically convert kar deta hai.
✅ No syntax needed, no explicit cast required.

Example: Converting int to double (Safe Conversion)
int num = 100;
double bigNum = num; // ✅ Implicit conversion (safe)
Console.WriteLine(bigNum);
📌 Output:
100
✅ Jab int ko double me convert karte hain, koi data loss nahi hota, isliye automatic conversion ho jata hai.
-----------------------------------------------
2️⃣ Explicit Conversion (Forcefully Done by Developer)
❌ Data loss ho sakta hai, isliye explicitly convert karna padta hai.
🛑 Syntax: (TargetType)value

Example: Converting double to int (Data Loss)
double num = 99.99;
int smallNum = (int)num; // ❌ Explicit conversion required
Console.WriteLine(smallNum);
📌 Output:
99
🚨 Decimal part (0.99) lost ho gaya, isliye 99 hi print hua.
----------------------------------------------------
3️⃣ Parse() Method (String to Numeric Conversion)
✅ Only for string to numeric types like int, double, decimal, DateTime, etc.
🛑 Throws Exception if invalid input is given

Example: Converting String to int Using Parse()
string strNum = "200";
int num = int.Parse(strNum); // ✅ Converts successfully
Console.WriteLine(num);
📌 Output:
200
----------------------------
🛑 Invalid String Input Example (Exception)

string invalidStr = "Hello";
int num = int.Parse(invalidStr); // ❌ Throws FormatException
❌ "Hello" is not a number, so runtime error (FormatException) aayega.
-------------------------------------------------------------------
4️⃣ TryParse() Method (Safe String to Numeric Conversion)
✅ Exception throw nahi hoti, bas false return hota hai agar conversion fail ho.

Example: Safe Conversion Using TryParse()

string str = "300";
int num;
bool success = int.TryParse(str, out num);

if (success)
    Console.WriteLine($"Converted Number: {num}");
else
    Console.WriteLine("Invalid Input!");
📌 Output:
Converted Number: 300
✅ Agar input invalid hota to exception nahi aati, sirf "Invalid Input!" print hota.
----------------------------------------------
5️⃣ Convert Class Methods (Multi-Type Conversion)
✅ Jab implicit or explicit conversion na ho sake, tab Convert class use hoti hai.
✅ More powerful than Parse() (Supports null values also)

Example: Convert string to int, double, bool

string strNum = "500";
int num = Convert.ToInt32(strNum); // ✅ Convert to integer
Console.WriteLine(num);
--------------
📌 Output:
500
✅ Convert.ToInt32() method null value ko 0 return karta hai, jabki Parse() exception throw karega.
---------------------------------------------------------
🚀 Real-World Example: User Input Conversion
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int result))
            Console.WriteLine($"Valid Number: {result}");
        else
            Console.WriteLine("Invalid Number. Please enter a valid integer.");
    }
}
📌 Output (Valid Input):
Enter a number: 100
Valid Number: 100
---------------------
📌 Output (Invalid Input):
Enter a number: ABC
Invalid Number. Please enter a valid integer.
✅ User se input leke safely integer me convert kiya bina exception ke.
-----------------------------------------------------------------
🚀 Conclusion
✅ Implicit conversion safe hai, jabki Explicit me data loss ho sakta hai.
✅ Parse() exception throw karta hai, jabki TryParse() safe hai.
✅ Convert class null handle kar sakti hai aur multi-type conversion support karti hai.
✅ Real-world applications me TryParse() best hai user input validation ke liye.