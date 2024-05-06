namespace MGC_Application;

public partial class ProfileForm : Form
{
    private string username;

    public ProfileForm(string _username)
    {
        InitializeComponent();

        username = _username;

        this.Text = $"{_username}'s Profile";
    }

    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        this.Hide();
        MainMenuForm.restrict = 0;

        MainMenuForm form = new MainMenuForm(username);
        form.Show();
    }

    private void backToMenuButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        MainMenuForm.restrict = 0;

        MainMenuForm form = new MainMenuForm(username);
        form.Show();
    }
}
