namespace EmployeesRecordSystem
{
    partial class frmListScannedFiles
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
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFile = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUplaod = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(14, 146);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(777, 353);
            this.dtglist.TabIndex = 20;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.Controls.Add(this.btnSearch);
            this.GroupBox1.Controls.Add(this.cboFile);
            this.GroupBox1.Controls.Add(this.txtSearch);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(14, 65);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(762, 68);
            this.GroupBox1.TabIndex = 23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(693, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboFile
            // 
            this.cboFile.FormattingEnabled = true;
            this.cboFile.Items.AddRange(new object[] {
            "pds",
            "otr",
            "saln"});
            this.cboFile.Location = new System.Drawing.Point(69, 25);
            this.cboFile.Name = "cboFile";
            this.cboFile.Size = new System.Drawing.Size(245, 24);
            this.cboFile.TabIndex = 3;
            this.cboFile.Text = "Select what file";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(442, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 23);
            this.txtSearch.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 17);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Files :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(320, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Seach by Name :";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(547, 505);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(119, 28);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUplaod
            // 
            this.btnUplaod.Location = new System.Drawing.Point(422, 505);
            this.btnUplaod.Name = "btnUplaod";
            this.btnUplaod.Size = new System.Drawing.Size(119, 28);
            this.btnUplaod.TabIndex = 26;
            this.btnUplaod.Text = "Upload Files";
            this.btnUplaod.UseVisualStyleBackColor = true;
            this.btnUplaod.Click += new System.EventHandler(this.btnUplaod_Click);
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(803, 55);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "List of Scanned Files";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(50, 226);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(129, 17);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Employee\'s Name :";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(672, 505);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(119, 28);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "View";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(185, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "NONE";
            // 
            // frmListScannedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 546);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUplaod);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblName);
            this.Name = "frmListScannedFiles";
            this.Text = "Scanned Files";
            this.Load += new System.EventHandler(this.frmListScannedFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.ComboBox cboFile;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnDel;
        internal System.Windows.Forms.Button btnUplaod;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.Label lblName;
    }
}