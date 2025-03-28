using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class 9_multi_threaded
    {
        static object fileLock = new object();
    static string filePath = "log.txt";

    static void Main()
    {
        Console.WriteLine("Starting Safe File Logging...\n");

        Task[] tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            int taskId = i + 1;
            tasks[i] = Task.Run(() => WriteLog($"Task {taskId} executed at {DateTime.Now}"));
        }

        Task.WaitAll(tasks);
        Console.WriteLine("\n✅ All logs written successfully!");
    }

    static void WriteLog(string message)
    {
        lock (fileLock) // Ensures only one thread writes at a time
        {
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
        Console.WriteLine($"Log written: {message}");
    }
    }
}