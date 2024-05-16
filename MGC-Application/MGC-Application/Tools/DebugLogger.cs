namespace MGC_Application;

public static class DebugLogger
{
    /// <summary>Log allows for application to log special changes or errors within application.</summary>
    /// <param name="_message">The message of which to log.</param>
    public static void Log(string _message)
    {
        string logFileName = $"logs.txt";
        string logPath = $"../Logs/{logFileName}";

        using (StreamWriter writer = new StreamWriter(logPath, true))
            writer.WriteLine($"{DateTime.Now} : {_message}");
    }
}
