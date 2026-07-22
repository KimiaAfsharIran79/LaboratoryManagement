namespace Laboratory
{
    partial class frmReceptionManage
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
            this.components = new System.ComponentModel.Container();
            this.Info = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.faHeaderDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnCancelHeader = new System.Windows.Forms.Button();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateHeader = new System.Windows.Forms.Button();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbInsuranceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReceptionHeaderID = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchHeader = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPatientHeaders = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtReceptionHeaderID = new System.Windows.Forms.TextBox();
            this.pnlReceptionDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTestCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkHasStar = new System.Windows.Forms.CheckBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelTest = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.pnlTotalPrice = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grdReceptionDetails = new System.Windows.Forms.DataGridView();
            this.clmnReceptionDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReceptionHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.Info.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlReceptionDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTotalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.LightBlue;
            this.Info.Controls.Add(this.txtAge);
            this.Info.Controls.Add(this.label17);
            this.Info.Controls.Add(this.faHeaderDate);
            this.Info.Controls.Add(this.btnCancelHeader);
            this.Info.Controls.Add(this.btnDeleteHeader);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.btnUpdateHeader);
            this.Info.Controls.Add(this.txtDrName);
            this.Info.Controls.Add(this.lblMobile);
            this.Info.Controls.Add(this.label1);
            this.Info.Controls.Add(this.label16);
            this.Info.Controls.Add(this.cmbInsuranceType);
            this.Info.Controls.Add(this.label7);
            this.Info.Controls.Add(this.label10);
            this.Info.Controls.Add(this.lblReceptionHeaderID);
            this.Info.Controls.Add(this.lblPatientFullName);
            this.Info.Controls.Add(this.label12);
            this.Info.Controls.Add(this.lblNationalCode);
            this.Info.Controls.Add(this.label11);
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(692, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(552, 306);
            this.Info.TabIndex = 1;
            this.Info.TabStop = false;
            this.Info.Text = "سربرگ پذیرش";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(361, 122);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(67, 26);
            this.txtAge.TabIndex = 4;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(439, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 83;
            this.label17.Text = "سن :";
            // 
            // faHeaderDate
            // 
            this.faHeaderDate.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            this.faHeaderDate.Location = new System.Drawing.Point(216, 165);
            this.faHeaderDate.Name = "faHeaderDate";
            this.faHeaderDate.Size = new System.Drawing.Size(213, 24);
            this.faHeaderDate.TabIndex = 5;
            // 
            // btnCancelHeader
            // 
            this.btnCancelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelHeader.Location = new System.Drawing.Point(22, 253);
            this.btnCancelHeader.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelHeader.Name = "btnCancelHeader";
            this.btnCancelHeader.Size = new System.Drawing.Size(115, 44);
            this.btnCancelHeader.TabIndex = 10;
            this.btnCancelHeader.Text = "بازگشت   ";
            this.btnCancelHeader.UseVisualStyleBackColor = false;
            this.btnCancelHeader.Click += new System.EventHandler(this.btnCancelHeader_Click);
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHeader.Location = new System.Drawing.Point(22, 149);
            this.btnDeleteHeader.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(115, 40);
            this.btnDeleteHeader.TabIndex = 8;
            this.btnDeleteHeader.Text = "حذف   ";
            this.btnDeleteHeader.UseVisualStyleBackColor = false;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "تاریخ پذیرش :";
            // 
            // btnUpdateHeader
            // 
            this.btnUpdateHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHeader.Location = new System.Drawing.Point(22, 200);
            this.btnUpdateHeader.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateHeader.Name = "btnUpdateHeader";
            this.btnUpdateHeader.Size = new System.Drawing.Size(115, 44);
            this.btnUpdateHeader.TabIndex = 9;
            this.btnUpdateHeader.Text = "ثبت ویرایش   ";
            this.btnUpdateHeader.UseVisualStyleBackColor = false;
            this.btnUpdateHeader.Click += new System.EventHandler(this.btnUpdateHeader_Click);
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(216, 208);
            this.txtDrName.MaxLength = 50;
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(213, 26);
            this.txtDrName.TabIndex = 6;
            this.txtDrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrName_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(39, 76);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMobile.Size = new System.Drawing.Size(0, 20);
            this.lblMobile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "شماره سربرگ  :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(187, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "موبایل :";
            // 
            // cmbInsuranceType
            // 
            this.cmbInsuranceType.FormattingEnabled = true;
            this.cmbInsuranceType.Location = new System.Drawing.Point(216, 248);
            this.cmbInsuranceType.Name = "cmbInsuranceType";
            this.cmbInsuranceType.Size = new System.Drawing.Size(213, 28);
            this.cmbInsuranceType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "نام بیمار :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(435, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "نام پزشک :";
            // 
            // lblReceptionHeaderID
            // 
            this.lblReceptionHeaderID.AutoSize = true;
            this.lblReceptionHeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionHeaderID.Location = new System.Drawing.Point(372, 35);
            this.lblReceptionHeaderID.Name = "lblReceptionHeaderID";
            this.lblReceptionHeaderID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReceptionHeaderID.Size = new System.Drawing.Size(0, 20);
            this.lblReceptionHeaderID.TabIndex = 0;
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFullName.Location = new System.Drawing.Point(80, 35);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientFullName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientFullName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(439, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "نوع بیمه :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(310, 76);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(0, 20);
            this.lblNationalCode.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(439, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "کدملی :";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSearch.Controls.Add(this.btnSearchHeader);
            this.pnlSearch.Controls.Add(this.label9);
            this.pnlSearch.Controls.Add(this.cmbPatientHeaders);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lstPatient);
            this.pnlSearch.Controls.Add(this.txtReceptionHeaderID);
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(12, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(677, 306);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.TabStop = false;
            this.pnlSearch.Text = "جستجو";
            // 
            // btnSearchHeader
            // 
            this.btnSearchHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHeader.Location = new System.Drawing.Point(10, 253);
            this.btnSearchHeader.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchHeader.Name = "btnSearchHeader";
            this.btnSearchHeader.Size = new System.Drawing.Size(121, 49);
            this.btnSearchHeader.TabIndex = 4;
            this.btnSearchHeader.Text = "جستجو";
            this.btnSearchHeader.UseVisualStyleBackColor = false;
            this.btnSearchHeader.Click += new System.EventHandler(this.btnSearchHeader_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = " سربرگ های بیمار:";
            // 
            // cmbPatientHeaders
            // 
            this.cmbPatientHeaders.FormattingEnabled = true;
            this.cmbPatientHeaders.Location = new System.Drawing.Point(10, 216);
            this.cmbPatientHeaders.Name = "cmbPatientHeaders";
            this.cmbPatientHeaders.Size = new System.Drawing.Size(662, 28);
            this.cmbPatientHeaders.TabIndex = 3;
            this.cmbPatientHeaders.SelectedValueChanged += new System.EventHandler(this.cmbPatientHeaders_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = " شماره سربرگ  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "مشخصات بیمار:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(255, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShortcutsEnabled = false;
            this.txtSearch.Size = new System.Drawing.Size(289, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lstPatient
            // 
            this.lstPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 20;
            this.lstPatient.Location = new System.Drawing.Point(9, 52);
            this.lstPatient.Margin = new System.Windows.Forms.Padding(6);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(535, 142);
            this.lstPatient.TabIndex = 2;
            this.lstPatient.Visible = false;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // txtReceptionHeaderID
            // 
            this.txtReceptionHeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptionHeaderID.Location = new System.Drawing.Point(9, 23);
            this.txtReceptionHeaderID.Name = "txtReceptionHeaderID";
            this.txtReceptionHeaderID.Size = new System.Drawing.Size(122, 28);
            this.txtReceptionHeaderID.TabIndex = 1;
            this.txtReceptionHeaderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceptionHeaderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceptionHeaderID_KeyPress);
            // 
            // pnlReceptionDetails
            // 
            this.pnlReceptionDetails.BackColor = System.Drawing.Color.White;
            this.pnlReceptionDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReceptionDetails.Controls.Add(this.panel1);
            this.pnlReceptionDetails.Controls.Add(this.btnCancelTest);
            this.pnlReceptionDetails.Controls.Add(this.btnUpdateTest);
            this.pnlReceptionDetails.Controls.Add(this.btnAddTest);
            this.pnlReceptionDetails.Location = new System.Drawing.Point(12, 324);
            this.pnlReceptionDetails.Name = "pnlReceptionDetails";
            this.pnlReceptionDetails.Size = new System.Drawing.Size(1232, 90);
            this.pnlReceptionDetails.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmbTestCategory);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.chkHasStar);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbTest);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(422, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 80);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(620, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "انتخاب رده";
            // 
            // cmbTestCategory
            // 
            this.cmbTestCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestCategory.FormattingEnabled = true;
            this.cmbTestCategory.Location = new System.Drawing.Point(554, 31);
            this.cmbTestCategory.Name = "cmbTestCategory";
            this.cmbTestCategory.Size = new System.Drawing.Size(228, 37);
            this.cmbTestCategory.TabIndex = 0;
            this.cmbTestCategory.SelectedIndexChanged += new System.EventHandler(this.cmbTestCategory_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(202, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 26);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 67;
            this.label13.Text = "ستاره دار";
            // 
            // chkHasStar
            // 
            this.chkHasStar.AutoSize = true;
            this.chkHasStar.Location = new System.Drawing.Point(38, 41);
            this.chkHasStar.Name = "chkHasStar";
            this.chkHasStar.Size = new System.Drawing.Size(18, 17);
            this.chkHasStar.TabIndex = 4;
            this.chkHasStar.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(103, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(89, 26);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "نتیجه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "انتخاب آزمایش";
            // 
            // cmbTest
            // 
            this.cmbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(316, 34);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(228, 37);
            this.cmbTest.TabIndex = 1;
            this.cmbTest.SelectedIndexChanged += new System.EventHandler(this.cmbTest_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "قیمت";
            // 
            // btnCancelTest
            // 
            this.btnCancelTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelTest.Location = new System.Drawing.Point(7, 19);
            this.btnCancelTest.Name = "btnCancelTest";
            this.btnCancelTest.Size = new System.Drawing.Size(111, 48);
            this.btnCancelTest.TabIndex = 3;
            this.btnCancelTest.Tag = "";
            this.btnCancelTest.Text = "بازگشت";
            this.btnCancelTest.UseVisualStyleBackColor = false;
            this.btnCancelTest.Click += new System.EventHandler(this.btnCancelTest_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateTest.Location = new System.Drawing.Point(124, 19);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(163, 48);
            this.btnUpdateTest.TabIndex = 2;
            this.btnUpdateTest.Text = "ثبت ویرایش آزمایش";
            this.btnUpdateTest.UseVisualStyleBackColor = false;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTest.Location = new System.Drawing.Point(293, 19);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(114, 48);
            this.btnAddTest.TabIndex = 1;
            this.btnAddTest.Text = "ثبت آزمایش";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // pnlTotalPrice
            // 
            this.pnlTotalPrice.BackColor = System.Drawing.Color.LightBlue;
            this.pnlTotalPrice.Controls.Add(this.label14);
            this.pnlTotalPrice.Controls.Add(this.lblTotalPrice);
            this.pnlTotalPrice.Location = new System.Drawing.Point(1250, 243);
            this.pnlTotalPrice.Name = "pnlTotalPrice";
            this.pnlTotalPrice.Size = new System.Drawing.Size(223, 171);
            this.pnlTotalPrice.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 25);
            this.label14.TabIndex = 81;
            this.label14.Text = "جمع  پرداختی (تومان)";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(67, 92);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.lblTotalPrice.TabIndex = 0;
            // 
            // grdReceptionDetails
            // 
            this.grdReceptionDetails.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdReceptionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceptionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnReceptionDetailsID,
            this.clmnReceptionHeaderID,
            this.clmnCategoryID,
            this.clmnTestID,
            this.clmnTestName,
            this.clmnPrice,
            this.clmnResult,
            this.clmnHasStar,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdReceptionDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdReceptionDetails.Location = new System.Drawing.Point(0, 423);
            this.grdReceptionDetails.Name = "grdReceptionDetails";
            this.grdReceptionDetails.RowHeadersWidth = 51;
            this.grdReceptionDetails.Size = new System.Drawing.Size(1482, 230);
            this.grdReceptionDetails.TabIndex = 3;
            this.grdReceptionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceptionDetails_CellContentClick);
            // 
            // clmnReceptionDetailsID
            // 
            this.clmnReceptionDetailsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReceptionDetailsID.DataPropertyName = "ReceptionDetailsID";
            this.clmnReceptionDetailsID.HeaderText = "شناسه جزییات پذیرش";
            this.clmnReceptionDetailsID.MinimumWidth = 6;
            this.clmnReceptionDetailsID.Name = "clmnReceptionDetailsID";
            this.clmnReceptionDetailsID.Visible = false;
            // 
            // clmnReceptionHeaderID
            // 
            this.clmnReceptionHeaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReceptionHeaderID.DataPropertyName = "ReceptionHeaderID";
            this.clmnReceptionHeaderID.HeaderText = "شناسه سربرگ پذیرش  ";
            this.clmnReceptionHeaderID.MinimumWidth = 6;
            this.clmnReceptionHeaderID.Name = "clmnReceptionHeaderID";
            this.clmnReceptionHeaderID.Visible = false;
            // 
            // clmnCategoryID
            // 
            this.clmnCategoryID.DataPropertyName = "CategoryID";
            this.clmnCategoryID.HeaderText = "شناسه رده";
            this.clmnCategoryID.MinimumWidth = 6;
            this.clmnCategoryID.Name = "clmnCategoryID";
            this.clmnCategoryID.Visible = false;
            this.clmnCategoryID.Width = 125;
            // 
            // clmnTestID
            // 
            this.clmnTestID.DataPropertyName = "TestID";
            this.clmnTestID.HeaderText = "شناسه تست";
            this.clmnTestID.MinimumWidth = 6;
            this.clmnTestID.Name = "clmnTestID";
            this.clmnTestID.Visible = false;
            this.clmnTestID.Width = 125;
            // 
            // clmnTestName
            // 
            this.clmnTestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTestName.DataPropertyName = "TestName";
            this.clmnTestName.HeaderText = "نام آزمایش";
            this.clmnTestName.MinimumWidth = 6;
            this.clmnTestName.Name = "clmnTestName";
            // 
            // clmnPrice
            // 
            this.clmnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPrice.DataPropertyName = "Price";
            this.clmnPrice.HeaderText = "قیمت ";
            this.clmnPrice.MinimumWidth = 6;
            this.clmnPrice.Name = "clmnPrice";
            // 
            // clmnResult
            // 
            this.clmnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnResult.DataPropertyName = "Result";
            this.clmnResult.HeaderText = "نتیجه آزمایش";
            this.clmnResult.MinimumWidth = 6;
            this.clmnResult.Name = "clmnResult";
            // 
            // clmnHasStar
            // 
            this.clmnHasStar.DataPropertyName = "HasStar";
            this.clmnHasStar.HeaderText = "ستاره دار";
            this.clmnHasStar.MinimumWidth = 6;
            this.clmnHasStar.Name = "clmnHasStar";
            this.clmnHasStar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnHasStar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnHasStar.Width = 125;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 125;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__30_;
            this.pictureBox1.Location = new System.Drawing.Point(1250, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 223);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmReceptionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdReceptionDetails);
            this.Controls.Add(this.pnlTotalPrice);
            this.Controls.Add(this.pnlReceptionDetails);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.Info);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceptionManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت سربرگ پذیرش";
            this.Load += new System.EventHandler(this.frmReceptionManage_Load);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlReceptionDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTotalPrice.ResumeLayout(false);
            this.pnlTotalPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Info;
        private FarsiLibrary.Win.Controls.FADatePicker faHeaderDate;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateHeader;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbInsuranceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReceptionHeaderID;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox pnlSearch;
        private System.Windows.Forms.Button btnSearchHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPatientHeaders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtReceptionHeaderID;
        private System.Windows.Forms.Panel pnlReceptionDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTestCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkHasStar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelTest;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Panel pnlTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView grdReceptionDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelHeader;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}