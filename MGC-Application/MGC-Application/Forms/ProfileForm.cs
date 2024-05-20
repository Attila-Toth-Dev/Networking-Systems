namespace MGC_Application.Forms;

public partial class ProfileForm : Form
{
    public ProfileForm()
    {
        InitializeComponent();

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
}
