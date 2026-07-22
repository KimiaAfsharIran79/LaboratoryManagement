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
using System.Globalization;

namespace Laboratory
{
    public partial class frmReceptionHeader : Form
    {
        DataAccess.ReceptionHeaderRepository repo = new DataAccess.ReceptionHeaderRepository();
        DataAccess.PatientRepository repoPatient = new DataAccess.PatientRepository();
        DataAccess.InsuranceTypeRepository repoIns = new DataAccess.InsuranceTypeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();

        int PatientID = 0;
        public int CurrentEpmloyeeID;
        int ReceptionHeaderID = 0;
        int ReceptionDetailsID = 0;
        float Result = 0;
       
        #region DataBinders
        private void BindGrid()
        {
            grdReceptionDetails.AutoGenerateColumns = false;
            grdReceptionDetails.DataSource = null;
            grdReceptionDetails.DataSource = repo.GetReceptionHeaderItems(ReceptionHeaderID);
        }

        private void BindTest()
        {            
            List<TestListItem> Tests = repoTest.GetAll();
            Tests.Insert(0, new TestListItem { TestID = -1, TestName = "....انتخاب کنید...." });
            cmbTest.DisplayMember = "TestName";
            cmbTest.ValueMember = "TestID";
            cmbTest.DataSource = Tests;
        }
        private void BindInsuranceTpye()
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
        private void ClearPanel()
        {
            cmbTest.SelectedIndex = 0;            
            lblPrice.Text = "";
            txtResult.Text = "";
            chkHasStar.Checked = false;
        }
        private void GotoAddMode()
        {
            btnAddNew.Enabled = true;
            btnUpdateTest.Enabled = false;
            btnCancel.Enabled = false;
            btnAddPay.Enabled = true;
            txtTotalPrice.Enabled = false;
        }
        private void GotoEditMode()
        {
            btnAddNew.Enabled = false;
            btnAddTest.Enabled = false;
            btnUpdateTest.Enabled = true;
            btnCancel.Enabled = true;
            btnAddPay.Enabled = false;
        }
        private void GotoPayMode()
        {
            btnAddNew.Enabled = false;
            btnUpdateTest.Enabled = false;
            btnCancel.Enabled = false;
            btnAddPay.Enabled = true;
            txtTotalPrice.Enabled=true;
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
        private string GetPersianDayOfWeek(DateTime dt)
        {
            var persianCulture = new CultureInfo("fa-IR");
            return persianCulture.DateTimeFormat.GetDayName(dt.DayOfWeek);
        }
        private string GetPersianDateTimeWithDayOfWeek()
        {            
            PersianCalendar pc = new PersianCalendar();
            DateTime now=DateTime.Now;
            int year = pc.GetYear(now);
            int month = pc.GetMonth(now);            
            int day=pc.GetDayOfMonth(now);
            
            string dayOfeWeek= GetPersianDayOfWeek(now);
            int hour=now.Hour;
            int minute=now.Minute;
            int second=now.Second;
            return $"{dayOfeWeek}{year: 0000}/{ month: 00}/{ day:00}     {hour:00} : {minute:00} : {second:00}";            
        }

        #endregion
        public frmReceptionHeader()
        {
            InitializeComponent();            
        }
       
        private void grdReceptionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceptionDetailsID = Convert.ToInt32(grdReceptionDetails.Rows[e.RowIndex].Cells[0].Value);
            {
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool hasRepHeader = repo.HasReceptionHeader(ReceptionHeaderID); ;
                        if (hasRepHeader == true)
                        {
                            MessageBox.Show("آزمایشی برای این سربرگ پذیرش ثبت شده است");
                            return;
                        }
                        bool s = repo.RemoveReceptionDetails(ReceptionDetailsID);
                        if (s == true)
                        {
                            BindGrid();
                        }
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    var RD = repo.GetReceptionDetail(ReceptionDetailsID);
                    cmbTest.SelectedValue = RD.TestID;                    
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
            if (txtPatientDescription.Text != "" && txtDrName.Text != "" && cmbInsuranceType.SelectedValue != null)
            {
                ReceptionHeader RH = new ReceptionHeader
                {
                    TotalPrice = 0,
                    HeaderDate = (DateTime)faHeaderDate.SelectedDateTime,
                    PatientID = PatientID,
                    NationalCode = lblNationalCode.Text,
                    EmployeeID = this.CurrentEpmloyeeID,
                    InsuranceTypeID = InsID,
                    DrName = txtDrName.Text,
                };// ReceptionHeaderID بطور خودکار توسط دیتابیس تولید می شود     

                ReceptionHeaderID = repo.RegisterReceptionHeader(RH);
                pnlReceptionDetails.Visible = true;
                ClearForm();
            }
            else
            {
                MessageBox.Show("مقادیر نباید خالی باشد");
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
                    lstPatient.DisplayMember = "Information";
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
            PatientID = Convert.ToInt32(lstPatient.SelectedValue);
            var p = repoPatient.Get(PatientID);
            lblPatientName.Text = p.FirstName;
            lblPatientFamily.Text = p.LastName;
            lblNationalCode.Text = p.NationalCode;
            lblMobile.Text = p.Mobile;
            lblAddress.Text = p.Address;
            lstPatient.Visible = false;
        }

        private void frmReceptionHeader_Load(object sender, EventArgs e)
        {                    
            pnlReceptionDetails.Visible = false;
            GotoAddMode();
            BindTest();
            BindGrid();
            BindInsuranceTpye();
        }     

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTest.SelectedIndex > 0)
            {
                var t = repoTest.Get(Convert.ToInt32(cmbTest.SelectedValue));
                lblPrice.Text = t.UnitPrice.ToString();
                if (lblPrice.Text == "")
                {
                    lblPrice.Text = "0";
                }
            }
        }

        private void lstPatient_DoubleClick(object sender, EventArgs e)
        {
            PatientID = Convert.ToInt32(lstPatient.SelectedValue);
            var p = repoPatient.Get(PatientID);
            lblPatientName.Text = p.FirstName;
            lblPatientFamily.Text = p.LastName;
            lblNationalCode.Text = p.NationalCode;
            lblMobile.Text = p.Mobile;
            lblAddress.Text = p.Address;
            lstPatient.Visible = false;
        }
       
        private void btnAddTest_Click(object sender, EventArgs e)
        {
            err.Clear();
            int TestID = Convert.ToInt32(cmbTest.SelectedValue);           
            if (TestID == -1)
            {
                err.SetError(cmbTest, "لطفا نام آزمایش را انتخاب کنید");
                return;
            }
            //if (txtResult.Text == "") 
            //{
            //    err.SetError(txtResult, "لطفا نتیجه آزمایش را وارد کنید");
            //    return;
            //}
            var PreReceptionDetailsItem=repo.ExistTestInReceptionHeader(ReceptionHeaderID,Convert.ToInt32(cmbTest.SelectedValue));
            if (PreReceptionDetailsItem==null)
            {                
                    var RD = new ReceptionDetail
                    {
                        Result=0,
                        ReceptionHeaderID = ReceptionHeaderID,
                        TestID = Convert.ToInt32(cmbTest.SelectedValue),
                        Price = Convert.ToInt64(lblPrice.Text),
                        HasStar = chkHasStar.Checked,
                        //Result = Convert.ToDouble(txtResult.Text)
                    };
                    repo.RegisterReceptionDetails(RD);                                
            }           
            BindGrid();
            ClearForm();
            ClearPanel();
            GotoPayMode();
        }

        private void faHeaderDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(faHeaderDate.Text))
            {
                MessageBox.Show("خطا", "لطفا تاریخ را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                faHeaderDate.Focus();
            }
        }

        private void txtDrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!IsPersianCharacter(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            err.Clear();
            int TestID = Convert.ToInt32(cmbTest.SelectedValue);
            if (TestID == -1)
            {
                err.SetError(cmbTest, "لطفا نام آزمایش را انتخاب کنید");
                return;
            }
            if (txtResult.Text == "")
            {
                err.SetError(txtResult, "لطفا نتیجه آزمایش را وارد کنید");
                return;
            }
            double result; 
            if(!double.TryParse(txtResult.Text,out result))
            {
                MessageBox.Show("خطا","لطفا یک عدد اعشاری معتبر وارد کنید.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var RD = new ReceptionDetail
            {
                ReceptionDetailsID = ReceptionDetailsID,
                ReceptionHeaderID = ReceptionHeaderID,
                TestID = Convert.ToInt32(cmbTest.SelectedValue),
                Price = Convert.ToInt32(lblPrice.Text),
                Result= Convert.ToDouble(txtResult.Text),
                HasStar=chkHasStar.Checked,
            };
            repo.UpdateReceptionDetails(RD);
            BindGrid();
            ClearPanel();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }               

        private void btnAddPay_Click(object sender, EventArgs e)
        {
           var finalPay = Convert.ToInt32(repo.GetTotalPrice(ReceptionHeaderID));
            txtTotalPrice.Text=finalPay.ToString();
            err.Clear();
            int InsID = Convert.ToInt32(cmbInsuranceType.SelectedValue);
            if (InsID == -1)
            {
                err.SetError(cmbInsuranceType, "لطفا نوع بیمه را انتخاب کنید");
                return;
            }
            ReceptionHeader RH = new ReceptionHeader
            {
                TotalPrice = Convert.ToInt32(txtTotalPrice.Text),
                HeaderDate = (DateTime)faHeaderDate.SelectedDateTime,
                PatientID = PatientID,
                NationalCode = lblNationalCode.Text,
                EmployeeID = this.CurrentEpmloyeeID,
                InsuranceTypeID = InsID,
                DrName = txtDrName.Text,
            };// ReceptionHeaderID بطور خودکار توسط دیتابیس تولید می شود     

            ReceptionHeaderID = repo.RegisterReceptionHeader(RH);
            pnlReceptionDetails.Visible = true;
            ClearForm();
        }
        
        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }

        private void txtDrName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grdReceptionDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ReceptionDetailsID = Convert.ToInt32(grdReceptionDetails.Rows[e.RowIndex].Cells[0].Value);
            {
                if (e.ColumnIndex == 6)
                {
                    var RD = repo.GetReceptionDetail(ReceptionDetailsID);
                    cmbTest.SelectedValue = RD.TestID;
                    lblPrice.Text=RD.Price.ToString();
                    txtResult.Text = Convert.ToString(RD.Result);
                    chkHasStar.Checked = Convert.ToBoolean(RD.HasStar);
                    GotoEditMode();
                }
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("آیا مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool hasRepHeader= repo.HasReceptionHeader(ReceptionHeaderID);
                        if (hasRepHeader == true)
                        {
                            MessageBox.Show("جزئیاتی برای این سربرگ پذیرش ثبت شده است");
                            return;
                        }
                        bool s = repo.RemoveReceptionDetails(ReceptionDetailsID);
                        if (s == true)
                        {
                            BindGrid();
                        }
                    }
                }
                
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
    }
}
