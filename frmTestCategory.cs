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
    public partial class frmTestCategory : Form
    {
        
        DataAccess.TestCategoryRepository repo = new DataAccess.TestCategoryRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdTestCategory.AutoGenerateColumns = false;
            grdTestCategory.DataSource = null;
            grdTestCategory.DataSource = repo.GetAll();
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
                    cmb.Text = "";
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

        public frmTestCategory()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtCatgoryName.Text != "")
            {
                TestCategory testcat = new TestCategory
                {
                    CategoryName = txtCatgoryName.Text,
                    Description = txtCatDescription.Text
                };
                repo.Add(testcat);
                ClearForm();
                BindGrid();
            }
            else
            {
                MessageBox.Show("لطفا تام رده را وارد کنید");
            }
        }// TestCategoryID بطور خودکار توسط دیتابیس تولید می شود

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCatgoryName.Text != "") 
            {
                TestCategory testcat = new TestCategory
                {
                    CategoryID = id,
                    CategoryName = txtCatgoryName.Text,
                    Description = txtCatDescription.Text,
                };
                repo.Update(testcat);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
            else
            {
                MessageBox.Show("لطفا تام رده را وارد کنید");
            }
        }

        private void grdCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdTestCategory.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool hastest = repo.HasTest(id);
                    if (!hastest)
                    {
                        repo.Remove(id);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این رده دارای آزمایش زیر مجموعه است");
                    }
                }
            }

            if (e.ColumnIndex == 3)
            {
                var testcat = repo.Get(id);
                GotoEditMode();
                txtCatgoryName.Text = testcat.CategoryName;
                txtCatDescription.Text = testcat.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void txtCatDescription_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

