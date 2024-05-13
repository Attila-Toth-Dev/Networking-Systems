namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public static int restrict = 0;

    private string username;
    private string password;

    public MainMenuForm(string _username, string _password)
    {
        InitializeComponent();

        username = _username;
        password = _password;

        welecomeLabel.Text = $"{username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {

    }

    private void installButton_Click(object sender, EventArgs e)
    {
        NetworkTools.DownloadFTPFile(NetworkTools.ServerIP, username, password, "Breakout.zip");
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void profileButton_Click(object sender, EventArgs e)
    {
        if (restrict == 0)
        {
            this.Hide();

            restrict++;
            ProfileForm form = new ProfileForm(username, password);
            form.Show();
        }
    }

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
