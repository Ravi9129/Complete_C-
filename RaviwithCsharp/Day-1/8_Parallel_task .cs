using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class 8_Parallel_task 
    {
        static void Main()
    {
        Console.WriteLine("Starting Multi-threaded Task Execution...\n");

        Task[] tasks = new Task[3];

        for (int i = 0; i < 3; i++)
        {
            int taskNumber = i + 1;
            tasks[i] = Task.Run(() => PerformTask(taskNumber));
        }

        Task.WaitAll(tasks); // Wait for all tasks to complete
        Console.WriteLine("\n✅ All tasks completed!");
    }

    static void PerformTask(int taskNumber)
    {
        Console.WriteLine($"Task {taskNumber} started...");
        Thread.Sleep(3000); // Simulate work
        Console.WriteLine($"Task {taskNumber} finished!");
    }
    }
}