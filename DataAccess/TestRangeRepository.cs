using DataAccess.Services;
using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DataAccess
{
    public class TestRangeRepository : ITestRangeRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext();

        public int Add(TestRange testRange)
        {
            db.TestRanges.Add(testRange);
            db.SaveChanges();
            return testRange.RangeID;
        }
        
        public TestRange Get(int RangeID)
        {
            return db.TestRanges.FirstOrDefault(x => x.RangeID == RangeID);
        }
        public List<RangeListItem> GetRangeByTestID(int testID)
        {
            return (from r in db.TestRanges
                    where r.TestID == testID
                    select new RangeListItem
                    {
                        RangeID = r.RangeID,
                        TestName = r.Test != null ? r.Test.TestName : "نام آزمایش یافت نشد",
                        FromValue = r.FromValue,
                        ToValue = r.ToValue,
                        FromAge = r.FromAge,
                        ToAge = r.ToAge,
                        Description = r.Description,
                        Hazard = r.Hazard,
                        Gender = r.Gender == 0 ? "مرد" : r.Gender == 1 ? "زن" : "هر دو"
                    }).ToList();
        }

        public List<RangeListItem> GetAll()
        {
            return (from r in db.TestRanges orderby r.RangeID descending
                    select new RangeListItem
                    {
                        RangeID=r.RangeID,
                        TestName=r.Test!=null?r.Test.TestName:"نام آزمایش یافت نشد",
                        FromValue=r.FromValue,
                        ToValue=r.ToValue,
                        FromAge=r.FromAge,
                        ToAge=r.ToAge,                        
                        Description=r.Description,
                        Hazard=r.Hazard,
                        Gender = r.Gender==0?"مرد":r.Gender==1?"زن":"هر دو"
                    }).ToList();
        }
       
        public bool Remove(int RangeID)
        {
            bool result=false;
            try
            {
                var r=db.TestRanges.FirstOrDefault(x=>x.RangeID==RangeID);
                db.TestRanges.Remove(r);
                db.SaveChanges();
                result=true;
            }
            catch (Exception ) 
            { 
                result=false;
            }
            return result;
        }
        

        public bool Update(TestRange testRange)
        {
            bool result = false;
            try
            {
                var r = db.TestRanges.FirstOrDefault(x => x.RangeID == testRange.RangeID);
                r.TestID = testRange.TestID;
                r.FromValue = testRange.FromValue;
                r.ToValue = testRange.ToValue;
                r.FromAge = testRange.FromAge;
                r.ToAge = testRange.ToAge;
                r.Description = testRange.Description;
                r.Gender = testRange.Gender;
                r.Hazard = testRange.Hazard;
                db.SaveChanges();
                result=true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }        
    }
}
