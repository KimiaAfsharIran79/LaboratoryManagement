namespace Laboratory
{
    partial class frmInsuranceType
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdInsuranceType = new System.Windows.Forms.DataGridView();
            this.clmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnInsuranceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsDescription = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsuranceName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsuranceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(552, 155);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 52);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(552, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdInsuranceType
            // 
            this.grdInsuranceType.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdInsuranceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsuranceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCategoryID,
            this.clmnInsuranceTypeName,
            this.clmnDescription,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdInsuranceType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdInsuranceType.GridColor = System.Drawing.Color.SteelBlue;
            this.grdInsuranceType.Location = new System.Drawing.Point(0, 213);
            this.grdInsuranceType.Margin = new System.Windows.Forms.Padding(4);
            this.grdInsuranceType.MultiSelect = false;
            this.grdInsuranceType.Name = "grdInsuranceType";
            this.grdInsuranceType.ReadOnly = true;
            this.grdInsuranceType.RowHeadersWidth = 51;
            this.grdInsuranceType.RowTemplate.Height = 24;
            this.grdInsuranceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInsuranceType.Size = new System.Drawing.Size(980, 328);
            this.grdInsuranceType.TabIndex = 21;
            this.grdInsuranceType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInsuranceType_CellContentClick);
            // 
            // clmnCategoryID
            // 
            this.clmnCategoryID.DataPropertyName = "InsuranceTypeID";
            this.clmnCategoryID.HeaderText = "شناسه نوع بیمه";
            this.clmnCategoryID.MinimumWidth = 6;
            this.clmnCategoryID.Name = "clmnCategoryID";
            this.clmnCategoryID.ReadOnly = true;
            this.clmnCategoryID.Visible = false;
            this.clmnCategoryID.Width = 125;
            // 
            // clmnInsuranceTypeName
            // 
            this.clmnInsuranceTypeName.DataPropertyName = "InsuranceTypeName";
            this.clmnInsuranceTypeName.HeaderText = "نام رده";
            this.clmnInsuranceTypeName.MinimumWidth = 6;
            this.clmnInsuranceTypeName.Name = "clmnInsuranceTypeName";
            this.clmnInsuranceTypeName.ReadOnly = true;
            this.clmnInsuranceTypeName.Width = 250;
            // 
            // clmnDescription
            // 
            this.clmnDescription.DataPropertyName = "Description";
            this.clmnDescription.HeaderText = "توضیحات";
            this.clmnDescription.MinimumWidth = 6;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ReadOnly = true;
            this.clmnDescription.Width = 430;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "توضیحات :";
            // 
            // txtInsDescription
            // 
            this.txtInsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsDescription.Location = new System.Drawing.Point(110, 78);
            this.txtInsDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsDescription.Multiline = true;
            this.txtInsDescription.Name = "txtInsDescription";
            this.txtInsDescription.Size = new System.Drawing.Size(401, 109);
            this.txtInsDescription.TabIndex = 19;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(552, 30);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 57);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام بیمه :";
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceName.Location = new System.Drawing.Point(110, 30);
            this.txtInsuranceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.Size = new System.Drawing.Size(401, 26);
            this.txtInsuranceName.TabIndex = 17;
            this.txtInsuranceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsuranceName_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__15_;
            this.pictureBox1.Location = new System.Drawing.Point(694, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 167);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmInsuranceType
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdInsuranceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsDescription);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsuranceName);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsuranceType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "مدیریت نوع بیمه";
            this.Load += new System.EventHandler(this.frmInsuranceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInsuranceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdInsuranceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsDescription;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsuranceName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnInsuranceTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}