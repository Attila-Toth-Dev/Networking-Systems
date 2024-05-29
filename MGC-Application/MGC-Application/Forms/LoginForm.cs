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
        // changes password to the characters inside text box.
        passwordTextBox.MaxLength = 50;
        password = passwordTextBox.Text;
    }

    /// <summary>Event for usernameTextBox text change.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        // changes username to the characters inside text box.
        usernameTextBox.MaxLength = 50;
        username = usernameTextBox.Text;
    }

    /// <summary>Event for serverIpTextBox text change.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        // changes server IP to the characters inside text box.
        serverIpTextBox.MaxLength = 50;
        serverIP = serverIpTextBox.Text;
    }

    /// <summary>Event for loginButton click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        // check to see if username, password and server IP
        // match up to FTP server allowed users.
        if (NetworkTools.CheckValidFTP(serverIP, username, password))
        {
            // if true, save username, password and serverIP to network class,
            // and display main menu form.
            //DebugLogger.Log($"Successfully logged into server {serverIP}.");

            NetworkTools.Username = username;
            NetworkTools.Password = password;
            NetworkTools.ServerIP = serverIP;

            Hide();

            MainMenuForm form = new MainMenuForm();
            form.Show();
        }
        else
        {
            // if false, return a dialog box erroring the user credentials.
            // prompt user to try logging in again.
            FileTools.ShowDialogMessage($"Error logging into server, please try again. (Line 74)", 1);

            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        DebugLogger.Break();
    }

    /// <summary>Event for clearFieldsButton click.</summary>
    private void clearFieldsButton_Click(object sender, EventArgs e)
    {
        // clear data inside text boxes.
        usernameTextBox.Clear();
        passwordTextBox.Clear();
        serverIpTextBox.Clear();
    }

    /// <summary>Event for passwordPictureBox mouse down.</summary>
    private void passwordPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
        // allow user to view password with mouse down.
        passwordTextBox.UseSystemPasswordChar = false;
    }

    /// <summary>Event for passwordPictureBox mouse up.</summary>
    private void passwordPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        // disable viewing of password back to password characters.
        passwordTextBox.UseSystemPasswordChar = true;
    }

    /// <summary>Event for LoginForm close.</summary>
    private void LoginForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close application.
        Application.Exit();
    }
}
