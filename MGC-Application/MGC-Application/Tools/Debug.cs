using MGC_Application.Forms;

namespace MGC_Application.Tools;

public class Debug
{
    private static readonly string LogPath = $"{WelcomeForm.LogPathFile}/Logs.txt";

    /// <summary>Log allows for application to log special changes or errors within application.</summary>
    /// <param name="_message">The message of which to log.</param>
    public static void Log(string _message)
    {
        // append the string message with time and date, alongside message
        // as a new ling in the logs file.
        using (StreamWriter writer = new StreamWriter(LogPath, true))
            writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    public static void LogException(Exception _ex)
    {
        using (StreamWriter writer = new StreamWriter(LogPath, true))
            writer.WriteLine($"{DateTime.Now} : {_ex.Message}");
    }

    /// <summary>Break makes a empty line of space in log files for ease of reading.</summary>
    public static void Break()
    {
        // create a new empty line in logs file.
        using (StreamWriter write = new StreamWriter(LogPath, true))
            write.WriteLine("");
    }
}
