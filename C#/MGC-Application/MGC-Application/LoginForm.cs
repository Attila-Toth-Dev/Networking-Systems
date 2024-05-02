namespace MGC_Application;

public partial class LoginForm : Form
{
    private int counter = 1;

    // File paths for storing users logins and logged in users
    private const string usersFilePath = "users.txt";
    private const string loginsFilePath = "logins.txt";

    public LoginForm()
    {
        InitializeComponent();
    }

    private void logoPictureBox_Click(object sender, EventArgs e)
    {
        counter += 1;

        if (counter == 3)
            MessageBox.Show("This is going to be a fun project!");
    }

    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.MaxLength = 15;
    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 15;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Validate the login credentials
        if (ValidateLogin(username, password))
        {
            // Update the login status to indicate the user is logged into the application
            UpdateLoginStatus(username, true);
            MessageBox.Show($"Succesfully logged in.\nWelcome {username}!");

            this.Hide();

            MainMenuForm form = new MainMenuForm(username);
            form.Show();
        }
        // Show an error message for invalid login
        else
        {
            MessageBox.Show("User details were incorrect.\nPlease try again...");

            usernameTextBox.Clear();
            passwordTextBox.Clear();

            usernameTextBox.Focus();
        }
    }

    /// <summary>Update the login status of the user.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <param name="_isLoggedIn">The password of the User.</param>
    private void UpdateLoginStatus(string _username, bool _isLoggedIn)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(usersFilePath);

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
        File.WriteAllLines(loginsFilePath, lines);
    }

    /// <summary>Function used to validate user login credentials.</summary>
    /// <param name="_username">The username of the user.</param>
    /// <param name="_password">The password of the user.</param>
    /// <returns>Returns either true or false comparing to the users credentials.</returns>
    private bool ValidateLogin(string _username, string _password)
    {
        // Read all lines from the users file
        string[] lines = File.ReadAllLines(usersFilePath);

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

    private void signUpButton_Click(object sender, EventArgs e)
    {
        // Retrieve entered usernam and password from the text boxes
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Check if the username is already used
        if (UserExists(username))
        {
            // Show an error message for an existing user
            MessageBox.Show("Warning, user already exists!\nPlease try again.");
        }
        else
        {
            // Add the new User to the users.txt file, update login status
            AddUser(username, password);
            MessageBox.Show($"User account created!\nWelcome {username}.");

            /*this.Hide();

            MainMenuForm form = new MainMenuForm(username);
            form.Show();*/
        }
    }

    /// <summary>Add users username and password to the logins and users txt files.</summary>
    /// <param name="username">The username of the User.</param>
    /// <param name="password">The password of the User.</param>
    private void AddUser(string username, string password)
    {
        // Append the new user information to the users file.
        File.AppendAllText(usersFilePath, $"{username},{password}{Environment.NewLine}");

        // Append the new user information to the logins file.
        File.AppendAllText(loginsFilePath, $"{username},{false}{Environment.NewLine}");
    }

    /// <summary>Function used to check if User already exists in user.txt file.</summary>
    /// <param name="_username">The username of the User.</param>
    /// <returns>Returns a true or false if the account exists or not.</returns>
    private bool UserExists(string _username)
    {
        // Read all lines from the logins file
        string[] lines = File.ReadAllLines(usersFilePath);

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
}
