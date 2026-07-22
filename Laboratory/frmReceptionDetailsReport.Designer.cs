namespace Laboratory
{
    partial class frmReceptionDetailsReport
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
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblReceptionHeaderID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientFullName = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPatientDescription = new System.Windows.Forms.Label();
            this.lblInsuranceTypeName = new System.Windows.Forms.Label();
            this.lblDrName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdReceptionDetails = new System.Windows.Forms.DataGridView();
            this.clmnReceptionDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReceptionHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblHeaderDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.PatientFullName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lblReceptionHeaderID
            // 
            this.lblReceptionHeaderID.AutoSize = true;
            this.lblReceptionHeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionHeaderID.Location = new System.Drawing.Point(185, 203);
            this.lblReceptionHeaderID.Name = "lblReceptionHeaderID";
            this.lblReceptionHeaderID.Size = new System.Drawing.Size(0, 20);
            this.lblReceptionHeaderID.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "شماره سربرگ  :";
            // 
            // PatientFullName
            // 
            this.PatientFullName.BackColor = System.Drawing.Color.White;
            this.PatientFullName.Controls.Add(this.lblAge);
            this.PatientFullName.Controls.Add(this.label17);
            this.PatientFullName.Controls.Add(this.lblPatientDescription);
            this.PatientFullName.Controls.Add(this.lblInsuranceTypeName);
            this.PatientFullName.Controls.Add(this.lblDrName);
            this.PatientFullName.Controls.Add(this.lblMobile);
            this.PatientFullName.Controls.Add(this.label16);
            this.PatientFullName.Controls.Add(this.label7);
            this.PatientFullName.Controls.Add(this.label10);
            this.PatientFullName.Controls.Add(this.lblPatientFullName);
            this.PatientFullName.Controls.Add(this.label12);
            this.PatientFullName.Controls.Add(this.label9);
            this.PatientFullName.Controls.Add(this.lblAddress);
            this.PatientFullName.Controls.Add(this.lblNationalCode);
            this.PatientFullName.Controls.Add(this.label2);
            this.PatientFullName.Controls.Add(this.label11);
            this.PatientFullName.Location = new System.Drawing.Point(12, 12);
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.Size = new System.Drawing.Size(1235, 167);
            this.PatientFullName.TabIndex = 84;
            this.PatientFullName.TabStop = false;
            this.PatientFullName.Text = "مشخصات بیمار";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(958, 130);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 20);
            this.lblAge.TabIndex = 88;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1044, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 87;
            this.label17.Text = "سن :";
            // 
            // lblPatientDescription
            // 
            this.lblPatientDescription.AutoSize = true;
            this.lblPatientDescription.Location = new System.Drawing.Point(509, 128);
            this.lblPatientDescription.Name = "lblPatientDescription";
            this.lblPatientDescription.Size = new System.Drawing.Size(0, 20);
            this.lblPatientDescription.TabIndex = 78;
            // 
            // lblInsuranceTypeName
            // 
            this.lblInsuranceTypeName.AutoSize = true;
            this.lblInsuranceTypeName.Location = new System.Drawing.Point(463, 80);
            this.lblInsuranceTypeName.Name = "lblInsuranceTypeName";
            this.lblInsuranceTypeName.Size = new System.Drawing.Size(0, 20);
            this.lblInsuranceTypeName.TabIndex = 77;
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Location = new System.Drawing.Point(102, 80);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(0, 20);
            this.lblDrName.TabIndex = 76;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(70, 34);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMobile.Size = new System.Drawing.Size(0, 20);
            this.lblMobile.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(195, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "موبایل :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1039, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "نام بیمار :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "نام پزشک :";
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFullName.Location = new System.Drawing.Point(920, 34);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientFullName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientFullName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(603, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "نوع بیمه :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1044, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "آدرس :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(821, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(0, 20);
            this.lblAddress.TabIndex = 46;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(477, 34);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationalCode.Size = new System.Drawing.Size(0, 20);
            this.lblNationalCode.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "توضیحات :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(603, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "کدملی :";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(702, 202);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 20);
            this.lblEmployee.TabIndex = 80;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(596, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 79;
            this.label19.Text = "نام کارمند :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory.Properties.Resources.images__29_;
            this.pictureBox1.Location = new System.Drawing.Point(1253, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
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
            this.clmnHasStar});
            this.grdReceptionDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdReceptionDetails.Location = new System.Drawing.Point(0, 240);
            this.grdReceptionDetails.Name = "grdReceptionDetails";
            this.grdReceptionDetails.RowHeadersWidth = 51;
            this.grdReceptionDetails.Size = new System.Drawing.Size(1482, 413);
            this.grdReceptionDetails.TabIndex = 88;
            // 
            // clmnReceptionDetailsID
            // 
            this.clmnReceptionDetailsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnReceptionDetailsID.DataPropertyName = "ReceptionDetailsID";
            this.clmnReceptionDetailsID.HeaderText = "شناسه جزِئیات پذیرش";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "شماره جزئیات  :";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(498, 202);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 20);
            this.lblDetails.TabIndex = 80;
            // 
            // lblHeaderDate
            // 
            this.lblHeaderDate.AutoSize = true;
            this.lblHeaderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDate.Location = new System.Drawing.Point(1036, 198);
            this.lblHeaderDate.Name = "lblHeaderDate";
            this.lblHeaderDate.Size = new System.Drawing.Size(0, 25);
            this.lblHeaderDate.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(899, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "تاریخ پذیرش :";
            // 
            // frmReceptionDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHeaderDate);
            this.Controls.Add(this.grdReceptionDetails);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.PatientFullName);
            this.Controls.Add(this.lblReceptionHeaderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceptionDetailsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "جزئیات پذیرش";
            this.Load += new System.EventHandler(this.frmReceptionDetailsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.PatientFullName.ResumeLayout(false);
            this.PatientFullName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReceptionHeaderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox PatientFullName;
        private System.Windows.Forms.Label lblDrName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPatientDescription;
        private System.Windows.Forms.Label lblInsuranceTypeName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView grdReceptionDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeaderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHasStar;
    }
}