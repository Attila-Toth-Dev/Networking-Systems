namespace MGC_Application;

public static class DebugLogger
{
    public static void WriteLog(string _message)
    {
        string logFileName = $"logs.txt";
        string logPath = $"Logs/{logFileName}";

        using (StreamWriter writer = new StreamWriter(logPath, true))
            writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    public static void WriteClosingLog()
    {
        string logFileName = $"logs.txt";
        string logPath = $"Logs/{logFileName}";

        using (StreamWriter write = new StreamWriter(logPath, true))
        {
            write.WriteLine($"{DateTime.Now} : Closed down application.");
            write.WriteLine($"---------------------------------------------------------");
        }
    }

    public static void WriteStartupLog()
    {
        string logFileName = $"logs.txt";
        string logPath = $"Logs/{logFileName}";

        using (StreamWriter write = new StreamWriter(logPath, true))
        {
            write.WriteLine($"---------------------------------------------------------");
            write.WriteLine($"{DateTime.Now} : Starting application up.\n");
        }
    }
}
