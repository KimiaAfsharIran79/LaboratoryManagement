using DomainModel.Models;
using FarsiLibrary.Win.Controls;
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
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        var rdb = (RadioButton)ctrl;
                        rdb.Checked = false;
                    }
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

        #endregion
        #region Checking
        private bool CheckIsNumericWithLength(string input, int length)
        {
            return !string.IsNullOrEmpty(input) &&
                   input.Length == length &&
                   long.TryParse(input, out _);
        }
        private bool CheckIsPersianLetters(string input)
        {
            string pattern = @"^[\u0600-\u06FF\s]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        private bool CheckAddress(string input)
        {
            string pattern = @"^[\u0600-\u06FF0-9,.\-_ ]*$";
            return  Regex.IsMatch(input, pattern);
        }
        private bool CheckInputs()
        {
            bool result = true;
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtPatientName":
                            if (!CheckIsPersianLetters(txt.Text))
                            {
                                err.SetError(txtPatientName, "نام را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtPatientFamily":
                            if (!CheckIsPersianLetters(txt.Text))
                            {
                                err.SetError(txtPatientFamily, "نام خانوادگی را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtPatientAddress":
                            if (!CheckAddress(txt.Text))
                            {
                                err.SetError(txtPatientAddress, "آدرس را به درستی وارد نمایید");
                                result = false;
                            }
                            break;
                    }                    
                }
                if (ctrl is MaskedTextBox mtxt)
                {
                    switch (mtxt.Name)
                    {
                        case "mtxtPatientMobile":
                            if (!CheckIsNumericWithLength(mtxt.Text, 11))
                            {
                                err.SetError(mtxtPatientMobile, "شماره موبایل را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "mtxtNationalcode":
                            if (!CheckIsNumericWithLength(mtxt.Text, 10))
                            {
                                err.SetError(mtxtNationalcode, "کد ملی را به درستی وارد نمایید");
                                result = false;
                            }
                            break;
                    }
                }
            }
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is RadioButton rdb)
                    {
                        if (!rdbMale.Checked && !rdbFemale.Checked)
                        {
                            err.SetError(grpGender, "لطفا جنسیت را انتخاب کنید!!");
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
        #endregion

        public frmPatient()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bool gender = rdbFemale.Checked;
            if (CheckInputs())
            {
                bool controlRepeat = repo.ControlRepeatPatient(mtxtNationalcode.Text.ToString());
                if (controlRepeat == false)
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
                    repo.Add(p);
                    ClearForm();
                    err.Clear();
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
                MessageBox.Show("لطفا مقادیر را به درستی وارد کنید.");
            }
        }


        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdPatients.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {                
                if (MessageBox.Show("آیا از حذف مطمئنید؟", "هشدار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {                    
                    bool hasHeader = repo.HasReceptionHeader(id);
                    if (!hasHeader)
                    {
                        err.Clear();
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
                err.Clear();
                var p = repo.Get(id);
                GotoEditMode();
                if (p.Gender) rdbFemale.Checked = true; else rdbMale.Checked = true;
                txtPatientName.Text = p.FirstName;
                txtPatientFamily.Text = p.LastName;
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
            err.Clear();
            ClearForm();
            GotoAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool gender = rdbFemale.Checked;
            if (CheckInputs())
            {
                bool controlRepeat = repo.ControlRepeatPatient(mtxtNationalcode.Text.ToString());
                if (controlRepeat == false)
                {
                    Patient p = new Patient
                    {
                        PatientID = id,
                        FirstName = txtPatientName.Text,
                        LastName = txtPatientFamily.Text,
                        Gender = gender,
                        NationalCode = mtxtNationalcode.Text,
                        Mobile = mtxtPatientMobile.Text,
                        Address = txtPatientAddress.Text,
                    };
                    repo.Update(p);
                    BindGrid();
                    ClearForm();
                    GotoAddMode();
                }
                else
                {
                    MessageBox.Show(" بیمار با این کد ملی قبلا ثبت شده ، لطفا دقت کنید");
                    mtxtNationalcode.Focus();
                }
            }
            else
            {
                MessageBox.Show("لطفا مقادیر را درست وارد کنید.");
            }            
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
            if(!((e.KeyChar >= '\u0600' && e.KeyChar <= '\u06FF')||
                (e.KeyChar>='0'&&e.KeyChar<='9')||
                (e.KeyChar >= '\u0660' && e.KeyChar <= '\u0669')||
                e.KeyChar=='\b'||e.KeyChar==' '||e.KeyChar==','))
            {
                e.Handled=true;
            }            
        }

        private void mtxtNationalcode_Leave(object sender, EventArgs e)
        {
            if (mtxtNationalcode.Text.Length != 10)
            {
                err.SetError(mtxtNationalcode, "کد ملی را به درستی وارد نمایید");
            }           
        }

        private void mtxtPatientMobile_Leave(object sender, EventArgs e)
        {
            if (mtxtPatientMobile.Text.Length != 11)
            {
                err.SetError(mtxtPatientMobile, "شماره موبایل را به درستی وارد نمایید");
            }
        }
    }
}

