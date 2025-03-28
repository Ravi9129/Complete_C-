using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaviwithCsharp.Day-1
{
    public class fileProcessing
    {
        static void Main()
    {
        Console.WriteLine("Starting File Processing System...\n");

        int totalFiles = 10;
        Task[] tasks = new Task[totalFiles];

        for (int i = 0; i < totalFiles; i++)
        {
            int fileNumber = i + 1;
            tasks[i] = Task.Run(() => ProcessFile(fileNumber, totalFiles));
        }

        Task.WaitAll(tasks); // Wait for all tasks to complete
        Console.WriteLine("\nAll files processed successfully!");
    }

    static void ProcessFile(int fileNumber, int totalFiles)
    {
        string logFilePath = "log.txt";
        int progress = 0;

        for (int i = 0; i <= 100; i += 10)
        {
            Console.Write($"\rProcessing File {fileNumber}/{totalFiles}: {i}% ");
            Thread.Sleep(200); // Simulate processing time

            progress = i;
        }

        string logMessage = $"File {fileNumber} processed successfully at {DateTime.Now}";

        lock (typeof(Program)) // Prevent race conditions in file writing
        {
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }

        Console.WriteLine($"\n✅ File {fileNumber} Processing Complete!");
    }
    }
}