using DataAccess.Services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestCategoryRepository : ITestCategoryRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext();
        public int Add(TestCategory testcategory)
        {
            db.TestCategories.Add(testcategory);
            db.SaveChanges();
            return testcategory.CategoryID;
        }

        public TestCategory Get(int CategoryID)
        {
            return db.TestCategories.FirstOrDefault(x => x.CategoryID == CategoryID);
        }

        public List<TestCategory> GetAll()
        {
            return db.TestCategories.OrderByDescending(x => x.CategoryID).ToList();
        }

        public bool HasTest(int CategoryID)
        {
            return db.Tests.Any(x => x.CategoryID == CategoryID);
        }

        public bool Remove(int CategoryID)
        {
            bool result = false;
            try
            {
                var testcat = db.TestCategories.FirstOrDefault(x => x.CategoryID == CategoryID);
                db.TestCategories.Remove(testcat);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(TestCategory testcategory)
        {
            bool result = false;
            try
            {
                var testcat = db.TestCategories.FirstOrDefault(x => x.CategoryID == testcategory.CategoryID);
                testcat.CategoryName = testcategory.CategoryName;
                testcat.Description = testcategory.Description;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
