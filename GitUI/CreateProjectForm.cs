using Utility;
using Octokit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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


        private void BtnCreate_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                CreateFolder();
                CreateProjectCommands();

                string url = CreateOnlineRepository();
                TbOutput.Text += "URL: " + url + Environment.NewLine;
                TbOutput.Text += "Origin: " + url + ".git" + Environment.NewLine;

                var results = Git.PushExistingRepository(url + ".git");

                foreach (var output in results)
                {
                    TbOutput.Text += output + Environment.NewLine;
                }
                MessageBox.Show("The repository " + TbProjectName.Text + " has been created at directory "
                    + createdDirectory + ". The application" + "will now close.");

                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unusual exception has occured.  Please try again.  Error: " + ex.ToString());
            }

            
        }


        private void ChangeLoginCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private string CreateOnlineRepository()
        {
            var client = new GitHubClient(new ProductHeaderValue(TbProjectName.Text));
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;
            client.Credentials = Git.Authenticate(username, password);
            var repo = Git.CreateRepository(TbProjectName.Text, client);
            return repo.Url;
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

        private void CreateProjectCommands()
        {
            LinkedList<string> commands = new LinkedList<string>();
            commands.AddLast("cd C:/");
            commands.AddLast("cd " + createdDirectory + ";");
            commands.AddLast("git init;");
            commands.AddLast("git add README.md;");
            commands.AddLast("git commit -m \"initial commit\";");
            commands.AddLast("git push -u origin master");

            foreach (var command in commands)
            {

                string output = CommandPrompt.Execute(command);
                TbOutput.Text += output + Environment.NewLine;
            }
        }

        private void SetUpForm()
        {
        //    CbApplication.Items.Add("Visual Studio 2019");
        //    CbApplication.Items.Add("VSCode");
        //    CbApplication.Items.Add("IntelliJ IDEA");
        //    CbApplication.Items.Add("PyCharm");
        }

    }
}
