using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 9_Recursion 
    {
        
    }
}
---------------------------------------------------
Recursion Kya Hai?
✅ Recursion ek technique hai jisme ek function apne aap ko call karta hai.
✅ Iska use tab hota hai jab ek problem ko chhoti subproblems me todna ho.
✅ Recursion ka har function call apna ek alag execution context maintain karta hai (Call Stack).
------------------------------------------------------
🚀 1. Simple Recursion Example (Countdown Timer)
✅ Scenario: Ek function countdown karega aur recursion use karega.

using System;

class Program
{
    static void Countdown(int number)
    {
        if (number <= 0) // ✅ Base Case (Stopping Condition)
        {
            Console.WriteLine("Time's up!");
            return;
        }

        Console.WriteLine(number);
        Countdown(number - 1); // ✅ Recursive Call (Function apne aap ko call kar raha hai)
    }

    static void Main()
    {
        Countdown(5);
    }
}
📌 Output:
5
4
3
2
1
Time's up!
📌 Yahan Countdown(5) recursively apne aap ko call karega jab tak number <= 0 nahi ho jata.
---------------------------------------------------
🚀 2. Factorial Calculation using Recursion
✅ Scenario: Ek function factorial calculate karega using recursion.
📌 Formula:

𝐹
𝑎
𝑐
𝑡
𝑜
𝑟
𝑖
𝑎
𝑙
(
𝑛
)
=
𝑛
×
𝐹
𝑎
𝑐
𝑡
𝑜
𝑟
𝑖
𝑎
𝑙
(
𝑛
−
1
)
Factorial(n)=n×Factorial(n−1)
𝐹
𝑎
𝑐
𝑡
𝑜
𝑟
𝑖
𝑎
𝑙
(
5
)
=
5
×
4
×
3
×
2
×
1
Factorial(5)=5×4×3×2×1
----------------------------------
using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0) return 1; // ✅ Base Case (Stopping Condition)
        return n * Factorial(n - 1); // ✅ Recursive Call
    }

    static void Main()
    {
        Console.WriteLine(Factorial(5)); // ✅ Output: 120
    }
}
📌 Output:
120
📌 Yahan Factorial(5) function apne aap ko call karta hai jab tak n == 0 nahi ho jata.
-------------------------------------------------------
🚀 3. Fibonacci Series using Recursion
✅ Scenario: Ek function Fibonacci series generate karega.
📌 Formula:

𝐹
(
𝑛
)
=
𝐹
(
𝑛
−
1
)
+
𝐹
(
𝑛
−
2
)
F(n)=F(n−1)+F(n−2)
𝐹
𝑖
𝑏
𝑜
𝑛
𝑎
𝑐
𝑐
𝑖
(
5
)
=
0
,
1
,
1
,
2
,
3
,
5
Fibonacci(5)=0,1,1,2,3,5
-----------------------------
using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0) return 0; // ✅ Base Case 1
        if (n == 1) return 1; // ✅ Base Case 2
        return Fibonacci(n - 1) + Fibonacci(n - 2); // ✅ Recursive Call
    }

    static void Main()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
📌 Output:

0 1 1 2 3 5
📌 Yahan recursion har Fibonacci number ko previous two numbers ka sum bana raha hai.
-------------------------------------------
🚀 4. Sum of Digits using Recursion
✅ Scenario: Ek function ek number ke digits ka sum calculate karega.
📌 Example:

𝑆
𝑢
𝑚
(
123
)
=
1
+
2
+
3
=
6
Sum(123)=1+2+3=6
-------------------------------
using System;

class Program
{
    static int SumOfDigits(int n)
    {
        if (n == 0) return 0; // ✅ Base Case
        return (n % 10) + SumOfDigits(n / 10); // ✅ Recursive Call
    }

    static void Main()
    {
        Console.WriteLine(SumOfDigits(123)); // ✅ Output: 6
    }
}
📌 Output:
6
📌 Yahan function last digit (n % 10) ko add karta hai aur remaining number (n / 10) ke liye recursive call karta hai.
----------------------------------------------------------------------------
🚀 5. Reverse a String using Recursion
✅ Scenario: Ek function string ko reverse karega using recursion.
📌 Example: "hello" → "olleh"

using System;

class Program
{
    static string ReverseString(string str)
    {
        if (str.Length <= 1) return str; // ✅ Base Case
        return ReverseString(str.Substring(1)) + str[0]; // ✅ Recursive Call
    }

    static void Main()
    {
        Console.WriteLine(ReverseString("hello")); // ✅ Output: "olleh"
    }
}
📌 Output:
olleh
📌 Yahan recursion pehle first character hata kar remaining string ko reverse karta hai, phir first character ko last me add karta hai.
-------------------------------------------------------------------
🚀 6. Checking Palindrome using Recursion
✅ Scenario: Ek function check karega ki string palindrome hai ya nahi.
📌 Example: "madam" → true, "hello" → false

using System;

class Program
{
    static bool IsPalindrome(string str, int start, int end)
    {
        if (start >= end) return true; // ✅ Base Case
        if (str[start] != str[end]) return false;
        return IsPalindrome(str, start + 1, end - 1); // ✅ Recursive Call
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome("madam", 0, 4)); // ✅ Output: true
        Console.WriteLine(IsPalindrome("hello", 0, 4)); // ✅ Output: false
    }
}
📌 Output:
True
False
📌 Yahan recursion first aur last character ko check karta hai, phir remaining string ke liye recursive call karta hai.
-------------------------------------------------------
🚀 7. Directory Traversal using Recursion
✅ Scenario: Ek function directories aur files ko recursively print karega.
📌 Example: Ek directory aur uske subdirectories ko traverse karna.
using System;
using System.IO;

class Program
{
    static void ListFiles(string path, int level = 0)
    {
        foreach (string file in Directory.GetFiles(path))
        {
            Console.WriteLine(new string(' ', level * 2) + Path.GetFileName(file));
        }

        foreach (string dir in Directory.GetDirectories(path))
        {
            Console.WriteLine(new string(' ', level * 2) + "[DIR] " + Path.GetFileName(dir));
            ListFiles(dir, level + 1); // ✅ Recursive Call
        }
    }

    static void Main()
    {
        ListFiles("C:\\Users\\Public"); // ✅ Replace with valid directory path
    }
}
📌 Ye function recursively ek directory aur uske subdirectories ke files list karega.

🚀 Conclusion
✅ Recursion complex problems (tree traversal, graph traversal, etc.) ke liye useful hai.
✅ Base case define karna zaroori hai warna stack overflow ho sakta hai.
✅ Agar memory efficient solution chahiye to recursion se bachna chahiye.