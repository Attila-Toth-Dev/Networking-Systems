using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTutorial
{
    public partial class MenuForm : Form
    {
        private string formMessage;

        public MenuForm(string _message)
        {
            InitializeComponent();
            formMessage = _message;

            stringInputLabel.Text = _message;
        }
    }
}
