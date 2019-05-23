using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesRecordSystem
{
    public partial class pdfviewer : Form
    {
        public pdfviewer(string filename)
        {
            InitializeComponent();
             
            //axAcroPDF1.src = Application.StartupPath + "\\PDF_Files\\" + filename; 
            axAcroPDF1.LoadFile(Application.StartupPath + "\\PDF_Files\\" + filename);
        }

        private void pdfviewer_Load(object sender, EventArgs e)
        { 

        }
    }
}
