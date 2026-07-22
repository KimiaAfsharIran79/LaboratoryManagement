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
    public partial class frmInsuranceType : Form
    {
        DataAccess.InsuranceTypeRepository repo = new DataAccess.InsuranceTypeRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdInsuranceType.AutoGenerateColumns = false;
            grdInsuranceType.DataSource = null;
            grdInsuranceType.DataSource = repo.GetAll();
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
                    cmb.SelectedIndex = 0;                    
                }
            }
        }
        private void GotoAddMode()
        {
            btnAddNew.Enabled = true;
            btnAddNew.BackColor = Color.SteelBlue;
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
        private bool IsPersianCharacter(char c)
        {
            return (c >= 0x0600 && c <= 0x06FF) ||
                   (c >= 0xFB50 && c <= 0xFDFF) ||
                   (c >= 0xFE70 && c <= 0xFeFF) ||
                   c == ' ' || c == '\b';
        }

        #endregion

        public frmInsuranceType()
        {
            InitializeComponent();
        }
        private void frmInsuranceType_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtInsuranceName.Text != "")
            {
                InsuranceType ins = new InsuranceType
                {
                    InsuranceTypeName = txtInsuranceName.Text,
                    Description = txtInsDescription.Text
                };
                repo.Add(ins);
                ClearForm();
                BindGrid();
            }            
        }// InsuranceTypeID بطور خودکار توسط دیتابیس تولید می شود

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InsuranceType ins = new InsuranceType
            {
                InsuranceTypeID = id,
                InsuranceTypeName = txtInsuranceName.Text,
                Description = txtInsDescription.Text,
            };
            repo.Update(ins);
            BindGrid();
            ClearForm();
            GotoAddMode();
        }

        private void grdInsuranceType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdInsuranceType.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("آیا از حذف مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool hasRH = repo.HasReceptionHeader(id);
                    if (!hasRH)
                    {
                        repo.Remove(id);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این بیمه دارای سربرگ آزمایش است");
                    }
                }
            }

            if (e.ColumnIndex == 3)
            {
                var ins = repo.Get(id);
                GotoEditMode();
                txtInsuranceName.Text = ins.InsuranceTypeName;
                txtInsDescription.Text = ins.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void txtInsuranceName_KeyPress(object sender, KeyPressEventArgs e)
        {                       
                if (!IsPersianCharacter(e.KeyChar))
                {
                    e.Handled = true;
                }            
        }
    }
}
