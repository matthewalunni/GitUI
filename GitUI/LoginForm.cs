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
            username = TbUsername.Text;
            password = TbPassword.Text;
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
