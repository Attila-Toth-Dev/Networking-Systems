namespace MGC_Application.Forms;

public partial class ProfileForm : Form
{
    private string currentSelectedProfilePicture;

    private MainMenuForm mainMenuForm;

    public ProfileForm(MainMenuForm _form)
    {
        InitializeComponent();

        profileNameLabel.Text = $"{NetworkTools.Username}";
        profileBioTextBox.Text = $"Hey there! I'm {NetworkTools.Username} and I love to play video games, especially MS Paint.";

        currentSelectedProfilePicture = string.Empty;

        mainMenuForm = _form;

        this.Text = $"{NetworkTools.Username} profile";
    }

    /// <summary>Event for returnButton click.</summary>
    private void returnButton_Click(object sender, EventArgs e)
    {
        // close the profile form.
        this.Close();
        this.Dispose();
        mainMenuForm.ProfileRestrict = 0;
    }

    /// <summary>Event for ProfileForm close.</summary>
    private void ProfileForm_Closed(object sender, FormClosedEventArgs e)
    {
        // close the profile form.
        this.Close();
        this.Dispose();
        mainMenuForm.ProfileRestrict = 0;
    }

    /// <summary>Event for profileIconListView click.</summary>
    private void profileIconListView_Click(object sender, EventArgs e)
    {
        // from list view, when selected, change icon
        // image from the profile file directory to
        // the corresponding image.
        ListViewItem item = profileIconListView.SelectedItems[0];
        currentSelectedProfilePicture = item.Text;

        profileIconPictureBox.Image = Image.FromFile($"Profile/{currentSelectedProfilePicture}.png");
        mainMenuForm.ProfileIcon = profileIconPictureBox.Image;
    }
}
