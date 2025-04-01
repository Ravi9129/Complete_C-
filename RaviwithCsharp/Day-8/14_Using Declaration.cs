using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 14_Using Declaration
    {
        
    }
}
------------------------------------
Destructors kya hote hain?
Destructor ek special method hota hai jo object ke memory ko release karne ke liye automatically call hota hai jab wo object garbage collector (GC) ke dwara destroy kiya jata hai.
---------------------------------------------
Real World Scenario:
Imagine kar, ek DatabaseConnection class hai. Tumhara program database se connect ho raha hai, aur jab kaam ho jaye toh tumhe connection close karna padta hai taaki resources waste na ho. Agar tum bhool jao connection close karna, toh wo connection open rahega aur system ki performance pe impact ho sakta hai.

Ab yahan Destructor ka kaam aata hai. Jab bhi object ka kaam ho jaye, GC automatically destructor ko call karega, aur wo object ka memory aur resources ko free kar dega.

Syntax:
Destructor ka naam class ke naam ke barabar hota hai, lekin usme tilde (~) laga hota hai.

class MyClass
{
    public MyClass()
    {
        // Constructor code
        Console.WriteLine("Object created");
    }

    ~MyClass()
    {
        // Destructor code
        Console.WriteLine("Object destroyed");
    }
}
Example:
-----------------------------------
Scenario: Database Connection
Maan lo tumhare paas ek DatabaseConnection class hai jisme connection open karne aur close karne ka kaam hota hai. Agar tum Dispose method ko manually call na kar pao, toh Destructor automatically kaam karega aur connection ko close kar dega jab object destroy ho.

using System;

class DatabaseConnection
{
    private string connectionString;
    
    public DatabaseConnection(string connection)
    {
        connectionString = connection;
        Console.WriteLine("Connecting to database...");
        // Simulate database connection opening
    }
    
    ~DatabaseConnection()  // Destructor
    {
        // Cleanup resources like closing the database connection
        Console.WriteLine("Closing database connection...");
    }
}

class Program
{
    static void Main()
    {
        // Creating object, this will simulate a database connection
        DatabaseConnection dbConnection = new DatabaseConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        
        // No need to explicitly close the connection, Destructor will handle it when the object is destroyed
        Console.WriteLine("Performing database operations...");
        
        // Force garbage collection for demonstration purposes
        dbConnection = null;   // Dereference the object
        GC.Collect();  // Manually trigger garbage collection
        
        Console.ReadLine();
    }
}
Explanation:
Constructor (DatabaseConnection) — Jab object banega, connection open hoga.

"Connecting to database..." message print hoga.

Destructor (~DatabaseConnection) — Jab object garbage collector ke through destroy hoga, destructor automatically call hoga aur connection close hoga.

"Closing database connection..." message print hoga.

GC.Collect() — Garbage collection ko forcefully call kar rahe hain, jo object ko destroy karega aur destructor ko trigger karega.

Output (Sample):
Connecting to database...
Performing database operations...
Closing database connection...
Real-World Use Case:
File Handling: Jab tum kisi file ko open karte ho, toh file ko close karna zaroori hota hai, warna system resources waste honge. Destructor use karke, tum automatically file ko close kar sakte ho jab object destroy ho.

Network Connections: Agar tumhare paas koi network socket connection hai, aur tumhe manually usse close karna padta hai, toh destructor use kar ke tum ensure kar sakte ho ki jab object destroy ho, connection close ho jaye.

Important Points about Destructors:
Automatic Call: Destructor ko manual call nahi kar sakte. Ye garbage collector ke through automatically call hota hai.

No Arguments or Return Types: Destructor na arguments le sakta hai, na return type ho sakta hai.

Performance Consideration: Destructor ko explicitly trigger karne ka koi fayda nahi hota, yeh garbage collector automatically manage karta hai.

Finalizer: Destructor ko finalizer bhi kaha jata hai, jo ek tarah se object ke memory cleanup ka final stage hota hai.

Final Thought:
Destructor ka kaam garbage collector ke saath milke memory ko clean-up karna hota hai jab objects ki zaroorat nahi rehti. Jab tak tumhara object memory mein hai, usse linked resources (like files, database connections) ka dhyan rakhna padta hai. Agar tum manually cleanup bhool jaoge, toh Destructor automatically help karega aur resources release karega.

Bas bhai, ye tha Destructor ka use, real-world scenario ke saath! Agar koi aur topic ho, bata de!