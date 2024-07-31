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

    public string GamePathFile => gameFilePathTextBox.Text;

    public bool IsInProcess { get; set; }

    #endregion
    
    private readonly ProfileForm profileForm;
    private readonly PropertiesForm propertiesForm;

    private string username;
    private string currentSelectedGame;


    public MainMenuForm(string _username, string _password)
    {
        InitializeComponent();

        currentSelectedGame = string.Empty;
        gameFilePathTextBox.Text = WelcomeForm.GamesDirectory;
        installedIcon.BackColor = Color.Gray;

        cancelButton.Enabled = false;

        propertiesForm = new PropertiesForm(this);
        profileForm = new ProfileForm(this);

        username = _username;

        welecomeLabel.Text = $"{_username}'s Library";

        FileTools.ShowDialogMessage($"Welcome to the MGC Client Launcher {username}!");
    }

    #region UI Event Functions

    /// <summary>Event for the game list view click.</summary>
    private void gameListView_Click(object sender, EventArgs e)
    {
        // current selected game is the game that has been
        // selected in list views name.
        var item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;
        FileTools.CurrentGame = currentSelectedGame;

        // verify if game has been installed in location.
        // if true, set game installed? icon colour to green.
        // if false, set game installed? icon colour to red.
        installedIcon.BackColor = FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text)
            ? Color.Green : Color.Red;
    }

    /// <summary>Event for the game folder path button click.</summary>
    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        // allow users to change install location path file
        // with opening a dialog browser.
        using var diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            // set the pathfile text to the designated path chosen
            // by the player.
            gameFilePathTextBox.Text = diag.SelectedPath;
            Debug.Log($"Current game filepath: {gameFilePathTextBox.Text} (Line 80)");
        }
    }

    /// <summary>Event for the logout tool strip menu item click.</summary>
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // show a decision dialog box for player
        // to choose if they would like to log out or not.
        var result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        // if true, close the main menu application,
        // then open the login form menu.
        if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
        {
            Debug.Log($"{Networking.Username} disconnected from {Networking.ServerIp}. (Line 97)");

            this.Hide();

            var form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event for the exit tool strip menu item click.</summary>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // show a decision dialog box for player
        // to choose if they would like to exit the application.
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        // if true, then close the application.
        if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
            Application.Exit();
    }

    /// <summary>Event for the profile picture box click.</summary>
    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        profileForm.ShowDialog();

        Debug.Break();
    }

    /// <summary>Event for main menu form close.</summary>
    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close the application,
        Application.Exit();
    }

    #endregion

    #region Button Event Functions

    /// <summary>Event for play button click.</summary>
    private void playButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to run.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 165)", 1);
            return;
        }

        // check to see if the game has been installed.
        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if game is installed,
            // run the current selected game .exe.
            if (FileTools.ExecuteGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
                FileTools.ShowDialogMessage($"Running {currentSelectedGame}.exe");
        }
        else
        {
            // else, prompt the user that files,
            // do not appear to be installed.
            FileTools.ShowDialogMessage($"{currentSelectedGame} files are missing. (Line 183)", 2);
        }

        Debug.Break();
    }

    /// <summary>Event for update button click.</summary>
    private void updateButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to update.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 196)");
            return;
        }

        // check to see if game has already been installed.
        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if installed, grab the file size of the local copy of the game,
            // and also grab the file size of the remote hosts copy of the game.
            long localFileLength = new FileInfo($"{gameFilePathTextBox.Text}/{currentSelectedGame}.zip").Length;
            long remoteFileLength = Networking.ValidateUpdate(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/");

            // if both have the same size, return no update.
            if (localFileLength == remoteFileLength)
                FileTools.ShowDialogMessage($"There is currently no update available for {currentSelectedGame}. (Line 212)");

            // if there is a difference size wise comparing to remote copy.
            if (localFileLength < remoteFileLength || localFileLength > remoteFileLength)
            {
                // check if the threaded worker is busy.
                if (updateWorker.IsBusy != true)
                {
                    // then prompt the user if they would like to update,
                    DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                    $"Update available for {currentSelectedGame}, would you like to update now?", true);
                    result.ShowDialog();

                    // if true, start the updating process on a different thread.
                    // if false, return and remove the prompt.
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

    /// <summary>Event for install button click.</summary>
    private void installButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to install.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 249)", 1);
            return;
        }

        // check to see if the game has not been installed,
        // if false, prompt user saying files have already been found.
        if (!FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if thread is not busy, start the install process
            // on the install thread.
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

    /// <summary>Event for uninstall button click.</summary>
    private void uninstallButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to uninstall.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 283)", 1);
            return;
        }

        // check to see if the game has been installed,
        // if false, prompt user saying game has not been installed.
        if (FileTools.VerifyGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // prompt user asking if they are certain on uninstalling.
            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();

            // if true, uninstall the game.zip and the game directory
            // from the install path file location.
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

    /// <summary>Event for cancel button click.</summary>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        // if true, cancel background process,
        // else, return prompt to user.
        if (updateWorker.IsBusy == true || installWorker.IsBusy == true)
        {
            updateWorker.CancelAsync();
            installWorker.CancelAsync();
        }
        else
            FileTools.ShowDialogMessage("There are no on-going processes running in the background, aborting process. (Line 330)", 1);
    }

    /// <summary>Event for properties button click.</summary>
    private void propertiesButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to access properties window. 
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

    /// <summary>Event for update worker do work.</summary>
    private void updateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        // check to see if there is a cancellation
        // pending from the user
        if (updateWorker.CancellationPending)
        {
            FileTools.ShowDialogMessage("Cancelled Update.");
            IsInProcess = false;
            e.Cancel = true;
        }

        // when updating, remove the .zip file and
        // main game directory from install location.
        if (FileTools.UninstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text))
        {
            Debug.Log($"Removed old instance of {currentSelectedGame} games files.");
            updateWorker.ReportProgress(0);

            // check to see if there is a cancellation
            // pending from the user
            if (updateWorker.CancellationPending)
            {
                FileTools.ShowDialogMessage("Cancelled Update.");
                IsInProcess = false;
                e.Cancel = true;
            }

            // once completely uninstalled, download the new copy
            // of the updated game.
            if (Networking.DownloadGameFiles(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/") && !updateWorker.CancellationPending)
            {
                Debug.Log($"Downloaded newer updated copy of {currentSelectedGame} games files.");
                updateWorker.ReportProgress(0);

                // check to see if there is a cancellation
                // pending from the user
                if (updateWorker.CancellationPending)
                {
                    FileTools.ShowDialogMessage("Cancelled Update.");
                    IsInProcess = false;
                    e.Cancel = true;
                }

                // then "install" the new copy by extracting
                // the .zip file.
                if (FileTools.InstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending) { }
                Debug.Log($"Successfully reinstalled {currentSelectedGame} game files.");
            }
        }
    }

    /// <summary>Event for update worker progress change.</summary>
    private void updateWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        // change progress value on report progress by 30.
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for update worker work complete.</summary>
    private void updateWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        // when complete, prompt user telling game has finished updating
        // and change the progress bar value to 100%
        // then reset the bar and re-enable buttons.
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

    /// <summary>Event for install worker do work.</summary>
    private void installWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        // check to see if there is a cancellation
        // pending requested by the user.
        if (installWorker.CancellationPending)
        {
            FileTools.ShowDialogMessage("Installation Cancelled.");
            IsInProcess = false;
            e.Cancel = true;
        }

        // prompt user letting them know game install
        // will commence.
        FileTools.ShowDialogMessage($"Starting download and install process for {currentSelectedGame}.");
        installWorker.ReportProgress(0);

        // then download the copy of the game from
        // the remote host.
        if (Networking.DownloadGameFiles(currentSelectedGame, $"ftp://{Networking.ServerIp}/Games/") && !updateWorker.CancellationPending)
        {
            Debug.Log($"Install worker cancel request: {e.Cancel}");

            // check to see if there is a cancellation
            // pending requested by the user.
            if (installWorker.CancellationPending)
            {
                FileTools.ShowDialogMessage("Installation Cancelled.");
                IsInProcess = false;
                e.Cancel = true;
            }

            Debug.Log($"Successfuly downloaded files from server.");
            Debug.Log($"Starting install now.");
            installWorker.ReportProgress(0);

            // then "install" the freshly downloaded .zip file.
            if (FileTools.InstallGameFiles(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
                installedIcon.BackColor = Color.Green;
        }
    }

    /// <summary>Event for install worker progress change.</summary>
    private void installWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        // change progress value on report progress by 30.
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for install worker work complete.</summary>
    private void installWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        // when complete, prompt user telling game has finished installing
        // and change the progress bar value to 100%
        // then reset the bar and re-enable buttons.
        progressBar.Value = 100;
        percentLabel.Text = $"{progressBar.Value}%";

        FileTools.ShowDialogMessage($"Succesfully installed {currentSelectedGame} game files.");

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
