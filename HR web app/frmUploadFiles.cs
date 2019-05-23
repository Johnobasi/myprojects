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
    public partial class frmUploadFiles : Form
    {
        public frmUploadFiles(string id)
        {
            InitializeComponent();

            lblEmpId.Text = id;

        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void UploadSecond(string txt)
        {
            sql = "INSERT INTO tblscannedfiles(EmpId, IMGCaption,ImgType,FilesLocation,DateUpload) " +
            " VALUES (" + lblEmpId.Text + " ,'" + txt + "','" + ComboBox1.Text + "','" + txt + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            config.Execute_Query(sql);
           
        }
 
        private void btnBrowse_Click(object sender, EventArgs e)
        { 
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.DereferenceLinks = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select a file to open";
            openFileDialog1.ValidateNames = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = openFileDialog1.FileName; 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (txtLocation.Text != "" && ComboBox1.Text != "Select what file to be upload")
            {
                Timer1.Start();
            }
            else if(ComboBox1.Text == "Select what file to be upload")
            {
                MessageBox.Show("Please select what file to be upload.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                UploadSecond(Path.GetFileName(txtLocation.Text));
                if(txtLocation.Text != "")
                {
                    System.IO.File.Copy(txtLocation.Text, Application.StartupPath + "/PDF_Files/" + System.IO.Path.GetFileName(txtLocation.Text), true);
                }
                MessageBox.Show("Scanned file uploaded successfully.");
                txtLocation.Clear();
                ProgressBar1.Value = 0;
                ComboBox1.Text = "Select what file to be upload";
            }
           
        }

        private void frmUploadFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
