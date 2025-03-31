using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 10_Primitive Types as Structures
    {
        
    }
}
---------------------------------------
Primitive Types as Structures in C# 🔥
🔹 C# ke jitne bhi primitive types hote hain (int, double, bool, char, etc.), woh internally structures hote hain.
🔹 Yeh value types hote hain, jo stack memory me store hote hain aur directly values hold karte hain.
🔹 Yeh System.ValueType class ko inherit karte hain.

📌 1. Primitive Types in C# as Structs
C# ke primitive types internally structs hote hain jo System.ValueType se inherit karte hain.

Primitive Type	Underlying Struct
int	System.Int32
long	System.Int64
float	System.Single
double	System.Double
char	System.Char
bool	System.Boolean
byte	System.Byte
short	System.Int16
✅ Yani jab bhi hum int, double ya bool use karte hain, toh C# unke corresponding struct ko use karta hai.
------------------------------------------------------------
📌 2. Example: Checking Struct Type of Primitive Types
Agar aap kisi primitive type ka typeof() check karein toh yeh System.Struct niklega.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(typeof(int));    // Output: System.Int32
        Console.WriteLine(typeof(double)); // Output: System.Double
        Console.WriteLine(typeof(bool));   // Output: System.Boolean
        Console.WriteLine(typeof(char));   // Output: System.Char
    }
}
✅ Jaisa ki output me dikh raha hai, primitive types internally System.Int32, System.Double jaise structs hain.
-----------------------------------------------------------
📌 3. Primitive Types as Structs - Practical Example
Agar hum kisi primitive type ka method call karein, toh yeh struct ke method ko invoke karega.

using System;

class Program
{
    static void Main()
    {
        int number = 123;
        Console.WriteLine(number.ToString());   // Convert int to string (System.Int32 method)
        
        double value = 45.67;
        Console.WriteLine(value.GetType());     // Get the type (System.Double method)
        
        bool isActive = true;
        Console.WriteLine(isActive.ToString()); // Convert bool to string (System.Boolean method)
    }
}
📌 Output
123
System.Double
True
✅ Yeh proof karta hai ki int, double, aur bool structs hain jo methods support karte hain.
------------------------------------------------------------
📌 4. Exploring System.Int32 Struct
Agar hum System.Int32 struct ka IL (Intermediate Language) dekhein toh yeh kuch aise define hota hai:
public struct Int32 : IComparable, IConvertible, IFormattable
{
    public int CompareTo(object value);
    public override bool Equals(object obj);
    public override int GetHashCode();
    public override string ToString();
    public string ToString(IFormatProvider provider);
}
✅ Iska matlab hai ki int ek full-fledged struct hai jo multiple interfaces implement karta hai.
------------------------------------------------
📌 6. When to Use Built-in Structs?
✅ Agar aapko fast, lightweight aur memory-efficient data type chahiye toh primitive types use karna best practice hai.
✅ Agar aapko kuch additional functionality add karni hai jo primitive types me nahi hai, tab aap custom struct bana sakte hain.
-------------------------------------------------
🔥 Final Thoughts
✔ C# me primitive types bhi internally structs hote hain.
✔ Yeh System.ValueType se inherit karte hain aur efficient memory management provide karte hain.
✔ Primitive types ke built-in methods bhi hote hain, jo unko aur powerful banate hain. 🚀