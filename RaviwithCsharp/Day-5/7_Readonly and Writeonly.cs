using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-5
{
    public class 7_Readonly and Writeonly
    {
        
    }
}
------------------------------------------------
1️⃣ Readonly Property (📖 Sirf Read Kar Sakte Hain, Modify Nahi!)
✅ Readonly properties ka value ek bar assign hone ke baad change nahi ho sakta.
✅ Iska use immutable (unchangeable) objects banane ke liye hota hai.
✅ Yeh properties sirf constructor ya getter me set ki ja sakti hain.

📌 Example: Readonly Property
using System;

class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        Name = name; // ✅ Readonly property ko constructor me set kar sakte hain
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Ravi", 22);
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");

        // ❌ student.Name = "Ahmed"; // Error! Readonly property ko modify nahi kar sakte.
    }
}
📌 Output:

Name: Ravi, Age: 22
----------------------------------------------------------------
2️⃣ Writeonly Property (✍ Sirf Likh Sakte Hain, Read Nahi!)
✅ Writeonly properties ka value set kiya ja sakta hai, lekin read nahi kar sakte.
✅ Mostly sensitive data store karne ke liye use hoti hai, jaise passwords, secret keys, etc.
✅ Yeh sirf set accessor ko support karti hai, get accessor nahi hota.

📌 Example: Writeonly Property
using System;

class BankAccount
{
    private string _password;

    public string Password
    {
        set
        {
            _password = value; // ✅ Value set kar sakte hain
            Console.WriteLine("Password updated successfully!");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Password = "Secure@123"; // ✅ Password ko set kar sakte hain

        // ❌ Console.WriteLine(account.Password); // Error! Writeonly property ko read nahi kar sakte.
    }
}
📌 Output:
Password updated successfully!
--------------------------------------------
📌 Real-World Use Cases

Readonly Property=	User's Date of Birth, Configuration Settings, API Keys
Writeonly Property=	Passwords, Security Codes, One-Time Tokens
--------------------------------
🔥 Conclusion
✅ Readonly properties immutable data store karne ke liye hoti hain.
✅ Writeonly properties sensitive data protect karne ke liye useful hoti hain.
✅ Dono ka use security aur code readability improve karne ke liye hota hai.

