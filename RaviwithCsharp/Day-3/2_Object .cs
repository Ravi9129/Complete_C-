using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 2_Object 
    {
        
    }
}
-------------------------------------------------------------------------
Object class ka real instance hota hai. Matlab jo bhi class hum banate hain, 
uska actual use tabhi hota hai jab hum uska object (instance) create karte hain.

Kab Use Hota Hai?
Jab class ke andar defined properties aur methods ko access karna ho.

Jab real-world entities ko represent karna ho. (Jaise ek employee, ek car, ek product)

Jab memory me ek specific entity store karni ho.
----------------------------------------------

Kaha Use Hota Hai?
Database Records Represent Karne Ke Liye (Jaise: Employee emp1 = new Employee();)

Web Applications Me Models Ke Liye (Jaise: ASP.NET MVC me User user = new User();)

Game Development Me Characters, Weapons, Vehicles Banane Ke Liye

E-Commerce Websites Me Products Ko Store Karne Ke Liye
----------------------------------------------
Real-World Example
Maan lo, ek Car Showroom hai jisme different-different cars hain. Har car ka brand, model aur price hota hai.


using System;

class Car  
{  
    // Properties  
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }

    // Constructor  
    public Car(string brand, string model, double price)  
    {  
        Brand = brand;
        Model = model;
        Price = price;
    }  

    // Method  
    public void DisplayCarInfo()  
    {  
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Price: {Price}");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        // Object Creation (Car Class Ka Instance)
        Car car1 = new Car("Toyota", "Corolla", 20000);
        Car car2 = new Car("Honda", "Civic", 25000);

        // Objects Ke Methods Call Karna
        car1.DisplayCarInfo();
        car2.DisplayCarInfo();
    }  
}
Ku Use Karein?
Real-world entities ko represent karne ke liye.

Memory me different instances store karne ke liye.

Multiple objects bana ke ek hi class ka reuse karne ke liye.

Class ke andar ke properties aur methods access karne ke liye.

Agar showroom me ek aur car add karni ho toh ek aur object create kar sakte hain:

Car car3 = new Car("BMW", "X5", 60000);
car3.DisplayCarInfo();
Matlab ek blueprint (class) se kitne bhi objects (instances) bana sakte ho.
