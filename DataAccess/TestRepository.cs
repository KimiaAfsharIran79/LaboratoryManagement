using DataAccess.Services;
using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestRepository : ITestRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext(); 
        public int Add(Test test)
        {
            db.Tests.Add(test);
            db.SaveChanges();
            return test.TestID;
        }        
        public Test Get(int TestID)
        {
            return db.Tests.FirstOrDefault(x=>x.TestID == TestID);
        }        
        public List<TestListItem> GetByCategoryID(int categoryID)
        {
            return (from t in db.Tests
                    where t.CategoryID == categoryID
                    select new TestListItem
                    {
                        TestID = t.TestID,
                        TestName = t.TestName
                    }).ToList();
        }

        public List<TestListItem> GetAll()
        {
            return (from t in db.Tests.OrderByDescending(x => x.TestID).ToList()
                    select new TestListItem
                    {
                        TestID = t.TestID,
                        TestName = t.TestName,
                        UnitName=t.Unit?.UnitName??"بدون واحد",
                        CategoryName = t.TestCategory?.CategoryName??"بدون دسته بندی",
                        AgeHasEffect=t.AgeHasEffect,
                        GenderHasEffect=t.GenderHasEffect,
                        UnitPrice=t.UnitPrice,
                    }).ToList();
        }

        public List<TestListItem> Search(string Phrase)
        {
            return (from t in db.Tests
                    where t.TestName.Contains(Phrase)
                    select new TestListItem
                    {
                        TestID = t.TestID,
                        TestName = t.TestName,
                        UnitName = t.Unit.UnitName ?? "بدون واحد",
                        CategoryName = t.TestCategory.CategoryName ?? "بدون دسته بندی",
                        AgeHasEffect = t.AgeHasEffect,
                        GenderHasEffect = t.GenderHasEffect,
                        UnitPrice = t.UnitPrice,
                    })
            .ToList();
        }
        public bool HasReceptionDetail(int TestID)
        {
            return db.ReceptionDetails.Any(x=>x.TestID== TestID);
        }
        public bool ControlRepeatTest(string TestName)
        {
            return db.Tests.Any(x => x.TestName == TestName);
        }

        public bool Remove(int TestID)
        {
            bool result = false;
            try
            {
                var t = db.Tests.FirstOrDefault(x => x.TestID == TestID);
                db.Tests.Remove(t);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ) 
            {
                result=false;
            }
            return result;
        }

        public bool Update(Test test)
        {
            bool result=false;
            try
            {
                var t=db.Tests.FirstOrDefault(x=>x.TestID==test.TestID);
                t.TestName = test.TestName;                
                t.AgeHasEffect = test.AgeHasEffect;
                t.CategoryID = test.CategoryID;
                t.GenderHasEffect = test.GenderHasEffect;
                db.SaveChanges();
                result=true;
            }
            catch (Exception)
            {
                result=false;
            }
            return result;
        }       
    }
}
