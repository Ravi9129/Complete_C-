using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class 5Loops 
    {
        
    }
}

---------------------------

5. Loops in C#
Loops ka use repeated operations ke liye hota hai.

for (int i = 2; i <= 10; i += 2)
{
    Console.WriteLine(i);
}

----------------------
ForEach Loop - Array Traversal

string[] fruits = { "Apple", "Banana", "Mango" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

----------------------

Nested For Loop - Multiplication Table
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}