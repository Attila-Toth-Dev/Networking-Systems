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

        welecomeLabel.Text = $"{NetworkTools.Username}'s Library";
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            DialogBoxForm dialog1 = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING, 
                "Please select a game before proceeding.");
            dialog1.ShowDialog();

            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");

            if (FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
            {
                DebugLogger.Log($"Running {currentSelectedGame}.exe");
                DialogBoxForm dialog2 = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE, 
                    $"Running {currentSelectedGame}.exe", 10);
                dialog2.ShowDialog();
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files are missing.");
            DialogBoxForm dialog3 = new DialogBoxForm(DialogBoxForm.MessageSeverity.ERROR,
                $"{currentSelectedGame} files are missing");
            dialog3.ShowDialog();
        }

        DebugLogger.Break();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            DialogBoxForm dialog1 = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                "Please select a game before proceeding.");
            dialog1.ShowDialog();

            return;
        }

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files are missing."); 
            DialogBoxForm dialog2 = new DialogBoxForm(DialogBoxForm.MessageSeverity.ERROR,
                $"{currentSelectedGame} files are missing");
            dialog2.ShowDialog();
        }

        DebugLogger.Break();
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            DialogBoxForm dialog1 = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                "Please select a game before proceeding.");
            dialog1.ShowDialog();

            return;
        }

        DebugLogger.Log($"Preparing {currentSelectedGame} install process.");

        DialogBoxForm dialog2 = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
                $"Starting {currentSelectedGame} download and install.");
        dialog2.ShowDialog();

        progressBar.Value = 10;
        installPercentLabel.Text = $"{progressBar.Value}%";

        if (!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed.");
            DebugLogger.Log($"Starting download now.");

            progressBar.Value = 20;
            installPercentLabel.Text = $"{progressBar.Value}%";

            if (NetworkTools.DownloadGameFromFtp(currentSelectedGame, gameFilePathTextBox.Text))
            {
                progressBar.Value = 60;
                installPercentLabel.Text = $"{progressBar.Value}%";

                DebugLogger.Log($"Successfuly downloaded files from server.");
                DebugLogger.Log($"Starting install now.");

                if (FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    progressBar.Value = 100;
                    installPercentLabel.Text = $"{progressBar.Value}%";

                    DebugLogger.Log($"Successfully installed {currentSelectedGame} files.");

                    DialogBoxForm dialog3 = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
                        $"{currentSelectedGame} has been fully installed.");
                    dialog3.ShowDialog();
                    
                    installedIcon.BackColor = Color.Green;
                }
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} files have already been installed.");
            
            DialogBoxForm dialog4 = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"{currentSelectedGame} files have already been installed.");
            dialog4.ShowDialog();
        }

        progressBar.Value = 0;
        installPercentLabel.Text = $"{progressBar.Value}%";

        DebugLogger.Break();
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(currentSelectedGame))
        {
            DebugLogger.Log($"Please select a game before proceeding.");
            DialogBoxForm dialog1 = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                "Please select a game before proceeding.");
            dialog1.ShowDialog();

            return;
        }

        DebugLogger.Log($"Preparing {currentSelectedGame} uninstall process.");

        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} directory has been found.");

            DialogBoxForm result = new DialogBoxForm(DialogBoxForm.MessageSeverity.WARNING,
                $"Are you sure you would like to uninstall {currentSelectedGame}?", true);
            result.ShowDialog();
            if (result.DecisionValue == 1)
            {
                DebugLogger.Log($"Starting uninstall now.");

                if (FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
                {
                    DebugLogger.Log($"Successfuly uninstalled {currentSelectedGame} files");

                    DialogBoxForm dialog2 = new DialogBoxForm(DialogBoxForm.MessageSeverity.MESSAGE,
                        $"{currentSelectedGame} has been fully uninstalled.");
                    dialog2.ShowDialog();

                    installedIcon.BackColor = Color.Red;
                }
            }
        }
        else
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed");

            DialogBoxForm dialog3 = new DialogBoxForm(DialogBoxForm.MessageSeverity.ERROR,
                $"{currentSelectedGame} files are missing");
            dialog3.ShowDialog();
        }

        DebugLogger.Break();
    }

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
        {
            Application.Exit();
        }
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
}
