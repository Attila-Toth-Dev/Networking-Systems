using System.Diagnostics;

namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public static int restrict = 0;

    private string breakoutFilePath = @"C:\Users\s220306\Desktop\Github\Networking-Systems\C#\MGC-Application\Games\Breakout\Breakout.exe";

    private string username;

    public MainMenuForm(string _username)
    {
        InitializeComponent();

        username = _username;

        welecomeLabel.Text = $"{_username}'s Library";
        myGamesListBox.SelectedIndex = 0;

        updateButton.Enabled = false;
        installButton.Enabled = false;
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }

    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
            Application.Exit();
    }

    private void myGamesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedGameNameLabel.Text = myGamesListBox.Text;
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        Process.Start(breakoutFilePath);
    }

    private void profileButton_Click(object sender, EventArgs e)
    {
        if (restrict == 0)
        {
            this.Hide();

            restrict++;
            ProfileForm form = new ProfileForm(username);
            form.Show();
        }
    }

    private void MainMenuForm_Closed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
