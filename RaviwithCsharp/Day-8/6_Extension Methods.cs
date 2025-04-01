using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-8
{
    public class 6_Extension Methods
    {
        
    }
}
------------------------------------------------
What are Extension Methods?
✅ Extension methods allow us to add new methods to existing classes without modifying their original code.
✅ Works on: Any existing class, including built-in .NET classes (string, int, List<T>, etc.).
✅ Declared as: A static method inside a static class.
✅ First parameter: Uses this keyword (this Type parameterName).

📌 Why Use Extension Methods?
🔥 Add functionality to existing classes without inheritance or modifying source code.
🔥 Improve code readability and reusability.
🔥 Use it on built-in .NET types (string, DateTime, List<T>, etc.).

📌 How to Create an Extension Method?
🚀 Syntax:


public static class MyExtensions
{
    public static returnType MethodName(this Type parameterName)
    {
        // Code here
    }
}
✔ The first parameter must start with this keyword.
✔ The method must be static and inside a static class.
------------------------------------------------------------------------------
📌 Example 1: String Extension Method
🚀 Custom method to check if a string contains only digits

using System;

public static class StringExtensions
{
    public static bool IsNumeric(this string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c)) 
                return false;
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        string value = "12345";
        Console.WriteLine(value.IsNumeric());  // ✅ Output: True

        string invalidValue = "123ABC";
        Console.WriteLine(invalidValue.IsNumeric());  // ✅ Output: False
    }
}
✔ Now, we can use .IsNumeric() on any string!
-------------------------------------------------------------
📌 Example 2: List Extension Method
🚀 Finds the maximum value in a list

using System;
using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{
    public static int MaxValue(this List<int> numbers)
    {
        return numbers.Count == 0 ? 0 : numbers.Max();
    }
}

class Program
{
    static void Main()
    {
        List<int> nums = new List<int> { 3, 7, 1, 9 };
        Console.WriteLine(nums.MaxValue()); // ✅ Output: 9
    }
}
✔ Works just like a built-in .Max() method!
--------------------------------------------------------------------------
📌 Example 3: DateTime Extension Method
🚀 Check if a date is a weekend

using System;

public static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}

class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine(today.IsWeekend() ? "It's a weekend!" : "It's a weekday.");
    }
}
✔ Now, .IsWeekend() can be called on any DateTime object!
--------------------------------------------------------------------------
📌 Example 4: Generic Extension Method
🚀 Swaps two elements in an array

using System;

public static class ArrayExtensions
{
    public static void Swap<T>(this T[] array, int index1, int index2)
    {
        if (index1 >= 0 && index2 >= 0 && index1 < array.Length && index2 < array.Length)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };
        arr.Swap(0, 2);
        Console.WriteLine(string.Join(", ", arr));  // ✅ Output: 3, 2, 1, 4
    }
}
✔ Works for any data type (int, string, double, etc.)!
-------------------------------------------------------------------------
📌 Example 5: Extension Method for IEnumerable<T>
🚀 Counts words in a sentence

using System;
using System.Linq;

public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        return input.Split(' ').Count(w => !string.IsNullOrWhiteSpace(w));
    }
}

class Program
{
    static void Main()
    {
        string sentence = "C# is awesome!";
        Console.WriteLine(sentence.WordCount());  // ✅ Output: 3
    }
}
✔ Now, we can call .WordCount() on any string!
----------------------------------------------------------
📌 Real-World Use Cases
✔ Extending Built-in .NET Classes (string, List<T>, DateTime, etc.)
✔ Reusing Code (Instead of writing utility methods in every project)
✔ Adding Extra Functionality to Third-Party Libraries