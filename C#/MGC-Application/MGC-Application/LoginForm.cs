namespace MGC_Application;

public partial class LoginForm : Form
{
    private string username;
    private string password;
    private string serverIP;

    /// <summary>Login Form constructor.</summary>
    public LoginForm()
    {
        InitializeComponent();

        username = "";
        password = "";

        serverIP = "";
    }

    /// <summary>Event function for password text box text changed.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.MaxLength = 15;

        password = passwordTextBox.Text;
    }

    /// <summary>Event function for username text box text changed.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 15;

        username = usernameTextBox.Text;
    }

    /// <summary>Event function for server ip text bot text changed.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        serverIP = serverIpTextBox.Text;
    }

    /// <summary>Event function for login button click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        if (NetworkTools.CheckValidFTP(serverIP, username, password))
        {
            NetworkTools.Username = username;
            NetworkTools.Password = password;
            NetworkTools.ServerIP = serverIP;

            Hide();

            MainMenuForm form = new MainMenuForm();
            form.Show();
        }
        else
        {
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }
    }

    /// <summary>Event function for login forms closed event.</summary>
    private void LoginForm_Closed(object sender, FormClosedEventArgs e) => Application.Exit();
}
