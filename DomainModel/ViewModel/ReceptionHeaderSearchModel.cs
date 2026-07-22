using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class ReceptionHeaderSearchModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ReceptionHeaderID { get; set; }
        public int? PatientID { get; set; }
        public int? EmployeeID { get; set; }              
    }
}
