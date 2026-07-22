using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class RangeListItem
    {
        public int RangeID { get; set; }

        public int TestID { get; set; }

        public double FromValue { get; set; }

        public double ToValue { get; set; }
       
        public string Description { get; set; }

        public string Gender { get; set; }

        public int? FromAge { get; set; }

        public int? ToAge { get; set; }

        public bool? Hazard { get; set; }
        public string TestName { get; set; }        
    }
}
