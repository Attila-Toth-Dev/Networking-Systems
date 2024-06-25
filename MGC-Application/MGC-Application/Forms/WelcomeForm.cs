namespace MGC_Application;

public partial class WelcomeForm : Form
{
    public static string logPathFile = @"";
    public static string usersPathFile = @"";
    public static string gamesPathFile = @"";

    public WelcomeForm()
    {
        InitializeComponent();

        logPathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        logPathFile = $@"{logPathFile}\MGC-Data";

        usersPathFile = $@"{logPathFile}\Users";

        gamesPathFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        gamesPathFile = $@"{gamesPathFile}\Games";

        FileTools.CreateDirectory(logPathFile, true);
        FileTools.CreateDirectory(usersPathFile);
        FileTools.CreateDirectory(gamesPathFile);
    }

    #region UI Events

    /// <summary>Event for load bar timer tick.</summary>
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

    /// <summary>Event for welcome form close.</summary>
    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close the application.
        Application.Exit();
    }

    #endregion
}
