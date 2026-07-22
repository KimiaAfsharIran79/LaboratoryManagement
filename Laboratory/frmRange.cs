using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        int testID;
        int gender = 2;
        int fromAge = 1;
        int toAge = 200;

        #region DataBinders
        private void BindGrid()
        {
            grdRanges.AutoGenerateColumns = false;
            grdRanges.DataSource = null;
            grdRanges.DataSource = repo.GetRangeByTestID(testID);
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
                if(ctrl is GroupBox)
                {
                }
                if (ctrl is TextBox)
                {
                    var txt = (TextBox)ctrl;
                    txt.Text = "";
                }
                if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = 0;
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
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is TextBox textBox)
                    {
                        var txt = (TextBox)ctrl;
                        txt.Text = "";
                    }
                    if (ctrl is ComboBox)
                    {
                        var cmb = (ComboBox)ctrl;
                        cmb.SelectedIndex = 0;
                    }
                    if (ctrl is RadioButton)
                    {
                        var rdb = (RadioButton)ctrl;
                        rdb.Checked = false;
                        gender = 2;
                    }
                }
            }
            lblTestName.Text = "";
        }
        private void GotoAddMode()
        {
            btnAddNew.Enabled = true;
            btnAddNew.BackColor=Color.SteelBlue;
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.LightGray;
            btnCancel.Enabled = false;            
            btnCancel.BackColor = Color.LightGray;
        }
        private void GotoEditMode()
        {            
            btnAddNew.Enabled = false;
            btnAddNew.BackColor = Color.LightGray;
            btnUpdate.Enabled = true;
            btnUpdate.BackColor = Color.SteelBlue;
            btnCancel.Enabled = true;
            btnCancel.BackColor = Color.SteelBlue;
        }

        private void GetGender()
        {
            if (rdbMale.Checked)
            {
                gender = 0;
            }
            else if (rdbFemale.Checked)
            {
                gender = 1;
            }
            else 
            {
                gender = 2;
            }
        }
        private void SetEffect()
        {
            var t = repoTest.Get(testID);
            if (!t.AgeHasEffect)
            {
                grpAge.Enabled = false;
            }
            else
            {
                grpAge.Enabled = true;
            }

            if (!t.GenderHasEffect)
            {
                grpGender.Enabled = false;
            }
            else
            {
                grpGender.Enabled = true;
            }
        }
        #endregion

        public frmRange()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            GetGender();
            if (txtFromValue.Text != "" && txtToValue.Text != "")
            {
                TestRange r = new TestRange
                {
                    TestID = testID,
                    FromValue = Convert.ToDouble(txtFromValue.Text),
                    ToValue = Convert.ToDouble(txtToValue.Text),
                    FromAge = fromAge,
                    ToAge = toAge,
                    Description = txtDescription.Text,
                    Gender = gender,
                    Hazard = chkHazard.Checked,
                }; // RangeID بطور خودکار توسط دیتابیس تولید می شود

                repo.Add(r);
                BindGrid();
                ClearForm();
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
                if (MessageBox.Show("آیا از حذف مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool s = repo.Remove(id);
                    if (s)
                    {
                        BindGrid();                        
                    }
                    else
                    {
                        MessageBox.Show("عملیات حذف امکانپذیر پذیر نمی باشد.");
                    }
                }
            }
            if (e.ColumnIndex == 9)
            {
                var r = repo.Get(id);
                if (r == null)
                {
                    MessageBox.Show("رکورد مورد نظر یافت نشد");
                    return;
                }
                GotoEditMode();
                if (r.Gender == 0)
                {
                    rdbMale.Checked = true;
                }
                if (r.Gender == 1)
                {
                    rdbFemale.Checked = true;
                }
                if(r.Gender == 2)   
                {
                    rdbMale.Checked= false;
                    rdbFemale.Checked= false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetGender();
            if (txtFromValue.Text != "" && txtToValue.Text != "")
            {
                TestRange r = new TestRange
                {
                    RangeID = id,
                    TestID = Convert.ToInt32(cmbTest.SelectedValue),
                    FromValue = Convert.ToDouble(txtFromValue.Text),
                    ToValue = Convert.ToDouble(txtToValue.Text),
                    FromAge = fromAge,
                    ToAge = toAge,
                    Description = txtDescription.Text,
                    Gender = gender,
                    Hazard = chkHazard.Checked,
                };
                repo.Update(r);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
            else
            {
                MessageBox.Show("مقادیر نباید خالی باشد");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void frmRange_Load(object sender, EventArgs e)
        {
            GotoAddMode();
            BindTest();
        }

        private void txtFromAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Phrase = txtSearch.Text;
            if (lstTest.Items.Count > 0)
            {
                lstTest.DataSource = null;
            }
            if (!string.IsNullOrEmpty(Phrase) && (Phrase.Length >= 1))
            {
                List<TestListItem> lst = repoTest.Search(Phrase);
                lstTest.DisplayMember = "TestName";
                lstTest.ValueMember = "TestID";
                lstTest.DataSource = lst;
                lstTest.Visible = true;
            }
            else
            {
                lstTest.Visible = false;
            }
        }
        private void lstTest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            testID = Convert.ToInt32(lstTest.SelectedValue);
            var t = repoTest.Get(testID);
            lblTestName.Text = t.TestName;
            cmbTest.SelectedValue = testID;
            lstTest.Visible = false;
            SetEffect();
            BindGrid();
        }

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            err.Clear();
            testID = Convert.ToInt32(cmbTest.SelectedValue);
            if (testID <= 0)
            {
                err.SetError(cmbTest, "لطفا نام آزمایش را انتخاب کنید");
            }
            else
            {
                var t = repoTest.Get(testID);
                lblTestName.Text = t.TestName;
                txtSearch.Text = t.TestName;
                SetEffect();
                BindGrid();
            }
        }

        private void txtFromAge_TextChanged(object sender, EventArgs e)
        {
            if (txtFromAge.Text.Length > 0)    fromAge = Convert.ToInt32(txtFromAge.Text);
        }

        private void txtToAge_TextChanged(object sender, EventArgs e)
        {
            if (txtToAge.Text.Length > 0)    toAge = Convert.ToInt32(txtToAge.Text);
        }        
    }   
}



