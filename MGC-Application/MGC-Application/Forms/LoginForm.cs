using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class LoginForm : Form
{
    private readonly CreateAccountForm createForm;

    public LoginForm()
    {
        InitializeComponent();

        this.Text = "<Temp Name>";

        createForm = new CreateAccountForm();
        passwordTextBox.UseSystemPasswordChar = true;

        Networking.DownloadFiles($"ftp://{Networking.ServerIp}/Users", "Users.txt");
    }

    #region UI Events

    private void passwordTextBox_TextChanged(object sender, EventArgs e) => passwordTextBox.MaxLength = 50;

    private void usernameTextBox_TextChanged(object sender, EventArgs e) => usernameTextBox.MaxLength = 50;

    private void clearFieldsLabel_Click(object sender, EventArgs e)
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        usernameTextBox.Focus();
    }

    private void passwordPictureBox_MouseDown(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = false;
    }

    private void passwordPictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        passwordTextBox.UseSystemPasswordChar = true;
    }

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

        uint user = Users.BKDRHash(usernameTextBox.Text);
        uint pass = Users.BKDRHash(passwordTextBox.Text);

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
