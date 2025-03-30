using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 4_in Parameter Modifier
    {
        
    }
}
--------------------------------------
in Kya Hota Hai?
✅ in ek parameter modifier hai jo kisi variable ko read-only mode me pass karne ke liye use hota hai.
✅ Iska matlab hai ki method ke andar iski value modify nahi ki ja sakti.
✅ Ye tab useful hota hai jab hume ensure karna ho ki method sirf parameter ka use kare, lekin usme koi changes na kare.
---------------------------------------------------------------
🚀 1. Simple Example of in Parameter
✅ Scenario: Ek method jo kisi number ka square calculate kare, lekin number ko modify nahi kar sake.

using System;

class Program
{
    static void CalculateSquare(in int number)
    {
        // number = number * number; // ❌ Error: 'in' parameter cannot be assigned to
        Console.WriteLine($"Square of {number} is {number * number}");
    }

    static void Main()
    {
        int value = 5;
        CalculateSquare(in value); // ✅ 'in' keyword optional hai

        Console.WriteLine($"Original Value: {value}"); // ✅ Value same rahegi
    }
}
📌 Output:
Square of 5 is 25
Original Value: 5
📌 Yahan number ki value method ke andar change nahi ho sakti, is wajah se ye immutable (read-only) rahta hai.
------------------------------------------------------------------------
🚀 2. in with Structs (Performance Optimization)
✅ Scenario: Agar hum kisi large struct ko method me pass karein, to in uska copy banane se bachata hai, performance improve hoti hai.

using System;

struct LargeData
{
    public int X, Y, Z;
}

class Program
{
    static void ProcessData(in LargeData data)
    {
        Console.WriteLine($"Processing Data: {data.X}, {data.Y}, {data.Z}");
    }

    static void Main()
    {
        LargeData myData = new LargeData { X = 10, Y = 20, Z = 30 };
        ProcessData(myData);  // ✅ Efficient because no copy is created
    }
}
📌 Agar in na hota, to struct ka ek new copy banta, jo memory inefficient hota.
--------------------------------------------------------------------
🚀 3. in vs ref vs out
Feature	in	ref	out
Initialization before method call	✅ Required	✅ Required	❌ Not required
Modification inside method	❌ Not Allowed	✅ Allowed	✅ Required
Use Case	Read-only parameters	Modify existing values	Return multiple values

📌 Example of ref (Modify Allowed):

static void Modify(ref int number)
{
    number = number * 2; // ✅ Allowed
}
--------------------------------------------------------
📌 Example of out (Initialization Required Inside Method):

static void GetValues(out int number)
{
    number = 10; // ✅ Must assign before use
}
--------------------------------------------------------
📌 Example of in (Read-Only, Cannot Modify):

static void Display(in int number)
{
    // number = number * 2; // ❌ Not Allowed
    Console.WriteLine(number);
}
-----------------------------------------------------
🚀 4. in with ReadOnly Structs
✅ Scenario: Kisi read-only struct ko efficiently pass karna.

using System;

readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void PrintPoint(in Point p)
    {
        Console.WriteLine($"Point: ({p.X}, {p.Y})");
    }

    static void Main()
    {
        Point p1 = new Point(3, 5);
        PrintPoint(p1);
    }
}
📌 Read-only structs ka in ke saath use karna efficient hota hai, kyunki ye unnecessary copies banane se bachata hai.
-----------------------------------------------------------------
🚀 5. Real-World Scenario: Immutable Data Processing
✅ Scenario: Ek Transaction class jo immutable values hold karti hai, taki kisi bhi function ke andar ye modify na ho sake.

using System;

struct Transaction
{
    public int ID { get; }
    public double Amount { get; }

    public Transaction(int id, double amount)
    {
        ID = id;
        Amount = amount;
    }
}

class Program
{
    static void PrintTransaction(in Transaction txn)
    {
        Console.WriteLine($"Transaction ID: {txn.ID}, Amount: {txn.Amount}");
    }

    static void Main()
    {
        Transaction t1 = new Transaction(101, 5000);
        PrintTransaction(t1);
    }
}
📌 Yeh approach data consistency ensure karti hai, taaki koi bhi function transaction object ko modify na kar sake.
---------------------------------------------------
🚀 Conclusion
✅ in use hota hai read-only parameters ke liye, jo method ke andar modify nahi ho sakte.
✅ Yeh ref aur out se different hai kyunki in method ke andar kisi variable ki value change hone nahi deta.
✅ Large struct pass karte waqt yeh memory performance optimize karta hai.