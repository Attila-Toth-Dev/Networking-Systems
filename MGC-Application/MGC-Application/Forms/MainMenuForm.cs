using MGC_Application.Forms;

namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public Image ProfileIcon
    {
        get => profilePictureBox.Image;
        set => profilePictureBox.Image = value;
    }

    public int ProfileRestrict
    {
        get => profileRestrict;
        set => profileRestrict = value;
    }

    public int PropertiesRestrict
    {
        get => propertiesRestrict;
        set => propertiesRestrict = value;
    }

    public string GamePathFile { get => gameFilePathTextBox.Text; }

    public bool IsInProcess { get; set; }

    private string currentSelectedGame;

    private int profileRestrict;
    private int propertiesRestrict;

    public MainMenuForm()
    {
        InitializeComponent();

        profileRestrict = 0;
        propertiesRestrict = 0;

        currentSelectedGame = string.Empty;
        gameFilePathTextBox.Text = WelcomeForm.gamesPathFile;

        installedIcon.BackColor = Color.Gray;

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    #region UI Event Functions

    /// <summary>Event for the gameListView click.</summary>
    private void gameListView_Click(object sender, EventArgs e)
    {
        // current selected game is the game that has been
        // selected in list views name.
        ListViewItem item = gameListView.SelectedItems[0];
        currentSelectedGame = item.Text;
        FileTools.currentGame = currentSelectedGame;

        // verify if game has been installed in location.
        // if true, set game installed? icon colour to green.
        // if false, set game installed? icon colour to red.
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
            installedIcon.BackColor = Color.Green;
        else
            installedIcon.BackColor = Color.Red;
    }

    /// <summary>Event for the gameFolderPathButton click.</summary>
    private void gameFolderPathButton_Click(object sender, EventArgs e)
    {
        // allow users to change install location path file
        // with opening a dialog browser.
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            // set the pathfile text to the designated path chosen
            // by the player.
            gameFilePathTextBox.Text = diag.SelectedPath;
            DebugLogger.Log($"Current game filepath: {gameFilePathTextBox.Text} (Line 80)");
        }
    }

    /// <summary>Event for the logoutToolStripMenuItem click.</summary>
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // show a decision dialog box for player
        // to choose if they would like to log out or not.
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        // if true, close the main menu application,
        // then open the login form menu.
        if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
        {
            DebugLogger.Log($"{NetworkTools.Username} disconnected from {NetworkTools.ServerIP}. (Line 97)");

            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event for the exitToolStripMenuItem click.</summary>
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

    /// <summary>Event for the profilePictureBox click.</summary>
    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        using (ProfileForm profile = new ProfileForm(this))
        {
            // when user clicks on profile icon, make sure the program
            // is able to only open up one profile menu, this eases memory usage.
            if (profile != null)
            {
                // if true, open the profile form menu as a dialog.
                // if false, if restrict value > 0 then prevent from opening another
                // profile menu dialog form.
                if (profileRestrict == 0)
                {
                    profileRestrict++;
                    profile.ShowDialog();
                }
                else
                    profile.Close();
            }
        }

        DebugLogger.Break();
    }

    /// <summary>Event for MainMenuForm close.</summary>
    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close the application,
        Application.Exit();
    }

    #endregion

    #region Button Event Functions

    /// <summary>Event for playButton click.</summary>
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
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if game is installed,
            // run the current selected game .exe.
            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
                FileTools.ShowDialogMessage($"Running {currentSelectedGame}.exe");
        }
        else
        {
            // else, prompt the user that files,
            // do not appear to be installed.
            FileTools.ShowDialogMessage($"{currentSelectedGame} files are missing. (Line 183)", 2);
        }

        DebugLogger.Break();
    }

    /// <summary>Event for updateButton click.</summary>
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
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if installed, grab the file size of the local copy of the game,
            // and also grab the file size of the remote hosts copy of the game.
            long localFileLength = new FileInfo($"{gameFilePathTextBox.Text}/{currentSelectedGame}.zip").Length;
            long remoteFileLength = NetworkTools.CheckForUpdate(currentSelectedGame);

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
                        DebugLogger.Log($"Starting update process now...");

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

    /// <summary>Event for installButton click.</summary>
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
        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // if thread is not busy, start the install process
            // on the install thread.
            if (installWorker.IsBusy != true)
            {
                DebugLogger.Log($"Starting install process now...");

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

    /// <summary>Event for uninstallButton click.</summary>
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
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // prompt user asking if they are certain on uninstalling.
            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();

            // if true, uninstall the game.zip and the game directory
            // from the install path file location.
            if (result.DecisionValue == DialogBoxForm.BoolValue.YES)
            {
                DebugLogger.Log("Starting uninstall process now...");

                if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
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

        DebugLogger.Break();
    }

    /// <summary>Event for cancelButton click.</summary>
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

    /// <summary>Event for propertiesButton click.</summary>
    private void propertiesButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to access properties window. 
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding. (Line 340)", 1);
            return;
        }

        using (PropertiesForm properties = new PropertiesForm(this))
        {
            // when user clicks on profile icon, make sure the program
            // is able to only open up one profile menu, this eases memory usage.
            if (properties != null)
            {
                // if true, open the profile form menu as a dialog.
                // if false, if restrict value > 0 then prevent from opening another
                // profile menu dialog form.
                if (propertiesRestrict == 0)
                {
                    propertiesRestrict++;
                    properties.ShowDialog();
                }
                else
                    properties.Close();
            }
        }

        DebugLogger.Break();
    }

    #endregion

    #region Worker Events

    /// <summary>Event for updateWorker do work.</summary>
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
        if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
        {
            //DebugLogger.Log($"Removed old instance of {currentSelectedGame} games files.");
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
            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame) && !updateWorker.CancellationPending)
            {
                //DebugLogger.Log($"Downloaded newer updated copy of {currentSelectedGame} games files.");
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
                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending) { }
                    //DebugLogger.Log($"Successfully reinstalled {currentSelectedGame} game files.");
            }
        }
    }

    /// <summary>Event for updateWorker progress change.</summary>
    private void updateWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        // change progress value on report progress by 30.
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for updateWorker work complete.</summary>
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

        DebugLogger.Break();
    }

    /// <summary>Event for installWorker do work.</summary>
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
        if (NetworkTools.DownloadGameFromFtp(currentSelectedGame) && !updateWorker.CancellationPending)
        {
            //DebugLogger.Log($"Install worker cancel request: {e.Cancel}");

            // check to see if there is a cancellation
            // pending requested by the user.
            if (installWorker.CancellationPending)
            {
                FileTools.ShowDialogMessage("Installation Cancelled.");
                IsInProcess = false;
                e.Cancel = true;
            }

            //DebugLogger.Log($"Successfuly downloaded files from server.");
            //DebugLogger.Log($"Starting install now.");
            installWorker.ReportProgress(0);

            // then "install" the freshly downloaded .zip file.
            if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
                installedIcon.BackColor = Color.Green;
        }
    }

    /// <summary>Event for installWorker progress change.</summary>
    private void installWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        // change progress value on report progress by 30.
        progressBar.Value += 30;
        percentLabel.Text = $"{progressBar.Value}%";
    }

    /// <summary>Event for installWorker work complete.</summary>
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

        DebugLogger.Break();
    }

    #endregion
}
