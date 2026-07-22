namespace Laboratory
{
    partial class frmReceptionHeader
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
            this.pnlReceptionDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.chkHasStar = new System.Windows.Forms.CheckBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPatientDescription = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPatientFamily = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbInsuranceType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddPay = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdReceptionDetails = new System.Windows.Forms.DataGridView();
            this.clmnReceptionDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReceptionHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.faHeaderDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.pnlReceptionDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReceptionDetails
            // 
            this.pnlReceptionDetails.BackColor = System.Drawing.Color.White;
            this.pnlReceptionDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReceptionDetails.Controls.Add(this.panel1);
            this.pnlReceptionDetails.Controls.Add(this.btnCancel);
            this.pnlReceptionDetails.Controls.Add(this.btnUpdateTest);
            this.pnlReceptionDetails.Controls.Add(this.btnAddTest);
            this.pnlReceptionDetails.Location = new System.Drawing.Point(12, 244);
            this.pnlReceptionDetails.Name = "pnlReceptionDetails";
            this.pnlReceptionDetails.Size = new System.Drawing.Size(1020, 90);
            this.pnlReceptionDetails.TabIndex = 5;
            this.pnlReceptionDetails.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.chkHasStar);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbTest);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(386, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 80);
            this.panel1.TabIndex = 0;
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
            this.chkHasStar.TabIndex = 2;
            this.chkHasStar.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(116, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(89, 26);
            this.txtResult.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "نتیجه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 8);
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
            this.cmbTest.Location = new System.Drawing.Point(321, 34);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(228, 37);
            this.cmbTest.TabIndex = 0;
            this.cmbTest.SelectedIndexChanged += new System.EventHandler(this.cmbTest_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "قیمت";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(241, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(0, 20);
            this.lblPrice.TabIndex = 60;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(13, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateTest.Location = new System.Drawing.Point(107, 23);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(146, 48);
            this.btnUpdateTest.TabIndex = 2;
            this.btnUpdateTest.Text = "ثبت ویرایش آزمایش";
            this.btnUpdateTest.UseVisualStyleBackColor = false;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTest.Location = new System.Drawing.Point(259, 23);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(114, 48);
            this.btnAddTest.TabIndex = 1;
            this.btnAddTest.Text = "ثبت آزمایش";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtPatientDescription
            // 
            this.txtPatientDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientDescription.Location = new System.Drawing.Point(234, 142);
            this.txtPatientDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtPatientDescription.Multiline = true;
            this.txtPatientDescription.Name = "txtPatientDescription";
            this.txtPatientDescription.Size = new System.Drawing.Size(360, 79);
            this.txtPatientDescription.TabIndex = 0;
            // 
            // lstPatient
            // 
            this.lstPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 20;
            this.lstPatient.Location = new System.Drawing.Point(122, 93);
            this.lstPatient.Margin = new System.Windows.Forms.Padding(6);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(437, 142);
            this.lstPatient.TabIndex = 2;
            this.lstPatient.Visible = false;
            this.lstPatient.DoubleClick += new System.EventHandler(this.lstPatient_DoubleClick);
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(1079, 265);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(172, 52);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "ثبت سربرگ پذیرش ";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "جستجوی بیمار:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(122, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShortcutsEnabled = false;
            this.txtSearch.Size = new System.Drawing.Size(437, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "تاریخ پذیرش :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "نام :";
            // 
            // lblPatientFamily
            // 
            this.lblPatientFamily.AutoSize = true;
            this.lblPatientFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFamily.Location = new System.Drawing.Point(176, 27);
            this.lblPatientFamily.Name = "lblPatientFamily";
            this.lblPatientFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientFamily.Size = new System.Drawing.Size(0, 20);
            this.lblPatientFamily.TabIndex = 50;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(482, 27);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "نام خانوادگی :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "آدرس :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(347, 105);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(0, 20);
            this.lblAddress.TabIndex = 46;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(401, 65);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(0, 20);
            this.lblNationalCode.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "توضیحات :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(526, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "کدملی :";
            // 
            // Info
            // 
            this.Info.Controls.Add(this.label17);
            this.Info.Controls.Add(this.txtDrName);
            this.Info.Controls.Add(this.lblMobile);
            this.Info.Controls.Add(this.label16);
            this.Info.Controls.Add(this.cmbInsuranceType);
            this.Info.Controls.Add(this.label7);
            this.Info.Controls.Add(this.label10);
            this.Info.Controls.Add(this.lblPatientFamily);
            this.Info.Controls.Add(this.lblPatientName);
            this.Info.Controls.Add(this.label12);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.label9);
            this.Info.Controls.Add(this.lblAddress);
            this.Info.Controls.Add(this.txtPatientDescription);
            this.Info.Controls.Add(this.lblNationalCode);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.label11);
            this.Info.Location = new System.Drawing.Point(568, 5);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(683, 230);
            this.Info.TabIndex = 3;
            this.Info.TabStop = false;
            this.Info.Text = "مشخصات بیمار";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(173, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 76;
            this.label17.Text = "دکتر:";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(6, 198);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(166, 26);
            this.txtDrName.TabIndex = 73;
            this.txtDrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrName_KeyPress_1);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(166, 65);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMobile.Size = new System.Drawing.Size(0, 20);
            this.lblMobile.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(291, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "موبایل :";
            // 
            // cmbInsuranceType
            // 
            this.cmbInsuranceType.FormattingEnabled = true;
            this.cmbInsuranceType.Location = new System.Drawing.Point(6, 142);
            this.cmbInsuranceType.Name = "cmbInsuranceType";
            this.cmbInsuranceType.Size = new System.Drawing.Size(202, 28);
            this.cmbInsuranceType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "نام پزشک :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(80, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "نوع بیمه :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(1301, 294);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(135, 26);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPrice_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1320, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 74;
            this.label14.Text = "جمع  پرداختی";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(131, 93);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 142);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // btnAddPay
            // 
            this.btnAddPay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPay.Location = new System.Drawing.Point(1290, 210);
            this.btnAddPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddPay.Name = "btnAddPay";
            this.btnAddPay.Size = new System.Drawing.Size(160, 52);
            this.btnAddPay.TabIndex = 6;
            this.btnAddPay.Text = "محاسبه جمع پرداختی";
            this.btnAddPay.UseVisualStyleBackColor = false;
            this.btnAddPay.Click += new System.EventHandler(this.btnAddPay_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1442, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 75;
            this.label15.Text = "تومان";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1259, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 174);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // grdReceptionDetails
            // 
            this.grdReceptionDetails.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdReceptionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceptionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnReceptionDetailsID,
            this.clmnReceptionHeaderID,
            this.clmnTestName,
            this.clmnPrice,
            this.clmnResult,
            this.clmnHasStar,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdReceptionDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdReceptionDetails.Location = new System.Drawing.Point(0, 345);
            this.grdReceptionDetails.Name = "grdReceptionDetails";
            this.grdReceptionDetails.RowHeadersWidth = 51;
            this.grdReceptionDetails.RowTemplate.Height = 24;
            this.grdReceptionDetails.Size = new System.Drawing.Size(1482, 308);
            this.grdReceptionDetails.TabIndex = 76;
            this.grdReceptionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceptionDetails_CellContentClick_1);
            // 
            // clmnReceptionDetailsID
            // 
            this.clmnReceptionDetailsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReceptionDetailsID.DataPropertyName = "ReceptionDetailsID";
            this.clmnReceptionDetailsID.HeaderText = "شناسه اقلام پذیرش";
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
            this.clmnPrice.DataPropertyName = "UnitPrice";
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
            // faHeaderDate
            // 
            this.faHeaderDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.faHeaderDate.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            this.faHeaderDate.Location = new System.Drawing.Point(122, 24);
            this.faHeaderDate.Name = "faHeaderDate";
            this.faHeaderDate.Size = new System.Drawing.Size(423, 28);
            this.faHeaderDate.TabIndex = 77;
            this.faHeaderDate.Leave += new System.EventHandler(this.faHeaderDate_Leave);
            // 
            // frmReceptionHeader
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.faHeaderDate);
            this.Controls.Add(this.grdReceptionDetails);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnAddPay);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnlReceptionDetails);
            this.Controls.Add(this.lstPatient);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.listBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceptionHeader";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت پذیرش بیمار";
            this.Load += new System.EventHandler(this.frmReceptionHeader_Load);
            this.pnlReceptionDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlReceptionDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPatientFamily;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPatientDescription;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInsuranceType;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkHasStar;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddPay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView grdReceptionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private FarsiLibrary.Win.Controls.FADatePicker faHeaderDate;
    }
}