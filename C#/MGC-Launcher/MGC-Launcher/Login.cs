namespace MGC_Launcher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txb_username.Text == "user" && txb_password.Text == "pass")
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password were wrong.");
                MessageBox.Show("Please try again.");

                txb_username.Clear();
                txb_password.Clear();

                txb_username.Focus();
            }
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {
            txb_username.MaxLength = 20;
        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {
            txb_password.PasswordChar = '*';
            txb_password.MaxLength = 20;
        }

        private void lbl_clearfields_Click(object sender, EventArgs e)
        {
            txb_username.Clear();
            txb_password.Clear();

            txb_username.Focus();
        }
    }
}
