namespace MGC_Application.Tools;

public class Credentials
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
                Debug.Log($"User details correct. Welcome {_username}");
                return true;
            }
        }

        Debug.Log("Account does not exist, please try again.");
        return false;
    }

    /// <summary>Checks to see if username already exists.</summary>
    /// <param name="_username">Username of the account to check.</param>
    public static bool UserExists(string _username)
    {
        string[] lines = File.ReadAllLines(credPathFile);

        foreach(var line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 2 && parts[0] == _username)
            {
                Debug.Log("Username already exists");
                return true;
            }
        }

        return false;
    }

    /// <summary>Function that adds the username and password details of account.</summary>
    /// <param name="_username">Username of the account.</param>
    /// <param name="_password">Password of the account.</param>
    public static void AddUser(string _username, string _password)
    {
        string pass = BKDRHash(_password).ToString();
        File.AppendAllText(credPathFile, $"{_username},{pass}{Environment.NewLine}");

        Debug.Log($"Successfully registered account.");
    }

    /// <summary>Hashing function that securely hashes the password for an account.</summary>
    /// <param name="_password">The password to hash for account.</param>
    public static uint BKDRHash(string _password)
    {
        uint seed = 1313;
        uint hash = 0;

        for (uint i = 0; i < _password.Length; i++)
            hash = (hash * seed) + ((byte)_password[(int)i]);

        return hash;
    }
}
