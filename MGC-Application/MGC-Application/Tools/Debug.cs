namespace MGC_Application.Tools;

public class Debug
{
    private static readonly string LogPath = $"{FileTools.LogPathFile}/Logs.txt";

    public static void Log(string _message)
    {
        using StreamWriter writer = new StreamWriter(LogPath, true);
        writer.WriteLine($"{DateTime.Now} : {_message}");
    }

    public static void LogException(Exception _ex)
    {
        using StreamWriter writer = new StreamWriter(LogPath, true);
        writer.WriteLine($"{DateTime.Now} : {_ex.Message}");
    }

    public static void Break()
    {
        using StreamWriter write = new StreamWriter(LogPath, true);
        write.WriteLine("");
    }
}
