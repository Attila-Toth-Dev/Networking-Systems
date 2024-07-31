using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class CreateAccountForm : Form
{
    public CreateAccountForm()
    {
        InitializeComponent();

        passwordTextBox.UseSystemPasswordChar = true;
    }

    #region Button Events

    /// <summary>Event for save button click.</summary>
    private void saveButton_Click(object sender, EventArgs e)
    {
        // check if user details are correct, with hashing username
        var hash = Users.BKDRHash(usernameTextBox.Text);
        if (Users.UserExists(hash.ToString()))
        {
            // if user already exists, clear and prompt again.
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            usernameTextBox.Focus();

            FileTools.ShowDialogMessage($"Username already exists, please try again.");
        }
        else
        {
            // else, add the user to the users file.
            Users.AddUser(usernameTextBox.Text, passwordTextBox.Text);
            FileTools.ShowDialogMessage($"Successfully registered account.");

            // then clear fields and close the window.
            usernameTextBox.Clear();
            passwordTextBox.Clear();

            this.Close();
        }
    }

    /// <summary>Event for cancel button click.</summary>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        // clear fields and close form.
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        this.Close();
    }

    #endregion
    
    /// <summary>Event from create account form closed.</summary>
    private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // clear fields and close form.
        usernameTextBox.Clear();
        passwordTextBox.Clear();

        this.Close();
    }
}
