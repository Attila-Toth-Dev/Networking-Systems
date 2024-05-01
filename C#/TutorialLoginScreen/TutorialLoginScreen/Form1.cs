namespace TutorialLoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "temp" && txt_password.Text == "pass")
            {
                new MenuForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name and password you entered is incorrect, please try again.");
                txt_username.Clear();
                txt_password.Clear();

                txt_username.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            // Set to no text
            //txt_password.Text = "";

            // The password character is an asterisk
            txt_password.PasswordChar = '*';

            // The control will allow no more than 14 characters
            txt_password.MaxLength = 20;
        }
    }
}
