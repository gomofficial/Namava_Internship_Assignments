
using Assignment_3.Interfaces;

namespace Assignment_3;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}