namespace MGC_Application;

public partial class WelcomeForm : Form
{
    private int counter = 1;

    /// <summary>Constructor for Welcome Form</summary>
    public WelcomeForm() => InitializeComponent();

    /// <summary>Function for Creating Directories upon intialization of launcher.</summary>
    /// <param name="_folderName">The name of the folder to be made.</param>
    private void CreateGameDirectory(string _folderName)
    {
        string dir = @$"{_folderName}";

        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
    }

    /// <summary>Event function for load bar time tick.</summary>
    private void loadBarTimer_Tick(object sender, EventArgs e)
    {
        CreateGameDirectory("Games");
        CreateGameDirectory("Log Files");
        
        if (loadingProgressBar.Value <= loadingProgressBar.Maximum)
            loadingProgressBar.Value += 5;

        loadingValueLabel.Text = $"{loadingProgressBar.Value}%";

        if (loadingProgressBar.Value >= loadingProgressBar.Maximum)
        {
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
    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e) => Application.Exit();
}
