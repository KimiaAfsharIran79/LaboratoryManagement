using DataAccess;
using DomainModel.Models;
using DomainModel.ViewModel;
using Framework;
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
    public partial class frmReceptionDetailsReport : Form
    {
        ReceptionHeaderRepository repoHeader = new ReceptionHeaderRepository();
        EmployeeRepository repoEmployee = new EmployeeRepository();
        PatientRepository repoPatient = new PatientRepository();
        TestRepository repoTest = new TestRepository();
        
        int receptionHeaderID;        

        #region DataBinders

        private void BindHeaders()
        {            
            var HeaderItems = repoHeader.GetReceptionHeaderItemByID(receptionHeaderID);
            lblReceptionHeaderID.Text = receptionHeaderID.ToString();
            lblEmployee.Text = HeaderItems.EmployeeFullName;
            lblPatientFullName.Text = HeaderItems.PatientFullName;
            lblMobile.Text = HeaderItems.Mobile;
            lblNationalCode.Text = HeaderItems.NationalCode;
            lblAddress.Text = HeaderItems.Address;
            lblAge.Text = HeaderItems.Age.ToString();
            lblPatientDescription.Text = HeaderItems.HeaderDescription;
            lblDrName.Text = HeaderItems.DrName;
            lblInsuranceTypeName.Text = HeaderItems.InsuranceTypeName;
            lblHeaderDate.Text = new DateUtility().ToPersianDateTime(HeaderItems.HeaderDate);
        }
        private void BindGrid()
        {
            grdReceptionDetails.AutoGenerateColumns = false;
            grdReceptionDetails.DataSource = null;
            grdReceptionDetails.DataSource = repoHeader.GetReceptionHeaderItems(receptionHeaderID);
        }
        
        #endregion        

        public frmReceptionDetailsReport(int ReceptionHeaderID)
        {
            InitializeComponent();
            receptionHeaderID = ReceptionHeaderID;                      
        }
        

        private void frmReceptionDetailsReport_Load(object sender, EventArgs e)
        {           
            BindGrid();
            BindHeaders();
        }
    }        
}
