namespace MGC_Application;

public class UserTools
{
    //private static string usersTxt = "users.txt";
    //private static string loginsTxt = "logins.txt";

    /// <summary>The Update Status Funciton updates the users login status.</summary>
    /// <param name="_username">The username of the user.</param>
    /// <param name="_isLoggedIn">The current login status.</param>
    /*public static void UpdateStatus(string _username, bool _isLoggedIn, string _serverIP)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(NetworkTools.FTPFileLocation(_serverIP, loginsTxt));

        // Iterate through each line to find the username logged in.
        for (int i = 0; i < lines.Length; i++)
        {
            // Split the line into username and login status
            string[] parts = lines[i].Split(',');

            // Split the line structure is valid and if the username and password match
            if (parts.Length == 2 && parts[0] == _username)
            {
                // Update the login status of the user
                lines[i] = $"{_username},{_isLoggedIn}";
                break;
            }
        }

        // Write the updated lines back to the logins file
        File.WriteAllLines(NetworkTools.FTPFileLocation(_serverIP, loginsTxt), lines);
    }*/

    /// <summary>Function used to validate user login credentials.</summary>
    /// <param name="_username">The username of the user.</param>
    /// <param name="_password">The password of the user.</param>
    /// <returns>Returns either true or false comparing to the users credentials.</returns>
    /*public static bool ValidateLogin(string _username, string _password, string _serverIP)
    {
        // Read all lines from the users file
        string[] lines = File.ReadAllLines(NetworkTools.FTPFileLocation(_serverIP, usersTxt));

        // Iterate through each line to find a matching username and password
        for (int i = 0; i < lines.Length; i++)
        {
            // Split the line into username and password
            string[] parts = lines[i].Split(',');

            // Split the line structure is valid and if the username and password match
            if (parts.Length == 2 && parts[0] == _username && parts[1] == _password)
                return true; // match found, login is valid
        }

        // no match found, login invalid
        return false;
    }*/

    /// <summary>Function used to check if User already exists in user.txt file.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <returns>Returns a true or false if the account exists or not.</returns>
    /*public static bool UserExists(string _username, string _serverIP)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(NetworkTools.FTPFileLocation(_serverIP, usersTxt));

        // Iterate through each line to find the username logged in.
        foreach (var line in lines)
        {
            // Split the line into username and login status
            string[] parts = line.Split(',');

            // Split the line structure is valid and if the username and password match
            if (parts.Length == 2 && parts[0] == _username)
            {
                // User already exists
                return true;
            }
        }

        // User does not exists
        return false;
    }*/

    /// <summary>Add users username and password to the logins and users txt files.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <param name="_password">The password of the User.</param>
    /*public static void AddUser(string _username, string _password, string _serverIP)
    {
        // Append the new user information to the users file.
        File.AppendAllText(NetworkTools.FTPFileLocation(_serverIP, usersTxt), $"{_username},{_password}{Environment.NewLine}");

        // Append the new user information to the logins file.
        File.AppendAllText(NetworkTools.FTPFileLocation(_serverIP, loginsTxt), $"{_username},{false}{Environment.NewLine}");
    }*/
}
