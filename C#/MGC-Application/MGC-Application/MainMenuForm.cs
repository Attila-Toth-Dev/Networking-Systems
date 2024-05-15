using System.Xml;
using System.Xml.Linq;

namespace MGC_Application;

public partial class MainMenuForm : Form
{
    private string currentSelectedGame;

    /// <summary>Constructor for MainMenuForm.</summary>
    public MainMenuForm()
    {
        InitializeComponent();

        gameListView.Items[0].Selected = true;
        currentSelectedGame = gameListView.Items[0].Name;

        downloadTimer.Stop();

        gameFolderPathTextBox.Text = @"Games";

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    /// <summary>Event function for play button click.</summary>
    private void playButton_Click(object sender, EventArgs e)
    {
        if (LocalFiles.IsGameInstalled(currentSelectedGame, gameFolderPathTextBox.Text))
        {
            LocalFiles.ExecuteGame(currentSelectedGame, gameFolderPathTextBox.Text);

            MessageBox.Show($"Launching {currentSelectedGame}.exe");
        }
        else
        {
            MessageBox.Show($"Cannot run {currentSelectedGame}.exe.\nGame files appear to be missing.");
        }
    }

    /// <summary>Event function for install button click.</summary>
    private void installButton_Click(object sender, EventArgs e)
    {
        if(!LocalFiles.IsGameInstalled(currentSelectedGame, gameFolderPathTextBox.Text))
        {
            if(NetworkTools.DownloadGameFromFtp(currentSelectedGame, gameFolderPathTextBox.Text))
            {
                if(LocalFiles.InstallGame(currentSelectedGame, gameFolderPathTextBox.Text))
                {
                    MessageBox.Show($"{currentSelectedGame} has been successfuly downloaded and installed.");
                }
            }
        }
    }

    /// <summary>Event function for uninstall button click.</summary>
    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (LocalFiles.IsGameInstalled(currentSelectedGame, gameFolderPathTextBox.Text))
        {
            LocalFiles.UninstallGame(currentSelectedGame, gameFolderPathTextBox.Text);

            MessageBox.Show($"Uninstalled {currentSelectedGame} and corresponding files.");
        }
        else
        {
            MessageBox.Show($"{currentSelectedGame} is not installed.\nAborting uninstall process.");
        }
    }

    /// <summary>Event function for logout tool strip menu item click.</summary>
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            DebugLogger.WriteLog($"{NetworkTools.Username} has logged out");

            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event function for exit tool strip menu item click.</summary>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            DebugLogger.WriteClosingLog();
            Application.Exit();
        }
    }

    /// <summary>Event function for profile button click.</summary>
    private void profileButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        ProfileForm form = new ProfileForm();
        form.Show();
    }

    /// <summary>Event function for game list view click.</summary>
    private void gameListView_Click(object sender, EventArgs e)
    {
        DebugLogger.WriteLog($"{currentSelectedGame} selected.");

        ListViewItem item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;
    }

    /// <summary>Event function for game folder path button click.</summary>
    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            DebugLogger.WriteLog($"Current Pathfile: {diag.SelectedPath}");
            gameFolderPathTextBox.Text = diag.SelectedPath;
        }
    }

    /// <summary>Event function for main menu form close.</summary>
    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        DebugLogger.WriteClosingLog();
        Application.Exit();
    }

    /// <summary>Event function for download timer tick count.</summary>
    private void downloadTimer_Tick(object? sender, EventArgs e)
    {

    }
}
