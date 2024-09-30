namespace MGC_Application.Tools;

public class Users
{
    public static bool ValidateLogin(string _username, string _password)
    {
        try
        {
            using(StreamReader reader = new StreamReader($"{FileTools.UsersPathFile}/Users.txt"))
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

            Debug.Log("Account details not registered, try again.");
            return false;
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    public static bool UserExists(string _username)
    {
        try
        {
            using (StreamReader reader = new StreamReader($"{FileTools.UsersPathFile}/Users.txt"))
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
            Debug.LogException(ex);
            return false;
        }
    }

    public static void AddUser(string _username, string _password)
    {
        try
        {
            string usersPath = $"{FileTools.UsersPathFile}/Users.txt";

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

    public static uint BKDRHash(string _string)
    {
        uint seed = 1313;
        uint hash = 0;

        for (uint i = 0; i < _string.Length; i++)
            hash = (hash * seed) + ((byte)_string[(int)i]);

        return hash;
    }
}
