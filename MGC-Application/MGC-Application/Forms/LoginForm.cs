using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class LoginForm : Form
{
    private readonly CreateAccountForm createForm;

    public LoginForm()
    {
        InitializeComponent();

        createForm = new CreateAccountForm();
        passwordTextBox.UseSystemPasswordChar = true;

        Debug.Log(Networking.DownloadFiles($"ftp://{Networking.ServerIp}/Users", "Users.txt")
            ? "Successfully downloaded users file."
            : "Error with users file.");
    }

    #region UI Events

    /// <summary>Event for password text box text change.</summary>
    private void passwordTextBox_TextChanged(object sender, EventArgs e) => passwordTextBox.MaxLength = 50;

    /// <summary>Event for username text box text change.</summary>
    private void usernameTextBox_TextChanged(object sender, EventArgs e) => usernameTextBox.MaxLength = 50;

    /// <summary>Event for clear fields label click.</summary>
    private void clearFieldsLabel_Click(object sender, EventArgs e)
    {
        // clear data inside text boxes.
        usernameTextBox.Clear();
        passwordTextBox.Clear();

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

    private void loginButton_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
        {
            FileTools.ShowDialogMessage("Please fill out all text boxes.");
            return;
        }

        if (!File.Exists($"{FileTools.UsersPathFile}/Users.txt"))
        {
            FileTools.ShowDialogMessage("Error validating users file.");
            return;
        }

        uint user = Users.BkdrHash(usernameTextBox.Text);
        uint pass = Users.BkdrHash(passwordTextBox.Text);

        if (Users.ValidateLogin(user.ToString(), pass.ToString()))
        {
            if (Networking.ValidateRemoteConnection(Networking.ServerIp))
            {
                if(Networking.UploadFiles("Users.txt", $"{FileTools.UsersPathFile}", 
                    $"ftp://{Networking.ServerIp}/Users/Users.txt"))
                {
                    File.Delete($"{FileTools.UsersPathFile}/Users.txt");

                    Hide();

                    MainMenuForm form = new MainMenuForm(usernameTextBox.Text);
                    form.Show();
                }
            }
            else
            {
                FileTools.ShowDialogMessage($"Error logging into server, please try again. (Line 74)", 1);

                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }
        else
        {
            FileTools.ShowDialogMessage("Account details are incorrect or does not exist, try again.");

            usernameTextBox.Clear();
            passwordTextBox.Clear();

            usernameTextBox.Focus();
        }

        Debug.Break();
    }

    private void createAccountButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        createForm.ShowDialog();
    }

    #endregion
}
