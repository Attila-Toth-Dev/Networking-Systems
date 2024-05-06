using System.Net.Sockets;

namespace MGC_Application;

public partial class LoginForm : Form
{
    /// <summary>Login Form constructor.</summary>
    public LoginForm() => InitializeComponent();

    /// <summary>Event function for password text box text changed.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.MaxLength = 15;
    }

    /// <summary>Event function for username text box text changed.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e) => usernameTextBox.MaxLength = 15;

    /// <summary>Event function for login button click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;
        string serverIP = serverIpTextBox.Text;
        int port = 445;

        // Validate the login credentials
        if (UserStatus.ValidateLogin(username, password) && PingServerClient(serverIP, port))
        {
            // Update the login status to indicate the user is logged into the application
            UserStatus.UpdateStatus(username, true);
            MessageBox.Show($"Succesfully logged in.\nWelcome {username}!");

            this.Hide();

            MainMenuForm form = new MainMenuForm(username);
            form.Show();
        }
        // Show an error message for invalid login
        else
        {
            MessageBox.Show("User details were incorrect.\nPlease try again...");

            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }
    }

    /// <summary>Event function for sign up button click.</summary>
    private void signUpButton_Click(object sender, EventArgs e)
    {
        // Retrieve entered usernam and password from the text boxes
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Check if the username is already used
        if (UserStatus.UserExists(username))
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
                UserStatus.AddUser(username, password);
                MessageBox.Show($"User account created!\nWelcome {username}.");

                loginButton.Focus();
            }
        }
    }

    /// <summary>The function pings the server client to see if user is able to connect to.</summary>
    /// <param name="_serverIP">The IP location the user wants to connect to.</param>
    /// <param name="_port">The specific port to connect to.</param>
    /// <returns>Returns true or false depending if connection was successful or not.</returns>
    private bool PingServerClient(string _serverIP, int _port)
    {
        try
        {
            using (var client = new TcpClient(_serverIP, _port))
                MessageBox.Show($"Successfully connected to host: {_serverIP}:{_port}");
            return true;
        }
        catch
        {
            MessageBox.Show($"Connection Failed with host: {_serverIP}:{_port}");
            return false;
        }
    }
}
