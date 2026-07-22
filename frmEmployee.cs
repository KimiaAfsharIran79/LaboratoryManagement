using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmEmployee : Form
    {
        DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdEmployee.AutoGenerateColumns = false;
            grdEmployee.DataSource = null;
            grdEmployee.DataSource = repo.GetAll();
        }

        #endregion
        #region Utility
        private void ClearForm()
        {
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    var txt = (TextBox)ctrl;
                    txt.Text = "";
                }
                if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
            }
        }
        private void GotoAddMode()
        {
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void GotoEditMode()
        {
            btnAddNew.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }
        private bool IsPersianCharacter(char c)
        {
            return (c >= 0x0600 && c <= 0x06FF) ||
                   (c >= 0xFB50 && c <= 0xFDFF) ||
                   (c >= 0xFE70 && c <= 0xFeFF) ||
                   c == ' ' || c == '\b';
        }
        #endregion
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                Employee emp = new Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    IsActive = IsActive
                }; // EmployeeID  بطور خودکار توسط دیتابیس تولید می شود

                bool controlRepeat = repo.ControlRepeatEmoloyee(txtUserName.Text.ToString());
                if (controlRepeat == false)
                {
                    repo.Add(emp);
                    ClearForm();
                    BindGrid();
                }
                else
                {
                    MessageBox.Show(" کارمند تکراری است ، لطفا دقت کنید");
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("مقادیر نباید خالی باشد");
            }
        }

        private void grdUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdEmployee.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!repo.HasReceptionHeader(id))
                    {
                        bool s = repo.Remove(id);
                        if (s)
                        {
                            BindGrid();
                        }
                        else
                        {
                            MessageBox.Show("عمیات حذف امکان پذیر نمی باشد");
                        }
                    }
                    else
                    {
                        MessageBox.Show("کارمند سربرگ پذیرش مرتبط دارد");
                    }
                }
            }
            if (e.ColumnIndex == 5)
            {
                var emp = repo.Get(id);
                GotoEditMode();
                if (emp.IsActive)
                {
                    rdbActive.Checked = true;
                }
                else
                {
                    rdbDeActive.Checked = true;
                }
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtUserName.Text = emp.UserName;
                txtPassword.Text = emp.Password;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;
            Employee employee = new Employee
            {
                EmployeeID = id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                IsActive = IsActive
            };
            repo.Update(employee);
            BindGrid();
            ClearForm();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z-0-9_.\-@]") && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("خطا", ".فقط حروف انگلیسی،اعداد و علایم(@ _ - .) مجازند", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z-0-9_.\-@]") && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("خطا", ".فقط حروف انگلیسی،اعداد و علایم(@ _ - .) مجازند", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
