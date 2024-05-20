using MGC_Application.Forms;

namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public static int restrict = 0;
    
    private string currentSelectedGame = string.Empty;

    private ProfileForm profileForm;

    public MainMenuForm()
    {
        InitializeComponent();

        profileForm = new ProfileForm();

        gameFilePathTextBox.Text = @"./Games";

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            MessageBox.Show("Please select a game before proceeding.");

            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");

            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
            {
                DebugLogger.Log($"Running {currentSelectedGame}.exe");
                MessageBox.Show($"Running {currentSelectedGame}.exe");
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files are missing.");
            MessageBox.Show($"{currentSelectedGame} files are missing.");
        }

        DebugLogger.Break();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            MessageBox.Show("Please select a game before proceeding.");

            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files are missing.");
            MessageBox.Show($"{currentSelectedGame} files are missing.");
        }

        DebugLogger.Break();
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            MessageBox.Show("Please select a game before proceeding.");

            return;
        }

        DebugLogger.Log($"Preparing {currentSelectedGame} install process.");

        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed.");
            DebugLogger.Log($"Starting download now.");

            MessageBox.Show($"Starting {currentSelectedGame} download and install.");

            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame, gameFilePathTextBox.Text))
            {
                DebugLogger.Log($"Successfuly downloaded files from server.");
                DebugLogger.Log($"Starting install now.");

                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    DebugLogger.Log($"Successfully installed {currentSelectedGame} files.");

                    MessageBox.Show($"{currentSelectedGame} has been fully installed.");
                }
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files have already been installed.");
            MessageBox.Show($"{currentSelectedGame} files have already been installed.");
        }

        DebugLogger.Break();
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            MessageBox.Show("Please select a game before proceeding.");

            return;
        }

        DebugLogger.Log($"Preparing {currentSelectedGame} uninstall process.");

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} directory has been found.");

            DialogResult result = MessageBox.Show($"Are you sure you would like to uninstall {currentSelectedGame}?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DebugLogger.Log($"Starting uninstall now.");

                if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    DebugLogger.Log($"Successfuly uninstalled {currentSelectedGame} files");

                    MessageBox.Show($"{currentSelectedGame} has been fully uninstalled.");
                }
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed");
            MessageBox.Show($"{currentSelectedGame} has not been installed");
        }

        DebugLogger.Break();
    }

    private void gameListView_Click(object sender, EventArgs e)
    {
        ListViewItem item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;

        DebugLogger.Log($"Current game selected: {item.Text}");
    }

    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            gameFilePathTextBox.Text = diag.SelectedPath;
            DebugLogger.Log($"Current game filepath: {diag.SelectedPath}");
        }
    }
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            DebugLogger.Log($"{NetworkTools.Username} disconnected from {NetworkTools.ServerIP}.");

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

    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        if(profileForm != null)
        {
            if (restrict == 0)
            {
                DebugLogger.Log($"Accessing {NetworkTools.Username} profile.");

                restrict++;
                profileForm.ShowDialog();
            }
            else
                profileForm.Close();
        }

        DebugLogger.Break();
    }

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
