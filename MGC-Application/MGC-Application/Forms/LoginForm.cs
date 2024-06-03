using MGC_Application.Forms;
using MGC_Application.Tools;

namespace MGC_Application;

public partial class LoginForm : Form
{
    private CreateAccountForm createForm;

    public LoginForm()
    {
        InitializeComponent();

        createForm = new CreateAccountForm();

        NetworkTools.Username = "ftp-user";
        NetworkTools.Password = "mn1-237A";

        passwordTextBox.UseSystemPasswordChar = true;
    }

    #region UI Events

    /// <summary>Event for passwordTextBox text change.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e)
    {
        // changes password to the characters inside text box.
        passwordTextBox.MaxLength = 50;
    }

    /// <summary>Event for usernameTextBox text change.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e)
    {
        // changes username to the characters inside text box.
        usernameTextBox.MaxLength = 50;
    }

    /// <summary>Event for serverIpTextBox text change.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e)
    {
        // changes server IP to the characters inside text box.
        serverIpTextBox.MaxLength = 50;
    }

    /// <summary>Event for clearFieldsLabel click.</summary>
    private void clearFieldsLabel_Click(object sender, EventArgs e)
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

    #endregion

    #region Button Events

    /// <summary>Event for loginButton click.</summary>
    private void loginButton_Click(object sender, EventArgs e)
    {
        // If text box space is empty, return null value.
        if(string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
           string.IsNullOrWhiteSpace(serverIpTextBox.Text))
        {
            FileTools.ShowDialogMessage("Please fill out all text boxes.");
            return;
        }

        // check to see if username, password and server IP
        // match up to FTP server allowed users.
        uint hashValue = CredentialsTools.BKDRHash(passwordTextBox.Text);
        if (CredentialsTools.ValidateLogin(usernameTextBox.Text, hashValue.ToString()))
        {
            if (NetworkTools.CheckValidFTP(serverIpTextBox.Text))
            {
                // if true, save username, password and serverIP to network class,
                // and display main menu form.
                NetworkTools.ServerIP = serverIpTextBox.Text;

                Hide();

                MainMenuForm form = new MainMenuForm(usernameTextBox.Text, passwordTextBox.Text);
                form.Show();
            }
            else
            {
                // if false, return a dialog box erroring the user credentials.
                // prompt user to try logging in again.
                FileTools.ShowDialogMessage($"Error logging into server, please try again. (Line 74)", 1);

                passwordTextBox.Clear();
                usernameTextBox.Focus();
                serverIpTextBox.Clear();
            }
        }
        else
        {
            // if false, prompt user to create an account
            // and to register an account.
            FileTools.ShowDialogMessage("Account does not exist, try again.");

            passwordTextBox.Clear();
            usernameTextBox.Clear();
            serverIpTextBox.Clear();
        }

        DebugLogger.Break();
    }

    /// <summary>Event for createAccountButton click.</summary>
    private void createAccountButton_Click(object sender, EventArgs e)
    {
        createForm.ShowDialog();
    }

    #endregion
}
