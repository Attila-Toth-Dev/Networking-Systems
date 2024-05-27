using MGC_Application.Forms;

namespace MGC_Application;

public partial class LoginForm : Form
{
    private string username;
    private string password;
    private string serverIP;

    public LoginForm()
    {
        InitializeComponent();

        username = string.Empty;
        password = string.Empty;
        serverIP = string.Empty;

        usernameTextBox.Text = "ftp-user";
        passwordTextBox.Text = "mn1-237A";
        serverIpTextBox.Text = "58.169.146.100";

        passwordTextBox.UseSystemPasswordChar = true;
    }

    /// <summary>Event for passwordTextBox text change.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        passwordTextBox.MaxLength = 50;
        password = passwordTextBox.Text;
    }

    /// <summary>Event for usernameTextBox text change.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        usernameTextBox.MaxLength = 50;
        username = usernameTextBox.Text;
    }

    /// <summary>Event for serverIpTextBox text change.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        serverIpTextBox.MaxLength = 50;
        serverIP = serverIpTextBox.Text;
    }

    /// <summary>Event for loginButton click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        if (NetworkTools.CheckValidFTP(serverIP, username, password))
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

    /// <summary>Event for clearFieldsButton click.</summary>
    private void clearFieldsButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();
        serverIpTextBox.Clear();
    }

    /// <summary>Event for passwordPictureBox mouse down.</summary>
    private void passwordPictureBox_MouseDown(object sender, MouseEventArgs e) => passwordTextBox.UseSystemPasswordChar = false;

    /// <summary>Event for passwordPictureBox mouse up.</summary>
    private void passwordPictureBox_MouseUp(object sender, MouseEventArgs e) => passwordTextBox.UseSystemPasswordChar = true;

    /// <summary>Event for LoginForm close.</summary>
    private void LoginForm_Closed(object sender, FormClosedEventArgs e) => Application.Exit();
}
