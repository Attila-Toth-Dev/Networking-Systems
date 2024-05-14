namespace MGC_Application;

public partial class ProfileForm : Form
{
    public ProfileForm()
    {
        InitializeComponent();

        this.Text = $"{NetworkTools.Username}'s Profile";
    }

    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        this.Hide();

        MainMenuForm form = new MainMenuForm();
        form.Show();
    }

    private void backToMenuButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        MainMenuForm form = new MainMenuForm();
        form.Show();
    }
}
