namespace WinFormsTutorial;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void sayHelloButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Hello {firstNameLabel.Text} {lastNameLabel.Text}!");

        MenuForm form = new MenuForm($"Hello {firstNameLabel.Text} {lastNameLabel.Text}!");
        this.Hide();
        form.Show();
    }
}
