using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-4
{
    public class 7_Local_function
    {
        
    }
}
-----------------------------------
Local functions C# 7.0 me introduce ki gayi ek feature hai jo methods ke andar methods define karne ki suvidha deti hai. Yeh private helper methods ki tarah kaam karti hain jo sirf us function ke andar accessible hoti hain jisme define ki gayi hain.

📌 Kab Use Karein?
✅ Jab ek method ke andar hi koi chhoti helper function chahiye ho jo sirf usi function me kaam kare.
✅ Jab code readability badhane ke liye complex logic ko chhoti-chhoti functions me todna ho.
✅ Jab unnecessary global/private methods na likhne ho jo kahin aur use nahi hote.
------------------------------------------------------
🎯 Real-World Example: E-Commerce Order Calculation
Maan lo ek E-Commerce Website hai jisme total order amount calculate karna hai.
Lekin discount aur tax alag se calculate karna pad raha hai, to hum local function ka use kar sakte hain.

using System;

class Program
{
    static void Main()
    {
        // Order details
        double itemPrice = 500;
        int quantity = 3;
        double discountRate = 10; // 10% discount
        double taxRate = 5; // 5% tax

        // Calculate final price
        double finalPrice = CalculateTotalPrice(itemPrice, quantity, discountRate, taxRate);
        Console.WriteLine($"Final Order Amount: {finalPrice}");
    }

    static double CalculateTotalPrice(double price, int qty, double discountPercent, double taxPercent)
    {
        // Local function to calculate discount
        double ApplyDiscount(double amount, double discount)
        {
            return amount - (amount * (discount / 100));
        }

        // Local function to calculate tax
        double ApplyTax(double amount, double tax)
        {
            return amount + (amount * (tax / 100));
        }

        // Step 1: Calculate subtotal
        double subtotal = price * qty;

        // Step 2: Apply discount
        double discountedPrice = ApplyDiscount(subtotal, discountPercent);

        // Step 3: Apply tax
        double finalAmount = ApplyTax(discountedPrice, taxPercent);

        return finalAmount;
    }
}
🛠️ Output:
Final Order Amount: 1417.5


----------------------------------------------------
📌 Important Points
✅ Local Function sirf usi method ke andar accessible hoti hai jisme define hoti hai.
✅ Local Function static bhi ho sakti hai agar usko outer function ke instance variables ki zaroorat na ho.
✅ Lambda expressions ke alternative ke taur par bhi use ho sakti hai (Func<>, Action<>).
✅ Local Function recursion support karti hai (khud ko call kar sakti hai).

