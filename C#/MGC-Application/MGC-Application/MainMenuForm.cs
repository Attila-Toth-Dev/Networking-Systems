namespace MGC_Application;

public partial class MainMenuForm : Form
{
    public static int restrict = 0;

    private string username;

    public MainMenuForm(string _username)
    {
        InitializeComponent();

        username = _username;

        welecomeLabel.Text = $"{username}'s Library";
    }

    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void playButton_Click(object sender, EventArgs e)
    {
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
        UserData.UpdateStatus(username, false);
        Application.Exit();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog ofd = new OpenFileDialog()
        {
            Filter = "All files|*.*",
            ValidateNames = true,
            Multiselect = true
        })
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foreach(string f in ofd.FileNames)
                {
                    FileInfo file = new FileInfo(f);
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    gameListView.Items.Add(item);
                }
            }
        }
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        if (gameListView.Items.Count > 0)
            gameListView.Items.Remove(gameListView.SelectedItems[0]);
        else
            MessageBox.Show("There is nothing to Remove!");
    }
}
