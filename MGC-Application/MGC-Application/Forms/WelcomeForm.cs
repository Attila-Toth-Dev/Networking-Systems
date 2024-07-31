using MGC_Application.Tools;

namespace MGC_Application.Forms;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();

        FileTools.LogPathFile = $@"{FileTools.DataDirectory}/";
        FileTools.UsersPathFile = $@"{FileTools.DataDirectory}/";

        if (!Directory.Exists(FileTools.DataDirectory))
            FileTools.CreateDirectory(FileTools.DataDirectory, true);

        if(!Directory.Exists(FileTools.GamesDirectory))
            FileTools.CreateDirectory(FileTools.GamesDirectory);
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
