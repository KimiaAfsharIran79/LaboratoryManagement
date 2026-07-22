using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ITestCategoryRepository
    {
        List<TestCategory> GetAll();
        TestCategory Get(int CategoryID);
        int Add(TestCategory testcategory);
        bool Remove(int CategoryID);
        bool Update(TestCategory testcategory);
        bool HasTest(int CategoryID);
    }
}
