using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace GitUI
{
    public partial class LoginForm : Form
    {
        public string username;
        public string password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (BasicForm.TextBoxesAreEmpty(this))
            {
                MessageBox.Show("Make sure the username and password fields are filled!");
                return;
            }
            else
            {
                username = TbUsername.Text;
                password = TbPassword.Text;
            }
        }
    }
}
