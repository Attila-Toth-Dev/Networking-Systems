namespace MGC_Application;

public partial class WelcomeForm : Form
{
    public static string logPathFile = @"Logs";
    public static string gamesPathFile = @"Documents\MGC-Launcher\Games";

    public WelcomeForm()
    {
        InitializeComponent();

        logPathFile = Environment.ExpandEnvironmentVariables(logPathFile);
        gamesPathFile = Environment.ExpandEnvironmentVariables(gamesPathFile);

        FileTools.CreateDirectory(gamesPathFile);
        FileTools.CreateDirectory(logPathFile, true);
    }

    private void loadBarTimer_Tick(object sender, EventArgs e)
    {
        loadingValueLabel.Text = $"{loadingProgressBar.Value}%";
        loadingProgressBar.Value += 10;

        if (loadingProgressBar.Value >= loadingProgressBar.Maximum)
        {
            loadBarTimer.Enabled = false;
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
