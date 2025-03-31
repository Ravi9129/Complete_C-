using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 5_Enumerations 
    {
        
    }
}
-------------------------------------
What is an Enumeration (Enum)?
Enum ek special data type hai jo name-based constant values ko represent karta hai. Enum ka use tab hota hai jab aapko ek set of related constants ko ek naam deke manage karna ho. Enums ko aap variables ko meaningful names assign karne ke liye use kar sakte hain, jo ki readability aur maintainability ko improve karta hai.

✅ Example: Days of the Week, Directions, Status Codes, etc.

📌 Syntax of Enum
enum EnumName
{
    Constant1,
    Constant2,
    Constant3
}
📌 Example 1: Basic Enum Usage
using System;

enum Day
{
    Sunday,    // Default value 0
    Monday,    // Default value 1
    Tuesday,   // Default value 2
    Wednesday, // Default value 3
    Thursday,  // Default value 4
    Friday,    // Default value 5
    Saturday   // Default value 6
}

class Program
{
    static void Main()
    {
        Day today = Day.Monday;
        Console.WriteLine($"Today is: {today}");  // Output: Today is: Monday

        int dayValue = (int)today;  // Enum ko integer me cast karna
        Console.WriteLine($"Numeric value of {today}: {dayValue}");  // Output: Numeric value of Monday: 1
    }
}
📌 Output:
Today is: Monday
Numeric value of Monday: 1
-------------------------------------------------------------------
📌 Example 2: Enum with Custom Values
Aap enums me default values ke alawa custom values bhi assign kar sakte hain.
using System;

enum Day
{
    Sunday = 1,    // Custom value 1
    Monday = 2,    // Custom value 2
    Tuesday = 3,   // Custom value 3
    Wednesday = 4, // Custom value 4
    Thursday = 5,  // Custom value 5
    Friday = 6,    // Custom value 6
    Saturday = 7   // Custom value 7
}

class Program
{
    static void Main()
    {
        Day today = Day.Wednesday;
        Console.WriteLine($"Today is: {today}");  // Output: Today is: Wednesday

        int dayValue = (int)today;  // Enum ko integer me cast karna
        Console.WriteLine($"Numeric value of {today}: {dayValue}");  // Output: Numeric value of Wednesday: 4
    }
}
📌 Output:
Today is: Wednesday
Numeric value of Wednesday: 4
----------------------------------------------------------------
📌 Example 3: Enum with Bit Flags (Flags Attribute)
Enums ko flags ke roop me bhi use kiya ja sakta hai, jo bitwise OR operations ko allow karta hai. Isme aap multiple constants ko combine kar sakte hain.

using System;

[Flags]
enum Permission
{
    None = 0,
    Read = 1,       // 0001
    Write = 2,      // 0010
    Execute = 4,    // 0100
    Delete = 8      // 1000
}

class Program
{
    static void Main()
    {
        Permission userPermissions = Permission.Read | Permission.Write;  // Combine permissions
        Console.WriteLine($"User Permissions: {userPermissions}");  // Output: User Permissions: Read, Write

        // Checking individual flags
        bool canWrite = (userPermissions & Permission.Write) == Permission.Write;
        Console.WriteLine($"Can write? {canWrite}");  // Output: Can write? True
    }
}
📌 Output:
User Permissions: Read, Write
Can write? True
----------------------------------------
📌 Enum as a Type
Aap enum ko directly ek type ke roop me bhi use kar sakte hain:

enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        Day today = Day.Friday;
        PrintDay(today);  // Output: Today is: Friday
    }

    static void PrintDay(Day day)
    {
        Console.WriteLine($"Today is: {day}");
    }
}
📌 Output:
Today is: Friday
--------------------------------------
📌 Enum and Switch Case
Enum ko switch case me use karna bhi kaafi common hai:
enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        Day today = Day.Wednesday;
        
        switch (today)
        {
            case Day.Sunday:
                Console.WriteLine("Today is Sunday.");
                break;
            case Day.Wednesday:
                Console.WriteLine("Today is Wednesday.");
                break;
            default:
                Console.WriteLine("It's a weekday.");
                break;
        }
    }
}
📌 Output:
Today is Wednesday.
-----------------------
📌 Enum Methods and Properties
Enums me kuch built-in methods aur properties hote hain jo kaafi useful hote hain.

1. Enum.GetValues()
Yeh method enum ke saare values ko array ki form me return karta hai:

enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        foreach (Day day in Enum.GetValues(typeof(Day)))
        {
            Console.WriteLine(day);
        }
    }
}
📌 Output:
Sunday
Monday
Tuesday
Wednesday
Thursday
Friday
Saturday
2. Enum.GetName()
Is method se aap kisi enum value ka name get kar sakte hain.

enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class Program
{
    static void Main()
    {
        string dayName = Enum.GetName(typeof(Day), 3);  // 3rd value (Wednesday)
        Console.WriteLine($"Day with value 3 is: {dayName}");
    }
}
📌 Output:
Day with value 3 is: Wednesday
📌 Rules for Using Enum
Default Values: Enum values by default 0 se start hote hain.

Explicit Values: Aap custom integer values assign kar sakte hain.

Flags: Agar aapko multiple values ko combine karna ho to Flags attribute use karein.

Enum and Memory: Enums memory me efficient hote hain kyunki yeh integer values store karte hain.
---------------------------------------------------------
📌 Interview Questions on Enums
🔹 Q: What is an Enum in C#?
✅ A: Enum ek special data type hai jo related constants ko represent karta hai, jisme aap har constant ko ek name-based value de sakte hain.

🔹 Q: Can we assign custom values to Enum constants?
✅ A: Haan, hum enums ko custom values assign kar sakte hain.

🔹 Q: What is the Flags attribute in Enums?
✅ A: Flags attribute ka use tab hota hai jab hume multiple enum values ko bitwise OR operator ke through combine karna ho.