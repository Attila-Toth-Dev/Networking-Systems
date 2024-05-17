namespace MGC_Application;

public partial class MainMenuForm : Form
{
    private string currentSelectedGame = "";

    public MainMenuForm()
    {
        InitializeComponent();

        gameListView.Items[0].Selected = true;
        gameFilePathTextBox.Text = @"./Games";

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");

            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
            {
                DebugLogger.Log($"Running .exe file now.");
                MessageBox.Show($"Running {currentSelectedGame}.exe");
            }
        }
        else
            MessageBox.Show($"{currentSelectedGame} is not installed or files are missing.");

        DebugLogger.Break();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if(FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} has been found.");

            //if()
        }

        DebugLogger.Break();
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed.");
            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame, gameFilePathTextBox.Text))
            {
                DebugLogger.Log($"Game files have been downloaded from {NetworkTools.ServerIP}.");

                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    DebugLogger.Log($"Installing {currentSelectedGame} files now.");
                    MessageBox.Show($"{currentSelectedGame} has now been installed.");
                }
            }
        }
        else
            MessageBox.Show($"{currentSelectedGame} is already installed.\nAborting install process.");

        // Add the ability to reinstall files for games.
        DebugLogger.Break();
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} have been found.");

            DialogResult result = MessageBox.Show($"Are you sure you would like to uninstall {currentSelectedGame}?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    DebugLogger.Log($"Uninstalling {currentSelectedGame} and files now.");
                    MessageBox.Show($"{currentSelectedGame} has been uninstalled.");
                }
            }
        }
        else
            MessageBox.Show($"{currentSelectedGame} files are missing.\nAborting uninstall.");

        DebugLogger.Break();
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
        {
            gameFilePathTextBox.Text = diag.SelectedPath;
        }
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

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void downloadTimer_Tick(object? sender, EventArgs e)
    {

    }
}
