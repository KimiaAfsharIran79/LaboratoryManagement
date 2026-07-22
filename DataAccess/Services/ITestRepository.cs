using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ITestRepository
    {
        List<TestListItem> GetAll();
        Test Get(int TestID);
        int Add(Test test);
        bool Remove(int TestID);
        bool Update(Test test);
        bool HasReceptionDetail(int TestID);
        bool ControlRepeatTest(string TestName);
    }
}
