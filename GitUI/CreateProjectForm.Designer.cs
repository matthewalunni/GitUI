namespace GitUI
{
    partial class CreateProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjectForm));
            this.TbDirectory = new System.Windows.Forms.TextBox();
            this.BtnDirectory = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLoginCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.TbOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbDirectory
            // 
            this.TbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDirectory.Location = new System.Drawing.Point(12, 65);
            this.TbDirectory.Name = "TbDirectory";
            this.TbDirectory.ReadOnly = true;
            this.TbDirectory.Size = new System.Drawing.Size(388, 22);
            this.TbDirectory.TabIndex = 0;
            // 
            // BtnDirectory
            // 
            this.BtnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDirectory.Location = new System.Drawing.Point(406, 65);
            this.BtnDirectory.Name = "BtnDirectory";
            this.BtnDirectory.Size = new System.Drawing.Size(75, 22);
            this.BtnDirectory.TabIndex = 1;
            this.BtnDirectory.Text = "...";
            this.BtnDirectory.UseVisualStyleBackColor = true;
            this.BtnDirectory.Click += new System.EventHandler(this.BtnDirectory_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCreate.Location = new System.Drawing.Point(212, 437);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // TbProjectName
            // 
            this.TbProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbProjectName.Location = new System.Drawing.Point(12, 130);
            this.TbProjectName.Name = "TbProjectName";
            this.TbProjectName.Size = new System.Drawing.Size(469, 22);
            this.TbProjectName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Directory:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLoginCredentialsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeLoginCredentialsToolStripMenuItem
            // 
            this.changeLoginCredentialsToolStripMenuItem.Name = "changeLoginCredentialsToolStripMenuItem";
            this.changeLoginCredentialsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.changeLoginCredentialsToolStripMenuItem.Text = "Change Login Credentials";
            this.changeLoginCredentialsToolStripMenuItem.Click += new System.EventHandler(this.ChangeLoginCredentialsToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output:";
            // 
            // TbOutput
            // 
            this.TbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbOutput.Location = new System.Drawing.Point(12, 186);
            this.TbOutput.Multiline = true;
            this.TbOutput.Name = "TbOutput";
            this.TbOutput.ReadOnly = true;
            this.TbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbOutput.Size = new System.Drawing.Size(469, 239);
            this.TbOutput.TabIndex = 10;
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.Controls.Add(this.TbOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnDirectory);
            this.Controls.Add(this.TbDirectory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateProjectForm";
            this.Text = "Create a New Git Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDirectory;
        private System.Windows.Forms.Button BtnDirectory;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbOutput;
        private System.Windows.Forms.ToolStripMenuItem changeLoginCredentialsToolStripMenuItem;
    }
}

