using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ITestRangeRepository
    {                                     
        List<RangeListItem> GetAll();
        TestRange Get(int RangeID);
        int Add(TestRange testRange);
        bool Remove(int RangeID);
        bool Update(TestRange testRange);
        //bool ControlRepeatTest(int TestID);
    }
}
