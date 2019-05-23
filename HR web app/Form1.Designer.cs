namespace EmployeesRecordSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsFiles = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsFiles,
            this.tsUser,
            this.tsReport,
            this.tsLogin});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(857, 72);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "Employee";
            // 
            // tsEmployee
            // 
            this.tsEmployee.Enabled = false;
            this.tsEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsEmployee.Image")));
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(64, 69);
            this.tsEmployee.Text = "Employee";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsFiles
            // 
            this.tsFiles.Enabled = false;
            this.tsFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsFiles.Image")));
            this.tsFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFiles.Name = "tsFiles";
            this.tsFiles.Size = new System.Drawing.Size(82, 69);
            this.tsFiles.Text = "Scanned Files";
            this.tsFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFiles.Click += new System.EventHandler(this.tsFiles_Click);
            // 
            // tsUser
            // 
            this.tsUser.Enabled = false;
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(85, 69);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.Enabled = false;
            this.tsReport.Image = ((System.Drawing.Image)(resources.GetObject("tsReport.Image")));
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(64, 69);
            this.tsReport.Text = "Reports";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::EmployeesRecordSystem.Properties.Resources.loginsystem;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(64, 69);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 509);
            this.Controls.Add(this.ToolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton tsEmployee;
        internal System.Windows.Forms.ToolStripButton tsFiles;
        internal System.Windows.Forms.ToolStripButton tsUser;
        internal System.Windows.Forms.ToolStripButton tsReport;
        internal System.Windows.Forms.ToolStripButton tsLogin;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
    }
}

