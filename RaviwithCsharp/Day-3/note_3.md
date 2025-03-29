Class C# ka ek basic aur sabse important concept hai. Ye ek blueprint (template) hoti hai jo objects banane ke liye use hoti hai. Isme properties (data) aur methods (functions) hote hain jo kisi ek entity ka structure define karte hain.

Kab use hoti hai?
Jab real-world entities ko represent karna ho. (Jaise: Car, Employee, Product)

Code ko organized aur reusable banane ke liye.

Object-Oriented Programming (OOP) follow karne ke liye.

Kaha use hoti hai?
Enterprise Applications: (Banking System, HR Management, Inventory System)

Game Development: (Character Class, Enemy Class)

Web Applications: (Model Classes in ASP.NET)

API Development: (DTOs and Business Logic Classes)
-------------------------------------------------------------------------
Object class ka real instance hota hai. Matlab jo bhi class hum banate hain, uska actual use tabhi hota hai jab hum uska object (instance) create karte hain.

Kab Use Hota Hai?
Jab class ke andar defined properties aur methods ko access karna ho.

Jab real-world entities ko represent karna ho. (Jaise ek employee, ek car, ek product)

Jab memory me ek specific entity store karni ho.

Kaha Use Hota Hai?
Database Records Represent Karne Ke Liye (Jaise: Employee emp1 = new Employee();)

Web Applications Me Models Ke Liye (Jaise: ASP.NET MVC me User user = new User();)

Game Development Me Characters, Weapons, Vehicles Banane Ke Liye

E-Commerce Websites Me Products Ko Store Karne Ke Liye


Ku Use Karein?
Real-world entities ko represent karne ke liye.

Memory me different instances store karne ke liye.

Multiple objects bana ke ek hi class ka reuse karne ke liye.

Class ke andar ke properties aur methods access karne ke liye.

Agar showroom me ek aur car add karni ho toh ek aur object create kar sakte hain:

Car car3 = new Car("BMW", "X5", 60000);
car3.DisplayCarInfo();
Matlab ek blueprint (class) se kitne bhi objects (instances) bana sakte ho.
----------------------------------------------------------------------------------------
Access Modifiers C# me data aur methods ki visibility control karne ke liye use hote hain. Ye define karte hain ki ek class, property ya method kaha aur kaun access kar sakta hai.