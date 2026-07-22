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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.txtToValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkHazard = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(267, 28);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(54, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "مرد";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBoth);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(29, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 68);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جنسیت";
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.Location = new System.Drawing.Point(53, 28);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(69, 24);
            this.rdbBoth.TabIndex = 2;
            this.rdbBoth.TabStop = true;
            this.rdbBoth.Text = "هر دو";
            this.rdbBoth.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(165, 28);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(49, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "زن";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "از سن";
            // 
            // txtFromAge
            // 
            this.txtFromAge.Location = new System.Drawing.Point(115, 106);
            this.txtFromAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(187, 26);
            this.txtFromAge.TabIndex = 3;
            this.txtFromAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAge_KeyPress);
            // 
            // txtToValue
            // 
            this.txtToValue.Location = new System.Drawing.Point(377, 63);
            this.txtToValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtToValue.Name = "txtToValue";
            this.txtToValue.Size = new System.Drawing.Size(185, 26);
            this.txtToValue.TabIndex = 2;
            this.txtToValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToValue_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "تا سن";
            // 
            // txtToAge
            // 
            this.txtToAge.Location = new System.Drawing.Point(377, 106);
            this.txtToAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(185, 26);
            this.txtToAge.TabIndex = 4;
            this.txtToAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAge_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(592, 23);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 52);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "نام آزمایش";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "تا مقدار";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(592, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(592, 106);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "از مقدار";
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
            this.grdRanges.Location = new System.Drawing.Point(0, 263);
            this.grdRanges.Margin = new System.Windows.Forms.Padding(4);
            this.grdRanges.MultiSelect = false;
            this.grdRanges.Name = "grdRanges";
            this.grdRanges.ReadOnly = true;
            this.grdRanges.RowHeadersWidth = 51;
            this.grdRanges.RowTemplate.Height = 24;
            this.grdRanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRanges.Size = new System.Drawing.Size(980, 278);
            this.grdRanges.TabIndex = 10;
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
            this.clmnFromValue.Width = 92;
            // 
            // clmnToValue
            // 
            this.clmnToValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnToValue.DataPropertyName = "ToValue";
            this.clmnToValue.HeaderText = "تا مقدار";
            this.clmnToValue.MinimumWidth = 6;
            this.clmnToValue.Name = "clmnToValue";
            this.clmnToValue.ReadOnly = true;
            this.clmnToValue.Width = 88;
            // 
            // clmnFromAge
            // 
            this.clmnFromAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnFromAge.DataPropertyName = "FromAge";
            this.clmnFromAge.HeaderText = "از سن";
            this.clmnFromAge.MinimumWidth = 6;
            this.clmnFromAge.Name = "clmnFromAge";
            this.clmnFromAge.ReadOnly = true;
            this.clmnFromAge.Width = 78;
            // 
            // clmnToAge
            // 
            this.clmnToAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnToAge.DataPropertyName = "ToAge";
            this.clmnToAge.HeaderText = "تا سن";
            this.clmnToAge.MinimumWidth = 6;
            this.clmnToAge.Name = "clmnToAge";
            this.clmnToAge.ReadOnly = true;
            this.clmnToAge.Width = 74;
            // 
            // clmnGender
            // 
            this.clmnGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnGender.DataPropertyName = "Gender";
            this.clmnGender.HeaderText = "جنسیت";
            this.clmnGender.MinimumWidth = 6;
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnGender.Width = 81;
            // 
            // clmcDescription
            // 
            this.clmcDescription.DataPropertyName = "Description";
            this.clmcDescription.HeaderText = "توضیحات";
            this.clmcDescription.MinimumWidth = 6;
            this.clmcDescription.Name = "clmcDescription";
            this.clmcDescription.ReadOnly = true;
            this.clmcDescription.Width = 125;
            // 
            // clmnHazard
            // 
            this.clmnHazard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnHazard.DataPropertyName = "Hazard";
            this.clmnHazard.HeaderText = "خطر";
            this.clmnHazard.MinimumWidth = 6;
            this.clmnHazard.Name = "clmnHazard";
            this.clmnHazard.ReadOnly = true;
            this.clmnHazard.Width = 45;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.ReadOnly = true;
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            // 
            // clmnDelete
            // 
            this.clmnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.ReadOnly = true;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtFromValue
            // 
            this.txtFromValue.Location = new System.Drawing.Point(116, 63);
            this.txtFromValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(187, 26);
            this.txtFromValue.TabIndex = 1;
            this.txtFromValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "توضیحات";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 147);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(446, 38);
            this.txtDescription.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__16_1;
            this.pictureBox1.Location = new System.Drawing.Point(741, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 222);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(111, 23);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(451, 28);
            this.cmbTest.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // chkHazard
            // 
            this.chkHazard.AutoSize = true;
            this.chkHazard.Location = new System.Drawing.Point(467, 216);
            this.chkHazard.Name = "chkHazard";
            this.chkHazard.Size = new System.Drawing.Size(95, 24);
            this.chkHazard.TabIndex = 74;
            this.chkHazard.Text = "خطر دارد";
            this.chkHazard.UseVisualStyleBackColor = true;
            // 
            // frmRange
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.chkHazard);
            this.Controls.Add(this.cmbTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFromAge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtToValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToAge);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdRanges);
            this.Controls.Add(this.txtFromValue);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت رنج آزمایش";
            this.Load += new System.EventHandler(this.frmRange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtToValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdRanges;
        private System.Windows.Forms.TextBox txtFromValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbTest;
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
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.RadioButton rdbBoth;
        private System.Windows.Forms.CheckBox chkHazard;
    }
}