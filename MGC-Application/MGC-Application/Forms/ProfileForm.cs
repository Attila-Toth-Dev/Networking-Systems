namespace MGC_Application.Forms;

public partial class ProfileForm : Form
{
    private string currentSelectedProfilePicture = string.Empty;

    public ProfileForm()
    {
        InitializeComponent();

        profileNameLabel.Text = $"{NetworkTools.Username}";
        profileBioTextBox.Text = $"Hey there! I'm {NetworkTools.Username} and I love to play video games, especially MS Paint.";

        this.Text = $"{NetworkTools.Username} profile";
    }

    private void returnButton_Click(object sender, EventArgs e)
    {
        this.Close();

        MainMenuForm.restrict = 0;
    }

    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        this.Close();

        MainMenuForm.restrict = 0;
    }

    private void changeIconButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog diag = new FolderBrowserDialog();
        if (diag.ShowDialog() == DialogResult.OK)
        {
            profileIconPictureBox.ImageLocation = diag.SelectedPath;
        }
    }

    private void profileIconListView_Click(object sender, EventArgs e)
    {
        ListViewItem item = profileIconListView.SelectedItems[0];
        currentSelectedProfilePicture = item.Text;

        profileIconPictureBox.Image = Image.FromFile($"Profile/{currentSelectedProfilePicture}.png");
    }
}
