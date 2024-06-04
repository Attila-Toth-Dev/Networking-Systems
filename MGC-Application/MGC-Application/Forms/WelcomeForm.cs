namespace MGC_Application;

public partial class WelcomeForm : Form
{
    public static string logPathFile = @"Logs";
    public static string usersPathFile = @"Users";
    public static string gamesPathFile = @"";

    public WelcomeForm()
    {
        InitializeComponent();

        logPathFile = Environment.ExpandEnvironmentVariables(logPathFile);

        gamesPathFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        gamesPathFile = $@"{gamesPathFile}\Games";

        FileTools.CreateDirectory(logPathFile, true);
        FileTools.CreateDirectory(usersPathFile);
        FileTools.CreateDirectory(gamesPathFile);
    }

    #region UI Events

    /// <summary>Event for loadBarTimer tick.</summary>
    private void loadBarTimer_Tick(object sender, EventArgs e)
    {
        // change the progress bar load up value
        // using the timer tick.
        loadingValueLabel.Text = $"{loadingProgressBar.Value}%";
        loadingProgressBar.Value += 10;

        // when loading bar is maximum, open up login form.
        if (loadingProgressBar.Value >= loadingProgressBar.Maximum)
        {
            loadBarTimer.Enabled = false;
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    #endregion

    /// <summary>Event for WelcomeForm close.</summary>
    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close the application.
        Application.Exit();
    }
}
