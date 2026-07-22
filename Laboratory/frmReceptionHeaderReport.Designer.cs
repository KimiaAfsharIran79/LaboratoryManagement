namespace Laboratory
{
    partial class frmReceptionHeaderReport
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
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceptionHeaderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.faToDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.faFromDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grdReceptionHeaderReport = new System.Windows.Forms.DataGridView();
            this.btnAllReportShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.clmnReceptionHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReceptionDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionHeaderReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReport.Location = new System.Drawing.Point(179, 508);
            this.btnSearchReport.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(237, 52);
            this.btnSearchReport.TabIndex = 56;
            this.btnSearchReport.Text = "جستجو ";
            this.btnSearchReport.UseVisualStyleBackColor = false;
            this.btnSearchReport.Click += new System.EventHandler(this.btnSearchReport_Click);
            // 
            // lstPatient
            // 
            this.lstPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 20;
            this.lstPatient.Location = new System.Drawing.Point(20, 63);
            this.lstPatient.Margin = new System.Windows.Forms.Padding(6);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(305, 182);
            this.lstPatient.TabIndex = 53;
            this.lstPatient.Visible = false;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(20, 39);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(305, 26);
            this.txtSearchPatient.TabIndex = 52;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            this.txtSearchPatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPatient_KeyPress);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(179, 456);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(238, 28);
            this.cmbEmployee.TabIndex = 50;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "کارمند :";
            // 
            // txtReceptionHeaderID
            // 
            this.txtReceptionHeaderID.Location = new System.Drawing.Point(31, 458);
            this.txtReceptionHeaderID.Name = "txtReceptionHeaderID";
            this.txtReceptionHeaderID.Size = new System.Drawing.Size(97, 26);
            this.txtReceptionHeaderID.TabIndex = 48;
            this.txtReceptionHeaderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceptionHeaderID.TextChanged += new System.EventHandler(this.txtReceptionHeaderID_TextChanged);
            this.txtReceptionHeaderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceptionHeaderID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "شماره سربرگ  :";
            // 
            // faToDate
            // 
            this.faToDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.faToDate.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            this.faToDate.Location = new System.Drawing.Point(8, 88);
            this.faToDate.Name = "faToDate";
            this.faToDate.Size = new System.Drawing.Size(317, 28);
            this.faToDate.TabIndex = 45;
            this.faToDate.SelectedDateTimeChanged += new System.EventHandler(this.faToDate_SelectedDateTimeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = " تا :";
            // 
            // faFromDate
            // 
            this.faFromDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.faFromDate.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            this.faFromDate.Location = new System.Drawing.Point(8, 40);
            this.faFromDate.Name = "faFromDate";
            this.faFromDate.Size = new System.Drawing.Size(317, 28);
            this.faFromDate.TabIndex = 43;
            this.faFromDate.SelectedDateTimeChanged += new System.EventHandler(this.faFromDate_SelectedDateTimeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "از :";
            // 
            // grdReceptionHeaderReport
            // 
            this.grdReceptionHeaderReport.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdReceptionHeaderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceptionHeaderReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnReceptionHeaderID,
            this.clmnHeaderDate,
            this.clmnPatientFullName,
            this.clmnMobile,
            this.clmnNationalCode,
            this.clmnEmployeeFullName,
            this.clmnTotalPrice,
            this.clmnReceptionDetails});
            this.grdReceptionHeaderReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdReceptionHeaderReport.Location = new System.Drawing.Point(441, 0);
            this.grdReceptionHeaderReport.Name = "grdReceptionHeaderReport";
            this.grdReceptionHeaderReport.RowHeadersWidth = 51;
            this.grdReceptionHeaderReport.RowTemplate.Height = 24;
            this.grdReceptionHeaderReport.Size = new System.Drawing.Size(1041, 653);
            this.grdReceptionHeaderReport.TabIndex = 57;
            this.grdReceptionHeaderReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceptionHeaderReport_CellContentClick);
            // 
            // btnAllReportShow
            // 
            this.btnAllReportShow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAllReportShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReportShow.Location = new System.Drawing.Point(21, 586);
            this.btnAllReportShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnAllReportShow.Name = "btnAllReportShow";
            this.btnAllReportShow.Size = new System.Drawing.Size(396, 52);
            this.btnAllReportShow.TabIndex = 58;
            this.btnAllReportShow.Text = "نمایش همه گزارشات";
            this.btnAllReportShow.UseVisualStyleBackColor = false;
            this.btnAllReportShow.Click += new System.EventHandler(this.btnAllReportShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.faFromDate);
            this.groupBox1.Controls.Add(this.faToDate);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 137);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو براساس تاریخ ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSearchPatient);
            this.groupBox2.Controls.Add(this.lstPatient);
            this.groupBox2.Location = new System.Drawing.Point(20, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 248);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو براساس (نام | تلفن | کد ملی) بیمار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "بیمار :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(31, 508);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 52);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "پاک کردن";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // clmnReceptionHeaderID
            // 
            this.clmnReceptionHeaderID.DataPropertyName = "ReceptionHeaderID";
            this.clmnReceptionHeaderID.HeaderText = "شماره سربرگ ";
            this.clmnReceptionHeaderID.MinimumWidth = 6;
            this.clmnReceptionHeaderID.Name = "clmnReceptionHeaderID";
            this.clmnReceptionHeaderID.Width = 125;
            // 
            // clmnHeaderDate
            // 
            this.clmnHeaderDate.DataPropertyName = "HeaderDate";
            this.clmnHeaderDate.HeaderText = "تاریخ";
            this.clmnHeaderDate.MinimumWidth = 6;
            this.clmnHeaderDate.Name = "clmnHeaderDate";
            this.clmnHeaderDate.Width = 145;
            // 
            // clmnPatientFullName
            // 
            this.clmnPatientFullName.DataPropertyName = "PatientFullName";
            this.clmnPatientFullName.HeaderText = "بیمار";
            this.clmnPatientFullName.MinimumWidth = 6;
            this.clmnPatientFullName.Name = "clmnPatientFullName";
            this.clmnPatientFullName.Width = 125;
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "موبایل";
            this.clmnMobile.MinimumWidth = 6;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.Width = 115;
            // 
            // clmnNationalCode
            // 
            this.clmnNationalCode.DataPropertyName = "NationalCode";
            this.clmnNationalCode.HeaderText = "کدملی";
            this.clmnNationalCode.MinimumWidth = 6;
            this.clmnNationalCode.Name = "clmnNationalCode";
            this.clmnNationalCode.Width = 115;
            // 
            // clmnEmployeeFullName
            // 
            this.clmnEmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.clmnEmployeeFullName.HeaderText = "کارمند";
            this.clmnEmployeeFullName.MinimumWidth = 6;
            this.clmnEmployeeFullName.Name = "clmnEmployeeFullName";
            this.clmnEmployeeFullName.Width = 125;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "TotalPrice";
            this.clmnTotalPrice.HeaderText = "قابل پرداخت";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.Width = 120;
            // 
            // clmnReceptionDetails
            // 
            this.clmnReceptionDetails.HeaderText = "جزِئیات";
            this.clmnReceptionDetails.MinimumWidth = 6;
            this.clmnReceptionDetails.Name = "clmnReceptionDetails";
            this.clmnReceptionDetails.Text = "جزِئیات";
            this.clmnReceptionDetails.UseColumnTextForButtonValue = true;
            this.clmnReceptionDetails.Width = 120;
            // 
            // frmReceptionHeaderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAllReportShow);
            this.Controls.Add(this.grdReceptionHeaderReport);
            this.Controls.Add(this.btnSearchReport);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceptionHeaderID);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceptionHeaderReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "گزارش جامع ";
            this.Load += new System.EventHandler(this.frmReceptionHeaderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceptionHeaderReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchReport;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceptionHeaderID;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker faToDate;
        private System.Windows.Forms.Label label2;
        private FarsiLibrary.Win.Controls.FADatePicker faFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdReceptionHeaderReport;
        private System.Windows.Forms.Button btnAllReportShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReceptionHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn clmnReceptionDetails;
    }
}