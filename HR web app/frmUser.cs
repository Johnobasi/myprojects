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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void btnNew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(this);

            sql = "SELECT `USER_ID`, `UNAME` AS NAME, `USERNAME`, `USERTYPE` FROM `useraccounts` ";
            config.Load_DTG(sql, dtgList);
            funct.ResponsiveDtg(dtgList);

            sql = "SELECT CONCAT(`AutoStart`, `AutoEnd`) FROM `tblauto` WHERE `autoID`=1";
            config.autonumber(sql, txtUserId);



        //autonum(1, txtUserId)
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword .Text =="" || txtUsername .Text == "")
            {
                MessageBox.Show("Fields are required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sql = "SELECT * FROM useraccounts WHERE USER_ID = '" + txtUserId.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                sql = "UPDATE `useraccounts` SET `UNAME`='" + txtName.Text + "', `USERNAME`='" + txtUsername.Text +
                "', `PASS`=sha1('" + txtPassword.Text + "'), `USERTYPE`='" + cboType.Text + "' WHERE USER_ID='" + txtUserId.Text + "'";
                config.Execute_CUD(sql,"no data update.","Data has been updated.");
            }
            else
            {
                sql = "insert into `useraccounts` (`USER_ID`, `UNAME`, `USERNAME`, `PASS`, `USERTYPE`)" +
                "values ('" + txtUserId.Text + "','" + txtName.Text + "','" + txtUsername.Text +
                "',sha1('" + txtPassword.Text + "'),'" + cboType.Text + "')";
                config.Execute_CUD(sql, "no save data", "Data has been saved in the database.");

                sql = "UPDATE `tblauto` SET `AutoEnd`=`AutoEnd`+1 WHERE `autoID`=1";
                config.Execute_Query(sql);
           
            } 
            btnNew_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `useraccounts` WHERE USER_ID='" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "no data deleted.", "Data has been deleted");

            btnNew_Click(sender, e); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `useraccounts` WHERE `USER_ID`='" + dtgList.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            { 
                txtUserId.Text = config.dt.Rows[0].Field<string>("USER_ID");
                txtName.Text = config.dt.Rows[0].Field<string>("UNAME");
                txtUsername.Text = config.dt.Rows[0].Field<string>("USERNAME");
                //txtPassword.Text = config.dt.Rows[0].Field<string>("PASS");
                cboType.Text = config.dt.Rows[0].Field<string>("USERTYPE"); 
            }
        }

        private void txtseaarch_TextChanged(object sender, EventArgs e)
        {
            if (cboCateg.Text == "ID")
            {
                sql = "SELECT `USER_ID`, `UNAME` AS NAME, `USERNAME`, `USERTYPE` FROM `useraccounts`" +
                        " WHERE USER_ID LIKE '%" + txtseaarch.Text + "%'";
                config.Load_DTG(sql, dtgList);
                funct.ResponsiveDtg(dtgList);

            }
            else if(cboCateg.Text=="NAME")
            {
                sql = "SELECT `USER_ID`, `UNAME` AS NAME, `USERNAME`, `USERTYPE` FROM `useraccounts`" +
                      " WHERE UNAME LIKE '%" + txtseaarch.Text + "%'";
                config.Load_DTG(sql, dtgList);
                funct.ResponsiveDtg(dtgList);
            }
            else
            {
                sql = "SELECT `USER_ID`, `UNAME` AS NAME, `USERNAME`, `USERTYPE` FROM `useraccounts`" +
                     " WHERE UNAME LIKE '%" + txtseaarch.Text + "%' OR USER_ID LIKE '%" + txtseaarch.Text + "%'";
                config.Load_DTG(sql, dtgList);
                funct.ResponsiveDtg(dtgList);
            }
       
        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCateg.Text == "ID")
            {
                sql = "SELECT USER_ID FROM useraccounts";
                config.autocomplete(sql, txtseaarch);
            }
            else if (cboCateg.Text == "NAME")
            {
                sql = "SELECT UNAME FROM useraccounts";
                config.autocomplete(sql, txtseaarch);
            } 
        }
    }
}
