namespace MGC_Application.Forms;

public partial class CreateAccountForm : Form
{
    public CreateAccountForm()
    {
        InitializeComponent();

        this.Text = "Create User Account";
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        // close the form
        this.Close();
    }

    private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // close the form
        this.Close();
    }
}
