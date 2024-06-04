using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class CreateAccountForm : Form
{
    public CreateAccountForm()
    {
        InitializeComponent();

        this.Text = "Create User Account";

        passwordTextBox.UseSystemPasswordChar = true;
    }

    #region Button Events

    /// <summary>Event for saveButton click.</summary>
    private void saveButton_Click(object sender, EventArgs e)
    {
        // if username already exists, then prompt player
        // with a different account name,
        // else add the username if username does not exists.
        if (Credentials.UserExists(usernameTextBox.Text))
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            FileTools.ShowDialogMessage($"Username already exists, please try again.");
        }
        else
        {
            if (Networking.FTPCredentialsCheck(usernameTextBox.Text, passwordTextBox.Text))
            {
                Credentials.AddUser(usernameTextBox.Text, passwordTextBox.Text);
                FileTools.ShowDialogMessage($"User account created.");

                usernameTextBox.Clear();
                passwordTextBox.Clear();

                this.Close();
            }
            else
                Debug.Log("Error uploading file data.");
        }
    }

    /// <summary>Event for cancelButton click.</summary>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        // close the form
        this.Close();
    }

    #endregion
    
    /// <summary>Event from CreateAccountForm closed.</summary>
    private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        // close the form
        this.Close();
    }
}
