using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-2
{
    public class Goto 
    {
        
    }
}

-------------------
Goto - Jump to a Label

int num = 1;
start:
Console.WriteLine(num);
num++;
if (num <= 5)
    goto start;