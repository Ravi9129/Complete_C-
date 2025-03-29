Scenario 1: User Authentication System (Read & Write Operations)
💡 Scenario: A simple console-based login system where the user must enter a username and password.

Explanation:

Console.ReadLine() is used to take user input.

Console.ReadKey(true) reads a key without displaying it (for password masking).

Console.Write("*") replaces typed characters with * for security.

Console.ForegroundColor is used to change text color.

Console.ResetColor() resets the console color to default.
-----------------------------------------------------------------
Scenario 2: Progress Bar Simulation (Console Write with Animation)
💡 Scenario: Simulating a progress bar while performing a time-consuming operation (e.g., file download).

Explanation:

Console.Write("\r") overwrites the same line in the console.

Thread.Sleep(200) simulates a time-consuming process.

The loop increments by 5% to create a progress bar effect.
------------------------------------
Scenario 3: Menu-Based Console Application
💡 Scenario: A menu-driven console application to perform basic operations.
 Explanation:

Console.Clear() is used to clear the console before showing the menu again.

Console.ReadLine() reads user input for menu selection.

switch-case handles different options.

Console.ReadKey() pauses the execution until the user presses a key.
------------------------------------
Scenario 4: Exception Handling in Console Application
💡 Scenario: A robust calculator that handles user input errors using exception handling.
Explanation:

Convert.ToDouble(Console.ReadLine()) converts input into a number.

Exception handling (try-catch) prevents crashes due to invalid input.

DivideByZeroException is thrown if the user tries to divide by zero.

InvalidOperationException is thrown for invalid operators.
------------------------------------------------------
Key Takeaways
✅ Console.ReadLine() for input, Console.WriteLine() for output.
✅ Console.Clear() for clearing the console screen.
✅ Console.ForegroundColor to change text colors dynamically.
✅ Console.ReadKey(true) for secure input handling (e.g., password masking).
✅ Console.Write("\r") for progress bars or real-time updates.
✅ Exception handling (try-catch) ensures robust input validation.
----------------------
Scenario 5 : Multi-Threaded Task Progress with Logging (File Handling + Progress Bar)
💡 Scenario:
Imagine you are developing a file processing system where multiple files need to be processed concurrently. The console should display a real-time progress bar, and all logs should be saved in a file.

Explanation:
Multi-threading with Task.Run() → Each file is processed in parallel.

Real-time Progress Bar using \r → Overwrites the same console line.

Thread-Safe File Writing → Uses lock to avoid multiple threads writing at the same time.

Logging to File (File.AppendAllText) → Saves progress logs to log.txt.
-------------------------------------------------------------
Scenario 6: Interactive Stock Price Monitor (Live Data Update + Color Highlighting)
💡 Scenario:
Imagine building a live stock market console application where stock prices update every second.

If the price increases, the console text turns green.

If the price decreases, it turns red.

If the price remains the same, it turns yellow.

Explanation:
Real-time stock price updates using Thread.Sleep(1000) → Refreshes every second.

Random price fluctuation (random.NextDouble() * 2 - 1) → Simulates real-world stock movement.

Color Coding (Console.ForegroundColor) →

Green for price increase

Red for price decrease

Yellow for no change

Non-blocking user exit with Console.KeyAvailable → Allows pressing ESC to exit without pausing the program.

 Key Learnings
✅ Multi-threading (Task.Run()) → Efficient parallel processing.

✅ File Handling (File.AppendAllText()) → Storing logs securely.

✅ Console Manipulation (\r, Console.ForegroundColor) → Live UI updates.
✅ Non-blocking user input (Console.KeyAvailable) → Interactive experience.
✅ Real-time simulations (Thread.Sleep()) → Stock price monitoring.
---------------------------------------------------------------
Q7: How can you display real-time updates in a console application?
✅ Answer:
To display real-time updates in a console application, we use:

\r (Carriage Return) → Updates the same line in the console without adding a new line.

Thread.Sleep(milliseconds) → Simulates real-time updates.

Console.Clear() → Clears the screen for a fresh update.

Console.CursorTop & Console.CursorLeft → Moves the cursor to a specific position.

Explanation:
\r → Overwrites the same line for a smooth update.

Thread.Sleep(1000) → Refreshes every second.

Console.KeyAvailable → Allows smooth exit by pressing ESC.
--------------------------------------
Q8: How do you handle multi-threading in console applications?
✅ Answer:
Multi-threading in a console application is done using:

Task.Run(() => method()) → Runs a method asynchronously.

Thread class → Runs parallel processes.

Task.WaitAll() → Ensures all threads complete before moving forward.

Explanation:
Task.Run() → Runs multiple tasks asynchronously.

Thread.Sleep(3000) → Simulates workload.

Task.WaitAll() → Ensures all tasks finish before program exits.
-----------------------------------------------------------------
Q9: How do you manage file writing safely in a multi-threaded environment?
✅ Answer:
In a multi-threaded environment, race conditions can occur when multiple threads try to write to the same file at the same time. To prevent this:

Use lock → Ensures only one thread writes at a time.

Use Mutex → Ensures thread safety across multiple processes.

Use StreamWriter with lock → Prevents conflicts.
Explanation:
lock (fileLock) → Prevents multiple threads from writing simultaneously.

File.AppendAllText() → Appends log safely to the file.

Task.Run() → Runs logging in parallel.
----------------------------------------------------

Q10: How do you dynamically change text color based on real-time data?
Answer:
We use Console.ForegroundColor to change the text color dynamically.
 Explanation:
Console.ForegroundColor = ConsoleColor.Green; → Changes text color based on conditions.

Thread.Sleep(1000) → Refreshes stock prices every second.

Console.ResetColor() → Resets to default after printing.
