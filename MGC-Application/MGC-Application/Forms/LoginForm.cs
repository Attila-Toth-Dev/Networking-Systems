using MGC_Application.Forms;

namespace MGC_Application;

public partial class LoginForm : Form
{
    private string username;
    private string password;
    private string serverIP;
    private string directory;

    public LoginForm()
    {
        InitializeComponent();

        username = string.Empty;
        password = string.Empty;
        serverIP = string.Empty;
        directory = string.Empty;

        passwordTextBox.UseSystemPasswordChar = true;
    }

    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.MaxLength = 50;
        password = passwordTextBox.Text;
    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 50;
        username = usernameTextBox.Text;
    }

    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        serverIpTextBox.MaxLength = 50;
        serverIP = serverIpTextBox.Text;
    }

    private void directoryTextBox_TextChanged(object sender, EventArgs e)
    {
        directory = directoryTextBox.Text;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        if (NetworkTools.CheckValidFTP(serverIP, username, password, directory))
        {
            DebugLogger.Log($"Successfully logged into server {serverIP}.");

            NetworkTools.Username = username;
            NetworkTools.Password = password;
            NetworkTools.ServerIP = serverIP;

            Hide();

            MainMenuForm form = new MainMenuForm();
            form.Show();
        }
        else
        {
            DebugLogger.Log("$Error logging into server.");

            DialogBoxForm dialog = new DialogBoxForm(DialogBoxForm.MessageSeverity.ERROR,
                $"Error logging into server.\nPlease try again.");
            dialog.ShowDialog();

            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        DebugLogger.Break();
    }

    private void passwordPitureBox_MouseDown(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = false;
    }

    private void passwordPitureBox_MouseUp(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = true;
    }

    private void LoginForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
