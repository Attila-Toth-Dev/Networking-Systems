namespace MGC_Application.Tools;

public class Debug
{
    private static readonly string LogPath = $"{FileTools.LogPathFile}/Logs.txt";

    /// <summary>
    /// Logs a message into the console output.
    /// </summary>
    /// <param name="_message">The message to output on log file.</param>
    public static void Log(string _message)
    {
        using StreamWriter writer = new StreamWriter(LogPath, true);
        writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    /// <summary>
    /// Log an Exception into the console output.
    /// </summary>
    /// <param name="_exception">The exception name of which to output to console file.</param>
    public static void LogException(Exception _exception)
    {
        using StreamWriter writer = new StreamWriter(LogPath, true);
        writer.WriteLine($"{DateTime.Now} : {_exception.Message}");
    }

    /// <summary>
    /// Adds a break in the console output to break up file to be easily readable.
    /// </summary>
    public static void Break()
    {
        using StreamWriter write = new StreamWriter(LogPath, true);
        write.WriteLine("");
    }
}
