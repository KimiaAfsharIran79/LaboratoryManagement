namespace Laboratory
{
    partial class frmPatient
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
            this.txtPatientFamily = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grdPatients = new System.Windows.Forms.DataGridView();
            this.clmnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtxtNationalcode = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPatientMobile = new System.Windows.Forms.MaskedTextBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientFamily
            // 
            this.txtPatientFamily.Location = new System.Drawing.Point(381, 21);
            this.txtPatientFamily.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientFamily.MaxLength = 100;
            this.txtPatientFamily.Name = "txtPatientFamily";
            this.txtPatientFamily.Size = new System.Drawing.Size(216, 26);
            this.txtPatientFamily.TabIndex = 1;
            this.txtPatientFamily.TextChanged += new System.EventHandler(this.txtPatientFamily_TextChanged);
            this.txtPatientFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPatientFamily_KeyDown);
            this.txtPatientFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientFamily_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(784, 149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 52);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(784, 84);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "نام خانوادگی :";
            // 
            // grdPatients
            // 
            this.grdPatients.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPatientID,
            this.clmnPatientName,
            this.clmnPatientFamily,
            this.clmnGender,
            this.clmnNationalCode,
            this.clmnMobile,
            this.clmnAddress,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPatients.GridColor = System.Drawing.Color.SteelBlue;
            this.grdPatients.Location = new System.Drawing.Point(0, 207);
            this.grdPatients.Margin = new System.Windows.Forms.Padding(4);
            this.grdPatients.MultiSelect = false;
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.ReadOnly = true;
            this.grdPatients.RowHeadersWidth = 51;
            this.grdPatients.RowTemplate.Height = 24;
            this.grdPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPatients.Size = new System.Drawing.Size(1182, 446);
            this.grdPatients.TabIndex = 9;
            this.grdPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellContentClick);
            // 
            // clmnPatientID
            // 
            this.clmnPatientID.DataPropertyName = "PatientID";
            this.clmnPatientID.HeaderText = "شناسه بیمار";
            this.clmnPatientID.MinimumWidth = 6;
            this.clmnPatientID.Name = "clmnPatientID";
            this.clmnPatientID.ReadOnly = true;
            this.clmnPatientID.Visible = false;
            this.clmnPatientID.Width = 10;
            // 
            // clmnPatientName
            // 
            this.clmnPatientName.DataPropertyName = "FirstName";
            this.clmnPatientName.HeaderText = "نام ";
            this.clmnPatientName.MinimumWidth = 6;
            this.clmnPatientName.Name = "clmnPatientName";
            this.clmnPatientName.ReadOnly = true;
            this.clmnPatientName.Width = 110;
            // 
            // clmnPatientFamily
            // 
            this.clmnPatientFamily.DataPropertyName = "LastName";
            this.clmnPatientFamily.HeaderText = "نام خانوادگی";
            this.clmnPatientFamily.MinimumWidth = 6;
            this.clmnPatientFamily.Name = "clmnPatientFamily";
            this.clmnPatientFamily.ReadOnly = true;
            this.clmnPatientFamily.Width = 120;
            // 
            // clmnGender
            // 
            this.clmnGender.DataPropertyName = "Gender";
            this.clmnGender.HeaderText = "جنسیت";
            this.clmnGender.MinimumWidth = 6;
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnGender.Width = 75;
            // 
            // clmnNationalCode
            // 
            this.clmnNationalCode.DataPropertyName = "NationalCode";
            this.clmnNationalCode.HeaderText = "کدملی";
            this.clmnNationalCode.MinimumWidth = 6;
            this.clmnNationalCode.Name = "clmnNationalCode";
            this.clmnNationalCode.ReadOnly = true;
            this.clmnNationalCode.Width = 125;
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "موبایل";
            this.clmnMobile.MinimumWidth = 6;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.ReadOnly = true;
            this.clmnMobile.Width = 125;
            // 
            // clmnAddress
            // 
            this.clmnAddress.DataPropertyName = "Address";
            this.clmnAddress.HeaderText = "آدرس";
            this.clmnAddress.MinimumWidth = 6;
            this.clmnAddress.Name = "clmnAddress";
            this.clmnAddress.ReadOnly = true;
            this.clmnAddress.Width = 325;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.ReadOnly = true;
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 120;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.ReadOnly = true;
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "آدرس";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(71, 110);
            this.txtPatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientAddress.MaxLength = 1000;
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(526, 80);
            this.txtPatientAddress.TabIndex = 4;
            this.txtPatientAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientAddress_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(784, 13);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 52);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "نام :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(71, 21);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.MaxLength = 100;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(183, 26);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            this.txtPatientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPatientName_KeyDown);
            this.txtPatientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "کدملی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "موبایل :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(940, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 178);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // mtxtNationalcode
            // 
            this.mtxtNationalcode.Location = new System.Drawing.Point(71, 61);
            this.mtxtNationalcode.Mask = "0000000000";
            this.mtxtNationalcode.Name = "mtxtNationalcode";
            this.mtxtNationalcode.Size = new System.Drawing.Size(183, 26);
            this.mtxtNationalcode.TabIndex = 2;
            this.mtxtNationalcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNationalcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtNationalcode_KeyPress);
            this.mtxtNationalcode.Leave += new System.EventHandler(this.mtxtNationalcode_Leave);
            // 
            // mtxtPatientMobile
            // 
            this.mtxtPatientMobile.Location = new System.Drawing.Point(381, 64);
            this.mtxtPatientMobile.Mask = "00000000000";
            this.mtxtPatientMobile.Name = "mtxtPatientMobile";
            this.mtxtPatientMobile.Size = new System.Drawing.Size(216, 26);
            this.mtxtPatientMobile.TabIndex = 3;
            this.mtxtPatientMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtPatientMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPatientMobile_KeyPress);
            this.mtxtPatientMobile.Leave += new System.EventHandler(this.mtxtPatientMobile_Leave);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(25, 47);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(54, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "مرد";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(30, 95);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(49, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "زن";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbFemale);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Location = new System.Drawing.Point(635, 21);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(115, 169);
            this.grpGender.TabIndex = 5;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "جنسیت";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPatient
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.mtxtPatientMobile);
            this.Controls.Add(this.mtxtNationalcode);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientFamily);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "مدیریت بیماران";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientFamily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdPatients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtNationalcode;
        private System.Windows.Forms.MaskedTextBox mtxtPatientMobile;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.ErrorProvider err;
    }
}