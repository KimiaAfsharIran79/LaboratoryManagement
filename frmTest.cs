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
    public partial class frmTest : Form
    {     
        DataAccess.TestRepository repo = new DataAccess.TestRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdTests.AutoGenerateColumns = false;
            grdTests.DataSource = null;
            grdTests.DataSource = repo.GetAll();
        }
        private void BindCat()
        {
            DataAccess.TestCategoryRepository repoCat = new DataAccess.TestCategoryRepository();
            List<TestCategory> categories = repoCat.GetAll();
            categories.Insert(0, new TestCategory { CategoryID = -1, CategoryName = "....انتخاب کنید...." });
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = categories;
        }
        private void BindUnit()
        {
            DataAccess.UnitRepository repoUnit = new DataAccess.UnitRepository();
            List<Unit> units = repoUnit.GetAll();
            units.Insert(0, new Unit { UnitID = -1, UnitName = "....انتخاب کنید...." });
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = units;
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
        private void ValidatePersianText(TextBox textBox)
        {
            Regex regex = new Regex("^[\u0600-\u06FF\\s]*$");
            if (!regex.IsMatch(textBox.Text))
            {
                MessageBox.Show("لطفا فقط حروف فارسی وارد کنید");
                textBox.Text = regex.Replace(textBox.Text, "");
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        #endregion
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
            BindCat();
            BindUnit();
        }        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text != "") 
            {
                err.Clear();
                int UnitID = Convert.ToInt32(cmbUnit.SelectedValue);
                if (UnitID == -1)
                {
                    err.SetError(cmbUnit, "لطفا واحد را انتخاب کنید");
                    return;
                }
                int CatID = Convert.ToInt32(cmbCategory.SelectedValue);
                if (CatID == -1)
                {
                    err.SetError(cmbCategory, "لطفا رده را انتخاب کنید");
                    return;
                }

                bool ageHasEffect = chkAge.Checked;
                bool genderHasEffect = chkGender.Checked;
                if (txtTestName.Text != "" && cmbUnit.Text != "" && cmbCategory.Text != "" && txtUnitPrice.Text != "")
                {
                    Test t = new Test
                    {
                        TestName = txtTestName.Text,
                        UnitID = UnitID,
                        CategoryID = CatID,
                        AgeHasEffect = ageHasEffect,
                        GenderHasEffect = genderHasEffect,
                        UnitPrice = Convert.ToInt64(txtUnitPrice.Text),
                    }; // TestID بطور خودکار توسط دیتابیس تولید می شود

                    bool controlRepeat = repo.ControlRepeatTest(txtTestName.Text.ToString());
                    if (controlRepeat == false)
                    {
                        repo.Add(t);
                        ClearForm();
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show(" آزمایش تکراری است ، لطفا دقت کنید");
                        txtTestName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("مقادیر نباید خالی باشد");
                }
            }
            else
            {
                MessageBox.Show("نام آزمایش را وارد کنید");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text != "")
            {
                err.Clear();
                int UnitID = Convert.ToInt32(cmbUnit.SelectedValue);
                if (UnitID == -1)
                {
                    err.SetError(cmbUnit, "لطفا واحد را انتخاب کنید");
                    return;
                }
                int CatID = Convert.ToInt32(cmbCategory.SelectedValue);
                if (CatID == -1)
                {
                    err.SetError(cmbCategory, "لطفا رده را انتخاب کنید");
                    return;
                }
                bool ageHasEffect = chkAge.Checked;
                bool genderHasEffect = chkGender.Checked;
                Test t = new Test
                {
                    TestID = id,
                    TestName = txtTestName.Text,
                    UnitID = Convert.ToInt32(cmbUnit.SelectedValue),
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    AgeHasEffect = ageHasEffect,
                    GenderHasEffect = genderHasEffect,
                    UnitPrice = Convert.ToInt64(txtUnitPrice.Text)
                };
                repo.Update(t);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
        }

        private void grdTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdTests.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool hasRD = repo.HasReceptionDetail(id);
                    if (!hasRD)
                    {
                        repo.Remove(id);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این آزمایش دارای جزِئیات آزمایش می باشد");
                    }
                }
            }
            if (e.ColumnIndex == 7)
            {

                var t = repo.Get(id);
                GotoEditMode();
                if (t.AgeHasEffect)
                {
                    chkAge.Checked = true;
                }
                if (t.GenderHasEffect)
                {
                    chkGender.Checked = true;
                }
                txtTestName.Text = t.TestName;
                cmbUnit.SelectedValue=t.UnitID;
                cmbCategory.SelectedValue = t.CategoryID;
                txtUnitPrice.Text =Convert.ToString(t.UnitPrice);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }
    }
}
