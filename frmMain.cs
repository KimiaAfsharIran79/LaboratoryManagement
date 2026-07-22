using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmMain : Form
    {
        public frmMain(string UserName)
        {
            InitializeComponent();
            lblCurrentUser.Text = UserName;
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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Framework.DateUtility utility = new Framework.DateUtility();
            lblCurrentDateTime.Text = utility.GetCurrenTimeToPersian();
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
        }

        private void ثبتسربرگآزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceptionHeader frm = new frmReceptionHeader();

            string UserName = lblCurrentUser.Text;
            Employee emp = new DataAccess.EmployeeRepository().GetEmployeeByUserName(UserName);
            int EmployeeID = emp.EmployeeID;
            frm.CurrentEpmloyeeID = EmployeeID;

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
        }

        private void گزارشجامعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHeaderReport frm = new frmHeaderReport();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmHeaderReport)
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
        }
    }
}
