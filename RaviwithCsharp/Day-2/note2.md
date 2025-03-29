1. Variables in C#
Variables data ko store karne ke liye use hoti hain. Har variable ka ek data type hota hai.

Real-World Scenario: E-commerce Order System
Maan lo tum ek e-commerce website bana rahe ho, jisme ek order system hai. Har order ka ek ID, customer name, aur total amount hota hai.

Explanation
orderId integer hai, jo order ka unique ID store karta hai.

customerName string hai, jo customer ka naam store karta hai.

totalAmount double hai, jo order ka total price store karta hai.
------------------------------------------------------------
2. Primitive Data Types in C#
Primitive types wo hote hain jo basic values store karte hain.

Data Type      	Size	Example
int	4 byte	 101
double  	 8 byte	    25.99
char    	 2 byte	    'A'
bool	    1 byte	    true / false
string  	Varies	    "Hello"
Scenario: Bank Account System
Ek bank account system jisme customer ka balance, account type, aur status store ho.
Explanation:

accountNumber stores customer ka unique account number

balance stores customer ka paisa

accountType stores account ka type ('S' - Savings, 'C' - Current)

isActive stores account active hai ya nahi
--------------------------------------------
Operators wo symbols hote hain jo values pe operations perform karte hain.

Operator Type	Example
Arithmetic   	+ - * / %
Comparison   	== != > < >= <=
Logical	`         &&   
Assignment     	= += -= *= /=
Bitwise	`      &

Explanation:

Employee ka baseSalary ₹50,000 hai

10% tax (taxRate = 0.1) deduct hoke netSalary nikala
-------------------------------
4. Switch Case in C#
switch ka use multiple conditions check karne ke liye hota hai.

Scenario: Online Food Ordering System
User alag-alag food items choose karega aur price calculate hoga.