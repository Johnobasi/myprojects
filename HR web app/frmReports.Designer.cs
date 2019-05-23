namespace EmployeesRecordSystem
{
    partial class frmReports
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
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboJobStatus = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboJobType = new System.Windows.Forms.ComboBox();
            this.btnPreviewPrint = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FlowLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlowLayoutPanel1.Controls.Add(this.Panel1);
            this.FlowLayoutPanel1.Controls.Add(this.Label3);
            this.FlowLayoutPanel1.Controls.Add(this.cboJobStatus);
            this.FlowLayoutPanel1.Controls.Add(this.Label4);
            this.FlowLayoutPanel1.Controls.Add(this.cboJobType);
            this.FlowLayoutPanel1.Controls.Add(this.btnPreviewPrint);
            this.FlowLayoutPanel1.Controls.Add(this.GroupBox2);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(168, 543);
            this.FlowLayoutPanel1.TabIndex = 8;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(159, 55);
            this.Panel1.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(3, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(144, 45);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Preview list of employees\r\n according to thier \r\nJobStatus and JobType";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 18);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "JobStatus :";
            // 
            // cboJobStatus
            // 
            this.cboJobStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobStatus.FormattingEnabled = true;
            this.cboJobStatus.Items.AddRange(new object[] {
            "Select",
            "Permanent",
            "Contractual"});
            this.cboJobStatus.Location = new System.Drawing.Point(3, 82);
            this.cboJobStatus.Name = "cboJobStatus";
            this.cboJobStatus.Size = new System.Drawing.Size(159, 24);
            this.cboJobStatus.TabIndex = 3;
            this.cboJobStatus.Text = "Select";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(3, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 18);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "JobType :";
            // 
            // cboJobType
            // 
            this.cboJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobType.FormattingEnabled = true;
            this.cboJobType.Items.AddRange(new object[] {
            "Select",
            "Teaching",
            "Non-Teaching"});
            this.cboJobType.Location = new System.Drawing.Point(3, 130);
            this.cboJobType.Name = "cboJobType";
            this.cboJobType.Size = new System.Drawing.Size(159, 24);
            this.cboJobType.TabIndex = 3;
            this.cboJobType.Text = "Select";
            // 
            // btnPreviewPrint
            // 
            this.btnPreviewPrint.Location = new System.Drawing.Point(3, 160);
            this.btnPreviewPrint.Name = "btnPreviewPrint";
            this.btnPreviewPrint.Size = new System.Drawing.Size(159, 30);
            this.btnPreviewPrint.TabIndex = 3;
            this.btnPreviewPrint.Text = "Preview";
            this.btnPreviewPrint.UseVisualStyleBackColor = true;
            this.btnPreviewPrint.Click += new System.EventHandler(this.btnPreviewPrint_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(3, 196);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(159, 126);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Service Record";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(9, 70);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(144, 28);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Preview";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBox1.Location = new System.Drawing.Point(9, 41);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 20);
            this.TextBox1.TabIndex = 5;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 25);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(87, 13);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Search By Name";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtSearchId);
            this.GroupBox1.Controls.Add(this.btnSearch);
            this.GroupBox1.Location = new System.Drawing.Point(613, 318);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(30, 10);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employees Records";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(9, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 15);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Employee\'s Id";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(7, 51);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(147, 21);
            this.txtSearchId.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Preview";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(168, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(700, 543);
            this.crystalReportViewer1.TabIndex = 10;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 543);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cboJobStatus;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboJobType;
        internal System.Windows.Forms.Button btnPreviewPrint;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSearchId;
        internal System.Windows.Forms.Button btnSearch;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}