namespace MGC_Application;

public partial class WelcomeForm : Form
{
    private int counter = 1;

    public WelcomeForm() => InitializeComponent();

    private void loadBarTimer_Tick(object sender, EventArgs e)
    {
        if (loadingProgressBar.Value <= 70)
            loadingProgressBar.Value += 4;

        if (loadingProgressBar.Value > 70)
            loadingProgressBar.Value += 1;

        loadingValueLabel.Text = $"{loadingProgressBar.Value}%";

        if (loadingProgressBar.Value >= loadingProgressBar.Maximum)
        {
            loadBarTimer.Enabled = false;
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

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

    private void WelcomeForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
