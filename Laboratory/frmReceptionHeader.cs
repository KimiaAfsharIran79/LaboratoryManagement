using DomainModel.Models;
using DomainModel.ViewModel;
using FarsiLibrary.Win.Controls;
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
    public partial class frmReceptionHeader : Form
    {
        DataAccess.ReceptionHeaderRepository repoHeader = new DataAccess.ReceptionHeaderRepository();
        DataAccess.PatientRepository repoPatient = new DataAccess.PatientRepository();
        DataAccess.InsuranceTypeRepository repoIns = new DataAccess.InsuranceTypeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();

        int receptionHeaderID;
        int patientID;
        public int currentEpmloyeeID;
        int receptionDetailsID;
        int testID;

        #region DataBinders
        private void BindGrid()
        {
            grdReceptionDetails.AutoGenerateColumns = false;
            grdReceptionDetails.DataSource = null;
            grdReceptionDetails.DataSource = repoHeader.GetReceptionHeaderItems(receptionHeaderID);
        }

        private void BindTest()
        {
            List<TestListItem> Tests = repoTest.GetAll();
            Tests.Insert(0, new TestListItem { TestID = -1, TestName = "....انتخاب کنید...." });
            cmbTest.DisplayMember = "TestName";
            cmbTest.ValueMember = "TestID";
            cmbTest.DataSource = Tests;
        }
        private void BindInsuranceType()
        {
            List<InsuranceType> insuranceTpye = repoIns.GetAll();
            insuranceTpye.Insert(0, new InsuranceType { InsuranceTypeID = -1, InsuranceTypeName = "....انتخاب کنید...." });
            cmbInsuranceType.DisplayMember = "InsuranceTypeName";
            cmbInsuranceType.ValueMember = "InsuranceTypeID";
            cmbInsuranceType.DataSource = insuranceTpye;
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
                if (ctrl is FADatePicker)
                {
                    var fa = (FADatePicker)ctrl;
                    fa.Text = "[هیج مقداری انتخاب نشده]";
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
                }
            }
        }
        private void ClearPanel()
        {
            cmbTest.SelectedIndex = 0;
            txtPrice.Text = "";
            txtResult.Text = "";
            chkHasStar.Checked = false;
        }
        private void GotoAddMode()
        {
            btnAddTest.Enabled = true;
            btnAddTest.BackColor = Color.SteelBlue;
            btnUpdateTest.Enabled = false;
            btnUpdateTest.BackColor = Color.LightGray;
            btnCancel.Enabled = false;
            btnCancel.BackColor = Color.LightGray;
        }
        private void GotoEditMode()
        {
            btnAddNew.Enabled = false;
            btnAddNew.BackColor = Color.LightGray;
            btnAddTest.Enabled = false;
            btnAddTest.BackColor = Color.LightGray;
            btnUpdateTest.Enabled = true;
            btnUpdateTest.BackColor = Color.SteelBlue;
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
        private void CalculateFinalPrice()
        {
            var totalPrice = Convert.ToInt64(repoHeader.GetTotalPrice(receptionHeaderID));
            if (totalPrice == 0)
            {
                ReceptionHeader item = repoHeader.Get(receptionHeaderID);
                item.TotalPrice = totalPrice;
                repoHeader.UpdateReceptionHeader(item);
            }
            lblTotalPrice.Text = totalPrice.ToString();            
        }
        private void SetHazardRange()
        {
            foreach (DataGridViewRow row in grdReceptionDetails.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    bool hasStar = Convert.ToBoolean(row.Cells[5].Value);
                    if (hasStar)
                    {
                        row.Cells[4].Style.ForeColor = Color.AntiqueWhite;
                        row.Cells[4].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    row.Cells[4].Style.ForeColor = Color.Black;
                    row.Cells[4].Style.BackColor = Color.White;
                }
            }
        }
        #endregion
        public frmReceptionHeader()
        {
            InitializeComponent();
        }

        private void grdReceptionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            receptionDetailsID = Convert.ToInt32(grdReceptionDetails.Rows[e.RowIndex].Cells[0].Value);
            {
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("آیا از حذف مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool s = repoHeader.RemoveReceptionDetails(receptionDetailsID);
                        if (s == true)
                        {                            
                            BindGrid();
                            CalculateFinalPrice();
                            ClearPanel();
                            SetHazardRange();
                        }
                        else
                        {
                            MessageBox.Show("حذف امکانپذیر نمی باشد.");
                        }
                    }
                    
                }
                if (e.ColumnIndex == 6)
                {                    
                    var RD = repoHeader.GetReceptionDetail(receptionDetailsID);
                    testID = RD.TestID;                    
                    cmbTest.SelectedValue = testID;
                    txtResult.Text = Convert.ToString(RD.Result);
                    chkHasStar.Checked = Convert.ToBoolean(RD.HasStar);
                    GotoEditMode();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            int InsID = Convert.ToInt32(cmbInsuranceType.SelectedValue);
            if (InsID == -1)
            {
                err.SetError(cmbInsuranceType, "لطفا نوع بیمه را انتخاب کنید");
                return;
            }
            if (txtDrName.Text != "")
            {
                ReceptionHeader RH = new ReceptionHeader
                {
                    TotalPrice = 0,
                    HeaderDate = (DateTime)faHeaderDate.SelectedDateTime,
                    PatientID = patientID,
                    NationalCode = lblNationalCode.Text,
                    EmployeeID = this.currentEpmloyeeID,
                    InsuranceTypeID = InsID,
                    DrName = txtDrName.Text,
                    HeaderDescription = txtHeaderDescription.Text,
                    Age=Convert.ToInt32(txtAge.Text)

                };// ReceptionHeaderID بطور خودکار توسط دیتابیس تولید می شود     

                receptionHeaderID = repoHeader.RegisterReceptionHeader(RH);               
                MessageBox.Show($"عملیات ثبت سربرگ {receptionHeaderID.ToString()} با موفقیت انجام شد، آزمایشات این سربرگ را وارد کنید.");
                btnAddNew.Enabled = false;
                pnlReceptionDetails.Visible = true;                                
            }
            else
            {
                MessageBox.Show("لطفا نام پزشک را وارد کنید.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (faHeaderDate.SelectedDateTime == null)
            {
                err.SetError(faHeaderDate, "لطفا تاریخ را انتخاب کنید");
                return;
            }
            else
            {
                string Phrase = txtSearch.Text;
                if (lstPatient.Items.Count > 0)
                {
                    lstPatient.DataSource = null;
                }
                if (!string.IsNullOrEmpty(Phrase) && (Phrase.Length >= 1))
                {
                    List<PatientListItem> lst = repoPatient.Search(Phrase);
                    lstPatient.DisplayMember = "PatientFullName";
                    lstPatient.ValueMember = "PatientID";
                    lstPatient.DataSource = lst;
                    lstPatient.Visible = true;
                }
                else
                {
                    lstPatient.Visible = false;
                }
            }
        }
        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            var p = repoPatient.Get(patientID);
            lblPatientFullName.Text = p.FirstName + " " + p.LastName;
            lblNationalCode.Text = p.NationalCode;
            lblMobile.Text = p.Mobile;
            lblAddress.Text = p.Address;            
            lstPatient.Visible = false;
        }

        private void frmReceptionHeader_Load(object sender, EventArgs e)
        {
            pnlTotalPrice.Visible = false;
            pnlReceptionDetails.Visible = false;
            GotoAddMode();
            BindTest();
            BindGrid();
            BindInsuranceType();
        }

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTest.SelectedIndex > 0)
            {
                var t = repoTest.Get(Convert.ToInt32(cmbTest.SelectedValue));
                txtPrice.Text = t.UnitPrice.ToString();
                if (txtPrice.Text == "")
                {
                    txtPrice.Text = "0";
                }
            }
        }

        private void lstPatient_DoubleClick(object sender, EventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            var p = repoPatient.Get(patientID);
            lblPatientFullName.Text = p.FirstName + " " + p.LastName;
            lblNationalCode.Text = p.NationalCode;
            lblMobile.Text = p.Mobile;
            lblAddress.Text = p.Address;
            lstPatient.Visible = false;
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            int testID = Convert.ToInt32(cmbTest.SelectedValue);
            if (testID == -1)
            {
                err.SetError(cmbTest, ".لطفا نام آزمایش را انتخاب کنید");
                return;
            }
            var PreTestID = repoHeader.ExistTestInReceptionDetail(receptionHeaderID, testID);
            if(PreTestID==null)
            {
                var RD = new ReceptionDetail
                {
                    ReceptionHeaderID = receptionHeaderID,
                    TestID = testID,
                    Price = Convert.ToInt64(txtPrice.Text),
                    Result = txtResult.Text.Length < 1 ? 0 : Convert.ToDouble(txtResult.Text),
                    HasStar = chkHasStar.Checked                   
                };
                int receptionDetailsID=repoHeader.RegisterReceptionDetails(RD);
                repoHeader.SetHasStarByResult(receptionDetailsID);
                CalculateFinalPrice();
                BindGrid();
                SetHazardRange();
                pnlTotalPrice.Visible = true;                
            }
            else
            {
                MessageBox.Show("این آزمایش قبلا ثبت شده است.");
            }            
            ClearPanel();
        }

        private void faHeaderDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(faHeaderDate.Text))
            {
                MessageBox.Show("خطا", "لطفا تاریخ را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                faHeaderDate.Focus();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(faHeaderDate.Text))
            {
                MessageBox.Show("خطا", "لطفا تاریخ را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Clear();
                faHeaderDate.Focus();
            }
        }

        private void txtDrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var RD = new ReceptionDetail
            {
                ReceptionDetailsID = receptionDetailsID,
                ReceptionHeaderID = receptionHeaderID,
                TestID = Convert.ToInt32(cmbTest.SelectedValue),
                Price = Convert.ToInt32(txtPrice.Text),
                Result = Convert.ToDouble(txtResult.Text),
                HasStar = chkHasStar.Checked,
            };
            ReceptionDetail repeat = null;
            if(testID!=RD.TestID)
            {
                repeat = repoHeader.ExistTestInReceptionDetail(RD.ReceptionHeaderID,RD.TestID);
            }
            if(repeat==null)
            {
                repoHeader.UpdateReceptionDetails(RD);
                repoHeader.SetHasStarByResult(RD.ReceptionDetailsID);
                BindGrid();
                SetHazardRange();
                CalculateFinalPrice();                
            }
            else
            {
                MessageBox.Show("این آزمایش قبلا ثبت شده است.");
            }
            ClearPanel();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearPanel();
            GotoAddMode();
        }
        
        private void mtxtDrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddFinal_Click(object sender, EventArgs e)
        {
            CalculateFinalPrice();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '۰' && e.KeyChar <= '۹')
            {
                return;
            }
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ی')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtHeaderDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isPersianLetter = (e.KeyChar >= '\u0600' && e.KeyChar <= '\u06FF');

            bool isPersianDigit = (e.KeyChar >= '\u0660' && e.KeyChar <= '\u0669');

            bool isControlCharacter = char.IsControl(e.KeyChar);

            if (isPersianLetter && isPersianDigit && isControlCharacter)
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }
    }
}
