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
    public partial class frmUnit : Form
    {
        
        DataAccess.UnitRepository repo = new DataAccess.UnitRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdUnits.AutoGenerateColumns = false;
            grdUnits.DataSource = null;
            grdUnits.DataSource = repo.GetAll();
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

        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text != "") 
            {
                Unit u = new Unit
                {
                    UnitName = txtUnitName.Text,
                    Description = txtUnitDescription.Text
                };
                repo.Add(u);
                ClearForm();
                BindGrid();
            }
                
        }// UnitID بطور خودکار توسط دیتابیس تولید می شود

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Unit u = new Unit
            {
                UnitID = id,
                UnitName = txtUnitName.Text,
                Description = txtUnitDescription.Text,
            };
            repo.Update(u);
            BindGrid();
            ClearForm();
            GotoAddMode();
        }

        private void grdUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdUnits.Rows[e.RowIndex].Cells[0].Value);
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
                        MessageBox.Show("این واحد دارای آزمایش زیر مجموعه است");
                    }
                }
            }

            if (e.ColumnIndex == 3)
            {
                var unit = repo.Get(id);
                GotoEditMode();
                txtUnitName.Text = unit.UnitName;
                txtUnitDescription.Text = unit.Description;                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }       
    }
}
