using DomainModel.Models;
using DomainModel.ViewModel;
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
    public partial class frmRange : Form
    {
        DataAccess.TestRangeRepository repo = new DataAccess.TestRangeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdRanges.AutoGenerateColumns = false;
            grdRanges.DataSource = null;
            grdRanges.DataSource = repo.GetAll();
        }
        private void BindTest()
        {
            DataAccess.TestRepository trepo = new DataAccess.TestRepository();
            List<TestListItem> Tests = trepo.GetAll();
            Tests.Insert(0, new TestListItem { TestID = -1, TestName = "....انتخاب کنید...." });
            cmbTest.DisplayMember = "TestName";
            cmbTest.ValueMember = "TestID";
            cmbTest.DataSource = Tests;
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
                if (ctrl is RadioButton)
                {
                    var rdb = (RadioButton)ctrl;
                    rdb.Checked = false;
                }
                if (ctrl is CheckBox)
                {
                    var chk = (CheckBox)ctrl;
                    chk.Checked = false;
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
        #endregion

        public frmRange()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            int TestID = Convert.ToInt32(cmbTest.SelectedValue);
            if (TestID == -1)
            {
                err.SetError(cmbTest, "لطفا نام آزمایش را انتخاب کنید");
                return;
            }
            int Gender = 0;
            if (rdbMale.Checked)
            {
                Gender = 0;
            }
            else if (rdbFemale.Checked)
            {
                Gender = 1;
            }
            else if (rdbBoth.Checked)
            {
                Gender = 2;
            }
            if (cmbTest.Text != "" && txtFromValue.Text != "" && txtToValue.Text != "" && txtFromAge.Text != "" && txtToAge.Text != "")
            {
                TestRange r = new TestRange
                {
                    TestID = Convert.ToInt32(cmbTest.SelectedValue),
                    FromValue = Convert.ToDouble(txtFromValue.Text),
                    ToValue = Convert.ToDouble(txtToValue.Text),
                    FromAge = Convert.ToInt32(txtFromAge.Text),
                    ToAge = Convert.ToInt32(txtToAge.Text),
                    Description = txtDescription.Text,
                    Gender = Gender,
                    Hazard = chkHazard.Checked,
                }; // RangeID بطور خودکار توسط دیتابیس تولید می شود
                bool controlReapetRange = repo.ControlRepeatTest(cmbTest.SelectedIndex);
                bool controlRepeatFromValue = repo.ControlRepeatFromValue(Convert.ToDouble(txtFromValue.Text));
                bool controlRepeatToValue = repo.ControlRepeatToValue(Convert.ToDouble(txtToValue.Text));

                if (controlReapetRange == false&& controlRepeatFromValue==false&& controlRepeatToValue==false)
                {
                    repo.Add(r);
                    ClearForm();
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("رنح ثبت شده تکراری است");
                }
                
            }
            else
            {
                MessageBox.Show("مقادیر نباید خالی باشد");
            }
        }
        
        private void grdRanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdRanges.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    repo.Remove(id);
                    BindGrid();
                }
            }
            else
            {
                if (e.ColumnIndex == 9)
                {
                    var r = repo.Get(id);
                    if (r == null)
                    {
                        MessageBox.Show("رکورد مورد نظر یافت نشد");
                        return;
                    }
                    GotoEditMode();
                    if (r.Gender==0)
                    {
                        rdbMale.Checked = true;
                    }
                    if (r.Gender == 1)
                    {
                        rdbFemale.Checked = true;
                    }
                    if (r.Gender == 2)
                    {
                        rdbBoth.Checked = true;
                    }
                    cmbTest.SelectedValue = r.TestID;
                    txtFromValue.Text = Convert.ToString(r.FromValue);
                    txtToValue.Text = Convert.ToString(r.ToValue);
                    txtFromAge.Text = Convert.ToString(r.FromAge);
                    txtToAge.Text = Convert.ToString(r.ToAge);
                    txtDescription.Text = r.Description;
                    chkHazard.Checked = Convert.ToBoolean(r.Hazard);
                }
            }                                        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Gender = 0;
            if (rdbMale.Checked)
            {
                Gender = 0;
            }
            else if (rdbFemale.Checked)
            {
                Gender = 1;
            }
            else if (rdbBoth.Checked)
            {
                Gender = 2;
            }
            TestRange r = new TestRange
            {
                RangeID = id,
                TestID = Convert.ToInt32(cmbTest.SelectedValue),
                FromValue = Convert.ToDouble(txtFromValue.Text),
                ToValue = Convert.ToDouble(txtToValue.Text),
                FromAge =Convert.ToInt32(txtFromAge.Text),
                ToAge = Convert.ToInt32(txtToAge.Text),
                Gender = Gender,
                Hazard = chkHazard.Checked,
            };
            repo.Update(r);
            BindGrid();
            ClearForm();
            GotoAddMode();
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {
             ClearForm();
            GotoAddMode();
        }

        private void frmRange_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
            BindTest();
        }

        private void txtFromAge_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
           {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
           }
        }       

        private void txtToAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }

        private void txtFromValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد اعشاری وارد کنید");
            }
            if(e.KeyChar=='.'&&(sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("  عدد اعشاری  فقط باید یک نقطه داشته باشد");
            }
        }
        private void txtToValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد اعشاری وارد کنید");
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("  عدد اعشاری  فقط باید یک نقطه داشته باشد");
            }
        }

        private void txtToValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد اعشاری وارد کنید");
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MessageBox.Show("  عدد اعشاری  فقط باید یک نقطه داشته باشد");
            }
        }        
    }        
}
        


