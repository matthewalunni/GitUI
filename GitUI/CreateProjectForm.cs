using System;
using System.IO;
using System.Windows.Forms;
using Utility;

namespace GitUI
{
    public partial class CreateProjectForm : Form
    {
        string directory = "";
        string createdDirectory = null;

        public CreateProjectForm()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void BtnDirectory_Click(object sender, EventArgs e)
        {
            directory = BasicForm.DirectoryUploadPrompt();
            TbDirectory.Text = directory;
        }


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateFolder();

            //create a folder in the directory
            //initialize source control --git init
            //go to GitHub and create a new repository

        }


        private void ChangeLoginCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }


        private void CreateFolder()
        {
            createdDirectory = directory + "\\" + TbProjectName.Text;
            if (Directory.Exists(createdDirectory))
            {
                MessageBox.Show("A folder with the name " + TbProjectName.Text +
                    " already exists.  Please choose another name.");
                createdDirectory = null;
                return;
            }
            else
            {
                Directory.CreateDirectory(createdDirectory);
            }
        }

        private void SetUpForm()
        {
            CbApplication.Items.Add("Visual Studio 2019");
            CbApplication.Items.Add("VSCode");
            CbApplication.Items.Add("IntelliJ IDEA");
            CbApplication.Items.Add("PyCharm");
        }

    }
}
