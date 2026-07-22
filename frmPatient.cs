using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmPatient : Form
    {

        DataAccess.PatientRepository repo = new DataAccess.PatientRepository();
        int id;
        #region DataBinders
        private void BindGrid()
        {
            grdPatients.AutoGenerateColumns = false;
            grdPatients.DataSource = null;
            grdPatients.DataSource = repo.GetAll();
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
                if (ctrl is RadioButton)
                {
                    var rdb = (RadioButton)ctrl;
                    rdb.Checked = false;
                }
                if (ctrl is MaskedTextBox)
                {
                    var mtxt = (MaskedTextBox)ctrl;
                    mtxt.Text = "";
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
        private bool IsPersianCharacter(char c)
        {
            return (c >= 0x0600 && c <= 0x06FF) ||
                   (c >= 0xFB50 && c <= 0xFDFF) ||
                   (c >= 0xFE70 && c <= 0xFeFF) ||
                   c == ' ' || c == '\b';
        }
        private bool IsValidCharacter(char c)
        {
            return char.IsControl(c) || char.IsDigit(c) || (c >= 'آ' && c <= 'ی');
        }

        #endregion

        public frmPatient()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {           
            bool gender = rdbMale.Checked;
            if (txtPatientName.Text != "" && txtPatientFamily.Text != "" && mtxtNationalcode.Text != "" && mtxtPatientMobile.Text != "")
            {
                Patient p = new Patient
                {
                    FirstName = txtPatientName.Text,
                    LastName = txtPatientFamily.Text,
                    Gender = gender,
                    NationalCode = mtxtNationalcode.Text,
                    Mobile = mtxtPatientMobile.Text,
                    Address = txtPatientAddress.Text,
                }; // PatientID بطور خودکار توسط دیتابیس تولید می شود
                bool controlRepeat = repo.ControlRepeatPatient(mtxtNationalcode.Text.ToString());
                if (controlRepeat == false)
                {
                    repo.Add(p);
                    ClearForm();
                    BindGrid();
                }
                else
                {
                    MessageBox.Show(" بیمار با این کد ملی قبلا ثبت شده ، لطفا دقت کنید");
                    mtxtNationalcode.Focus();
                }
            }
            else
            {
                MessageBox.Show("مقادیر نباید خالی باشد");
            }
        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdPatients.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool hasHeader = repo.HasReceptionHeader(id);
                    if (!hasHeader)
                    {
                        repo.Remove(id);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این بیمار دارای سربرگ آزمایش می باشد");
                    }
                }
            }            
            if (e.ColumnIndex == 7)
            {
                var p = repo.Get(id);
                GotoEditMode();
                if(p.Gender)
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }
                txtPatientName.Text = p.FirstName;
                txtPatientFamily.Text=p.LastName;               
                mtxtNationalcode.Text = p.NationalCode;
                mtxtPatientMobile.Text = p.Mobile;                                
                txtPatientAddress.Text = p.Address;  
            }
        }
        private void frmPatient_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool Gender = rdbMale.Checked;
            Patient p = new Patient
            {
                PatientID = id,
                FirstName = txtPatientName.Text,
                LastName = txtPatientFamily.Text,
                Gender = Gender,
                NationalCode = mtxtNationalcode.Text,
                Mobile = mtxtPatientMobile.Text,
                Address = txtPatientAddress.Text,
            };
            repo.Update(p);
            BindGrid();
            ClearForm();
            GotoAddMode();
        }                       

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            ValidatePersianText(txtPatientName);
        }

        private void txtPatientFamily_TextChanged(object sender, EventArgs e)
        {
            ValidatePersianText(txtPatientFamily);
        }

        private void txtPatientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
            }
        }

        private void txtPatientFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
            }

        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPatientFamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtxtNationalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }

        private void mtxtPatientMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }

        private void txtPatientAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}

