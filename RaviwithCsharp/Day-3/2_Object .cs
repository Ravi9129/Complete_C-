using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class Car 
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
}