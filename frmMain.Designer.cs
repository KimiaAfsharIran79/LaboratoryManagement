namespace Laboratory
{
    partial class frmMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCurrentDateTime = new System.Windows.Forms.ToolStripLabel();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.بیشازسیسالسابقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سابقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آدرسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمنوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبترنجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتواحدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشجامعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتسربرگآزمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبیمارانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبیمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentDateTime,
            this.lblCurrentUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 635);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "CurrentDateTime";
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(0, 22);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 22);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // بیشازسیسالسابقهToolStripMenuItem
            // 
            this.بیشازسیسالسابقهToolStripMenuItem.Name = "بیشازسیسالسابقهToolStripMenuItem";
            this.بیشازسیسالسابقهToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.بیشازسیسالسابقهToolStripMenuItem.Text = "بیش از 15 سال سابقه ";
            // 
            // سابقهToolStripMenuItem
            // 
            this.سابقهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بیشازسیسالسابقهToolStripMenuItem});
            this.سابقهToolStripMenuItem.Name = "سابقهToolStripMenuItem";
            this.سابقهToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.سابقهToolStripMenuItem.Text = "سابقه";
            // 
            // تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem
            // 
            this.تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem.Name = "تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem";
            this.تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem.Text = "تهران خ شریعتی آزمایشگاه دی";
            // 
            // آدرسToolStripMenuItem
            // 
            this.آدرسToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem});
            this.آدرسToolStripMenuItem.Name = "آدرسToolStripMenuItem";
            this.آدرسToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.آدرسToolStripMenuItem.Text = "آدرس";
            // 
            // دربارهماToolStripMenuItem
            // 
            this.دربارهماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آدرسToolStripMenuItem,
            this.سابقهToolStripMenuItem});
            this.دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            this.دربارهماToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // آزمایشToolStripMenuItem
            // 
            this.آزمایشToolStripMenuItem.Name = "آزمایشToolStripMenuItem";
            this.آزمایشToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.آزمایشToolStripMenuItem.Text = "ثبت آزمایش";
            this.آزمایشToolStripMenuItem.Click += new System.EventHandler(this.آزمایشToolStripMenuItem_Click);
            // 
            // مدیریتمنوToolStripMenuItem
            // 
            this.مدیریتمنوToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دستهبندیToolStripMenuItem,
            this.آزمایشToolStripMenuItem,
            this.ثبترنجToolStripMenuItem,
            this.ثبتواحدToolStripMenuItem});
            this.مدیریتمنوToolStripMenuItem.Name = "مدیریتمنوToolStripMenuItem";
            this.مدیریتمنوToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.مدیریتمنوToolStripMenuItem.Text = "مدیریت آزمایش";
            // 
            // دستهبندیToolStripMenuItem
            // 
            this.دستهبندیToolStripMenuItem.Name = "دستهبندیToolStripMenuItem";
            this.دستهبندیToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.دستهبندیToolStripMenuItem.Text = "دسته بندی ";
            this.دستهبندیToolStripMenuItem.Click += new System.EventHandler(this.دستهبندیToolStripMenuItem_Click);
            // 
            // ثبترنجToolStripMenuItem
            // 
            this.ثبترنجToolStripMenuItem.Name = "ثبترنجToolStripMenuItem";
            this.ثبترنجToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.ثبترنجToolStripMenuItem.Text = "ثبت رنج";
            this.ثبترنجToolStripMenuItem.Click += new System.EventHandler(this.ثبترنجToolStripMenuItem_Click);
            // 
            // ثبتواحدToolStripMenuItem
            // 
            this.ثبتواحدToolStripMenuItem.Name = "ثبتواحدToolStripMenuItem";
            this.ثبتواحدToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.ثبتواحدToolStripMenuItem.Text = "ثبت واحد";
            this.ثبتواحدToolStripMenuItem.Click += new System.EventHandler(this.ثبتواحدToolStripMenuItem_Click);
            // 
            // گزارشجامعToolStripMenuItem
            // 
            this.گزارشجامعToolStripMenuItem.Name = "گزارشجامعToolStripMenuItem";
            this.گزارشجامعToolStripMenuItem.Size = new System.Drawing.Size(268, 28);
            this.گزارشجامعToolStripMenuItem.Text = "گزارش جامع";
            this.گزارشجامعToolStripMenuItem.Click += new System.EventHandler(this.گزارشجامعToolStripMenuItem_Click);
            // 
            // ثبتسربرگآزمایشToolStripMenuItem
            // 
            this.ثبتسربرگآزمایشToolStripMenuItem.Name = "ثبتسربرگآزمایشToolStripMenuItem";
            this.ثبتسربرگآزمایشToolStripMenuItem.Size = new System.Drawing.Size(268, 28);
            this.ثبتسربرگآزمایشToolStripMenuItem.Text = "ثبت سربرگ آزمایش بیمار";
            this.ثبتسربرگآزمایشToolStripMenuItem.Click += new System.EventHandler(this.ثبتسربرگآزمایشToolStripMenuItem_Click);
            // 
            // فروشToolStripMenuItem
            // 
            this.فروشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتسربرگآزمایشToolStripMenuItem,
            this.گزارشجامعToolStripMenuItem});
            this.فروشToolStripMenuItem.Name = "فروشToolStripMenuItem";
            this.فروشToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.فروشToolStripMenuItem.Text = "پذیرش";
            // 
            // مدیریتبیمارانToolStripMenuItem
            // 
            this.مدیریتبیمارانToolStripMenuItem.Name = "مدیریتبیمارانToolStripMenuItem";
            this.مدیریتبیمارانToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.مدیریتبیمارانToolStripMenuItem.Text = "مدیریت بیماران";
            this.مدیریتبیمارانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتبیمارانToolStripMenuItem_Click);
            // 
            // مدیریتکارمندانToolStripMenuItem
            // 
            this.مدیریتکارمندانToolStripMenuItem.Name = "مدیریتکارمندانToolStripMenuItem";
            this.مدیریتکارمندانToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.مدیریتکارمندانToolStripMenuItem.Text = "مدیریت کارمندان";
            this.مدیریتکارمندانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکارمندانToolStripMenuItem_Click);
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکارمندانToolStripMenuItem,
            this.مدیریتبیمارانToolStripMenuItem,
            this.مدیریتبیمهToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // مدیریتبیمهToolStripMenuItem
            // 
            this.مدیریتبیمهToolStripMenuItem.Name = "مدیریتبیمهToolStripMenuItem";
            this.مدیریتبیمهToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.مدیریتبیمهToolStripMenuItem.Text = "مدیریت بیمه";
            this.مدیریتبیمهToolStripMenuItem.Click += new System.EventHandler(this.مدیریتبیمهToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.فروشToolStripMenuItem,
            this.مدیریتمنوToolStripMenuItem,
            this.دربارهماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1201, 660);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblCurrentDateTime;
        private System.Windows.Forms.ToolStripLabel lblCurrentUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem بیشازسیسالسابقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سابقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تهرانخشریعتیبالاترازتحلیلدادهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آدرسToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمنوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشجامعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتسربرگآزمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبیمارانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکارمندانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ثبترنجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتواحدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبیمهToolStripMenuItem;
    }
}