using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-7
{
    public class 3_Partial Methods
    {
        
    }
}
------------------------------------------
What is a Partial Method?
partial method ek special type ka method hota hai jo partial class ya partial struct ke andar define kiya jata hai. Yeh method declaration aur implementation ko alag-alag files me rakhne me madad karta hai.

✅ Method ka declaration ek partial class ke ek part me hota hai.
✅ Us method ki implementation (optional) doosre partial part me ki ja sakti hai.
✅ Agar implementation nahi hoti, to compiler us method ko hata deta hai.

📌 Why Use Partial Methods?
🔹 Large Codebases: Jab code auto-generated ho aur hume future me implement karna ho.
🔹 Performance Optimization: Agar method ki implementation nahi di to compiler us method ko completely hata deta hai, jisse extra overhead nahi banta.
🔹 Encapsulation: Private helper methods ya extension points create karne ke liye useful hota hai.

📌 Syntax of Partial Method
partial class MyClass
{
    partial void MyPartialMethod();  // ✅ Declaration (No body)
}
  
partial class MyClass
{
    partial void MyPartialMethod()   // ✅ Implementation (Optional)
    {
        Console.WriteLine("This is a partial method!");
    }
}
------------------------------------------------
📌 Example 1: Basic Partial Method
📄 File 1: Employee_Part1.cs (Declaration)
public partial class Employee
{
    partial void DisplayMessage();  // ✅ Partial method declared
}
📄 File 2: Employee_Part2.cs (Implementation)

public partial class Employee
{
    partial void DisplayMessage()  // ✅ Partial method implemented
    {
        Console.WriteLine("Hello from Partial Method!");
    }

    public void Show()
    {
        DisplayMessage();  // ✅ Method ko call kar sakte hain
    }
}
📌 Usage in Main Program:
using System;

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Show();
    }
}
📌 Output:
Hello from Partial Method!
------------------------------------------------------
📌 Example 2: Partial Method Without Implementation
Agar hum partial method ka implementation nahi dete, to compiler us method ko hata dega.

public partial class Product
{
    partial void LogDetails();  // ✅ Method ka sirf declaration

    public void ShowProduct()
    {
        Console.WriteLine("Product details displayed.");
        LogDetails();  // ✅ Yeh method call nahi hoga kyunki koi implementation nahi hai
    }
}
📌 Output:
Product details displayed.
✅ No error! Kyunki LogDetails ka implementation nahi hai, compiler usko hata dega.

📌 Rules of Partial Methods
✅ Partial methods sirf partial class ya partial struct ke andar ho sakte hain.
✅ Yeh methods private hote hain.
✅ Return type always void hoti hai.
✅ static, virtual, abstract, sealed ya extern nahi ho sakta.
✅ Agar implementation nahi likhi jati to compiler method ko hata deta hai.

📌 When to Use Partial Methods?
✅ Jab auto-generated code me hum extension points provide karna chahein.
✅ Jab performance optimization chahiye ho (compiler unused methods ko hata dega).
✅ Jab code organization aur flexibility badhani ho.

📌 Interview Questions on Partial Methods
🔹 Q: What is a Partial Method in C#?
✅ A: Partial method ek special method hota hai jo sirf partial class me declare hota hai. Agar implementation di jaye to execute hota hai, nahi to compiler usko hata deta hai.

🔹 Q: What is the return type of a Partial Method?
✅ A: Sirf void. Koi return type allowed nahi hai.

🔹 Q: Can a Partial Method be public or static?
✅ Nahi, yeh sirf private hote hain aur static, virtual, abstract ya sealed nahi ho sakte.