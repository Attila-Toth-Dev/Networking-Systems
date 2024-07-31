using MGC_Application.Forms;

namespace MGC_Application.Tools;

public class Users
{
    /// <summary>Checks if account details are correct.</summary>
    /// <param name="_username">Username of account.</param>
    /// <param name="_password">Password of account.</param>
    public static bool ValidateLogin(string _username, string _password)
    {
        try
        {
            using(StreamReader reader = new StreamReader($"{WelcomeForm.UsersPathFile}/Users.txt"))
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if(parts.Length == 2 && parts[0] == _username && parts[1] == _password)
                    {
                        Debug.Log($"User details correct. Welcome {_username}.");
                        return true;
                    }
                }
            }

            Debug.Log("Account details do not match, please try again.");
            return false;
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Checks to see if username already exists.</summary>
    /// <param name="_username">Username of the account to check.</param>
    public static bool UserExists(string _username)
    {
        try
        {
            using (StreamReader reader = new StreamReader($"{WelcomeForm.UsersPathFile}/Users.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2 && parts[0] == _username)
                    {
                        Debug.Log($"User account already exists.");
                        return true;
                    }
                }

                Debug.Log($"User account does not exist.");
                return false;
            }
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Function that adds the username and password details of account.</summary>
    /// <param name="_username">Username of the account.</param>
    /// <param name="_password">Password of the account.</param>
    public static void AddUser(string _username, string _password)
    {
        try
        {
            string usersPathName = $"Users.txt";
            string usersPath = $"{WelcomeForm.UsersPathFile}/{usersPathName}";

            using(StreamWriter writer = new StreamWriter(usersPath, true))
            {
                string pass = BKDRHash(_password).ToString();
                string user = BKDRHash(_username).ToString();
                writer.Write($"{user},{pass}{Environment.NewLine}");

                Debug.Log($"Successfully registered account.");
            }
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }

    /// <summary>Hashing function that securely hashes the password for an account.</summary>
    /// <param name="_string">The password to hash for account.</param>
    public static uint BKDRHash(string _string)
    {
        uint seed = 1313;
        uint hash = 0;

        for (uint i = 0; i < _string.Length; i++)
            hash = (hash * seed) + ((byte)_string[(int)i]);

        return hash;
    }
}
