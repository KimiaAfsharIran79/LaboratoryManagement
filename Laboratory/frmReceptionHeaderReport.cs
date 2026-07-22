using DataAccess;
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
    public partial class frmReceptionHeaderReport : Form
    {
        ReceptionHeaderRepository repoHeader = new ReceptionHeaderRepository();
        PatientRepository repoCustomer = new PatientRepository();
        EmployeeRepository repoEmployee = new EmployeeRepository();
        PatientRepository repoPatient = new PatientRepository();

        List<ReceptionHeaderListItem> reportList;

        DateTime? searchingFromDate;
        DateTime? searchingToDate;

        int? receptionHeaderID;
        int? patientID;
        int? employeeID;

        #region DataBinders
        private void BindGrid()
        {
            grdReceptionHeaderReport.AutoGenerateColumns = false;
            grdReceptionHeaderReport.DataSource = null;
            grdReceptionHeaderReport.DataSource = reportList;
        }
        private void BindEmployee()
        {
            List<EmployeeListItem> employees = repoEmployee.GetEmployee();
            employees.Insert(0, new EmployeeListItem { EmployeeID = -1, EmployeeFullName = "....انتخاب کنید...." });
            cmbEmployee.DisplayMember = "EmployeeFullName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = employees;
        }
        private void BindGridDateToPersian()
        {
            Framework.DateUtility date = new Framework.DateUtility();
            if (reportList != null)
            {
                foreach (DataGridViewRow row in grdReceptionHeaderReport.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Value = date.ToPersianDateTime(Convert.ToDateTime(cell.Value));
                        }
                    }
                }
            }
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
            }
        }
        private bool CheckIsNumeric(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                   long.TryParse(input, out _);
        }

        //private void OpenForm(int receptionHeaderID)
        //{
        //    Form receptionDetailsReport = new frmReceptionDetailsReport(receptionHeaderID);
        //    Form frmMain = this.MdiParent;

        //    foreach (Form openedForm in frmMain.MdiChildren)
        //    {
        //        if (openedForm.GetType() == receptionDetailsReport.GetType())
        //        {
        //            openedForm.Close();
        //            break;
        //        }
        //    }
        //    receptionDetailsReport.MdiParent = frmMain;
        //    receptionDetailsReport.Show();

        //}
        #endregion
        public frmReceptionHeaderReport()
        {
            InitializeComponent();
        }

        private void frmReceptionHeaderReport_Load(object sender, EventArgs e)
        {
            BindEmployee();
        }

        private void btnSearchReport_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (searchingFromDate.HasValue || searchingToDate.HasValue || receptionHeaderID.HasValue || patientID.HasValue || employeeID.HasValue)
            {
                ReceptionHeaderSearchModel sm = new ReceptionHeaderSearchModel
                {
                    FromDate = searchingFromDate,
                    ToDate = searchingToDate,
                    ReceptionHeaderID = receptionHeaderID,
                    PatientID = patientID,
                    EmployeeID = employeeID
                };
                reportList = repoHeader.Search(sm);
                BindGrid();
                BindGridDateToPersian();
            }
            else
            {
                MessageBox.Show("هیچ موردی برای جستجو انتخاب نشده است.");
            }
        }

        private void btnAllReportShow_Click(object sender, EventArgs e)
        {
            err.Clear();
            reportList = repoHeader.GetAll();
            BindGrid();
            BindGridDateToPersian();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtReceptionHeaderID.Text != "" || txtSearchPatient.Text != "" || faFromDate.SelectedDateTime != null || faToDate.SelectedDateTime != null||cmbEmployee.SelectedValue!=null)
            {
                ClearForm();
                grdReceptionHeaderReport.DataSource = null;
            }
        }
        private void faFromDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            searchingFromDate = (DateTime?)faFromDate.SelectedDateTime;
            if (!searchingFromDate.HasValue)
            {
                reportList.Clear();
            }
        }
        private void faToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            searchingToDate = (DateTime?)faToDate.SelectedDateTime;
            if (!searchingToDate.HasValue)
            {
                reportList.Clear();
            }
        }
        private void txtReceptionHeaderID_TextChanged(object sender, EventArgs e)
        {
            string RHID = txtReceptionHeaderID.Text;

            if (RHID.Length > 0)
            {
                if (!CheckIsNumeric(RHID))
                {
                    err.SetError(txtReceptionHeaderID, "شماره سربرگ را به عدد وارد کنید");
                    return;
                }
                receptionHeaderID = Convert.ToInt32(RHID);
            }
            else
            {
                receptionHeaderID = null;
                //reportList.Clear();
            }
        }

        private void grdReceptionHeaderReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int receptionHeaderID = Convert.ToInt32(grdReceptionHeaderReport.Rows[e.RowIndex].Cells[0].Value);            
            if (e.ColumnIndex == 7)
            {
                var hasAnyDetails = repoHeader.GetReceptionHeaderItems(receptionHeaderID);
                if (hasAnyDetails.Count > 0)
                {
                    Form formToCheck = Application.OpenForms["frmReceptionDetailsReport"];

                    if (formToCheck != null)
                    {
                        formToCheck.Close();
                    }
                    frmReceptionDetailsReport frm = new frmReceptionDetailsReport(receptionHeaderID);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("این سربرگ فاقد جزئیات است");
                }
            }
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            if (lstPatient.Items.Count > 0)
            {
                lstPatient.DataSource = null;
            }
            if (!string.IsNullOrEmpty(txtSearchPatient.Text) && txtSearchPatient.Text.Length >= 1)
            {
                List<PatientListItem> lst = repoPatient.Search(txtSearchPatient.Text);
                lstPatient.DisplayMember = "PatientFullName";
                lstPatient.ValueMember = "PatientID";
                lstPatient.DataSource = lst;
                lstPatient.Visible = true;
            }
            else
            {
                patientID = null;
                
                BindGrid();
                reportList.Clear();
            }
        }

        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            var patient = repoPatient.Get(Convert.ToInt32(lstPatient.SelectedValue));
            txtSearchPatient.Text = patient.FirstName + " " + patient.LastName;
            lstPatient.Visible = false;
        }
        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex != 0 && cmbEmployee.SelectedIndex != -1)
            {
                employeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
            }
            else
            {
                employeeID = null;
            }
        }

        private void txtSearchPatient_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
