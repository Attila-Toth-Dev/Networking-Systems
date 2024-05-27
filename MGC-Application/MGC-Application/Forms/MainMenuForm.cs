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

        gameFilePathTextBox.Text = WelcomeForm.gamesPathFile;
        installedIcon.BackColor = Color.Gray;

        updateWorker.WorkerReportsProgress = true;
        installWorker.WorkerReportsProgress = true;

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    #region UI Event Functions

    /// <summary>Event for the gameListView click.</summary>
    private void gameListView_Click(object sender, EventArgs e)
    {
        ListViewItem item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
            installedIcon.BackColor = Color.Green;
        else
            installedIcon.BackColor = Color.Red;

        DebugLogger.Log($"Current game selected: {item.Text}");
    }

    /// <summary>Event for the gameFolderPathButton click.</summary>
    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            gameFilePathTextBox.Text = diag.SelectedPath;
            DebugLogger.Log($"Current game filepath: {diag.SelectedPath}");
        }
    }

    /// <summary>Event for the logoutToolStripMenuItem click.</summary>
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        if (result.DecisionValue == 1)
        {
            DebugLogger.Log($"{NetworkTools.Username} disconnected from {NetworkTools.ServerIP}.");

            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event for the exitToolStripMenuItem click.</summary>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        if (result.DecisionValue == 1)
            Application.Exit();
    }

    /// <summary>Event for the profilePictureBox click.</summary>
    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        if (profileForm != null)
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

    /// <summary>Event for MainMenuForm close.</summary>
    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e) => Application.Exit();

    #endregion

    #region Button Event Functions

    /// <summary>Event for playButton click.</summary>
    private void playButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");

            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
                FileTools.ShowDialogMessage($"Running {currentSelectedGame}.exe");
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} files are missing.", 2);

        DebugLogger.Break();
    }

    /// <summary>Event for updateButton click.</summary>
    private void updateButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.");
            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have been found.");

            long localFileLength = new FileInfo($"{gameFilePathTextBox.Text}/{currentSelectedGame}.zip").Length;
            long remoteFileLength = NetworkTools.CheckForUpdate(currentSelectedGame);

            if (localFileLength == remoteFileLength)
            {

                FileTools.ShowDialogMessage($"There is currently no update available for {currentSelectedGame}.");
            }

            if (updateWorker.IsBusy != true)
            {
                if (localFileLength < remoteFileLength || localFileLength > remoteFileLength)
                {
                    DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                    $"Update available for {currentSelectedGame}, would you like to update now?", true);
                    result.ShowDialog();

                    if (result.DecisionValue == 1)
                        updateWorker.RunWorkerAsync();
                }
            }
            else
                FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background.", 2);
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed.", 1);
    }

    /// <summary>Event for installButton click.</summary>
    private void installButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have not been found.");

            if (installWorker.IsBusy != true)
                installWorker.RunWorkerAsync();

            else
                FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background.");
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have already been installed.", 1);
    }

    /// <summary>Event for uninstallButton click.</summary>
    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have been found.");

            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();

            if (result.DecisionValue == 1)
            {
                if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    progressBar.Value = 100;
                    percentLabel.Text = $"{progressBar.Value}%";

                    FileTools.ShowDialogMessage($"Successfully uninstalled {currentSelectedGame} game files.");
                    installedIcon.BackColor = Color.Red;

                    progressBar.Value = 0;
                    percentLabel.Text = $"{progressBar.Value}%";
                }
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed.", 2);

        DebugLogger.Break();
    }

    #endregion

    #region Worker Events

    /// <summary>Event for updateWorker do work.</summary>
    private void updateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
        {
            updateWorker.ReportProgress(0);
            DebugLogger.Log($"Removed old instance of {currentSelectedGame} games files.");

            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame))
            {
                updateWorker.ReportProgress(0);
                DebugLogger.Log($"Downloaded newer updated copy of {currentSelectedGame} games files.");

                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    updateWorker.ReportProgress(0);
                    DebugLogger.Log($"Successfully reinstalled {currentSelectedGame} game files.");
                }
            }
        }
    }

    /// <summary>Event for updateWorker progress change.</summary>
    private void updateWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for updateWorker work complete.</summary>
    private void updateWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        progressBar.Value = 100;
        percentLabel.Text = $"{progressBar.Value}%";

        FileTools.ShowDialogMessage($"Succesfully updated {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        DebugLogger.Break();
    }

    /// <summary>Event for installWorker do work.</summary>
    private void installWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        FileTools.ShowDialogMessage($"Starting download and install process for {currentSelectedGame}.");
        installWorker.ReportProgress(0);

        if (NetworkTools.DownloadGameFromFtp(currentSelectedGame))
        {
            DebugLogger.Log($"Successfuly downloaded files from server.");
            DebugLogger.Log($"Starting install now.");

            installWorker.ReportProgress(0);

            if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
            {
                installWorker.ReportProgress(0);
                installedIcon.BackColor = Color.Green;
            }
        }
    }

    /// <summary>Event for installWorker progress change.</summary>
    private void installWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for installWorker work complete.</summary>
    private void installWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        progressBar.Value = 100;
        percentLabel.Text = $"{progressBar.Value}%";

        FileTools.ShowDialogMessage($"Succesfully installed {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        DebugLogger.Break();
    }

    #endregion
}
