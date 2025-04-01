using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-9
{
    public class 1_Delegates 
    {
        
    }
}
----------------------------------------
Delegates kya hote hain?
Delegate ek type-safe function pointer hota hai. Iska matlab hai, ki delegate ko hum ek method ki reference (pointer) de sakte hain, aur phir us delegate ke through us method ko call kar sakte hain.

Real world example se samajhte hain.

Real World Scenario:
Maan lo, tumhare paas ek Calculator class hai, jisme do numbers ke beech addition aur subtraction ka kaam karne wale methods hain. Tum chahte ho ki koi bhi method dynamically select kiya jaaye aur use kiya jaaye.

Is case mein, delegate ka use hoga, taaki ek method ko select karke usse call kiya jaa sake bina directly method name likhe.

Syntax:
Delegate Declaration: Sabse pehle, ek delegate type define karte hain.

delegate return_type DelegateName(parameters);
return_type: Jo function return karega uska type.

DelegateName: Delegate ka naam.

parameters: Function ke parameters.

Delegate Initialization: Phir, is delegate ko ek specific method ke saath initialize karte hain.

DelegateName delegateObject = new DelegateName(methodName);
Delegate Invocation: Delegate ko call karte hain jaise ek function ko call karte hain.
----------------------------------------
Example: Calculator with Delegates
Step 1: Delegate Declaration
Sabse pehle hum ek delegate declare karte hain, jo kisi bhi operation ko perform kare.

using System;

public delegate int MathOperation(int a, int b);

public class Calculator
{
    // Methods for basic operations
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
        return a / b;
    }
}
--------------------------------------------
Step 2: Delegate Initialization
Yahaan hum ek MathOperation delegate create karenge, jo kisi bhi math operation ko reference karega.

class Program
{
    static void Main()
    {
        // Create an instance of Calculator
        Calculator calc = new Calculator();

        // Create a delegate instance and assign the Add method
        MathOperation addDelegate = new MathOperation(calc.Add);
        MathOperation subtractDelegate = new MathOperation(calc.Subtract);

        // Call the delegate
        int result1 = addDelegate(10, 5);  // 10 + 5
        int result2 = subtractDelegate(10, 5);  // 10 - 5

        Console.WriteLine("Addition: " + result1);  // Output: 15
        Console.WriteLine("Subtraction: " + result2);  // Output: 5

        // Dynamically assign another method, like Multiply
        MathOperation multiplyDelegate = new MathOperation(calc.Multiply);
        int result3 = multiplyDelegate(10, 5);  // 10 * 5
        Console.WriteLine("Multiplication: " + result3);  // Output: 50
    }
}
Explanation:
Delegate Declaration (MathOperation):

delegate int MathOperation(int a, int b); ek delegate declare karta hai, jo kisi bhi function ko point karega jo do integers ko leke ek integer return karega.

Delegate Initialization:

Phir humne MathOperation addDelegate ko calc.Add method ke saath bind kiya.

Ye hi cheez humne subtractDelegate aur multiplyDelegate ke saath bhi kiya.

Delegate Invocation:

Jab tum addDelegate(10, 5) call karte ho, to ye internally calc.Add(10, 5) call karta hai aur result deta hai.

Dynamically Changing Delegate:

Tum multiplyDelegate ko set kar sakte ho dynamically aur phir usse calc.Multiply ko call karwa sakte ho, bina directly method name likhe.

Output:
Addition: 15
Subtraction: 5
Multiplication: 50
Use Case of Delegates:
Event Handling: Delegates ka most common use event handling mein hota hai. Jab kisi event ko handle karna ho, toh delegate us event handler ke method ko point karta hai.

Callback Functions: Jab ek method ko dusre method mein dynamically pass karna ho, toh delegate ka use hota hai. Jaise kisi asynchronous task mein callback function pass karna.

Command Pattern: Jab tumhe apne program ko modular aur flexible banana ho, toh command pattern implement karte waqt delegate ka use hota hai.

Multithreading: Agar multiple threads hain jo same method ko call karte hain, toh delegate se methods ko asynchronously handle kiya ja sakta hai.

Important Points:
Type-Safety: Delegate type-safe hota hai, matlab jo function tum delegate ke saath assign kar rahe ho, uske parameters aur return type match hone chahiye.

Multicast Delegates: Ek delegate multiple methods ko bind kar sakta hai, jise multicast delegate kehte hain. Agar tum += operator ka use karte ho, toh delegate multiple methods ko point kar sakta hai.

Events: Delegate ka use events ko handle karne mein bhi hota hai. Event ko handle karne wala method delegate ke through trigger hota hai.

Multicast Delegate Example:
using System;

public delegate void MessageDelegate(string message);

class Program
{
    static void Main()
    {
        MessageDelegate msgDelegate = new MessageDelegate(PrintMessage);
        
        // Add another method to the delegate
        msgDelegate += DisplayMessage;

        // Calling the multicast delegate
        msgDelegate("Hello, World!");
    }

    static void PrintMessage(string message)
    {
        Console.WriteLine("Print: " + message);
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine("Display: " + message);
    }
}
Output:
Print: Hello, World!
Display: Hello, World!
------------------------------
Conclusion:
Delegates ka use hum dynamic method invocation ke liye karte hain.
 Wo ek tarah se method reference hota hai jo aapko method ko call karne ki flexibility deta hai.
 Jab aapko apne program mein kisi function ko dynamically pass karna ho, 
 ya event-driven programming karni ho, tab delegates kaafi helpful hote hain.