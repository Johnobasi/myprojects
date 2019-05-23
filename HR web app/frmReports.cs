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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void reports(string sql, string rptname)
        {

            try
            {

                config.loadReports(sql);

                string reportname = rptname;


                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\report\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }


        }
        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {

            if(cboJobStatus.Text == "Select" && cboJobType.Text == "Select")
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                      ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                      ",EndDate   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID`";
                reports(sql, "ListEmployee");

            }
            else if (cboJobStatus.Text == "Select" && cboJobType.Text != "Select")
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                       ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                       ",EndDate   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID` AND JobType='" + cboJobType.Text + "'";
                reports(sql, "ListEmployeeJobType");
            }
            else if (cboJobStatus.Text != "Select" && cboJobType.Text == "Select")
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                       ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                       ",EndDate   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID` AND JobStatus='" + cboJobStatus.Text + "'";
                reports(sql, "ListEmployeeJobStatus");
            }
            else if (cboJobStatus.Text != "Select" && cboJobType.Text != "Select" )
            {
                sql = "SELECT distinct(E.`EMPLOYEE_ID`) as 'EmployeeId', concat(`LAST_NAME`,', ',`FIRST_NAME`,' ',  `MIDDLE_NAME`) as Name" +
                       ", `ADDRESS` as 'Address', `GENDER` as 'Sex', `AGE` as 'Age',`D_HIRED` AS 'HiredDate', `JobStatus`,JobType " +
                       ",EndDate   FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID` " +
                       " AND JobStatus='" + cboJobStatus.Text + "' AND JobType='" + cboJobType.Text + "'";
                reports(sql, "ListEmployeeJobStatusJobType");
            }
 
           
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            sql = "SELECT concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`)  FROM `employees`";
            config.autocomplete(sql, TextBox1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `employees` as E, `employeesworkinfo` W WHERE E.`EMPLOYEE_ID`=W.`EMPLOYEE_ID`  AND concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) LIKE '%" + TextBox1.Text + "%'";
            reports(sql, "ServiceRecord");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
