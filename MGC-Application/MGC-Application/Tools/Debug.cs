namespace MGC_Application;

public class Debug
{
    /// <summary>Log allows for application to log special changes or errors within application.</summary>
    /// <param name="_message">The message of which to log.</param>
    public static void Log(string _message)
    {
        string logFileName = $"Console Log.txt";
        string logPath = $"{WelcomeForm.logPathFile}/{logFileName}";

        // append the string message with time and date, alongside message
        // as a new ling in the logs file.
        using (StreamWriter writer = new StreamWriter(logPath, true))
            writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    /// <summary>Break makes a empty line of space in log files for ease of reading.</summary>
    public static void Break()
    {
        string logFileName = $"Console Log.txt";
        string logPath = $"{WelcomeForm.logPathFile}/{logFileName}";

        // create a new empty line in logs file.
        using (StreamWriter write = new StreamWriter(logPath, true))
            write.WriteLine("");
    }
}
