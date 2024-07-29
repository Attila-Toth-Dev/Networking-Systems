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

        Networking.Username = "ftp-user";
        Networking.Password = "mn1-237A";
        Networking.ServerIP = "58.169.146.100";

        passwordTextBox.UseSystemPasswordChar = true;

        Networking.DownloadFiles($"ftp://{Networking.ServerIP}/Users/Users.txt", "Users.txt");
    }

    #region UI Events

    /// <summary>Event for password text box text change.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e) => passwordTextBox.MaxLength = 50;

    /// <summary>Event for username text box text change.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e) => usernameTextBox.MaxLength = 50;

    /// <summary>Event for server IP text box text change.</summary>
    private void serverIpTextBox_TextChanged(object sender, EventArgs e) => serverIpTextBox.MaxLength = 50;

    /// <summary>Event for clear fields label click.</summary>
    private void clearFieldsLabel_Click(object sender, EventArgs e)
    {
        // clear data inside text boxes.
        usernameTextBox.Clear();
        passwordTextBox.Clear();
        serverIpTextBox.Clear();

        usernameTextBox.Focus();
    }

    /// <summary>Event for password picture box mouse down.</summary>
    private void passwordPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
        // allow user to view password with mouse down.
        passwordTextBox.UseSystemPasswordChar = false;
    }

    /// <summary>Event for password picture box mouse up.</summary>
    private void passwordPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        // disable viewing of password back to password characters.
        passwordTextBox.UseSystemPasswordChar = true;
    }

    /// <summary>Event for login form close.</summary>
    private void LoginForm_Closed(object sender, FormClosedEventArgs e) => Application.Exit();

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

        // If the user.txt file does not exist, return.
        if (!File.Exists($"{WelcomeForm.UsersPathFile}/Users.txt"))
        {
            FileTools.ShowDialogMessage("Something went wrong with Users file.");
            return;
        }

        // hash username and password to validate user details
        uint user = Users.BKDRHash(usernameTextBox.Text);
        uint pass = Users.BKDRHash(passwordTextBox.Text);

        // validate the hashed login credentials
        if (Users.ValidateLogin(user.ToString(), pass.ToString()))
        {
            // if true validate and start a remote connection to host.
            if (Networking.ValidateRemoteConnection(serverIpTextBox.Text))
            {
                Networking.ServerIP = serverIpTextBox.Text;
                
                // start upload process for user.txt file to remote host.
                if(Networking.UploadFiles("Users.txt", $"{WelcomeForm.UsersPathFile}", 
                    $"ftp://{Networking.ServerIP}/Users/Users.txt"))
                {
                    // delete local user file.
                    File.Delete($"{WelcomeForm.UsersPathFile}/Users.txt");

                    Hide();

                    // display main menu form.
                    MainMenuForm form = new MainMenuForm(usernameTextBox.Text, passwordTextBox.Text);
                    form.Show();
                }
            }
            // else if connection was invalid with remote host.
            else
            {
                // display error connection popup message.
                FileTools.ShowDialogMessage($"Error logging into server, please try again. (Line 74)", 1);

                passwordTextBox.Clear();
                usernameTextBox.Focus();
                //serverIpTextBox.Clear();
            }
        }
        // else prompt user that account does not exist or details are wrong.
        else
        {
            // display account error popup.
            FileTools.ShowDialogMessage("Account details are incorrect or does not exist, try again.");

            passwordTextBox.Clear();
            usernameTextBox.Clear();
            //serverIpTextBox.Clear();
        }

        Debug.Break();
    }

    /// <summary>Event for create account button click.</summary>
    private void createAccountButton_Click(object sender, EventArgs e) => createForm.ShowDialog();

    #endregion
}
