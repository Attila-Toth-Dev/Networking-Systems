namespace MGC_Application;

public partial class MainMenuForm : Form
{

    public MainMenuForm(string _username)
    {
        InitializeComponent();

        usernameLabel.Text = _username;
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }
    }

    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
            Application.Exit();
    }
}
