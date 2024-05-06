namespace MGC_Application;

public partial class LoginForm : Form
{
    public static string loginsFilePath = "";
    public static string usersFilePath = "";

    private string serverIp = "";

    /// <summary>Login Form constructor.</summary>
    public LoginForm()
    {
        InitializeComponent();
    }

    /// <summary>Event function for password text box text changed.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.MaxLength = 15;
    }

    /// <summary>Event function for username text box text changed.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 15;
    }

    /// <summary>Event function for server ip text bot text changed.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        serverIp = serverIpTextBox.Text;

        loginsFilePath = $@"\\{serverIp}\mgc-launcher\logins.txt";
        usersFilePath = $@"\\{serverIp}\mgc-launcher\users.txt";
    }

    /// <summary>Event function for login button click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;
        int port = 7777;

        // Validate Server Connection
        if (NetworkTools.IsValidIP(serverIp, port))
        {

        }
    }

    /// <summary>Event function for sign up button click.</summary>
    private void signUpButton_Click(object sender, EventArgs e)
    {
        // Retrieve entered usernam and password from the text boxes
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Check if the username is already used
        if (UserData.UserExists(username))
        {
            // Show an error message for an existing user
            MessageBox.Show("Warning, user already exists!\nPlease try again.");

            loginButton.Focus();
        }
        else
        {
            // If the password is empty, show error message
            if (password == "" || password[0] == ' ')
            {
                MessageBox.Show("Error, cannot have empty password.\nPlease try again.");

                passwordTextBox.Clear();
                usernameTextBox.Focus();
            }
            else
            {
                // Add the new User to the users.txt file, update login status
                UserData.AddUser(username, password);
                MessageBox.Show($"User account created!\nWelcome {username}.");

                loginButton.Focus();
            }
        }
    }

    /// <summary>Event function for login forms closed event.</summary>
    private void LoginForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
