using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 5_ref return
    {
        
    }
}
-------------------------------------------------------------
ref return Kya Hota Hai?
✅ ref return ek special feature hai jo method se kisi variable ka reference return karne ke liye use hota hai, instead of returning a copy.
✅ Iska fayda yeh hai ki hum directly kisi memory location ka reference return kar sakte hain, aur usi variable par changes kar sakte hain.
✅ Yeh performance optimization ke liye useful hota hai, specially jab large objects ya arrays ke saath kaam ho.
----------------------------------------------------------------
🚀 1. Simple Example of ref return
✅ Scenario: Ek array hai jisme kisi specific index ka reference return karna hai, taaki usi memory location par changes ho.

using System;

class Program
{
    static ref int GetElement(ref int[] numbers, int index)
    {
        return ref numbers[index]; // ✅ Returning reference to array element
    }

    static void Main()
    {
        int[] myArray = { 10, 20, 30, 40, 50 };

        // Get reference to 2nd index element
        ref int element = ref GetElement(ref myArray, 2);

        Console.WriteLine($"Before Modification: {myArray[2]}"); // Output: 30

        // Modify the actual array element via reference
        element = 100;

        Console.WriteLine($"After Modification: {myArray[2]}"); // Output: 100
    }
}
📌 Output:
Before Modification: 30
After Modification: 100
📌 Yahan GetElement method ek specific index ka reference return karta hai, taaki usi memory location par changes ho sakein.
----------------------------------------------------------------
🚀 2. ref return with Fields (Updating an Object's Property)
✅ Scenario: Ek Car class hai jisme Speed field ka reference return karna hai, taaki directly speed modify ho sake.

using System;

class Car
{
    private int speed = 60;

    public ref int GetSpeed() // ✅ Returning reference
    {
        return ref speed;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        ref int carSpeed = ref myCar.GetSpeed(); // ✅ Get reference of speed

        Console.WriteLine($"Before Modification: {carSpeed}"); // Output: 60

        carSpeed = 100; // ✅ Directly modifying the field

        Console.WriteLine($"After Modification: {carSpeed}"); // Output: 100
    }
}
📌 Output:
Before Modification: 60
After Modification: 100
📌 Yahan GetSpeed() method speed ka reference return karta hai, jo directly modify ho sakta hai.
---------------------------------------------------------------------------------
🚀 3. ref return with Structs (Memory Optimization)
✅ Scenario: Ek struct hai jo kisi employee ka salary hold karta hai, hum reference return kar rahe hain taki copy create na ho.
using System;

struct Employee
{
    public int Salary;
}

class Program
{
    static ref int GetSalary(ref Employee emp)
    {
        return ref emp.Salary;
    }

    static void Main()
    {
        Employee emp1 = new Employee { Salary = 5000 };

        ref int salaryRef = ref GetSalary(ref emp1); // ✅ Getting reference

        Console.WriteLine($"Before: {emp1.Salary}"); // Output: 5000

        salaryRef += 2000; // ✅ Directly modifying salary

        Console.WriteLine($"After: {emp1.Salary}"); // Output: 7000
    }
}
📌 Output:
Before: 5000
After: 7000
📌 Yahan GetSalary() function Employee ka Salary field ka reference return karta hai, jo direct modify ho sakta hai.
---------------------------------------------------------
🚀 4. ref return vs Normal Return

📌 Example of Normal Return:


static int GetValue(int number)
{
    return number * 2; // ❌ Returns copy
}
--------------------------------------------------
📌 Example of ref return:

static ref int GetRef(int[] arr, int index)
{
    return ref arr[index]; // ✅ Returns reference
}
----------------------------------------------------------
🚀 5. Real-World Scenario: Game Development
✅ Scenario: Game ke andar ek player ka health variable dynamically modify karna hai, bina extra copy banaye.
using System;

class Player
{
    private int health = 100;

    public ref int GetHealth() // ✅ Returning reference
    {
        return ref health;
    }
}

class Program
{
    static void Main()
    {
        Player hero = new Player();

        ref int playerHealth = ref hero.GetHealth();

        Console.WriteLine($"Player Health Before: {playerHealth}"); // Output: 100

        playerHealth -= 20; // ✅ Directly modifying health

        Console.WriteLine($"Player Health After: {playerHealth}"); // Output: 80
    }
}
📌 Yahan health ka reference return kiya jata hai, taaki bina copy banaye directly modify ho sake.
----------------------------------------------------------------------
🚀 Conclusion
✅ ref return ka use tab hota hai jab hume kisi variable ka reference return karna ho, instead of making a copy.
✅ Yeh performance optimization aur memory efficiency ke liye useful hai, specially large objects ke saath kaam karte waqt.
✅ Iska use arrays, structs, object fields, aur game development scenarios me hota hai.