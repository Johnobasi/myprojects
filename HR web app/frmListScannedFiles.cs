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
    public partial class frmListScannedFiles : Form
    {
        public frmListScannedFiles()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboFile.Text != "Select what file")
            {
                sql = "SELECT * " +
                        " FROM  `tblscannedfiles` s,  `employees` e WHERE  `EMPLOYEE_ID` = `EmpId` AND ImgType='"
                        + cboFile.Text + "'  AND  concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) Like '%"
                        + txtSearch.Text + "%'";
                config.singleResult(sql);
                if(config.dt.Rows.Count > 0)
                {
                    lblName.Text = config.dt.Rows[0].Field<string>("FIRST_NAME").ToString() + " " + config.dt.Rows[0].Field<string>("LAST_NAME").ToString();
                }

                sql = "SELECT ScannedId,EMPLOYEE_ID, concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) as 'Name', `IMGCaption` as 'FilesName', `ImgType` as 'FilesType', `DateUpload` as 'DateUploaded' " +
                        " FROM  `tblscannedfiles` s,  `employees` e WHERE  `EMPLOYEE_ID` = `EmpId` AND ImgType='" + cboFile.Text + "'  AND   concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) Like '%" + txtSearch.Text + "%'";
                config.Load_DTG(sql, dtglist);
                dtglist.Columns[0].Visible = false;
                dtglist.Columns[1].Visible = false;

            }
            else if (cboFile.Text == "Select what file")
            {
                MessageBox.Show("Select what files to search", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
           
        }

        private void btnUplaod_Click(object sender, EventArgs e)
        {
            Form frm = new frmUploadFiles(dtglist.CurrentRow.Cells[1].Value.ToString());
            frm.ShowDialog();

        }

        private void frmListScannedFiles_Load(object sender, EventArgs e)
        {
            sql = "SELECT ScannedId,EMPLOYEE_ID, concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) as 'Employees Name', `IMGCaption` as 'FilesName', `ImgType` as 'FilesType', `DateUpload` as 'DateUploaded' " +
                 " FROM  `tblscannedfiles` s,  `employees` e WHERE  `EMPLOYEE_ID` = `EmpId` AND concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) Like '%" + txtSearch.Text + "%'";

            config.Load_DTG(sql, dtglist);
            dtglist.Columns[0].Visible = false;
            dtglist.Columns[1].Visible = false;


            sql = "SELECT concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) FROM `employees`";
            config.autocomplete(sql, txtSearch);
            
            //sql = "SELECT concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) FROM `employees`"
            //append(sql, txtSearch)
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tblscannedfiles WHERE ScannedId= " + dtglist.CurrentRow.Cells[0].Value;
            config.Execute_CUD(sql, "No delete data", "Data has been deleted");
            frmListScannedFiles_Load(sender, e);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM  `tblscannedfiles` s,  `employees` e WHERE  `EMPLOYEE_ID` =  `EmpId` AND ScannedId=" + dtglist.CurrentRow.Cells[0].Value;
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                string filename = config.dt.Rows[0].Field<string>("FilesLocation").ToString();
                Form frm = new pdfviewer(filename);
                frm.Show();
            }
             
        }
    }
}
