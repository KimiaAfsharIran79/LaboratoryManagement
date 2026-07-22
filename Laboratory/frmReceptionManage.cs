using DomainModel.Models;
using DomainModel.ViewModel;
using FarsiLibrary.Utils;
using FarsiLibrary.Win.Controls;
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
    public partial class frmReceptionManage : Form
    {
        DataAccess.ReceptionHeaderRepository repoHeader = new DataAccess.ReceptionHeaderRepository();
        DataAccess.PatientRepository repoPatient = new DataAccess.PatientRepository();
        DataAccess.InsuranceTypeRepository repoIns = new DataAccess.InsuranceTypeRepository();
        DataAccess.TestRepository repoTest = new DataAccess.TestRepository();
        DataAccess.TestCategoryRepository repoTestCat = new DataAccess.TestCategoryRepository();

        int patientID;
        int receptionHeaderID;
        int receptionDetailsID;
        int testID;
        int categoryID;
        int totalPrice = 0;
        ReceptionHeader currentReceptionHeader;

        #region DataBinders
        private void BindGrid()
        {
            grdReceptionDetails.AutoGenerateColumns = false;
            grdReceptionDetails.DataSource = null;
            grdReceptionDetails.DataSource = repoHeader.GetReceptionDetailsByID(receptionHeaderID);
        }

        private void BindTestCategory()
        {
            List<TestCategory> categories = repoTestCat.GetAll();
            categories.Insert(0, new TestCategory { CategoryID = -1, CategoryName = ".......انتخاب کنید......." });
            cmbTestCategory.DisplayMember = "CategoryName";
            cmbTestCategory.ValueMember = "CategoryID";
            cmbTestCategory.DataSource = categories;
        }

        private void BindTest()
        {
            List<TestListItem> Tests = repoTest.GetByCategoryID(categoryID);
            Tests.Insert(0, new TestListItem { TestID = -1, TestName = "......انتخاب کنید......" });
            cmbTest.DisplayMember = "TestName";
            cmbTest.ValueMember = "TestID";
            cmbTest.DataSource = Tests;
        }
        private void BindInsuranceTpye()
        {
            List<InsuranceType> insuranceTpye = repoIns.GetAll();
            insuranceTpye.Insert(0, new InsuranceType { InsuranceTypeID = -1, InsuranceTypeName = "......انتخاب کنید....." });
            cmbInsuranceType.DisplayMember = "InsuranceTypeName";
            cmbInsuranceType.ValueMember = "InsuranceTypeID";
            cmbInsuranceType.DataSource = insuranceTpye;
        }
        private void BindcmbPatientHeaders()
        {
            ReceptionHeaderSearchModel sm = new ReceptionHeaderSearchModel();
            sm.PatientID = patientID;
            List<ReceptionHeaderListItem> headers = repoHeader.Search(sm);
            headers.Insert(0, new ReceptionHeaderListItem { ReceptionHeaderID = -1, Information = "................................................سربرگ بیمار را از اینجا انتخاب کنید................................................" });
            cmbPatientHeaders.DisplayMember = "Information";
            cmbPatientHeaders.ValueMember = "ReceptionHeaderID";
            cmbPatientHeaders.DataSource = headers;
        }
        private void BindReceptionHeader()
        {
            ReceptionHeaderListItem h = repoHeader.GetReceptionHeaderItemByID(receptionHeaderID);
            lblReceptionHeaderID.Text = h.ReceptionHeaderID.ToString();
            lblPatientFullName.Text = h.PatientFullName;
            lblNationalCode.Text = h.NationalCode;
            lblMobile.Text = h.Mobile;
            faHeaderDate.SelectedDateTime = h.HeaderDate;
            txtDrName.Text = h.DrName;
            cmbInsuranceType.SelectedValue = h.InsuranceTypeID;
            txtAge.Text = h.Age.ToString();
            lblTotalPrice.Text = h.TotalPrice.ToString();
        }
        #endregion        

        #region Utility 
        private void ClearForm()
        {
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
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
                    if (ctrl is FADatePicker)
                    {
                        var fa = (FADatePicker)ctrl;
                        fa.Text = "[هیج مقداری انتخاب نشده]";
                    }
                }
                lblReceptionHeaderID.Text = "";
                lblPatientFullName.Text = "";
                lblNationalCode.Text = "";
                lblMobile.Text = "";
                lblTotalPrice.Text = "";
                patientID = 0;
                receptionHeaderID = 0;
                receptionDetailsID = 0;
                testID = 0;
                categoryID = 0;
                grdReceptionDetails.DataSource = null;
            }
        }
        private void ClearPanelTest()
        {
            cmbTestCategory.SelectedIndex = 0;
            cmbTest.SelectedIndex = 0;
            txtPrice.Text = "";
            txtResult.Text = "";
            chkHasStar.Checked = false;
        }
        private void GotoSearchHeaderMode()
        {
            btnSearchHeader.Enabled = true;
            btnSearchHeader.BackColor = Color.SteelBlue;

            btnDeleteHeader.Enabled = false;
            btnDeleteHeader.BackColor = Color.LightGray;
            btnUpdateHeader.Enabled = false;
            btnUpdateHeader.BackColor = Color.LightGray;
            btnCancelHeader.Enabled = false;
            btnCancelHeader.BackColor = Color.LightGray;

            btnAddTest.Enabled = false;
            btnAddTest.BackColor = Color.LightGray;
            btnUpdateTest.Enabled = false;
            btnUpdateTest.BackColor = Color.LightGray;
            btnCancelTest.Enabled = false;
            btnCancelTest.BackColor = Color.LightGray;

            pnlReceptionDetails.Enabled = false;
            pnlSearch.Enabled = true ;
        }
        private void GotoManageHeaderMode()
        {
            btnSearchHeader.Enabled = false;
            btnSearchHeader.BackColor = Color.LightGray;

            btnDeleteHeader.Enabled = true;
            btnDeleteHeader.BackColor = Color.SteelBlue;
            btnUpdateHeader.Enabled = true;
            btnUpdateHeader.BackColor = Color.SteelBlue;
            btnCancelHeader.Enabled = true;
            btnCancelHeader.BackColor = Color.SteelBlue;
            pnlReceptionDetails.Enabled = true;
            pnlSearch.Enabled = false ;
        }
        private void GotoAddModeTest()
        {
            btnAddTest.Enabled = true;
            btnAddTest.BackColor = Color.SteelBlue;
            btnUpdateTest.Enabled = false;
            btnUpdateTest.BackColor = Color.LightGray;
            btnCancelTest.Enabled = false;
            btnCancelTest.BackColor = Color.LightGray;
        }
        private void GotoEditModeTest()
        {
            btnAddTest.Enabled = false;
            btnAddTest.BackColor = Color.LightGray;
            btnUpdateTest.Enabled = true;
            btnUpdateTest.BackColor = Color.SteelBlue;
            btnCancelTest.Enabled = true;
            btnCancelTest.BackColor = Color.SteelBlue;
        }
        private void IsValidReceptionHeaderIDInTextBox()
        {
            if (!string.IsNullOrEmpty(txtReceptionHeaderID.Text))
            {
                bool result = repoHeader.ReceptionHeaderExist(Convert.ToInt32(txtReceptionHeaderID.Text));
                if (result)
                {
                    receptionHeaderID = Convert.ToInt32(txtReceptionHeaderID.Text);
                    currentReceptionHeader = repoHeader.Get(receptionHeaderID);
                    patientID = currentReceptionHeader.PatientID;
                }
                else
                {
                    MessageBox.Show("این سربرگ وجود ندارد.");
                }
            }
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
            lblTotalPrice.Text = totalPrice.ToString();
        }
        private void SetHazardRange()
        {
            foreach (DataGridViewRow row in grdReceptionDetails.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    bool hasStar = Convert.ToBoolean(row.Cells[7].Value);
                    if (hasStar)
                    {
                        row.Cells[6].Style.ForeColor = Color.AntiqueWhite;
                        row.Cells[6].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    row.Cells[6].Style.ForeColor = Color.Black;
                    row.Cells[6].Style.BackColor = Color.White;
                }
            }
        }
            #endregion
            public frmReceptionManage()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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

        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            var p = repoPatient.Get(patientID);
            txtSearch.Text = p.FirstName + " " + p.LastName;
            lstPatient.Visible = false;
            BindcmbPatientHeaders();
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

        private void frmReceptionManage_Load(object sender, EventArgs e)
        {
            GotoSearchHeaderMode();
            BindInsuranceTpye();
            BindTestCategory();
        }

        private void cmbTestCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryID = Convert.ToInt32(cmbTestCategory.SelectedValue);
            BindTest();
        }

        private void cmbPatientHeaders_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedHeaderID = Convert.ToInt32(cmbPatientHeaders.SelectedValue);
            if (selectedHeaderID > 0)
            {
                receptionHeaderID = selectedHeaderID;
                txtReceptionHeaderID.Text = receptionHeaderID.ToString();
            }
        }

        private void btnSearchHeader_Click(object sender, EventArgs e)
        {
            IsValidReceptionHeaderIDInTextBox();           
            if (receptionHeaderID != 0)                
            {
                currentReceptionHeader = repoHeader.Get(receptionHeaderID);
                BindGrid();
                BindcmbPatientHeaders();
                BindTestCategory();
                BindReceptionHeader();

                txtSearch.Text = "";
                txtReceptionHeaderID.Text = "";                
                GotoManageHeaderMode();
                GotoAddModeTest();                
            }
            else
            {
                MessageBox.Show("لطفا شماره سربرگ را وارد کنید.");
            }
        }

        private void btnCancelHeader_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoSearchHeaderMode();
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از حذف این سربرگ مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repoHeader.RemoveReceptionHeader(receptionHeaderID);
                    MessageBox.Show($"عملیات حذف سربرگ {receptionHeaderID.ToString()} با موفقیت انجام شد.");
                    ClearForm();
                    GotoSearchHeaderMode();
                }
            }
            catch
            {
                MessageBox.Show("عملیات حذف سربرگ ناموفق بود.");
            }

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
            if (PreTestID == null)
            {
                var RD = new ReceptionDetail
                {
                    ReceptionHeaderID = receptionHeaderID,
                    TestID = testID,
                    Price = Convert.ToInt64(txtPrice.Text),
                    HasStar = chkHasStar.Checked,
                    Result = txtResult.Text.Length < 1 ? 0 : Convert.ToDouble(txtResult.Text)
                };
                int receptionDetailsID = repoHeader.RegisterReceptionDetails(RD);
                repoHeader.SetHasStarByResult(receptionDetailsID);
                CalculateFinalPrice();
                BindGrid();
                SetHazardRange();                
            }
            else
            {
                MessageBox.Show("این آزمایش قبلا ثبت شده است.");
            }
            ClearPanelTest();
        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
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
            if (testID != RD.TestID)
            {
                repeat = repoHeader.ExistTestInReceptionDetail(RD.ReceptionHeaderID, RD.TestID);
            }
            if (repeat == null)
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
            ClearPanelTest();
            GotoAddModeTest();
        }

        private void btnCancelTest_Click(object sender, EventArgs e)
        {
            ClearPanelTest();
            GotoAddModeTest();
        }

        private void grdReceptionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            receptionDetailsID = Convert.ToInt32(grdReceptionDetails.Rows[e.RowIndex].Cells[0].Value);
            {
                if (e.ColumnIndex == 9)
                {
                    if (MessageBox.Show("آیا از حذف مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool s = repoHeader.RemoveReceptionDetails(receptionDetailsID);
                        if (s == true)
                        {
                            BindGrid();
                            CalculateFinalPrice();
                            ClearPanelTest();
                            SetHazardRange();
                        }
                        else
                        {
                            MessageBox.Show("حذف امکانپذیر نمی باشد.");
                        }
                    }                    
                }
                if (e.ColumnIndex == 8)
                {
                    var RD = repoHeader.GetReceptionDetail(receptionDetailsID);
                    testID = RD.TestID;
                    cmbTestCategory.SelectedValue = Convert.ToInt32(grdReceptionDetails.Rows[e.RowIndex].Cells[2].Value);
                    cmbTest.SelectedValue = testID;
                    txtResult.Text = Convert.ToString(RD.Result);
                    chkHasStar.Checked = Convert.ToBoolean(RD.HasStar);
                    GotoEditModeTest();
                }
            }
        }

        private void btnUpdateHeader_Click(object sender, EventArgs e)
        {
            try
            {
                ReceptionHeader newReceptionHeader = new ReceptionHeader
                {
                    ReceptionHeaderID = receptionHeaderID,
                    PatientID = patientID,
                    NationalCode = currentReceptionHeader.NationalCode,
                    EmployeeID = currentReceptionHeader.EmployeeID,
                    HeaderDescription = currentReceptionHeader.HeaderDescription,
                    TotalPrice = totalPrice,
                    HeaderDate = Convert.ToDateTime(faHeaderDate.SelectedDateTime),
                    InsuranceTypeID = Convert.ToInt32(cmbInsuranceType.SelectedValue),
                    DrName = txtDrName.Text,
                    Age = Convert.ToInt32(txtAge.Text)
                };
                repoHeader.UpdateReceptionHeader(newReceptionHeader);
                MessageBox.Show($"عملیات ویرایش سربرگ {receptionHeaderID.ToString()} با موفقیت انجام شد.");
                GotoSearchHeaderMode();
                ClearForm();
            }
            catch
            {
                MessageBox.Show("به روز رسانی این سربرگ امکان پذیر نمی باشد.");
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

        private void txtDrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsPersianCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void txtReceptionHeaderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد صحیح وارد کنید");
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
    }
}
