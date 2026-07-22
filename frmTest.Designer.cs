namespace Laboratory
{
    partial class frmTest
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
            this.grdTests = new System.Windows.Forms.DataGridView();
            this.clmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAgeHasEffect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnGenderHasEffect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HasEffect = new System.Windows.Forms.GroupBox();
            this.chkGender = new System.Windows.Forms.CheckBox();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTests)).BeginInit();
            this.HasEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTests
            // 
            this.grdTests.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTestID,
            this.clmnTestName,
            this.clmnUnitName,
            this.clmnCategoryName,
            this.clmnUnitPrice,
            this.clmnAgeHasEffect,
            this.clmnGenderHasEffect,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTests.GridColor = System.Drawing.Color.SteelBlue;
            this.grdTests.Location = new System.Drawing.Point(0, 241);
            this.grdTests.MultiSelect = false;
            this.grdTests.Name = "grdTests";
            this.grdTests.ReadOnly = true;
            this.grdTests.RowHeadersWidth = 51;
            this.grdTests.RowTemplate.Height = 24;
            this.grdTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTests.Size = new System.Drawing.Size(980, 300);
            this.grdTests.TabIndex = 8;
            this.grdTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTests_CellContentClick);
            // 
            // clmnTestID
            // 
            this.clmnTestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTestID.DataPropertyName = "TestID";
            this.clmnTestID.HeaderText = "شناسه تست";
            this.clmnTestID.MinimumWidth = 6;
            this.clmnTestID.Name = "clmnTestID";
            this.clmnTestID.ReadOnly = true;
            this.clmnTestID.Visible = false;
            // 
            // clmnTestName
            // 
            this.clmnTestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTestName.DataPropertyName = "TestName";
            this.clmnTestName.HeaderText = "نام آزمایش ";
            this.clmnTestName.MinimumWidth = 6;
            this.clmnTestName.Name = "clmnTestName";
            this.clmnTestName.ReadOnly = true;
            // 
            // clmnUnitName
            // 
            this.clmnUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmnUnitName.DataPropertyName = "UnitName";
            this.clmnUnitName.HeaderText = "نام واحد";
            this.clmnUnitName.MinimumWidth = 6;
            this.clmnUnitName.Name = "clmnUnitName";
            this.clmnUnitName.ReadOnly = true;
            this.clmnUnitName.Width = 83;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "نام رده";
            this.clmnCategoryName.MinimumWidth = 6;
            this.clmnCategoryName.Name = "clmnCategoryName";
            this.clmnCategoryName.ReadOnly = true;
            // 
            // clmnUnitPrice
            // 
            this.clmnUnitPrice.DataPropertyName = "UnitPrice";
            this.clmnUnitPrice.HeaderText = "قیمت ";
            this.clmnUnitPrice.MinimumWidth = 6;
            this.clmnUnitPrice.Name = "clmnUnitPrice";
            this.clmnUnitPrice.ReadOnly = true;
            this.clmnUnitPrice.Width = 125;
            // 
            // clmnAgeHasEffect
            // 
            this.clmnAgeHasEffect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmnAgeHasEffect.DataPropertyName = "AgeHasEffect";
            this.clmnAgeHasEffect.HeaderText = "تاثیر سن";
            this.clmnAgeHasEffect.MinimumWidth = 6;
            this.clmnAgeHasEffect.Name = "clmnAgeHasEffect";
            this.clmnAgeHasEffect.ReadOnly = true;
            this.clmnAgeHasEffect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnAgeHasEffect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnAgeHasEffect.Width = 85;
            // 
            // clmnGenderHasEffect
            // 
            this.clmnGenderHasEffect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmnGenderHasEffect.DataPropertyName = "GenderHasEffect";
            this.clmnGenderHasEffect.HeaderText = "تاثیر جنسیت";
            this.clmnGenderHasEffect.MinimumWidth = 6;
            this.clmnGenderHasEffect.Name = "clmnGenderHasEffect";
            this.clmnGenderHasEffect.ReadOnly = true;
            this.clmnGenderHasEffect.Width = 82;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(622, 165);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(495, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 52);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = " رده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = " واحد";
            // 
            // HasEffect
            // 
            this.HasEffect.Controls.Add(this.chkGender);
            this.HasEffect.Controls.Add(this.chkAge);
            this.HasEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasEffect.Location = new System.Drawing.Point(426, 19);
            this.HasEffect.Margin = new System.Windows.Forms.Padding(2);
            this.HasEffect.Name = "HasEffect";
            this.HasEffect.Padding = new System.Windows.Forms.Padding(2);
            this.HasEffect.Size = new System.Drawing.Size(262, 117);
            this.HasEffect.TabIndex = 4;
            this.HasEffect.TabStop = false;
            this.HasEffect.Text = "تاثیر دارد";
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.Location = new System.Drawing.Point(40, 72);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(74, 24);
            this.chkGender.TabIndex = 1;
            this.chkGender.Text = "جنسیت";
            this.chkGender.UseVisualStyleBackColor = true;
            // 
            // chkAge
            // 
            this.chkAge.AutoSize = true;
            this.chkAge.Location = new System.Drawing.Point(63, 24);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(51, 24);
            this.chkAge.TabIndex = 0;
            this.chkAge.Text = "سن";
            this.chkAge.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(368, 165);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(114, 52);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(97, 25);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(252, 26);
            this.txtTestName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "نام آزمایش";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(741, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 222);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(97, 71);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(252, 28);
            this.cmbUnit.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(97, 116);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(252, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(97, 165);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(252, 26);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "قیمت";
            // 
            // frmTest
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdTests);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HasEffect);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت آزمایش";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTests)).EndInit();
            this.HasEffect.ResumeLayout(false);
            this.HasEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdTests;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox HasEffect;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGender;
        private System.Windows.Forms.CheckBox chkAge;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnAgeHasEffect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnGenderHasEffect;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}