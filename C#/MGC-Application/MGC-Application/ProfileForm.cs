namespace MGC_Application;

public partial class ProfileForm : Form
{
    /// <summary>Profile Form Constructor</summary>
    public ProfileForm()
    {
        InitializeComponent();

        this.Text = $"{NetworkTools.Username}'s Profile";
    }

    /// <summary>Event function for profile form close.</summary>
    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        this.Hide();

        MainMenuForm form = new MainMenuForm();
        form.Show();
    }

    /// <summary>Event function for back to menu button click.</summary>
    private void backToMenuButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        MainMenuForm form = new MainMenuForm();
        form.Show();
    }
}
