namespace MGC_Application;

public partial class WelcomeForm : Form
{
    private int counter = 1;

    /// <summary>Constructor for Welcome Form</summary>
    public WelcomeForm() => InitializeComponent();

    /// <summary>Event function for load bar time tick.</summary>
    private void loadBarTimer_Tick(object sender, EventArgs e)
    {
        loadingValueLabel.Text = $"{loadingProgressBar.Value}%";
        loadingProgressBar.Value += 5;

        if (loadingProgressBar.Value <= 10)
            CreateGameDirectories("Games", "Logs");

        if (loadingProgressBar.Value >= loadingProgressBar.Maximum)
        {
            DebugLogger.WriteStartupLog();

            loadBarTimer.Enabled = false;
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event function for secret picture box click.</summary>
    private void secretPictureBox_Click(object sender, EventArgs e)
    {
        counter += 1;

        if (counter == 3)
        {
            loadBarTimer.Enabled = false;
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    /// <summary>Event function for welcome form closed.</summary>
    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e)
    {
        DebugLogger.WriteClosingLog();
        Application.Exit();
    }

    /// <summary>Function for Creating Directories upon intialization of launcher.</summary>
    /// <param name="_folderName">The name of the folder to be made.</param>
    private void CreateGameDirectories(string _gameFolder, string _logFolder)
    {
        string gameDir = @$"{_gameFolder}";
        string logDir = @$"{_logFolder}";

        if (!Directory.Exists(gameDir) || !Directory.Exists(logDir))
        {
            Directory.CreateDirectory(gameDir);
            Directory.CreateDirectory(logDir);
        }
    }
}
