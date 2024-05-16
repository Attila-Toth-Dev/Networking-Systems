namespace MGC_Application;

public partial class LoginForm : Form
{
    private string username = "";
    private string password = "";
    private string serverIP = "";

    public LoginForm()
    {
        InitializeComponent();

        passwordTextBox.UseSystemPasswordChar = true;
    }

    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.MaxLength = 15;
        password = passwordTextBox.Text;
    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 15;
        username = usernameTextBox.Text;
    }

    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        serverIP = serverIpTextBox.Text;
    }

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

    private void LoginForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void passwordPitureBox_MouseDown(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = false;
    }

    private void passwordPitureBox_MouseUp(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = true;
    }
}
