namespace MGC_Application.Tools;

public class Debug
{
    private static readonly string LogPath = $"{FileTools.LogPathFile}/Logs.txt";

    /// <summary>Log allows for application to log special changes or errors within application.</summary>
    /// <param name="_message">The message of which to log.</param>
    public static void Log(string _message)
    {
        // log an error message and append to file.
        using (StreamWriter writer = new StreamWriter(LogPath, true))
            writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    /// <summary>LogException, while similar to log, logs exception errors to log file.</summary>
    /// <param name="_ex">The exception error to log.</param>
    public static void LogException(Exception _ex)
    {
        // log an exception error and append to file.
        using (StreamWriter writer = new StreamWriter(LogPath, true))
            writer.WriteLine($"{DateTime.Now} : {_ex.Message}");
    }

    /// <summary>Break makes a empty line of space in log files for ease of reading.</summary>
    public static void Break()
    {
        // append a new line in log output.
        using (StreamWriter write = new StreamWriter(LogPath, true))
            write.WriteLine("");
    }
}
