using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-9
{
    public class 3_Encapsulation 
    {
        
    }
}
---------------------------------------------------------
Encapsulation ka matlab hota hai:

Apni data aur functions ko ek hi jagah (class ke andar) chhupa ke rakhna aur bahar se direct access nahi dena.
Sirf hum khud (class ke functions ke through) data ko control karte hain — kaise data ko read ya update karna hai, hum tay karte hain.

➡️ Isse data secure rehta hai aur galat tareeke se use hone se bach jaata hai.

💬 Thodi aur asaan bhaasha mein:
Data ko ek capsule (dabbe) ke andar bandh karna.

Bahar waale ko seedha access nahi dena.

Agar kuch chahiye ya badalna hai, toh gatekeeper (function/method) ke zariye karna padega.
-----------------------------------------------------------------
🎯 Real-world Example:
ATM Machine ka socho:

Tum apna ATM card daalte ho aur pin code daalte ho.

Tumhe poora internal system nahi dikhta: "bank mein backend pe kya ho raha hai, paise kaise deduct ho rahe hain", ye sab chhupa hua hai.

Tum sirf options dekhte ho: withdraw, balance inquiry etc.

Agar tum kuch galat karoge (jaise galat pin daloge), toh system allow nahi karega.
----------------------------------
Yani:
ATM ke andar pura mechanism chhupa hua hai = Encapsulation ✅

Tum sirf allowed actions kar sakte ho.
---------------------------------------------------------
👨‍💻 Programming Example:
maan lo ek BankAccount class hai:

public class BankAccount
{
    // Data chhupa ke rakha (private)
    private decimal balance;

    // Constructor
    public BankAccount(decimal initialBalance)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Method (Gatekeeper) balance ko dekhne ke liye
    public decimal GetBalance()
    {
        return balance;
    }

    // Method paisa jama karne ke liye
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Method paisa nikalne ke liye
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
        }
    }
}
➡️ Yahan balance private hai, direct koi balance ko nahi chhed sakta.

➡️ Sirf Deposit() aur Withdraw() methods ke through paisa jama ya nikal sakte ho.
--------------------------------------------------------------------
🤔 Agar Encapsulation nahi hota:
Toh koi bhi programmer direct balance ka value kuch bhi kar sakta:

BankAccount acc = new BankAccount(5000);
acc.balance = -9999;  // Galat! Negative balance kaise ho sakta? 🚫
Isiliye Encapsulation humare data ko safe rakhta hai.
---------------------------------------------------
🧠 Encapsulation ka Faayda:

Point	Faayda
1️⃣	Data Security: Sensitive data hide rehta hai.
2️⃣	Controlled Access: Sirf functions ke through access hota hai.
3️⃣	Code Easy to Maintain: Agar andar ka logic badalna ho, toh baahar waale code ko chhedna nahi padta.
4️⃣	Validation kar sakte ho: Jaise deposit hamesha positive amount ka hi ho.
5️⃣	Loose Coupling: Baaki system ko pata nahi andar kya chal raha hai, bus functions use karte hain.
-------------------------------------------------------------------
🚀 Ek aur chhota Example:
Car ko socho:

Car ka engine andar chhupa hua hai.

Tumhe sirf accelerator, brake aur steering use karna aata hai.

Tum engine ka internal working nahi jaante, na direct access karte ho.

Yeh bhi Encapsulation hai! ✅

📝 Final Line:
Encapsulation = Data ko hide karna + Gatekeeper (method) se controlled access dena.