using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class WelcomeForm : Form
{
    public static string LogPathFile = @"";
    public static string UsersPathFile = @"";

    public static string GamesDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/MGC-Games";
    public static string DataDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/MGC-Data";

    public WelcomeForm()
    {
        InitializeComponent();

        LogPathFile = $@"{DataDirectory}/";
        UsersPathFile = $@"{DataDirectory}/";

        if (!Directory.Exists(DataDirectory))
            FileTools.CreateDirectory(DataDirectory, true);

        if(!Directory.Exists(GamesDirectory))
            FileTools.CreateDirectory(GamesDirectory);
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
    private void WelcomeForm_Closed(object _sender, FormClosedEventArgs e)
    {
        // close the application.
        Application.Exit();
    }

    #endregion
}
