using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesRecordSystem.Includes;

namespace EmployeesRecordSystem
{
    public partial class frmLogin : Form
    {
        private Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `useraccounts` WHERE `USERNAME`='" + UsernameTextBox.Text  + "' AND  `PASS`= sha1('" + PasswordTextBox.Text  + "')";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact administrator", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
