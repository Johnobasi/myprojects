using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesRecordSystem.Properties;

namespace EmployeesRecordSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        public void enabled_menu()
        {
            tsEmployee.Enabled = true;
            tsFiles.Enabled = true;
            tsReport.Enabled = true;
            tsUser.Enabled = true;
            tsLogin.Text = "Logout";
            tsLogin.Image = Resources.lock_open;
        }
        private void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frmEmployees());
        }

        private void tsFiles_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frmListScannedFiles());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frmUser());
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frmReports());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                Form frm = new frmLogin(this);
                frm.Show();
            }
            else
            {
                tsEmployee.Enabled = false;
                tsFiles.Enabled = false;
                tsReport.Enabled = false;
                tsUser.Enabled = false;
                tsLogin.Text = "Login";
                tsLogin.Image = Resources.loginsystem;
                closeChildForm();
            }
        }
    }
}
