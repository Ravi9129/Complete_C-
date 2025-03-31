using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-6
{
    public class 10_Explicit Interface
    {
        
    }
}
------------------------------------------------------------
What is Explicit Interface Implementation?
C# me explicit interface implementation ka use tab hota hai jab ek class multiple interfaces ke same name wale methods ko implement kare.
Agar ek class do ya zyada interfaces implement kar rahi hai aur unme same method name hai, to explicit implementation se specify kar sakte hain ki kaunsa method kis interface ka hai.

👀 🔹 Without explicit implementation – Naming conflict ho sakta hai.
👀 🔹 With explicit implementation – Methods interface ke through access kiye jate hain, directly nahi.

🎯 Why Use Explicit Interface Implementation?
✅ Method Name Conflict Resolve Karna – Jab do interfaces me same method name ho.
✅ Encapsulation – Interface methods ko public banane ki zaroorat nahi hoti.
✅ Better Code Organization – Ek hi class me multiple behavior ko alag se handle kar sakte hain.
-----------------------------------------------------------------
📌 Example 1: Basic Explicit Interface Implementation
using System;

// ✅ Interface 1
interface IPrinter
{
    void Print();
}

// ✅ Interface 2 (Same method name)
interface IScanner
{
    void Print();
}

// ✅ Class implementing both interfaces explicitly
class MultiFunctionDevice : IPrinter, IScanner
{
    // ✅ Explicit Implementation (Directly Accessible Nahi Hoga)
    void IPrinter.Print()
    {
        Console.WriteLine("Printing document...");
    }

    void IScanner.Print()
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionDevice device = new MultiFunctionDevice();

        // ❌ device.Print();  // Compile-time error (Direct access not allowed)

        // ✅ Accessing explicit methods via interface reference
        ((IPrinter)device).Print();  // 🔥 Output: Printing document...
        ((IScanner)device).Print();  // 🔥 Output: Scanning document...
    }
}
📌 Output:
Printing document...
Scanning document...
✅ Explanation:
IPrinter aur IScanner dono me same Print() method hai.

MultiFunctionDevice class dono interfaces ko implement kar rahi hai.

Explicit Implementation (IPrinter.Print() and IScanner.Print()) ki wajah se ye methods direct access nahi hote.

Methods ko access karne ke liye interface ka reference use karna padta hai.
--------------------------------------------------------
📌 Example 2: Explicit Interface Implementation with Different Signatures
Agar interfaces me method names same ho but parameters different ho, to explicit implementation ki zaroorat nahi hoti.

using System;

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Print(string documentType);
}

class MultiFunctionDevice : IPrinter, IScanner
{
    public void Print() // ✅ IPrinter ka implementation
    {
        Console.WriteLine("Printing document...");
    }

    public void Print(string documentType) // ✅ IScanner ka implementation
    {
        Console.WriteLine($"Scanning {documentType} document...");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionDevice device = new MultiFunctionDevice();
        device.Print();             // 🔥 Output: Printing document...
        device.Print("PDF");        // 🔥 Output: Scanning PDF document...
    }
}
📌 Output:
Printing document...
Scanning PDF document...
✅ Explanation:
Agar method signatures different hain, to explicit implementation ki zaroorat nahi.

Ek method parameter ke bina hai, dusra parameter ke sath hai, is wajah se method overloading ho rahi hai.

📌 Example 3: Explicit Implementation with Properties
using System;

interface IReadable
{
    string Content { get; }
}

interface IWritable
{
    string Content { set; }
}

class Document : IReadable, IWritable
{
    private string content;

    // ✅ Explicit property implementation
    string IReadable.Content => content; // Read-only property

    string IWritable.Content
    {
        set { content = value; }
    }
}

class Program
{
    static void Main()
    {
        Document doc = new Document();

        // ✅ Using interface references to access explicit properties
        IWritable writableDoc = doc;
        writableDoc.Content = "C# Interfaces Example";

        IReadable readableDoc = doc;
        Console.WriteLine(readableDoc.Content);  // 🔥 Output: C# Interfaces Example
    }
}
📌 Output:
C# Interfaces Example
✅ Explanation:
IReadable ka Content read-only hai.

IWritable ka Content write-only hai.

Explicit implementation se dono ko alag tarike se implement kiya gaya hai.

📌 Key Points on Explicit Interface Implementation
🔹 Explicitly implemented methods are not accessible via the class object.
🔹 Explicit implementation ka use tab hota hai jab multiple interfaces same method name ke saath ho.
🔹 Explicitly implemented properties and methods ko sirf interface reference se access kiya ja sakta hai.
🔹 It provides encapsulation, resolving method conflicts, and better interface control.

📌 Interview Questions on Explicit Interface Implementation
🔹 Q: What is explicit interface implementation in C#?
✅ A: Jab ek class multiple interfaces ke same name wale methods ko implement karti hai, tab explicitly methods define kiye jate hain.

🔹 Q: Can explicitly implemented methods be accessed directly via the class object?
✅ A: Nahi, explicit methods sirf interface reference ke through access kiye ja sakte hain.

🔹 Q: What is the main benefit of explicit interface implementation?
✅ A: Ye naming conflicts resolve karta hai aur interfaces ke methods ko encapsulate karta hai.