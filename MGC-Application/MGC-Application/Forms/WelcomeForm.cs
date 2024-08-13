using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();

        FileTools.LogPathFile = $@"{FileTools.DataDirectory}/";
        FileTools.UsersPathFile = $@"{FileTools.DataDirectory}/";

        if (!Directory.Exists(FileTools.DataDirectory))
            FileTools.CreateDirectory(FileTools.DataDirectory, true);

        if (!Directory.Exists(FileTools.GamesDirectory))
            FileTools.CreateDirectory(FileTools.GamesDirectory);
    }

    #region UI Events

    private void connectButton_Click(object sender, EventArgs e)
    {
        // If text box space is empty, return null value.
        if(string.IsNullOrWhiteSpace(serverIPTextBox.Text))
        {
            FileTools.ShowDialogMessage("Please fill out all text boxes.");
            return;
        }

        // If the user.txt file does not exist, return.
        /*if (!File.Exists($"{FileTools.UsersPathFile}/Users.txt"))
        {
            FileTools.ShowDialogMessage("Error validating users file.");
            return;
        }*/

        // if true validate and start a remote connection to host.
        if (Networking.ValidateRemoteConnection(serverIPTextBox.Text))
        {
            Networking.ServerIp = serverIPTextBox.Text;

            Hide();

            // display main menu form.
            LoginForm form = new LoginForm();
            form.Show();
        }
        // else if connection was invalid with remote host.
        else
        {
            // display error connection popup message.
            FileTools.ShowDialogMessage($"Error logging into server, please try again. (Line 74)", 1);
            serverIPTextBox.Clear();
        }
    }

    /// <summary>Event for welcome form close.</summary>
    private void WelcomeForm_Closed(object _sender, FormClosedEventArgs e)
    {
        // close the application.
        Application.Exit();
    }

    #endregion
    
}
