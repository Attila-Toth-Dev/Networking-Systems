using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGC_Application
{
    public partial class ProfileForm : Form
    {
        public ProfileForm(string _username)
        {
            InitializeComponent();

            this.Text = $"{_username} Profile";
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
    }
}
