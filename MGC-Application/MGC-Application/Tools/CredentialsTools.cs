namespace MGC_Application.Tools;

public class CredentialsTools
{
    private static string credPathFile = $"{WelcomeForm.credentialsPathFile}/Credentials.txt";

    /// <summary>Checks if account details are correct.</summary>
    /// <param name="_username">Username of account.</param>
    /// <param name="_password">Password of account.</param>
    public static bool ValidateLogin(string _username, string _password)
    {
        string[] lines = File.ReadAllLines(credPathFile);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            if (parts.Length == 2 && parts[0] == _username && parts[1] == _password)
            {
                DebugLogger.Log($"User details correct. Welcome {_username}");
                return true;
            }
        }

        return false;
    }

    /// <summary>Checks to see if username already exists.</summary>
    /// <param name="_username"></param>
    public static bool UserExists(string _username)
    {
        string[] lines = File.ReadAllLines(credPathFile);

        foreach(var line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 2 && parts[0] == _username)
                return true;
        }

        return false;
    }

    public static void AddUser(string _username, string _password)
    {
        File.AppendAllText(credPathFile,
            $"{_username},{_password}{Environment.NewLine}");
    }
}
