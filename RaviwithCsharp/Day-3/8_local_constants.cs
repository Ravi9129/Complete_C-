using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 7_local_constants
    {
        
    }
}
---------------------------------------------------------------------------------------
local constants wahi const fields hoti hain, lekin ye kisi class ke andar nahi, balki kisi method ke andar define hoti hain.

🔹 Ye sirf usi method ke andar accessible hoti hain jisme ye define hoti hain.
🔹 Inka scope method ke andar limited hota hai, yani method ke bahar inhe access nahi kiya ja sakta.
🔹 Ye bhi compile-time constants hote hain, yani inki value execution ke time par change nahi ki ja sakti.
------------------------------------------------------------------------------------------------
🚀 Real-World Example 1: Sales Tax Calculation
✅ Scenario: Ek e-commerce application jisme tax rate fix hai aur kisi bhi purchase par use hoti hai.

using System;

class ShoppingCart
{
    public void CalculateTotal(double price)
    {
        const double TAX_RATE = 0.18; // 18% tax fix hai

        double taxAmount = price * TAX_RATE;
        double totalPrice = price + taxAmount;

        Console.WriteLine($"Product Price: {price}, Tax: {taxAmount}, Total Price: {totalPrice}");
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.CalculateTotal(1000); // 1000 ka product, 18% tax lagayega
    }
}
📌 Yahan TAX_RATE ek local constant hai jo sirf CalculateTotal method ke andar accessible hai.
📌 Iska fayda ye hai ki accidental modification se bacha sakte hain.

🚀 Real-World Example 2: Converting Kilometers to Miles
✅ Scenario: Ek travel application jisme kilometers ko miles me convert karna hai, aur conversion factor fix hai.
----------------------------------------------------------------
using System;

class Travel
{
    public void ConvertToMiles(double kilometers)
    {
        const double KM_TO_MILES = 0.621371; // Fixed conversion factor

        double miles = kilometers * KM_TO_MILES;
        Console.WriteLine($"{kilometers} km = {miles} miles");
    }
}

class Program
{
    static void Main()
    {
        Travel travel = new Travel();
        travel.ConvertToMiles(10); // 10 km ko miles me convert karega
    }
}
📌 Yahan KM_TO_MILES ek local constant hai jo sirf ConvertToMiles method ke andar hi kaam karega.
📌 Agar hume ye value change karni ho to bas method ke andar change karni hogi, baki code ko touch nahi karna padega.
--------------------------------------------------------------
🚀 Real-World Example 3: Checking Leap Year
✅ Scenario: Ek calendar application jisme leap year check karna hai, aur leap year ke rules fix hain.

using System;

class Calendar
{
    public void CheckLeapYear(int year)
    {
        const int LEAP_DIVISIBLE_BY_4 = 4;
        const int LEAP_DIVISIBLE_BY_100 = 100;
        const int LEAP_DIVISIBLE_BY_400 = 400;

        bool isLeapYear = (year % LEAP_DIVISIBLE_BY_4 == 0 && year % LEAP_DIVISIBLE_BY_100 != 0) ||
                          (year % LEAP_DIVISIBLE_BY_400 == 0);

        Console.WriteLine($"{year} is {(isLeapYear ? "a Leap Year" : "not a Leap Year")}");
    }
}

class Program
{
    static void Main()
    {
        Calendar calendar = new Calendar();
        calendar.CheckLeapYear(2024); // Leap year check karega
    }
}
📌 Yahan LEAP_DIVISIBLE_BY_4, LEAP_DIVISIBLE_BY_100, aur LEAP_DIVISIBLE_BY_400 local constants hain jo sirf CheckLeapYear method me use ho sakti hain.
📌 Iska fayda ye hai ki magic numbers avoid ho jati hain, aur code readable ban jata hai.

----------------------------------------------------------------
🚀 Conclusion
🔹 Local constants (const) kisi bhi method ke andar define hoti hain aur sirf usi method ke andar use ho sakti hain.
🔹 Ye compile-time par replace ho jati hain, yani runtime par koi memory allocate nahi hoti.
🔹 Agar ek method ke andar koi fix value chahiye jo kabhi change nahi hogi (jaise Tax Rate, Currency Conversion), to local constant use karo.
🔹 Agar kisi value ko class level par fix rakhna hai, to class constant (const) ya readonly field (readonly) use karo.