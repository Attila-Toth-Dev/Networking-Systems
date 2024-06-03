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
        if (CredentialsTools.UserExists(usernameTextBox.Text))
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            FileTools.ShowDialogMessage($"Username already exists, please try again.");
        }
        else
        {
            CredentialsTools.AddUser(usernameTextBox.Text, passwordTextBox.Text);
            FileTools.ShowDialogMessage($"User account created.");
            this.Close();
        }
    }

    /// <summary>Event for cancelButton click.</summary>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        // close the form
        this.Close();
    }

    #endregion
    
    /// <summary>Event from CreateAccountForm closed.</summary>
    private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // close the form
        this.Close();
    }
}
