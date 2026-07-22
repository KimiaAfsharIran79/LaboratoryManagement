using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class PatientListItem
    {
        public int PatientID { get; set; }
        public string PatientFullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }        
    }
}
