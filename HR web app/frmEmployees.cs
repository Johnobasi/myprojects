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
using System.IO;

namespace EmployeesRecordSystem
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

   
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);

        }
        private void retrieve_data()
        {

            txtempId.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TabControl1.SelectedTab = tpAddEmp;
            txtempId.Enabled = false;


            sql = "SELECT *  FROM `employees` as E, `employeesworkinfo` W " +
                      "WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID` and E.`EMPLOYEE_ID`='" +
                      DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {


                txtempId.Text = config.dt.Rows[0].Field<int>("EMPLOYEE_ID").ToString(); 
                txtfname.Text = config.dt.Rows[0].Field<string>("FIRST_NAME").ToString();
                txtlname.Text = config.dt.Rows[0].Field<string>("LAST_NAME").ToString();
                txtmname.Text = config.dt.Rows[0].Field<string>("MIDDLE_NAME").ToString();
                txtaddress.Text = config.dt.Rows[0].Field<string>("ADDRESS").ToString();
                txtcontact.Text = config.dt.Rows[0].Field<string>("PHONE_NUMBER").ToString();
                txtstatus.Text = config.dt.Rows[0].Field<string>("STATUS").ToString();
                dtpdbirth.Text = config.dt.Rows[0].Field<DateTime>("BIRTH_DATE").ToString();
                txtbplace.Text = config.dt.Rows[0].Field<string>("BIRTH_PLACE").ToString();
                if (config.dt.Rows[0].Field<string>("GENDER").ToString()=="Male")
                {
                    rdomale.Checked = true;

                }
                else
                {
                    rdofemale.Checked = true;
                } 
                txtage.Text = config.dt.Rows[0].Field<int>("AGE").ToString();
                cboJobStatus.Text = config.dt.Rows[0].Field<string>("JobStatus").ToString();
                cboJobType.Text = config.dt.Rows[0].Field<string>("JobType").ToString();
                dtpdhired.Text = config.dt.Rows[0].Field<DateTime>("D_HIRED").ToString();
                dtpEndDate.Text = config.dt.Rows[0].Field<DateTime>("EndDate").ToString();
                txtSocialAdd.Text = config.dt.Rows[0].Field<string>("SocialAccnt").ToString();
                txtEmailad.Text = config.dt.Rows[0].Field<string>("EmailAdd").ToString();
                txtSalary.Text = config.dt.Rows[0].Field<double>("Salary").ToString();
                txtSalaryGrade.Text = config.dt.Rows[0].Field<double>("SalaryGrade").ToString();
                txtPosition.Text = config.dt.Rows[0].Field<string>("Position").ToString();
                PictureBox1.ImageLocation = Application.StartupPath +  "/Photo/" + config.dt.Rows[0].Field<string>("EMPIMAGE").ToString();
                tpAddEmp.Text = "Update Employee";
            }
            else
            {
                txtaddress.Clear();
                txtage.Clear();
                txtbplace.Clear();
                txtcontact.Clear();
                txtEmailad.Clear();
                txtempId.Clear();
                txtfname.Clear();
                txtlname.Clear();
                txtmname.Clear();
                txtPhoto.Clear();
                txtPosition.Clear();
                txtSalary.Clear();
                txtSalaryGrade.Clear();
                txtstatus.Text = "Single";
                PictureBox1.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                tpAddEmp.Text = "Add New Employee";
            }
             

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox9);
            funct.clearTxt(GroupBox10);
            txtempId.Enabled = true;
            tpAddEmp.Text = "Add New Employee";
            cboJobStatus.Text = "Select";
            cboJobType.Text = "Select";
            dtpdbirth.Value = DateTime.Now;
            dtpdhired.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            PictureBox1.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
            sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
            ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
            ",EndDate   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID`";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
     
        }

        private void btnempsave_Click(object sender, EventArgs e)

        {
            string gender;
            if (rdomale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            sql = "SELECT * FROM employees e ,employeesworkinfo w WHERE e.EMPLOYEE_ID=w.EMPLOYEE_ID AND e.EMPLOYEE_ID= " + txtempId.Text;
            config.singleResult(sql);

            if(txtfname.Text == "" || txtlname.Text =="" || txtaddress.Text =="" 
                 || txtage.Text =="" || txtcontact.Text =="" || cboJobType.Text == "Select"
                 || txtstatus.Text =="" || cboJobStatus.Text =="" || cboJobType.Text =="Select")
            {
                MessageBox.Show("Empty Fields are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 

            if(config.dt.Rows.Count > 0)
            {
              
                sql = "UPDATE `employees` E,`employeesworkinfo` W  SET " +
                    "`FIRST_NAME`='" + txtfname.Text + "', `LAST_NAME`='" + txtlname.Text +"', `MIDDLE_NAME`='" + txtmname.Text +
                    "',  `ADDRESS`='" + txtaddress.Text + "', `PHONE_NUMBER`='" + txtcontact.Text + "', `STATUS`='" + txtstatus.Text +
                    "', `BIRTH_DATE`='" +  dtpdbirth.Text + "',`BIRTH_PLACE`='" + txtbplace.Text +
                    "', `GENDER`='" + gender + "', `AGE`='" + txtage.Text +
                    "',`EmailAdd`='" + txtEmailad.Text + "', `SocialAccnt`='" + txtSocialAdd.Text +
                    "',EMPIMAGE = '" + Path.GetFileName(PictureBox1.ImageLocation) + 
                    "' WHERE E.`EMPLOYEE_ID`= W.`EMPLOYEE_ID` and E.`EMPLOYEE_ID`= '" + txtempId.Text + "' ";
                config.Execute_CUD(sql, "No data update.", "Data has been updated in the database");


                //sql = "";
                //config.Execute_Query(sql);

            }
            else
            {

                sql = "insert into `employees`  " +
                    "(`EMPLOYEE_ID`, `FIRST_NAME`, `LAST_NAME`, `MIDDLE_NAME`, `ADDRESS`, `PHONE_NUMBER`, `STATUS`, `BIRTH_DATE`," +
                    "`BIRTH_PLACE`, `GENDER`, `AGE`, `EMPIMAGE`,`EmailAdd`, `SocialAccnt`)" +
                    " VALUES " +
                    "('" + txtempId.Text + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txtmname.Text +
                    "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtstatus.Text + "','" + dtpdbirth.Text +
                    "','" + txtbplace.Text + "','" + gender + "','" + txtage.Text + "','" + Path.GetFileName(PictureBox1.ImageLocation) +
                    "','" + txtEmailad.Text + "','" + txtSocialAdd.Text + "' )";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");


                sql = "insert into `employeesworkinfo` (`EMPLOYEE_ID`, `JobStatus`, `JobType`, `D_HIRED`,EndDate,`SalaryGrade`, `Salary`, `Position`)" +
                    " values " +
                    " ('" + txtempId.Text + "','" + cboJobStatus.Text + "','" + cboJobType.Text +
                    "','"  + dtpdhired.Text + "','" + dtpEndDate.Text +
                    "','" + txtSalaryGrade.Text + "','" + txtSalary.Text + "','" + txtPosition.Text + "')";
                config.Execute_Query(sql);


            }
            if(txtPhoto.Text != "")
            {
                File.Copy(txtPhoto.Text, Application.StartupPath + "/Photo/" + Path.GetFileName(PictureBox1.ImageLocation), true);
            }
            btnNew_Click(sender, e);
            
        }

        private void dtpdbirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime f_date = dtpdbirth.Value;
            DateTime s_date = DateTime.Now;
            int age;

            age = s_date.Year - f_date.Year;

            txtage.Text = age.ToString();
             
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.DereferenceLinks = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select a file to open";
            openFileDialog1.ValidateNames = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPhoto.Text = openFileDialog1.FileName;
                PictureBox1.ImageLocation = openFileDialog1.FileName;
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            } 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search_value = txtsearch.Text;
            if(cboCategory.Text  == "ID")
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                              ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                              "   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID`" +
                               "AND E.`EMPLOYEE_ID` LIKE '%" + search_value + "%'";
                config.Load_DTG(sql, DataGridView1);
                sql = "SELECT * FROM employees WHERE `EMPLOYEE_ID` LIKE '%" + search_value + "%'";
                config.singleResult(sql);

                if(search_value== "")
                {
                    if(config.dt.Rows.Count > 0)
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("EMPIMAGE").ToString();
                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }
                
                }
                else
                {
                    PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                }
                
            }
            else
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                       ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                       "   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID`" +
                      "AND  concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) LIKE '%" + txtsearch.Text + "%'";
               config.Load_DTG(sql, DataGridView1);

                sql = "SELECT * FROM employees WHERE concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) LIKE '%" + txtsearch.Text + "%'";
                config.singleResult(sql);

                if (search_value == "")
                {
                    if (config.dt.Rows.Count > 0)
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("EMPIMAGE").ToString();
                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }

                }
                else
                {
                    PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                }
            }
             
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM employees WHERE EMPLOYEE_ID = '" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql); 
            if (config.dt.Rows.Count > 0)
            {
                PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("EMPIMAGE").ToString();
            }
            else
            {
                PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
            } 
             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Form frm = new frmUploadFiles(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `employees` WHERE  `EMPLOYEE_ID`='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM `employeesworkinfo` WHERE  `EMPLOYEE_ID`='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql,"No date delete","Data has been deleted.");
            btnNew_Click(sender, e);
        }
    }
}
