using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-9
{
    public class 4_Polymorphism 
    {
        
    }
}
---------------------------------------------------------------

Polymorphism kya hota hai?
Polymorphism ka matlab hota hai:

"Ek kaam ko alag-alag tareekon se karna" ya "ek cheez ka multiple forms lena".

Simple bhaasha mein:

Ek hi function/method alag-alag behaviour dikhaata hai depending on situation ya object.

Code flexible aur powerful ban jaata hai.

💬 Aur simple bolun toh:
Ek naam, lekin kaam alag-alag situation mein thoda alag hota hai.

Same action, different behaviour.
----------------------------------------------------------

🎯 Real-world Example:
TV Remote ko socho:

Remote mein ek Power Button hota hai.

Tum TV ke remote se TV on/off karte ho.

Tum AC ke remote se AC on/off karte ho.

Tum Set-Top Box ke remote se Set-Top Box on/off karte ho.

Button wahi ek hai (Power Button)
Kaam har device ka alag hai.

➡️ Yeh hai Polymorphism. ✅
--------------------------------------------------------------

👨‍💻 Programming mein do tareeke hote hain Polymorphism ke:

Type	Meaning
1️⃣ Compile-time Polymorphism (Static)	Jab program ke compile hone ke waqt decide ho jaaye kaunsa function chalega (Method Overloading)
2️⃣ Runtime Polymorphism (Dynamic)	Jab program chalne ke dauraan decide hota hai kaunsa function chalega (Method Overriding)
1️⃣ Compile-time Polymorphism (Method Overloading)
Ek hi naam ke methods, par arguments alag.

Example:
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
➡️ Yahan Add() method teen baar likha hai, but alag-alag arguments ke saath.

➡️ Jab tum Add(2,3) bulaoge to 2-argument waala chalega.

➡️ Jab Add(2.5, 3.7) bulaoge to double waala chalega.

2️⃣ Runtime Polymorphism (Method Overriding)
Parent class ka method child class apne tareeke se likh leti hai.

Example:

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}
---------------------------
Usage:

Animal myAnimal = new Animal();
myAnimal.Sound();  // Output: Animal makes a sound

Animal myDog = new Dog();
myDog.Sound();     // Output: Dog barks

Animal myCat = new Cat();
myCat.Sound();     // Output: Cat meows
➡️ Yahan Sound() method sab mein hai, par alag behavior ke saath.

➡️ Run time par decide hota hai ki kaunsa version chalega.
-------------------------------------------------------
🧠 Polymorphism ka Faayda:

Point	Faayda
1️⃣	Code reuse hota hai.
2️⃣	Code easy maintainable hota hai.
3️⃣	New functionality add karna easy hota hai without breaking existing code.
4️⃣	Flexible aur scalable design milta hai.
-------------------------------------------
🚀 Ek aur real-life Example:
Payment System ka socho:

Payment class bani hai.

CreditCardPayment, PayPalPayment, BankTransferPayment subclasses hain.

Har payment method apna alag logic use karega.
--------------------------------------------------------
Par jab use karoge:


Payment payment = new PayPalPayment();
payment.Pay();
➡️ Tumhe fark nahi padta andar kya chal raha hai.
➡️ Bus Pay() call karoge, correct wala apne aap chalega.
-------------------------------------------------
📝 Final Line:
Polymorphism = "Ek hi kaam, alag-alag tareeke se karna", 
jaise ek remote ka power button har device ke liye kaam karta hai but action alag hota hai.