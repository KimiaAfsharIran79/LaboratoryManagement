namespace Laboratory
{
    partial class frmUnit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitDescription = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdUnits = new System.Windows.Forms.DataGridView();
            this.clmnUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
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
            // txtUnitDescription
            // 
            this.txtUnitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitDescription.Location = new System.Drawing.Point(110, 91);
            this.txtUnitDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitDescription.MaxLength = 400;
            this.txtUnitDescription.Multiline = true;
            this.txtUnitDescription.Name = "txtUnitDescription";
            this.txtUnitDescription.Size = new System.Drawing.Size(401, 109);
            this.txtUnitDescription.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(540, 25);
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
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام واحد";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(540, 158);
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
            this.btnUpdate.Location = new System.Drawing.Point(540, 91);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "ثبت ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdUnits
            // 
            this.grdUnits.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnUnitID,
            this.clmnUnitName,
            this.clmnDescription,
            this.clmnUpdate,
            this.clmnDelete});
            this.grdUnits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdUnits.GridColor = System.Drawing.Color.SteelBlue;
            this.grdUnits.Location = new System.Drawing.Point(0, 216);
            this.grdUnits.Margin = new System.Windows.Forms.Padding(4);
            this.grdUnits.MultiSelect = false;
            this.grdUnits.Name = "grdUnits";
            this.grdUnits.ReadOnly = true;
            this.grdUnits.RowHeadersWidth = 51;
            this.grdUnits.RowTemplate.Height = 24;
            this.grdUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUnits.Size = new System.Drawing.Size(980, 325);
            this.grdUnits.TabIndex = 5;
            this.grdUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUnits_CellContentClick);
            // 
            // clmnUnitID
            // 
            this.clmnUnitID.DataPropertyName = "UnitID";
            this.clmnUnitID.HeaderText = "شناسه";
            this.clmnUnitID.MinimumWidth = 6;
            this.clmnUnitID.Name = "clmnUnitID";
            this.clmnUnitID.ReadOnly = true;
            this.clmnUnitID.Visible = false;
            this.clmnUnitID.Width = 125;
            // 
            // clmnUnitName
            // 
            this.clmnUnitName.DataPropertyName = "UnitName";
            this.clmnUnitName.HeaderText = "نام واحد";
            this.clmnUnitName.MinimumWidth = 6;
            this.clmnUnitName.Name = "clmnUnitName";
            this.clmnUnitName.ReadOnly = true;
            this.clmnUnitName.Width = 125;
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
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitName.Location = new System.Drawing.Point(110, 43);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitName.MaxLength = 50;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(401, 26);
            this.txtUnitName.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__24_;
            this.pictureBox1.Location = new System.Drawing.Point(703, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 175);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmUnit
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnitDescription);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "مدیریت واحد آزمایش";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitDescription;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdUnits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.ErrorProvider err;
    }
}