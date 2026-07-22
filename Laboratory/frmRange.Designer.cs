namespace Laboratory
{
    partial class frmRange
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
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.txtToValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grdRanges = new System.Windows.Forms.DataGridView();
            this.clmnRangeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFromValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFromAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHazard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkHazard = new System.Windows.Forms.CheckBox();
            this.grpAge = new System.Windows.Forms.GroupBox();
            this.grpValue = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.grpAge.SuspendLayout();
            this.grpValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(13, 25);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "مرد";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbFemale);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Location = new System.Drawing.Point(486, 152);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(130, 112);
            this.grpGender.TabIndex = 71;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "جنسیت :";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(17, 72);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(47, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "زن";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "از :";
            // 
            // txtFromAge
            // 
            this.txtFromAge.Location = new System.Drawing.Point(141, 44);
            this.txtFromAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(87, 26);
            this.txtFromAge.TabIndex = 0;
            this.txtFromAge.TextChanged += new System.EventHandler(this.txtFromAge_TextChanged);
            this.txtFromAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAge_KeyPress);
            // 
            // txtToValue
            // 
            this.txtToValue.Location = new System.Drawing.Point(7, 44);
            this.txtToValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtToValue.Name = "txtToValue";
            this.txtToValue.Size = new System.Drawing.Size(87, 26);
            this.txtToValue.TabIndex = 1;
            this.txtToValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "تا :";
            // 
            // txtToAge
            // 
            this.txtToAge.Location = new System.Drawing.Point(7, 44);
            this.txtToAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(87, 26);
            this.txtToAge.TabIndex = 1;
            this.txtToAge.TextChanged += new System.EventHandler(this.txtToAge_TextChanged);
            this.txtToAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAge_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(1088, 56);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 52);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "تا :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(1088, 210);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 52);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(1088, 135);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "از :";
            // 
            // grdRanges
            // 
            this.grdRanges.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnRangeID,
            this.clmnTestName,
            this.clmnFromValue,
            this.clmnToValue,
            this.clmnFromAge,
            this.clmnToAge,
            this.clmnGender,
            this.clmcDescription,
            this.clmnHazard,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdRanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdRanges.GridColor = System.Drawing.Color.SteelBlue;
            this.grdRanges.Location = new System.Drawing.Point(0, 286);
            this.grdRanges.Margin = new System.Windows.Forms.Padding(4);
            this.grdRanges.MultiSelect = false;
            this.grdRanges.Name = "grdRanges";
            this.grdRanges.ReadOnly = true;
            this.grdRanges.RowHeadersWidth = 51;
            this.grdRanges.RowTemplate.Height = 24;
            this.grdRanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRanges.Size = new System.Drawing.Size(1482, 367);
            this.grdRanges.TabIndex = 5;
            this.grdRanges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRanges_CellContentClick);
            // 
            // clmnRangeID
            // 
            this.clmnRangeID.DataPropertyName = "RangeID";
            this.clmnRangeID.HeaderText = "شناسه رنج ";
            this.clmnRangeID.MinimumWidth = 6;
            this.clmnRangeID.Name = "clmnRangeID";
            this.clmnRangeID.ReadOnly = true;
            this.clmnRangeID.Visible = false;
            this.clmnRangeID.Width = 125;
            // 
            // clmnTestName
            // 
            this.clmnTestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTestName.DataPropertyName = "TestName";
            this.clmnTestName.HeaderText = "نام آزمایش";
            this.clmnTestName.MinimumWidth = 6;
            this.clmnTestName.Name = "clmnTestName";
            this.clmnTestName.ReadOnly = true;
            // 
            // clmnFromValue
            // 
            this.clmnFromValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnFromValue.DataPropertyName = "FromValue";
            this.clmnFromValue.HeaderText = "از مقدار";
            this.clmnFromValue.MinimumWidth = 6;
            this.clmnFromValue.Name = "clmnFromValue";
            this.clmnFromValue.ReadOnly = true;
            this.clmnFromValue.Width = 84;
            // 
            // clmnToValue
            // 
            this.clmnToValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnToValue.DataPropertyName = "ToValue";
            this.clmnToValue.HeaderText = "تا مقدار";
            this.clmnToValue.MinimumWidth = 6;
            this.clmnToValue.Name = "clmnToValue";
            this.clmnToValue.ReadOnly = true;
            this.clmnToValue.Width = 80;
            // 
            // clmnFromAge
            // 
            this.clmnFromAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnFromAge.DataPropertyName = "FromAge";
            this.clmnFromAge.HeaderText = "از سن";
            this.clmnFromAge.MinimumWidth = 6;
            this.clmnFromAge.Name = "clmnFromAge";
            this.clmnFromAge.ReadOnly = true;
            this.clmnFromAge.Width = 73;
            // 
            // clmnToAge
            // 
            this.clmnToAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnToAge.DataPropertyName = "ToAge";
            this.clmnToAge.HeaderText = "تا سن";
            this.clmnToAge.MinimumWidth = 6;
            this.clmnToAge.Name = "clmnToAge";
            this.clmnToAge.ReadOnly = true;
            this.clmnToAge.Width = 69;
            // 
            // clmnGender
            // 
            this.clmnGender.DataPropertyName = "Gender";
            this.clmnGender.HeaderText = "جنسیت";
            this.clmnGender.MinimumWidth = 6;
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnGender.Width = 90;
            // 
            // clmcDescription
            // 
            this.clmcDescription.DataPropertyName = "Description";
            this.clmcDescription.HeaderText = "توضیحات";
            this.clmcDescription.MinimumWidth = 6;
            this.clmcDescription.Name = "clmcDescription";
            this.clmcDescription.ReadOnly = true;
            this.clmcDescription.Width = 300;
            // 
            // clmnHazard
            // 
            this.clmnHazard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnHazard.DataPropertyName = "Hazard";
            this.clmnHazard.HeaderText = "خطر";
            this.clmnHazard.MinimumWidth = 6;
            this.clmnHazard.Name = "clmnHazard";
            this.clmnHazard.ReadOnly = true;
            this.clmnHazard.Width = 42;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.ReadOnly = true;
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 125;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.ReadOnly = true;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // txtFromValue
            // 
            this.txtFromValue.Location = new System.Drawing.Point(142, 44);
            this.txtFromValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(84, 26);
            this.txtFromValue.TabIndex = 0;
            this.txtFromValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(874, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "توضیحات :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(764, 167);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(285, 97);
            this.txtDescription.TabIndex = 1;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // chkHazard
            // 
            this.chkHazard.AutoSize = true;
            this.chkHazard.Location = new System.Drawing.Point(643, 232);
            this.chkHazard.Name = "chkHazard";
            this.chkHazard.Size = new System.Drawing.Size(87, 24);
            this.chkHazard.TabIndex = 0;
            this.chkHazard.Text = "خطر دارد";
            this.chkHazard.UseVisualStyleBackColor = true;
            // 
            // grpAge
            // 
            this.grpAge.Controls.Add(this.label2);
            this.grpAge.Controls.Add(this.txtFromAge);
            this.grpAge.Controls.Add(this.label3);
            this.grpAge.Controls.Add(this.txtToAge);
            this.grpAge.Location = new System.Drawing.Point(768, 28);
            this.grpAge.Name = "grpAge";
            this.grpAge.Size = new System.Drawing.Size(281, 100);
            this.grpAge.TabIndex = 75;
            this.grpAge.TabStop = false;
            this.grpAge.Text = "سن :";
            // 
            // grpValue
            // 
            this.grpValue.Controls.Add(this.txtFromValue);
            this.grpValue.Controls.Add(this.label5);
            this.grpValue.Controls.Add(this.txtToValue);
            this.grpValue.Controls.Add(this.label4);
            this.grpValue.Location = new System.Drawing.Point(490, 28);
            this.grpValue.Name = "grpValue";
            this.grpValue.Size = new System.Drawing.Size(272, 100);
            this.grpValue.TabIndex = 76;
            this.grpValue.TabStop = false;
            this.grpValue.Text = "مقدار :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTestName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lstTest);
            this.groupBox1.Controls.Add(this.cmbTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 271);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نام آزمایش را انتخاب یا جستجو کنید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "جستجو  :";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Location = new System.Drawing.Point(79, 44);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(0, 20);
            this.lblTestName.TabIndex = 79;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(22, 131);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShortcutsEnabled = false;
            this.txtSearch.Size = new System.Drawing.Size(306, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "انتخاب :";
            // 
            // lstTest
            // 
            this.lstTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 20;
            this.lstTest.Location = new System.Drawing.Point(22, 158);
            this.lstTest.Margin = new System.Windows.Forms.Padding(6);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(306, 102);
            this.lstTest.TabIndex = 2;
            this.lstTest.Visible = false;
            this.lstTest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTest_MouseDoubleClick);
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(22, 88);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(306, 28);
            this.cmbTest.TabIndex = 0;
            this.cmbTest.SelectedIndexChanged += new System.EventHandler(this.cmbTest_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__21_;
            this.pictureBox1.Location = new System.Drawing.Point(1243, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 194);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // frmRange
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpValue);
            this.Controls.Add(this.grpAge);
            this.Controls.Add(this.chkHazard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdRanges);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "مدیریت رنج آزمایش";
            this.Load += new System.EventHandler(this.frmRange_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.grpAge.ResumeLayout(false);
            this.grpAge.PerformLayout();
            this.grpValue.ResumeLayout(false);
            this.grpValue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.TextBox txtToValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdRanges;
        private System.Windows.Forms.TextBox txtFromValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.CheckBox chkHazard;
        private System.Windows.Forms.GroupBox grpAge;
        private System.Windows.Forms.GroupBox grpValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRangeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFromValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFromAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHazard;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}