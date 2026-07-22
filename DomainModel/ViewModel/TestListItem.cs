using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel
{
    public class TestListItem
    {
        public int TestID { get; set; }
        public string TestName { get; set; }

        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public bool AgeHasEffect { get; set; }

        public bool GenderHasEffect { get; set; }

        public int CategoryID { get; set; }
        public  string CategoryName { get; set; }
        public long? UnitPrice { get; set; }               
    }
}
