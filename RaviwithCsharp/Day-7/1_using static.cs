using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 1_using static
    {
        
    }
}
-----------------------------------------------
What is using static in C#?
using static ek feature hai jo C# 6.0 se introduce hua tha. Ye kisi static class ya enum ke static members ko directly use karne ki permission deta hai bina class name likhne ke.

🔹 Normal Way (Without using static):

using System;

class Program
{
    static void Main()
    {
        double result = Math.Sqrt(25); // 🔥 System.Math likhna zaroori hai
        Console.WriteLine(result);
    }
}
🔹 using static Way:

using System;
using static System.Math; // 🔥 `using static` ka use kiya

class Program
{
    static void Main()
    {
        double result = Sqrt(25); // ✅ Direct access, `Math.` likhna nahi pada
        Console.WriteLine(result);
    }
}
📌 Output:
5
✅ Explanation:
using static System.Math; likhne se Math class ke static members (e.g., Sqrt(), Pow(), PI, etc.) ko direct access mil gaya.

Ab hume Math. likhne ki zaroorat nahi hai.
----------------------------------------------
📌 Why Use using static?
✅ Code ko short aur readable banane ke liye.
✅ Bar-bar static class ka naam likhne ki zaroorat nahi hoti.
✅ Mathematical ya utility functions direct call karne ke liye useful hai.
---------------------------------------------
📌 Example 1: Using using static with System.Math

using System;
using static System.Math; // ✅ Static members directly accessible

class Program
{
    static void Main()
    {
        Console.WriteLine(PI);        // 🔥 Math.PI ke bina direct access
        Console.WriteLine(Sqrt(64));  // 🔥 Math.Sqrt(64) ke bina direct access
        Console.WriteLine(Pow(2, 3)); // 🔥 Math.Pow(2,3) direct call
    }
}
📌 Output:
3.14159265358979
8
64
-------------------------------------------------------
📌 Example 2: Using using static with Custom Static Class
Agar hum khud ki static class banayein, to using static ka use karke uske static methods ko direct call kar sakte hain.

using System;
using static Utility; // ✅ Custom static class ko import kiya

static class Utility
{
    public static void SayHello()
    {
        Console.WriteLine("Hello from Utility Class!");
    }

    public static int Square(int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        SayHello(); // 🔥 Direct call
        Console.WriteLine(Square(5)); // 🔥 Direct call
    }
}
📌 Output:
Hello from Utility Class!
25
✅ Explanation:
using static Utility; likhne se Utility.SayHello() aur Utility.Square() ko direct call kar sakte hain.
-------------------------------------------------------------
📌 Example 3: Using using static with Enums
Agar enum values ko directly use karna ho bina EnumName. likhe, to using static use kar sakte hain.

using System;
using static Days; // ✅ Enum values ko direct use karne ke liye

enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        Days today = Friday; // 🔥 Directly access kiya
        Console.WriteLine($"Today is {today}");
    }
}
📌 Output:
Today is Friday
✅ Explanation:
using static Days; likhne se Days.Friday ko direct Friday likh ke access kar sake.
-----------------------------------------------------
📌 Example 4: Using using static with Console Class
Agar bar-bar Console.WriteLine() likhna avoid karna ho, to using static System.Console; ka use kar sakte hain.
using static System.Console; // ✅ Console ko direct access karne ke liye

class Program
{
    static void Main()
    {
        WriteLine("Hello, World!"); // 🔥 Console.WriteLine() ki jagah sirf WriteLine()
    }
}
📌 Output:
Hello, World!
📌 When NOT to Use using static?
❌ Jab confusing code ban raha ho ya naming conflicts ho rahe ho.
❌ Jab bahut saari static classes ka use ho, jisme same naam ke members ho sakte hain.
❌ Jab code readability kharab ho jaye aur dusre developers ko samajhne me dikkat aaye.
----------------------------------------------------------
📌 Interview Questions on using static
🔹 Q: What is using static in C#?
✅ A: using static ek feature hai jo kisi static class ke members ko directly access karne deta hai bina class ka naam likhe.

🔹 Q: Can using static be used with non-static classes?
✅ Nahi, using static sirf static classes ke saath hi kaam karta hai.

🔹 Q: How does using static improve code readability?
✅ Ye unnecessary static class names likhne ki zaroorat ko hatata hai aur code ko short aur readable banata hai.

🔹 Q: Can using static be used with multiple static classes?
✅ Haan, lekin agar same naam ke members different static classes me ho, to naming conflicts ho sakta hai.

🔹 Q: What is the difference between using namespace and using static?
✅ using namespace poore namespace ko import karta hai, jabki using static sirf ek static class ke members ko directly access karne deta hai.

