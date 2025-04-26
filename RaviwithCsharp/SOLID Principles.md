S — Single Responsibility Principle (SRP)

Ek class sirf ek kaam kare, aur us responsibility ko properly handle kare.

O — Open/Closed Principle (OCP)

Code "open for extension" hona chahiye, "closed for modification" hona chahiye.

L — Liskov Substitution Principle (LSP)

Child classes parent classes ke place pe use hone chahiye bina functionality tod ke.

I — Interface Segregation Principle (ISP)

Bade interfaces ko chhote-chhote specific interfaces mein tod do. 
Client ko sirf wahi method implement karne do jo usko chahiye.

D — Dependency Inversion Principle (DIP)

High-level modules ko low-level modules pe depend nahi karna chahiye. 
Dono abstraction pe depend karein.


SOLID Principles

------------------------------------------------

🚀 SOLID Principles — Full Deep Explanation
🧠 What is SOLID?
SOLID ek mnemonic hai (yaani short name), jo 5 alag-alag software design ke rules ko represent karta hai.

SOLID principles help karte hain code ko:

Easy to Understand

Easy to Extend

Easy to Maintain

Reusable and Scalable

📚 SOLID full form:

Letter	Principle Name
S	Single Responsibility Principle
O	Open/Closed Principle
L	Liskov Substitution Principle
I	Interface Segregation Principle
D	Dependency Inversion Principle
🔥 1. S - Single Responsibility Principle (SRP)
📖 Definition:
Ek class ka sirf ek hi reason hona chahiye change hone ka.

Yani: Ek class ka sirf ek kaam hona chahiye.

🎯 Real World Example:
Ek Author class banaayi.

Author ke kaam hai:

Name store karna

Book likhna

Data save karna (Database)

Galat Approach:

csharp
Copy
Edit
public class Author
{
    public string Name { get; set; }
    
    public void WriteBook() { }
    public void SaveToDatabase() { }   // ❌
}
Yahan Author ka kaam likhna hai, Database ka kaam alag hona chahiye.

✅ Correct Approach:

csharp
Copy
Edit
public class Author
{
    public string Name { get; set; }
    
    public void WriteBook() { }
}

public class AuthorRepository
{
    public void SaveToDatabase(Author author) { }
}
Matlab:

Author class sirf Author ka kaam karegi (Book likhna).

AuthorRepository class Database ka kaam karegi (Data Save karna).

🔥 2. O - Open/Closed Principle (OCP)
📖 Definition:
Code Open hona chahiye Extension ke liye,
Closed hona chahiye Modification ke liye.

Yani: Naye features add kar sakte ho bina purana code tod ke.
------------------------------------------
🎯 Real World Example:
Suppose ek Payment system hai.
------------------------------------------
Galat Approach:

public class Payment
{
    public void Pay(string paymentType)
    {
        if (paymentType == "CreditCard")
        {
            // Credit Card Payment
        }
        else if (paymentType == "Paypal")
        {
            // Paypal Payment
        }
    }
}
Agar naye Payment method aaye, toh har baar if-else modify karna padega ❌.
----------------------------------------------------------------
✅ Correct Approach (Open for Extension):

public interface IPayment
{
    void Pay();
}

public class CreditCardPayment : IPayment
{
    public void Pay() { /* logic */ }
}

public class PaypalPayment : IPayment
{
    public void Pay() { /* logic */ }
}

public class PaymentProcessor
{
    public void ProcessPayment(IPayment payment)
    {
        payment.Pay();
    }
}
Matlab:

Naya payment method? Bas ek naye class banao, purana code nahi chhedna. ✅

🔥 3. L - Liskov Substitution Principle (LSP)
📖 Definition:
Child class ko parent class ke jaise behave karna chahiye bina kisi issue ke.

Yani: Jahan parent class ka object chale, wahan child class ka bhi chalna chahiye.
-------------------------------------------------
🎯 Real World Example:
Galat Example:

Edit
public class Bird
{
    public virtual void Fly() { }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new Exception("Ostrich can't fly!");
    }
}
Ostrich ek Bird hai, lekin fly nahi kar sakti! ❌
------------------------------------------------------
✅ Correct Example:

public abstract class Bird { }
public abstract class FlyingBird : Bird
{
    public abstract void Fly();
}

public class Sparrow : FlyingBird
{
    public override void Fly() { }
}

public class Ostrich : Bird { }
Matlab:

Jis Bird ka fly hona zaruri hai, use FlyingBird inherit karaao.

Jis Bird ka fly nahi hona, use simple Bird se inherit karaao.

🔥 4. I - Interface Segregation Principle (ISP)
📖 Definition:
Client ko wohi interface dena chahiye jo use chahiye,
na ki unnecessary functions force karne chahiye.

Yani: Interface ko chhota aur meaningful rakho.
------------------------------------------------------------
🎯 Real World Example:
Galat Approach:

public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work() { }
    public void Eat() { }  // Robots don't eat! ❌
}
-----------------------------------------------
✅ Correct Approach:

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Human : IWorkable, IEatable
{
    public void Work() { }
    public void Eat() { }
}

public class Robot : IWorkable
{
    public void Work() { }
}
Matlab:

Robots sirf kaam karein, khaana na khayen.

Insaan kaam bhi karein, khaana bhi khayein.
-------------------------------------------------------------
🔥 5. D - Dependency Inversion Principle (DIP)
📖 Definition:
High Level modules ko low-level modules pe depend nahi karna chahiye.
Dono ko abstraction pe depend karna chahiye.

Yani: Direct class pe depend nahi, interface pe depend karo.
-------------------------------------------------
🎯 Real World Example:
Galat Approach:

public class MySQLDatabase
{
    public void Save() { }
}

public class DataAccess
{
    private MySQLDatabase _db = new MySQLDatabase();

    public void SaveData()
    {
        _db.Save();
    }
}
DataAccess class direct MySQLDatabase pe depend hai. ❌
-------------------------------------------
✅ Correct Approach:

public interface IDatabase
{
    void Save();
}

public class MySQLDatabase : IDatabase
{
    public void Save() { }
}

public class DataAccess
{
    private IDatabase _db;

    public DataAccess(IDatabase db)
    {
        _db = db;
    }

    public void SaveData()
    {
        _db.Save();
    }
}
Matlab:

Chaaho toh MySQLDatabase ka object do,

Chaaho toh MongoDBDatabase ka object do — koi dikkat nahi! ✅
-------------------------------------------------------------
🔥 Ek Line Mein Each SOLID Principle:

Principle	Ek Line Mein
S - Single Responsibility	Ek class ka sirf ek kaam hona chahiye
O - Open/Closed	Naya feature add ho, bina purana tod ke
L - Liskov Substitution	Child class parent ki tarah behave kare bina dikkat ke
I - Interface Segregation	Chhote chhote interface banao, na ki bade zabardasti wale
D - Dependency Inversion	Interfaces ke through depend karo, na ki direct classes pe
--------------------------------------------------
📚 Final Real World Short Story:
Teri ek Car hai:

S: Engine ka kaam hai chalna, Brake ka kaam hai rukhna.

O: Car mein naya music system lagana hai? Naya component add karo, purana todna nahi.

L: Nayi car banayi jo chalti nahi — to LSP break hua.

I: Car ka Remote alag, Ignition alag, Music system alag — alag interfaces.

D: Car Driver remote pe depend karta hai, remote pe nahi jaanta andar kya chip lagi hai.