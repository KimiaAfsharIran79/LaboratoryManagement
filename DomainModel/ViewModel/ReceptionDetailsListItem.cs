using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class ReceptionDetailsListItem
    {
        public int ReceptionDetailsID { get; set; }
        public int CategoryID { get; set; }

        public int TestID { get; set; }

        public long Price { get; set; }

        public int ReceptionHeaderID { get; set; }

        public double? Result { get; set; }

        public bool? HasStar { get; set; }

        public string TestName { get; set; }
        
    }
}
