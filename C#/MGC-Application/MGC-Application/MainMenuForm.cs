namespace MGC_Application;

public partial class MainMenuForm : Form
{
    private string testFilePath = @"C:\Users\s220306\Desktop\Github\Networking-Systems\C#\MGC-Application\MGC-Application\bin\Debug\net8.0-windows";

    public MainMenuForm(string _username)
    {
        InitializeComponent();

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
        //Process.Start("test.txt");
        File.Open(testFilePath, FileMode.Open);
    }
}
