using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-9
{
    public class 2_Multicast Delegates
    {
        
    }
}
-----------------------------------
Multicast Delegates in C#
Multicast delegates C# mein ek special type ke delegates hote hain jo multiple methods ko ek hi delegate instance ke through call karte hain. Matlab, ek delegate multiple methods ko bind karke unhe ek saath invoke kar sakta hai.

Real-World Scenario:

Maan lo tumhe ek application mein multiple actions perform karne hain jab ek event trigger ho. Jaise agar kisi button ko click kiya jaye, toh tumhe ek message show karna ho, ek log file mein entry karni ho, aur ek email send karni ho. Tum multicast delegate ka use kar sakte ho taaki sabhi methods ek hi delegate ke through execute ho jaayein.
-----------------------------------------------------
Syntax of Multicast Delegate:
Delegate Declaration: Pehle ek delegate type declare karna hota hai jo void return type ko handle kare, jaise ki hum event handling ke liye use karte hain.

delegate void ActionDelegate(string message);
Multiple Methods Bind: Tum ek delegate ko multiple methods se bind kar sakte ho using += operator.

Method Invocation: Jab tum delegate ko invoke karte ho, toh wo sabhi bound methods ko sequentially call karega.
----------------------------------------------------------
Example: Multicast Delegate
using System;

public delegate void ActionDelegate(string message);

class Program
{
    static void Main()
    {
        // Create delegate instance and bind methods using +=
        ActionDelegate action = new ActionDelegate(PrintMessage);
        
        // Add another method to the delegate
        action += DisplayMessage;
        action += LogMessage;

        // Call the multicast delegate
        action("Hello, World!");
    }

    // Method 1
    static void PrintMessage(string message)
    {
        Console.WriteLine("Message Printed: " + message);
    }

    // Method 2
    static void DisplayMessage(string message)
    {
        Console.WriteLine("Message Displayed: " + message);
    }

    // Method 3
    static void LogMessage(string message)
    {
        Console.WriteLine("Message Logged: " + message);
    }
}
Explanation:
Delegate Declaration:

delegate void ActionDelegate(string message); ek delegate type declare karte hain jo ek string argument leta hai aur void return karta hai (koi value nahi return karta).

Binding Multiple Methods:

action += DisplayMessage; aur action += LogMessage; ka matlab hai ki humne PrintMessage, DisplayMessage, aur LogMessage methods ko ek hi delegate instance ke saath bind kiya hai.

Multicast Delegate Invocation:

Jab action("Hello, World!"); ko call kiya jaata hai, to ye PrintMessage, DisplayMessage, aur LogMessage methods ko sequentially call karta hai.

Execution:

Pehle PrintMessage call hoga.

Phir DisplayMessage call hoga.

Phir LogMessage call hoga.

Output:
Message Printed: Hello, World!
Message Displayed: Hello, World!
Message Logged: Hello, World!
---------------------------------------------
Important Points About Multicast Delegates:
Return Type:

Multicast delegates sirf void return type wale methods ke liye kaam karte hain, kyunki jab delegate multiple methods ko call karta hai, to unmein se pehla method jo value return karega, woh baaki methods ke execution ko ignore kar dega.
-------------------------------------------------
Order of Execution:

Methods ko call karne ka order += operator ke sequence mein hota hai. Matlab jo method pehle bind kiya gaya ho, wo pehle execute hoga.
------------------------------------------------
Removing Methods from Delegate:

Tum -= operator ka use karke methods ko multicast delegate se remove bhi kar sakte ho.

action -= DisplayMessage;  // Removes DisplayMessage from the delegate
Delegate Chaining:

Tum delegates ko ek chain ki tarah bhi use kar sakte ho, jisme ek delegate dusre delegate ko call karega. 
Ye concept delegate chaining kehlata hai.
--------------------------------------------------------
Advanced Example: Removing Methods from Multicast Delegate
using System;

public delegate void ActionDelegate(string message);

class Program
{
    static void Main()
    {
        // Create delegate instance and bind methods using +=
        ActionDelegate action = new ActionDelegate(PrintMessage);
        
        // Add methods to the delegate
        action += DisplayMessage;
        action += LogMessage;

        // Call the multicast delegate
        Console.WriteLine("Before Removing Method:");
        action("Hello, World!");

        // Removing one method from the delegate
        action -= DisplayMessage;

        // Call the multicast delegate again
        Console.WriteLine("\nAfter Removing Method:");
        action("Hello, World!");
    }

    static void PrintMessage(string message)
    {
        Console.WriteLine("Message Printed: " + message);
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine("Message Displayed: " + message);
    }

    static void LogMessage(string message)
    {
        Console.WriteLine("Message Logged: " + message);
    }
}
Output:
Before Removing Method:
Message Printed: Hello, World!
Message Displayed: Hello, World!
Message Logged: Hello, World!

After Removing Method:
Message Printed: Hello, World!
Message Logged: Hello, World!
--------------------------------
Use Cases of Multicast Delegates:
Event Handling:

Jab multiple event handlers ko ek hi event ke liye register karna ho. Jaise kisi button ke click par ek method message display kare aur doosra method log kare.
-------------------------------------
Notification Systems:

Jab ek action ko multiple systems ko notify karna ho. Jaise ek email send karna aur phir SMS alert bhejna.
--------------------------------------
Logging:

Jab ek application mein logging ka requirement ho aur multiple logs ko track karna ho, tab multicast delegates ka use kiya jaata hai.

Observer Pattern:

Jab ek observer pattern implement karte ho, to multiple observers ek hi event ko handle karte hain. Is scenario mein multicast delegates ka use hota hai.
-----------------------------------------------
Conclusion:
Multicast delegates ek powerful feature hain jise hum multiple methods ko ek delegate ke saath bind kar sakte hain. 
Ye method ko sequence mein call karte hain,
 aur += operator ke through easily manage kiya jaa sakta hai. Jab tumhe ek event ke liye multiple actions perform karni ho, 
tab multicast delegates ka use kaafi useful hota hai.