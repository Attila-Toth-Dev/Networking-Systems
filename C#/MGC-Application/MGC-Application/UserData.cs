namespace MGC_Application;

public static class UserData
{
    /// <summary>The Update Status Funciton updates the users login status.</summary>
    /// <param name="_username">The username of the user.</param>
    /// <param name="_isLoggedIn">The current login status.</param>
    public static void UpdateStatus(string _username, bool _isLoggedIn)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(LoginForm.loginsFilePath);

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
        File.WriteAllLines(LoginForm.loginsFilePath, lines);
    }

    /// <summary>Function used to validate user login credentials.</summary>
    /// <param name="_username">The username of the user.</param>
    /// <param name="_password">The password of the user.</param>
    /// <returns>Returns either true or false comparing to the users credentials.</returns>
    public static bool ValidateLogin(string _username, string _password)
    {
        // Read all lines from the users file
        string[] lines = File.ReadAllLines(LoginForm.usersFilePath);

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
    }

    /// <summary>Function used to check if User already exists in user.txt file.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <returns>Returns a true or false if the account exists or not.</returns>
    public static bool UserExists(string _username)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(LoginForm.usersFilePath);

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
    }

    /// <summary>Add users username and password to the logins and users txt files.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <param name="_password">The password of the User.</param>
    public static void AddUser(string _username, string _password)
    {
        // Append the new user information to the users file.
        File.AppendAllText(LoginForm.usersFilePath, $"{_username},{_password}{Environment.NewLine}");

        // Append the new user information to the logins file.
        File.AppendAllText(LoginForm.loginsFilePath, $"{_username},{false}{Environment.NewLine}");
    }
}
