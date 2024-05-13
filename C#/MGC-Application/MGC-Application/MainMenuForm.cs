namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public static int restrict = 0;

    private string username;
    private string password;

    private string serverIP;

    private string currentSelectedGame;

    public MainMenuForm(string _username, string _password, string _serverIP)
    {
        InitializeComponent();

        username = _username;
        password = _password;

        serverIP = _serverIP;

        currentSelectedGame = "";

        welecomeLabel.Text = $"{username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        if (NetworkTools.IsGameDownloaded(serverIP, username, password, currentSelectedGame))
            NetworkTools.RunInstalledGame(serverIP, username, password, currentSelectedGame);
        else
        {
            MessageBox.Show($"{currentSelectedGame} has not been installed.\nPlease install and try again.");

        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {

    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (NetworkTools.IsGameDownloaded(serverIP, username, password, currentSelectedGame))
            MessageBox.Show($"{currentSelectedGame} is already installed.");

        else
        {
            DialogResult dialogResult = MessageBox.Show($"{currentSelectedGame} has not been installed.\nWould you like to install it?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                NetworkTools.DownloadFTPFile(serverIP, username, password, currentSelectedGame);
        }
    }

    private void removeButton_Click(object sender, EventArgs e)
    {

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
            ProfileForm form = new ProfileForm(username, password, serverIP);
            form.Show();
        }
    }

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void gameListView_Click(object sender, EventArgs e)
    {
        ListViewItem item = gameListView.SelectedItems[0];

        currentSelectedGame = item.Text;
    }

    private void gameListView_ItemChecked(object sender, ItemCheckedEventArgs e)
    {

    }
}
