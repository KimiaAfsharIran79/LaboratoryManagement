using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class ReceptionHeaderListItem
    {
        public int ReceptionHeaderID { get; set; }

        public DateTime HeaderDate { get; set; }

        public int PatientID { get; set; }
        public string PatientFullName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public int EmployeeID { get; set; }
        public string EmployeeFullName { get; set; }

        public int InsuranceTypeID { get; set; }
        public string InsuranceTypeName { get; set; }

        public string DrName { get; set; }
        public string HeaderDescription { get; set; }

        public long? TotalPrice { get; set; }
        public string Information { get; set; }
    }
}
