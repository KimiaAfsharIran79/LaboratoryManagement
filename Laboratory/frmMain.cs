using DomainModel.Models;
using Laboratory;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Laboratory
{
    public partial class frmMain : Form
    {
        #region Utility
        private void SetVisiblity()
        {
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (this.MdiChildren.Length > 0)
                {
                    PicBox.Visible = false;
                }
                else
                {
                    PicBox.Visible = true;
                }
            }
        }
        #endregion

        public frmMain(Employee emp)
        {
            InitializeComponent();
            lblCurrentUser.Text = emp.UserName;
            lblEmployeeFullName.Text = emp.FirstName + " " + emp.LastName;
        }

        private void مدیریتکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmEmployee frm = new frmEmployee();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmEmployee)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Framework.DateUtility date = new Framework.DateUtility();
            lblCurrentDateTime.Text = date.GetCurrenTimeToPersian();
            lblDate.Text = date.GetPersianDateTime(DateTime.Now);
        }


        private void دستهبندیToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmTestCategory frm = new frmTestCategory();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmTestCategory)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void ثبتواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmUnit frm = new frmUnit();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmUnit)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void ثبترنجToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmRange frm = new frmRange();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmRange)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }
        private void آزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmTest)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void مدیریتبیمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsuranceType frm = new frmInsuranceType();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmInsuranceType)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void مدیریتبیمارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmPatient)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void ثبتسربرگToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceptionHeader frm = new frmReceptionHeader();

            string UserName = lblCurrentUser.Text;
            Employee emp = new DataAccess.EmployeeRepository().GetEmployeeByUserName(UserName);
            int EmployeeID = emp.EmployeeID;
            frm.currentEpmloyeeID = EmployeeID;

            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmReceptionHeader)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void مدیریتسربرگ_Click(object sender, EventArgs e)
        {
            frmReceptionManage frm = new frmReceptionManage();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmReceptionManage)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }

        private void گزارشجامعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReceptionHeaderReport frm = new frmReceptionHeaderReport();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmReceptionHeaderReport)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            SetVisiblity();
        }
    }
}

