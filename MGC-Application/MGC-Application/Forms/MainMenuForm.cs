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
        installedIcon.BackColor = Color.Gray;

        updateWorker.WorkerReportsProgress = true;
        installWorker.WorkerReportsProgress = true;

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    #region UI Event Functions

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

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        if (result.DecisionValue == 1)
            Application.Exit();
    }

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

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    #endregion

    #region Button Event Functions

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

            if (updateWorker.IsBusy != true)
                updateWorker.RunWorkerAsync();
            
            else
                FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background.", 2);
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed.", 1);
    }

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
                    FileTools.ShowDialogMessage($"Successfully uninstalled {currentSelectedGame} game files.");
                    installedIcon.BackColor = Color.Red;
                }
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed.", 2);

        DebugLogger.Break();
    }

    #endregion

    #region Worker Events

    private void updateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        FileTools.ShowDialogMessage($"Starting update process for {currentSelectedGame}.");
    }

    private void updateWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        FileTools.ShowDialogMessage($"Succesfully updated {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        DebugLogger.Break();
    }

    private void installWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        FileTools.ShowDialogMessage($"Starting download and install process for {currentSelectedGame}.");

        if (NetworkTools.DownloadGameFromFtp(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"Successfuly downloaded files from server.");
            DebugLogger.Log($"Starting install now.");

            if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                installedIcon.BackColor = Color.Green;
        }
    }

    private void installWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        FileTools.ShowDialogMessage($"Succesfully installed {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        DebugLogger.Break();
    }

    #endregion
}
