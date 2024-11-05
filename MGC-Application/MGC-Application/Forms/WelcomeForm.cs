using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();

        this.Text = "<Temp Name>";

        FileTools.CreateDirectory(FileTools.DataDirectory);

        Thread.Sleep(1000);

        FileTools.CreateDirectory(FileTools.LogPathFile, true);
        FileTools.CreateDirectory(FileTools.GamesDirectory);
    }

    #region UI Events

    private void connectButton_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(serverIPTextBox.Text))
        {
            FileTools.ShowDialogMessage("Please fill out all text boxes.");
            return;
        }

        if (Networking.ValidateRemoteConnection(serverIPTextBox.Text))
        {
            Networking.ServerIp = serverIPTextBox.Text;

            Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
        else
        {
            FileTools.ShowDialogMessage("Error logging into server, please try again. (Line 74)", 1);
            serverIPTextBox.Clear();
        }
    }

    private void WelcomeForm_Closed(object _sender, FormClosedEventArgs e)
    {
        // close the application.
        Application.Exit();
    }

    #endregion
    
}
