namespace EmployeesRecordSystem
{
    partial class frmEmployees
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddEmp = new System.Windows.Forms.TabPage();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtempId = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboJobStatus = new System.Windows.Forms.ComboBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            this.cboJobType = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtSalaryGrade = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtSocialAdd = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtEmailad = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnempsave = new System.Windows.Forms.Button();
            this.tpListEmp = new System.Windows.Forms.TabPage();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl1.SuspendLayout();
            this.tpAddEmp.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox10.SuspendLayout();
            this.tpListEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tpAddEmp);
            this.TabControl1.Controls.Add(this.tpListEmp);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(866, 485);
            this.TabControl1.TabIndex = 36;
            // 
            // tpAddEmp
            // 
            this.tpAddEmp.Controls.Add(this.Button2);
            this.tpAddEmp.Controls.Add(this.btnNew);
            this.tpAddEmp.Controls.Add(this.GroupBox9);
            this.tpAddEmp.Controls.Add(this.btnempsave);
            this.tpAddEmp.Location = new System.Drawing.Point(4, 22);
            this.tpAddEmp.Name = "tpAddEmp";
            this.tpAddEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddEmp.Size = new System.Drawing.Size(858, 459);
            this.tpAddEmp.TabIndex = 0;
            this.tpAddEmp.Text = "Add New Employee";
            this.tpAddEmp.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(242, 363);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(98, 28);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(138, 363);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 28);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox9.Controls.Add(this.PictureBox1);
            this.GroupBox9.Controls.Add(this.txtempId);
            this.GroupBox9.Controls.Add(this.Label20);
            this.GroupBox9.Controls.Add(this.GroupBox10);
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.txtSocialAdd);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.Label7);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtEmailad);
            this.GroupBox9.Controls.Add(this.Label6);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Controls.Add(this.txtPhoto);
            this.GroupBox9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox9.ForeColor = System.Drawing.Color.Black;
            this.GroupBox9.Location = new System.Drawing.Point(6, 6);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(844, 347);
            this.GroupBox9.TabIndex = 0;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Personal Information";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(663, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(175, 151);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 31;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtempId
            // 
            this.txtempId.Location = new System.Drawing.Point(100, 20);
            this.txtempId.Name = "txtempId";
            this.txtempId.Size = new System.Drawing.Size(130, 21);
            this.txtempId.TabIndex = 22;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(68, 23);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(26, 14);
            this.Label20.TabIndex = 24;
            this.Label20.Text = "Id :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox10.Controls.Add(this.dtpEndDate);
            this.GroupBox10.Controls.Add(this.cboJobStatus);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.lblEndDate);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.cboJobType);
            this.GroupBox10.Controls.Add(this.txtPosition);
            this.GroupBox10.Controls.Add(this.Label5);
            this.GroupBox10.Controls.Add(this.txtSalary);
            this.GroupBox10.Controls.Add(this.Label4);
            this.GroupBox10.Controls.Add(this.txtSalaryGrade);
            this.GroupBox10.Controls.Add(this.Label3);
            this.GroupBox10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox10.ForeColor = System.Drawing.Color.Black;
            this.GroupBox10.Location = new System.Drawing.Point(6, 233);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(832, 108);
            this.GroupBox10.TabIndex = 1;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Work Information";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(334, 49);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(130, 21);
            this.dtpEndDate.TabIndex = 16;
            // 
            // cboJobStatus
            // 
            this.cboJobStatus.FormattingEnabled = true;
            this.cboJobStatus.Items.AddRange(new object[] {
            "Permanent",
            "Contractual"});
            this.cboJobStatus.Location = new System.Drawing.Point(85, 20);
            this.cboJobStatus.Name = "cboJobStatus";
            this.cboJobStatus.Size = new System.Drawing.Size(151, 22);
            this.cboJobStatus.TabIndex = 15;
            this.cboJobStatus.Text = "Select";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(6, 23);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(76, 14);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "Job Status :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(10, 51);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(69, 14);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Job Type :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(258, 54);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 14);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date :";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(252, 23);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(76, 14);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date Hired :";
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(334, 21);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(130, 21);
            this.dtpdhired.TabIndex = 13;
            // 
            // cboJobType
            // 
            this.cboJobType.FormattingEnabled = true;
            this.cboJobType.Items.AddRange(new object[] {
            "Teaching",
            "Non-Teaching"});
            this.cboJobType.Location = new System.Drawing.Point(85, 48);
            this.cboJobType.Name = "cboJobType";
            this.cboJobType.Size = new System.Drawing.Size(149, 22);
            this.cboJobType.TabIndex = 14;
            this.cboJobType.Text = "Select";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(85, 76);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(151, 21);
            this.txtPosition.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(22, 79);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 14);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Position :";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(576, 49);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(153, 21);
            this.txtSalary.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(479, 54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 14);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Salary :";
            // 
            // txtSalaryGrade
            // 
            this.txtSalaryGrade.Location = new System.Drawing.Point(576, 21);
            this.txtSalaryGrade.Name = "txtSalaryGrade";
            this.txtSalaryGrade.Size = new System.Drawing.Size(153, 21);
            this.txtSalaryGrade.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(479, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 14);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Salary Grade :";
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(100, 173);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(273, 54);
            this.txtbplace.TabIndex = 9;
            this.txtbplace.Text = "";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(100, 74);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(255, 54);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(1, 181);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(91, 14);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Place of Birth :";
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(100, 134);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(221, 21);
            this.dtpdbirth.TabIndex = 5;
            this.dtpdbirth.ValueChanged += new System.EventHandler(this.dtpdbirth_ValueChanged);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(8, 137);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(86, 14);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date of Birth :";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(306, 47);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(132, 21);
            this.txtlname.TabIndex = 1;
            // 
            // txtSocialAdd
            // 
            this.txtSocialAdd.Location = new System.Drawing.Point(488, 201);
            this.txtSocialAdd.Name = "txtSocialAdd";
            this.txtSocialAdd.Size = new System.Drawing.Size(350, 21);
            this.txtSocialAdd.TabIndex = 1;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(327, 139);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(31, 14);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(384, 204);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(101, 14);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Social address :";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(476, 74);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(178, 21);
            this.txtcontact.TabIndex = 4;
            // 
            // txtEmailad
            // 
            this.txtEmailad.Location = new System.Drawing.Point(488, 173);
            this.txtEmailad.Name = "txtEmailad";
            this.txtEmailad.Size = new System.Drawing.Size(350, 21);
            this.txtEmailad.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(385, 176);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 14);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Email Address :";
            // 
            // txtage
            // 
            this.txtage.Enabled = false;
            this.txtage.Location = new System.Drawing.Point(364, 134);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(118, 21);
            this.txtage.TabIndex = 6;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(100, 47);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(130, 21);
            this.txtfname.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(502, 137);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(28, 14);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sex";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(540, 47);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(114, 21);
            this.txtmname.TabIndex = 2;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(587, 135);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(67, 18);
            this.rdofemale.TabIndex = 8;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(533, 135);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(52, 18);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(361, 76);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(109, 14);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Contact Number :";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(17, 50);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(77, 14);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "First Name :";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(407, 109);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(51, 14);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Status :";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Widow"});
            this.txtstatus.Location = new System.Drawing.Point(464, 106);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(190, 22);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "Single";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(228, 50);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(76, 14);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Last Name :";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(29, 77);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(65, 14);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Address :";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(444, 50);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(90, 14);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Middle Name :";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(719, 67);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(100, 21);
            this.txtPhoto.TabIndex = 32;
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(6, 362);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(126, 29);
            this.btnempsave.TabIndex = 3;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // tpListEmp
            // 
            this.tpListEmp.Controls.Add(this.PictureBox2);
            this.tpListEmp.Controls.Add(this.btnEdit);
            this.tpListEmp.Controls.Add(this.Label1);
            this.tpListEmp.Controls.Add(this.btnUpload);
            this.tpListEmp.Controls.Add(this.btnRemove);
            this.tpListEmp.Controls.Add(this.GroupBox1);
            this.tpListEmp.Controls.Add(this.DataGridView1);
            this.tpListEmp.Location = new System.Drawing.Point(4, 22);
            this.tpListEmp.Name = "tpListEmp";
            this.tpListEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpListEmp.Size = new System.Drawing.Size(858, 459);
            this.tpListEmp.TabIndex = 1;
            this.tpListEmp.Text = "List of Employees";
            this.tpListEmp.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Location = new System.Drawing.Point(674, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(179, 103);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(464, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Selected Employee";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 25F);
            this.Label1.Location = new System.Drawing.Point(18, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(323, 41);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Search For Employees";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(608, 428);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 25);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Scanned Files";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(752, 428);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 25);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboCategory);
            this.GroupBox1.Controls.Add(this.txtsearch);
            this.GroupBox1.Location = new System.Drawing.Point(6, 66);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(394, 49);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search                                                              Category";
            // 
            // cboCategory
            // 
            this.cboCategory.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cboCategory.Location = new System.Drawing.Point(224, 19);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(161, 21);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.Text = "ID";
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Location = new System.Drawing.Point(6, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(212, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.Location = new System.Drawing.Point(6, 121);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(847, 301);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            this.DataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 509);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.TabControl1.ResumeLayout(false);
            this.tpAddEmp.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.tpListEmp.ResumeLayout(false);
            this.tpListEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tpAddEmp;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtempId;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.DateTimePicker dtpEndDate;
        internal System.Windows.Forms.ComboBox cboJobStatus;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label lblEndDate;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.ComboBox cboJobType;
        internal System.Windows.Forms.TextBox txtPosition;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSalary;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtSalaryGrade;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.TextBox txtSocialAdd;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtEmailad;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox txtPhoto;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.TabPage tpListEmp;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnUpload;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}