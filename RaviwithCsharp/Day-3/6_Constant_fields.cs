using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-3
{
    public class 6_Constant_fields
    {
        
    }
}
--------------------------------------------------
Constant fields (const) wo fields hoti hain jin ki value compile-time par fix hoti hai aur badal nahi sakti.

🔹 Ek baar initialize ho gayi to change nahi ho sakti.
🔹 Ye class level par hoti hain lekin static nahi hoti (directly class ke andar use hoti hain).
🔹 Memory efficient hoti hain kyunki har jagah inline replace hoti hain (runtime par nahi allocate hoti).
---------------------------------------------------------------------------
🚀 Real-World Example 1: Math Constants (PI, Gravity, Speed of Light)
✅ Scenario: Ek physics application jisme kuch fix mathematical constants hamesha use hongi.

using System;

class MathConstants  
{  
    public const double PI = 3.14159;  
    public const double Gravity = 9.81;  
    public const int SpeedOfLight = 299792458; // meters per second  

    public static void DisplayConstants()  
    {  
        Console.WriteLine($"PI: {PI}");  
        Console.WriteLine($"Gravity: {Gravity} m/s²");  
        Console.WriteLine($"Speed of Light: {SpeedOfLight} m/s");  
    }  
}

class Program  
{  
    static void Main()  
    {  
        MathConstants.DisplayConstants();  
        // MathConstants.PI = 3.14;  ❌ Error: Constant ki value change nahi ho sakti  
    }  
}
📌 Har jaga PI, Gravity, aur SpeedOfLight ka value fix rahega aur ye compile-time par replace ho jayenge.
----------------------------------------------------------------------
🚀 Real-World Example 2: API URLs (Avoid Hardcoding Everywhere)
✅ Scenario: Ek software application jisme API base URL fix hai, par baar-baar likhne ki zaroorat nahi.

class Config  
{  
    public const string API_BASE_URL = "https://api.example.com/v1/";  
}

class Program  
{  
    static void Main()  
    {  
        Console.WriteLine($"Fetching data from: {Config.API_BASE_URL}users");  
    }  
}
📌 Agar API URL ek hi jagah define kar diya const se, to change karne ki zaroorat nahi hogi har file me.
---------------------------------------------------------------------------------
🚀 Real-World Example 3: Days of the Week (Avoid Magic Numbers)
✅ Scenario: Kisi application me days ke values ko readable banane ke liye constant define karna.

class WeekDays  
{  
    public const int SUNDAY = 0;  
    public const int MONDAY = 1;  
    public const int TUESDAY = 2;  
    public const int WEDNESDAY = 3;  
}

class Program  
{  
    static void Main()  
    {  
        Console.WriteLine($"Sunday index: {WeekDays.SUNDAY}");  
        Console.WriteLine($"Monday index: {WeekDays.MONDAY}");  
    }  
}
📌 Magic numbers avoid karne ke liye const ka use kiya jata hai, taake code readable aur maintainable rahe.
-----------------------------------------------------------------------------------------------------
🚀 Real-World Example 4: Tax Rates (Fix Value for Calculations)
✅ Scenario: Ek billing system jisme tax rate fix hai aur har transaction me use ho raha hai.

class Billing  
{  
    public const double GST_RATE = 0.18;  

    public static double CalculateGST(double amount)  
    {  
        return amount * GST_RATE;  
    }  
}

class Program  
{  
    static void Main()  
    {  
        double billAmount = 1000;  
        double gst = Billing.CalculateGST(billAmount);  
        Console.WriteLine($"Bill Amount: {billAmount}, GST: {gst}, Total: {billAmount + gst}");  
    }  
}
📌 Har billing transaction ke liye GST_RATE fix rahega aur code clean aur maintainable rahega.


🚀 Conclusion
🔹 Constant fields (const) compile-time par fix hoti hain, aur change nahi ho sakti.
🔹 Ye har jaga inline replace ho jati hain, isliye ye fastest aur memory efficient hoti hain.
🔹 Agar kisi value ko kabhi change nahi karna, jaise PI, GST_RATE, API_URL, to const use karo.
🔹 Agar kisi value ko runtime par modify karna hai, jaise TotalEmployees, ActiveUser, to static use karo.