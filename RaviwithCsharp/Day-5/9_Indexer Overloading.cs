using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class Indexer Overloading
    {
        
    }
}
---------------------------------------------------------------
What is an Indexer?
✅ Indexer ek special type ka property hai jo object ko array ki tarah behave karne deta hai.
✅ Hum this keyword ka use karke indexing define kar sakte hain.
✅ Isse hum object ke andar values ko index-based access kar sakte hain.

📌 Indexer Overloading Kya Hai?
✅ Indexer overloading ka matlab hai ki ek class me multiple indexers ho sakte hain, jo different parameter types ya counts accept karte hain.
✅ Yeh concept method overloading jaisa hi hai, bas yeh indexers pe apply hota hai.
------------------------------------------------------------
🎯 Example: Indexer Overloading in C#
1️⃣ Overloading by Different Parameter Types
using System;

class StudentRecords
{
    private string[] names = new string[5]; // Array to store student names

    // ✅ Indexer 1: Access by Integer Index
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }

    // ✅ Indexer 2: Access by String Key
    public string this[string searchName]
    {
        get
        {
            foreach (var name in names)
            {
                if (name == searchName) return "Student Found: " + name;
            }
            return "Student Not Found!";
        }
    }
}

class Program
{
    static void Main()
    {
        StudentRecords records = new StudentRecords();
        
        // Using Integer Indexer
        records[0] = "Rajput";
        records[1] = "Ravi";

        Console.WriteLine(records[0]); // Output: Rajput

        // Using String Indexer
        Console.WriteLine(records["Rajput"]);   // Output: Student Found: Rajput
        Console.WriteLine(records["John"]);  // Output: Student Not Found!
    }
}
📌 Output:
Rajput
Student Found: Rajput
Student Not Found!
✅ Yahan ek hi class me do indexers hain:

Pehla indexer integer index leta hai aur array ke through data access karta hai.

Dusra indexer string leta hai aur naam match karta hai.
----------------------------------------------------------------
2️⃣ Overloading by Different Parameter Count
using System;

class Library
{
    private string[] books = new string[5];

    // ✅ Indexer 1: Access by Index
    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    // ✅ Indexer 2: Access by Index & Default Message
    public string this[int index, string message]
    {
        get { return books[index] ?? message; }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        library[0] = "C# Programming";
        library[1] = "Java Fundamentals";

        Console.WriteLine(library[0]);                // Output: C# Programming
        Console.WriteLine(library[1, "Not Available"]); // Output: Java Fundamentals
        Console.WriteLine(library[3, "Not Available"]); // Output: Not Available
    }
}
📌 Output:
C# Programming
Java Fundamentals
Not Available
✅ Yahan do indexers hain:

Pehla sirf index leta hai aur book return karta hai.

Dusra index + default message leta hai jo tab return hota hai jab book available na ho.
-----------------------------------------------
🔥 Conclusion
✅ Indexer overloading se ek hi class me multiple ways se data access kar sakte hain.
✅ Alag-alag parameter types ya counts ke saath overload kar sakte hain.
✅ Yeh concept data structures aur collections me kaafi useful hota hai.