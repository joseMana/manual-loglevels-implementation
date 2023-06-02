public class Program
{
    static void Main()
    {
        Logger w = new Logger(LogLevel.Critical);

        w.Log(LogLevel.Debug, "Debug");
        w.Log(LogLevel.Info, "Info");
        w.Log(LogLevel.Warning, "Warning");
        w.Log(LogLevel.Exception, "Error");
        w.Log(LogLevel.Critical, "Critical");

        Console.ReadLine();
    }
}

public enum LogLevel
{
    Debug,
    Info,
    Warning,
    Exception,
    Critical
}

public class Logger
{
    private LogLevel logLevel;

    public Logger(LogLevel logLevel)
    {
        this.logLevel = logLevel;
    }

    public void Log(LogLevel level, string message)
    {
        if (level >= logLevel)
            Console.WriteLine($"[{level}] {message}");
    }
}