namespace Laboratory
{
    partial class frmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDeActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.clmnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(116, 38);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(462, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(623, 25);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(114, 52);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDeActive);
            this.groupBox1.Controls.Add(this.rdbActive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(360, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت فعالیت";
            // 
            // rdbDeActive
            // 
            this.rdbDeActive.AutoSize = true;
            this.rdbDeActive.Location = new System.Drawing.Point(4, 51);
            this.rdbDeActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDeActive.Name = "rdbDeActive";
            this.rdbDeActive.Size = new System.Drawing.Size(83, 24);
            this.rdbDeActive.TabIndex = 1;
            this.rdbDeActive.Text = "غیرفعال";
            this.rdbDeActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(28, 11);
            this.rdbActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(59, 24);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.Text = "فعال";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(116, 87);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(462, 26);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(116, 133);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 26);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام کاربری :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 182);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "رمز عبور :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(623, 101);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 52);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(623, 169);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 52);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grdEmployee
            // 
            this.grdEmployee.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEmployeeID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnUserName,
            this.clmnIsActive,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdEmployee.GridColor = System.Drawing.Color.SteelBlue;
            this.grdEmployee.Location = new System.Drawing.Point(0, 253);
            this.grdEmployee.MultiSelect = false;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.ReadOnly = true;
            this.grdEmployee.RowHeadersWidth = 51;
            this.grdEmployee.RowTemplate.Height = 24;
            this.grdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployee.Size = new System.Drawing.Size(982, 300);
            this.grdEmployee.TabIndex = 12;
            this.grdEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsers_CellContentClick);
            // 
            // clmnEmployeeID
            // 
            this.clmnEmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnEmployeeID.DataPropertyName = "EmployeeID";
            this.clmnEmployeeID.HeaderText = "شناسه کارمند";
            this.clmnEmployeeID.MinimumWidth = 6;
            this.clmnEmployeeID.Name = "clmnEmployeeID";
            this.clmnEmployeeID.ReadOnly = true;
            this.clmnEmployeeID.Visible = false;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.DataPropertyName = "FirstName";
            this.clmnFirstName.HeaderText = "نام ";
            this.clmnFirstName.MinimumWidth = 6;
            this.clmnFirstName.Name = "clmnFirstName";
            this.clmnFirstName.ReadOnly = true;
            this.clmnFirstName.Width = 125;
            // 
            // clmnLastName
            // 
            this.clmnLastName.DataPropertyName = "LastName";
            this.clmnLastName.HeaderText = "نام خانوادگی";
            this.clmnLastName.MinimumWidth = 6;
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.ReadOnly = true;
            this.clmnLastName.Width = 125;
            // 
            // clmnUserName
            // 
            this.clmnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnUserName.DataPropertyName = "UserName";
            this.clmnUserName.HeaderText = "نام کاربری";
            this.clmnUserName.MinimumWidth = 6;
            this.clmnUserName.Name = "clmnUserName";
            this.clmnUserName.ReadOnly = true;
            // 
            // clmnIsActive
            // 
            this.clmnIsActive.DataPropertyName = "IsActive";
            this.clmnIsActive.HeaderText = "فعال";
            this.clmnIsActive.MinimumWidth = 6;
            this.clmnIsActive.Name = "clmnIsActive";
            this.clmnIsActive.ReadOnly = true;
            this.clmnIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnIsActive.Width = 125;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__3_;
            this.pictureBox1.Location = new System.Drawing.Point(765, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 222);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "مدیریت کارمندان";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbDeActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}
