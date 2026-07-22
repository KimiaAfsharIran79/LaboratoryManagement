namespace Laboratory
{
    partial class frmTestCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatDescription = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdTestCategory = new System.Windows.Forms.DataGridView();
            this.clmnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCatgoryName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "توضیحات";
            // 
            // txtCatDescription
            // 
            this.txtCatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatDescription.Location = new System.Drawing.Point(110, 91);
            this.txtCatDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatDescription.MaxLength = 400;
            this.txtCatDescription.Multiline = true;
            this.txtCatDescription.Name = "txtCatDescription";
            this.txtCatDescription.Size = new System.Drawing.Size(401, 109);
            this.txtCatDescription.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(543, 13);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 57);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "ثبت جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام رده";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(543, 146);
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
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(543, 79);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdTestCategory
            // 
            this.grdTestCategory.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdTestCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCategoryID,
            this.clmnCategoryName,
            this.clmnDescription,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdTestCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTestCategory.GridColor = System.Drawing.Color.SteelBlue;
            this.grdTestCategory.Location = new System.Drawing.Point(0, 216);
            this.grdTestCategory.Margin = new System.Windows.Forms.Padding(4);
            this.grdTestCategory.MultiSelect = false;
            this.grdTestCategory.Name = "grdTestCategory";
            this.grdTestCategory.ReadOnly = true;
            this.grdTestCategory.RowHeadersWidth = 51;
            this.grdTestCategory.RowTemplate.Height = 24;
            this.grdTestCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTestCategory.Size = new System.Drawing.Size(980, 325);
            this.grdTestCategory.TabIndex = 5;
            this.grdTestCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellContentClick);
            // 
            // clmnCategoryID
            // 
            this.clmnCategoryID.DataPropertyName = "CategoryID";
            this.clmnCategoryID.HeaderText = "شناسه";
            this.clmnCategoryID.MinimumWidth = 6;
            this.clmnCategoryID.Name = "clmnCategoryID";
            this.clmnCategoryID.ReadOnly = true;
            this.clmnCategoryID.Visible = false;
            this.clmnCategoryID.Width = 125;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "نام رده";
            this.clmnCategoryName.MinimumWidth = 6;
            this.clmnCategoryName.Name = "clmnCategoryName";
            this.clmnCategoryName.ReadOnly = true;
            this.clmnCategoryName.Width = 125;
            // 
            // clmnDescription
            // 
            this.clmnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDescription.DataPropertyName = "Description";
            this.clmnDescription.HeaderText = "توضیحات";
            this.clmnDescription.MinimumWidth = 6;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ReadOnly = true;
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
            // txtCatgoryName
            // 
            this.txtCatgoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatgoryName.Location = new System.Drawing.Point(110, 43);
            this.txtCatgoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatgoryName.MaxLength = 50;
            this.txtCatgoryName.Name = "txtCatgoryName";
            this.txtCatgoryName.Size = new System.Drawing.Size(401, 26);
            this.txtCatgoryName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.download__9_;
            this.pictureBox1.Location = new System.Drawing.Point(691, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 171);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmTestCategory
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.txtCatgoryName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdTestCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCatDescription);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTestCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دسته بندی آزمایش";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatDescription;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdTestCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCatgoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}