namespace MGC_Application;

public partial class ProfileForm : Form
{
    private string username;
    private string password;

    private string serverIP;

    public ProfileForm(string _username, string _password, string _serverIP)
    {
        InitializeComponent();

        username = _username;
        password = _password;

        serverIP = _serverIP;

        this.Text = $"{_username}'s Profile";
    }

    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        this.Hide();
        MainMenuForm.restrict = 0;

        MainMenuForm form = new MainMenuForm(username, password, serverIP);
        form.Show();
    }

    private void backToMenuButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        MainMenuForm.restrict = 0;

        MainMenuForm form = new MainMenuForm(username, password, serverIP);
        form.Show();
    }
}
