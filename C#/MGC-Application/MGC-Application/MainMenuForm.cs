using System.Diagnostics;

namespace MGC_Application;

public partial class MainMenuForm : Form
{
    private string tankGameFilePath = @"C:\Users\s220306\Desktop\Github\Networking-Systems\C#\MGC-Application\Games\TankGame\TankGame.exe";
    private string breakoutFilePath = @"C:\Users\s220306\Desktop\Github\Networking-Systems\C#\MGC-Application\Games\Breakout\Breakout.exe";
    private string dungeonCrawlerFilePath = @"C:\Users\s220306\Desktop\Github\Networking-Systems\C#\MGC-Application\Games\Dungeon Crawler\LabyrinthCrawler.exe";

    private string username;

    public MainMenuForm(string _username)
    {
        InitializeComponent();

        username = _username;

        welecomeLabel.Text = $"Welcome {_username}!";
        myGamesListBox.SelectedIndex = 0;

        updateButton.Enabled = false;
        installButton.Enabled = false;
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

    private void myGamesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedGameNameLabel.Text = myGamesListBox.Text;
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        Process.Start(dungeonCrawlerFilePath);
    }

    private void profileIconPictureBox_Click(object sender, EventArgs e)
    {
        ProfileForm form = new ProfileForm(username);
        form.Show();
    }
}
