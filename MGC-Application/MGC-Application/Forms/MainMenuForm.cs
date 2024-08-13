using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class MainMenuForm : Form
{
    #region Getters/Setters

    public Image ProfileIcon
    {
        get => profilePictureBox.Image;
        set => profilePictureBox.Image = value;
    }

    public string CurrentGame
    {
        get => currentSelectedGame;
        set => currentSelectedGame = value;
    }

    public string GamePathFile => gameFilePathTextBox.Text;

    public bool IsInProcess { get; set; }

    #endregion
    
    private readonly ProfileForm profileForm;
    private readonly PropertiesForm propertiesForm;

    private readonly string username;
    private string currentSelectedGame;

    public MainMenuForm(string _username)
    {
        InitializeComponent();

        username = _username;

        currentSelectedGame = string.Empty;
        gameFilePathTextBox.Text = FileTools.GamesDirectory;
        installedIcon.BackColor = Color.Gray;

        cancelButton.Enabled = false;

        propertiesForm = new PropertiesForm(this);
        profileForm = new ProfileForm(this, username);

        welecomeLabel.Text = $"{_username}'s Library";

        FileTools.ShowDialogMessage($"Welcome to the MGC Client Launcher {username}!");
    }

    #region UI Event Functions

    private void gameListView_Click(object sender, EventArgs e)
    {
        var item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;

        installedIcon.BackColor = FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text)
            ? Color.Green : Color.Red;
    }

    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        using var diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            gameFilePathTextBox.Text = diag.SelectedPath;
            Debug.Log($"Current game filepath: {gameFilePathTextBox.Text} (Line 80)");
        }
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
        {
            Debug.Log($"{Networking.Username} disconnected from {Networking.ServerIp}. (Line 97)");

            this.Hide();

            var form = new LoginForm();
            form.Show();
        }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
            Application.Exit();
    }

    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        profileForm.ShowDialog();

        Debug.Break();
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
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 165)", 1);
            return;
        }

        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            if (FileTools.ExecuteGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
                FileTools.ShowDialogMessage($"Running {currentSelectedGame}.exe");
        }
        else
        {
            FileTools.ShowDialogMessage($"{currentSelectedGame} files are missing. (Line 183)", 2);
        }

        Debug.Break();
    }
    
    private void updateButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 196)");
            return;
        }

        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            long localFileLength = new FileInfo($"{gameFilePathTextBox.Text}/{currentSelectedGame}.zip").Length;
            long remoteFileLength = Networking.ValidateUpdate(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/");

            if (localFileLength == remoteFileLength)
                FileTools.ShowDialogMessage($"There is currently no update available for {currentSelectedGame}. (Line 212)");

            if (localFileLength < remoteFileLength || localFileLength > remoteFileLength)
            {
                if (updateWorker.IsBusy != true)
                {
                    DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                    $"Update available for {currentSelectedGame}, would you like to update now?", true);
                    result.ShowDialog();

                    if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
                    {
                        Debug.Log($"Starting update process now...");

                        IsInProcess = true;

                        updateButton.Enabled = false;
                        installButton.Enabled = false;
                        uninstallButton.Enabled = false;

                        updateWorker.RunWorkerAsync();
                    }
                }
                else
                    FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background. (Line 235)", 2);
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed. (Line 239)", 1);
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 249)", 1);
            return;
        }

        if (!FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            if (installWorker.IsBusy != true)
            {
                Debug.Log($"Starting install process now...");

                IsInProcess = true;

                installButton.Enabled = false;
                updateButton.Enabled = false;
                uninstallButton.Enabled = false;

                installWorker.RunWorkerAsync();
            }
            else
                FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background. (Line 270)");
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have already been installed. (Line 273)", 1);
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 283)", 1);
            return;
        }

        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();

            if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
            {
                Debug.Log("Starting uninstall process now...");

                if (FileTools.UninstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    progressBar.Value = 100;
                    percentLabel.Text = $"{progressBar.Value}%";

                    FileTools.ShowDialogMessage($"Successfully uninstalled {currentSelectedGame} game files. (Line 305)");
                    installedIcon.BackColor = Color.Red;

                    progressBar.Value = 0;
                    percentLabel.Text = $"{progressBar.Value}%";
                }
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed. (Line 314)", 2);

        Debug.Break();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        if (updateWorker.IsBusy == true || installWorker.IsBusy == true)
        {
            updateWorker.CancelAsync();
            installWorker.CancelAsync();
        }
        else
            FileTools.ShowDialogMessage("There are no on-going processes running in the background, aborting process. (Line 330)", 1);
    }

    private void propertiesButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 340)", 1);
            return;
        }
        else
            propertiesForm.ShowDialog();

        Debug.Break();
    }

    #endregion

    #region Worker Events

    private void updateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (updateWorker.CancellationPending)
        {
            FileTools.ShowDialogMessage("Cancelled Update.");
            IsInProcess = false;
            e.Cancel = true;
        }

        if (FileTools.UninstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            Debug.Log($"Removed old instance of {currentSelectedGame} games files.");
            updateWorker.ReportProgress(0);

            if (updateWorker.CancellationPending)
            {
                FileTools.ShowDialogMessage("Cancelled Update.");
                IsInProcess = false;
                e.Cancel = true;
            }

            if (Networking.DownloadGameFiles(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/") && !updateWorker.CancellationPending)
            {
                Debug.Log($"Downloaded newer updated copy of {currentSelectedGame} games files.");
                updateWorker.ReportProgress(0);

                if (updateWorker.CancellationPending)
                {
                    FileTools.ShowDialogMessage("Cancelled Update.");
                    IsInProcess = false;
                    e.Cancel = true;
                }

                if (FileTools.InstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending) { }
                Debug.Log($"Successfully reinstalled {currentSelectedGame} game files.");
            }
        }
    }

    private void updateWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    private void updateWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        progressBar.Value = 100;
        percentLabel.Text = $"{progressBar.Value}%";

        FileTools.ShowDialogMessage($"Succesfully updated {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        IsInProcess = false;

        updateButton.Enabled = true;
        installButton.Enabled = true;
        uninstallButton.Enabled = true;

        Debug.Break();
    }

    private void installWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (installWorker.CancellationPending)
        {
            FileTools.ShowDialogMessage("Installation Cancelled.");
            IsInProcess = false;
            e.Cancel = true;
        }

        FileTools.ShowDialogMessage($"Starting download and install process for {currentSelectedGame}.");
        installWorker.ReportProgress(0);

        if (Networking.DownloadGameFiles(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/") && !updateWorker.CancellationPending)
        {
            Debug.Log($"Install worker cancel request: {e.Cancel}");

            if (installWorker.CancellationPending)
            {
                FileTools.ShowDialogMessage("Installation Cancelled.");
                IsInProcess = false;
                e.Cancel = true;
            }

            Debug.Log("Successfuly downloaded files from server.");
            Debug.Log("Starting install now.");
            installWorker.ReportProgress(0);

            if (FileTools.InstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
                installedIcon.BackColor = Color.Green;
        }
    }

    private void installWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    private void installWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        progressBar.Value = 100;
        percentLabel.Text = $"{progressBar.Value}%";

        FileTools.ShowDialogMessage($"Successfully installed {currentSelectedGame} game files.");

        progressBar.Value = 0;
        percentLabel.Text = $"{progressBar.Value}%";

        IsInProcess = false;

        installButton.Enabled = true;
        updateButton.Enabled = true;
        uninstallButton.Enabled = true;

        Debug.Break();
    }

    #endregion
}
