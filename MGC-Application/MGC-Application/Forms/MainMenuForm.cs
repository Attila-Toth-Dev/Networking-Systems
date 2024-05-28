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

    public string currentSelectedGame;

    private ProfileForm profileForm;
    private PropertiesForm propertiesForm;

    private int profileRestrict;
    private int propertiesRestrict;

    public MainMenuForm()
    {
        InitializeComponent();

        profileForm = new ProfileForm(this);
        propertiesForm = new PropertiesForm(this);
        
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

        // verify if game has been installed in location.
        // if true, set game installed? icon colour to green.
        // if false, set game installed? icon colour to red.
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
            installedIcon.BackColor = Color.Green;
        else
            installedIcon.BackColor = Color.Red;

        DebugLogger.Log($"Current game selected: {item.Text}");
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
            DebugLogger.Log($"Current game filepath: {gameFilePathTextBox.Text}");
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
        // show a decision dialog box for player
        // to choose if they would like to exit the application.
        DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
            "Are you sure you want to logout?", true);
        result.ShowDialog();

        // if true, then close the application.
        if (result.DecisionValue == 1)
            Application.Exit();
    }

    /// <summary>Event for the profilePictureBox click.</summary>
    private void profilePictureBox_Click(object sender, EventArgs e)
    {
        // when user clicks on profile icon, make sure the program
        // is able to only open up one profile menu, this eases memory usage.
        if (profileForm != null)
        {
            // if true, open the profile form menu as a dialog.
            // if false, if restrict value > 0 then prevent from opening another
            // profile menu dialog form.
            if (profileRestrict == 0)
            {
                DebugLogger.Log($"Accessing {NetworkTools.Username} profile.");

                profileRestrict++;
                profileForm.ShowDialog();
            }
            else
                profileForm.Close();
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
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        // check to see if the game has been installed.
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");

            // if game is installed,
            // run the current selected game .exe.
            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
                FileTools.ShowDialogMessage($"Running {currentSelectedGame}.exe");
        }
        else
        {
            // else, prompt the user that files,
            // do not appear to be installed.
            FileTools.ShowDialogMessage($"{currentSelectedGame} files are missing.", 2);
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
            FileTools.ShowDialogMessage($"Please select a game before proceeding.");
            return;
        }

        // check to see if game has already been installed.
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have been found.");

            // if installed, grab the file size of the local copy of the game,
            // and also grab the file size of the remote hosts copy of the game.
            long localFileLength = new FileInfo($"{gameFilePathTextBox.Text}/{currentSelectedGame}.zip").Length;
            long remoteFileLength = NetworkTools.CheckForUpdate(currentSelectedGame);

            // if both have the same size, return no update.
            if (localFileLength == remoteFileLength)
                FileTools.ShowDialogMessage($"There is currently no update available for {currentSelectedGame}.");

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
                    if (result.DecisionValue == 1)
                    {
                        updateButton.Enabled = false;
                        installButton.Enabled = false;

                        updateWorker.RunWorkerAsync();
                    }
                }
                else
                    FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background.", 2);
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have not been installed.", 1);
    }

    /// <summary>Event for installButton click.</summary>
    private void installButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to install.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        // check to see if the game has not been installed,
        // if false, prompt user saying files have already been found.
        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have not been found.");

            // if thread is not busy, start the install process
            // on the install thread.
            if (installWorker.IsBusy != true)
            {
                installButton.Enabled = false;
                updateButton.Enabled = false;

                installWorker.RunWorkerAsync();
            }
            else
                FileTools.ShowDialogMessage($"Could not perform task as there are already processes running in the background.");
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} game files have already been installed.", 1);
    }

    /// <summary>Event for uninstallButton click.</summary>
    private void uninstallButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to uninstall.
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        // check to see if the game has been installed,
        // if false, prompt user saying game has not been installed.
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} game files have been found.");

            // prompt user asking if they are certain on uninstalling.
            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();

            // if true, uninstall the game.zip and the game directory
            // from the install path file location.
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

    /// <summary>Event for cancelButton click.</summary>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        // if true, cancel background process,
        // else, return prompt to user.
        if (updateWorker.IsBusy == true || installWorker.IsBusy == true)
        {
            updateWorker.CancelAsync();
            installWorker.CancelAsync();

            // abort ftp processes going on.
            // and uninstall the downloaded zip to avoid conflict errors.
            //NetworkTools.request?.Abort();
            // make so we wait for worker stop confirmation,
            // then unistall file.
            //FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text);
        }
        else
            FileTools.ShowDialogMessage("There are no on-going processes running in the background, aborting process.", 1);
    }

    /// <summary>Event for propertiesButton click.</summary>
    private void propertiesButton_Click(object sender, EventArgs e)
    {
        // if a game has not been selected, then prompt user to
        // select a game to access properties window. 
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            FileTools.ShowDialogMessage($"Please select a game before proceeding.", 1);
            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            // when user clicks on profile icon, make sure the program
            // is able to only open up one profile menu, this eases memory usage.
            if (propertiesForm != null)
            {
                // if true, open the profile form menu as a dialog.
                // if false, if restrict value > 0 then prevent from opening another
                // profile menu dialog form.
                if (propertiesRestrict == 0)
                {
                    DebugLogger.Log($"Accessing {currentSelectedGame} properties window.");

                    propertiesRestrict++;
                    propertiesForm.ShowDialog();
                }
                else
                    propertiesForm.Close();
            }
        }
        else
            FileTools.ShowDialogMessage($"{currentSelectedGame} is not installed or has not been found. Please install and try again.", 1);

        DebugLogger.Break();
    }

    #endregion

    #region Worker Events

    /// <summary>Event for updateWorker do work.</summary>
    private void updateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        // when updating, remove the .zip file and
        // main game directory from install location.
        if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
        {
            updateWorker.ReportProgress(0);
            DebugLogger.Log($"Removed old instance of {currentSelectedGame} games files.");

            // once completely uninstalled, download the new copy
            // of the updated game.
            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame) && !updateWorker.CancellationPending)
            {
                updateWorker.ReportProgress(0);
                DebugLogger.Log($"Downloaded newer updated copy of {currentSelectedGame} games files.");

                // then "install" the new copy by extracting
                // the .zip file.
                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
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

        updateButton.Enabled = true;
        installButton.Enabled = true;

        DebugLogger.Break();
    }

    /// <summary>Event for installWorker do work.</summary>
    private void installWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (installWorker.CancellationPending)
            e.Cancel = true;

        // prompt user letting them know game install
        // will commence.
        FileTools.ShowDialogMessage($"Starting download and install process for {currentSelectedGame}.");
        installWorker.ReportProgress(0);

        // then download the copy of the game from
        // the remote host.
        if (NetworkTools.DownloadGameFromFtp(currentSelectedGame) && !updateWorker.CancellationPending)
        {
            if (installWorker.CancellationPending)
                e.Cancel = true;

            installWorker.ReportProgress(0);
            DebugLogger.Log($"Successfuly downloaded files from server.");
            DebugLogger.Log($"Starting install now.");

            // then "install" the freshly downloaded .zip file.
            if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text) && !updateWorker.CancellationPending)
            {
                if (installWorker.CancellationPending)
                    e.Cancel = true;

                installWorker.ReportProgress(0);
                installedIcon.BackColor = Color.Green;
            }
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

        installButton.Enabled = true;
        updateButton.Enabled = true;

        DebugLogger.Break();
    }

    #endregion
}
