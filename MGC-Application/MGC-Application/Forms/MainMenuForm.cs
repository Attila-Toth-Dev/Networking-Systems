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
        if(FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} files have been found.");
            
            if(FileTools.Run(currentSelectedGame, gameFilePathTextBox.Text))
                DebugLogger.Log($"Running .exe file now.");
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
    }

    private void installButton_Click(object sender, EventArgs e)
    {
        if(!FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} has not been installed.");
            
            if(FileTools.Install(currentSelectedGame, gameFilePathTextBox.Text))
                DebugLogger.Log($"Installing {currentSelectedGame} files now.");
        }
    }

    private void uninstallButton_Click(object sender, EventArgs e)
    {
        if (FileTools.VerifyGameLocation(currentSelectedGame, gameFilePathTextBox.Text))
        {
            DebugLogger.Log($"{currentSelectedGame} have been found.");
            
            if(FileTools.Uninstall(currentSelectedGame, gameFilePathTextBox.Text))
                DebugLogger.Log($"Uninstalling {currentSelectedGame} and files now.");
        }
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
