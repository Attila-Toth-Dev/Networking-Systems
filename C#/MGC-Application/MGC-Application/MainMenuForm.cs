namespace MGC_Application;

public partial class MainMenuForm : Form
{
    private string currentSelectedGame;

    public MainMenuForm()
    {
        InitializeComponent();

        gameListView.Items[0].Selected = true;
        gameFolderPathTextBox.Text = @"Games";

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        LocalFiles.ExecuteGame(currentSelectedGame, gameFolderPathTextBox.Text);
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        LocalFiles.InstallGame(currentSelectedGame, gameFolderPathTextBox.Text);
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        LocalFiles.UninstallGame(currentSelectedGame, gameFolderPathTextBox.Text);
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

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void profileButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        ProfileForm form = new ProfileForm();
        form.Show();
    }

    private void gameListView_Click(object sender, EventArgs e)
    {
        ListViewItem item = gameListView.SelectedItems[0];

        currentSelectedGame = item.Text;
    }

    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
            gameFolderPathTextBox.Text = diag.SelectedPath;
    }

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
