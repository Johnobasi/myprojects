namespace EmployeesRecordSystem
{
    partial class frmUser
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.txtseaarch = new System.Windows.Forms.TextBox();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboCateg);
            this.GroupBox1.Controls.Add(this.txtseaarch);
            this.GroupBox1.Location = new System.Drawing.Point(12, 186);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(659, 49);
            this.GroupBox1.TabIndex = 58;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search";
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Items.AddRange(new object[] {
            "ID",
            "NAME"});
            this.cboCateg.Location = new System.Drawing.Point(417, 19);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(236, 21);
            this.cboCateg.TabIndex = 1;
            this.cboCateg.Text = "---Category---";
            this.cboCateg.SelectedIndexChanged += new System.EventHandler(this.cboCateg_SelectedIndexChanged);
            // 
            // txtseaarch
            // 
            this.txtseaarch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtseaarch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtseaarch.Location = new System.Drawing.Point(7, 20);
            this.txtseaarch.Name = "txtseaarch";
            this.txtseaarch.Size = new System.Drawing.Size(409, 20);
            this.txtseaarch.TabIndex = 0;
            this.txtseaarch.TextChanged += new System.EventHandler(this.txtseaarch_TextChanged);
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(10, 242);
            this.dtgList.Name = "dtgList";
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(677, 283);
            this.dtgList.TabIndex = 57;
            this.dtgList.Click += new System.EventHandler(this.dtgList_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(185, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 23);
            this.txtName.TabIndex = 48;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(115, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 15);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "Name***";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(185, 12);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(332, 23);
            this.txtUserId.TabIndex = 46;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(108, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 15);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "User Id***";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 23);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(185, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(332, 23);
            this.txtUsername.TabIndex = 50;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(413, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(337, 157);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 23);
            this.btnNew.TabIndex = 60;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(122, 131);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 15);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "Type***";
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(185, 128);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(331, 23);
            this.cboType.TabIndex = 53;
            this.cboType.Text = "Administrator";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(185, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(332, 23);
            this.txtPassword.TabIndex = 52;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(90, 102);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 15);
            this.Label4.TabIndex = 51;
            this.Label4.Text = "Password***";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(92, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 15);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "Username***";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 537);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Name = "frmUser";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.TextBox txtseaarch;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtUserId;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}