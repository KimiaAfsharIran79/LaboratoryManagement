using DataAccess.Services;
using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReceptionHeaderRepository : IReceptionHeaderRepository
    {

        private DomainModel.Models.LaboratoryContext db = new LaboratoryContext();

        public int RegisterReceptionHeader(ReceptionHeader receptionHeader)
        {
            db.ReceptionHeaders.Add(receptionHeader);
            db.SaveChanges();
            return receptionHeader.ReceptionHeaderID;
        }

        public int RegisterReceptionDetails(ReceptionDetail receptionDetail)
        {
            db.ReceptionDetails.Add(receptionDetail);
            db.SaveChanges();
            return receptionDetail.ReceptionDetailsID;
        }
        public ReceptionHeader Get(int ReceptionHeaderID)
        {
            return db.ReceptionHeaders.FirstOrDefault(x => x.ReceptionHeaderID == ReceptionHeaderID);
        }
        public ReceptionHeaderListItem GetReceptionHeaderItemByID(int receptionHeaderID)
        {
            return (from h in db.ReceptionHeaders
                    where h.ReceptionHeaderID == receptionHeaderID
                    select new ReceptionHeaderListItem
                    {
                        ReceptionHeaderID = h.ReceptionHeaderID,
                        HeaderDate = h.HeaderDate,
                        EmployeeID = h.EmployeeID,
                        EmployeeFullName = h.Employee.FirstName + " " + h.Employee.LastName,
                        PatientID = h.PatientID,
                        PatientFullName = h.Patient.FirstName + " " + h.Patient.LastName,
                        NationalCode = h.NationalCode,
                        Mobile = h.Patient.Mobile,
                        Address = h.Patient.Address,
                        Age = h.Age,
                        InsuranceTypeID = h.InsuranceType.InsuranceTypeID,
                        InsuranceTypeName = h.InsuranceType.InsuranceTypeName,
                        DrName = h.DrName,
                        HeaderDescription = h.HeaderDescription,
                        TotalPrice = h.TotalPrice.HasValue ? h.TotalPrice : 0,
                    }).FirstOrDefault();
        }
        public ReceptionDetail GetReceptionDetail(int ReceptionDetailsID)
        {
            return db.ReceptionDetails.FirstOrDefault(x => x.ReceptionDetailsID == ReceptionDetailsID);
        }
        public List<ReceptionDetailsListItem> GetReceptionDetailsByID(int receptionHeaderID)
        {
            return (from RD in db.ReceptionDetails
                    where RD.ReceptionHeaderID == receptionHeaderID
                    select new ReceptionDetailsListItem
                    {
                        ReceptionDetailsID = RD.ReceptionDetailsID,
                        ReceptionHeaderID = RD.ReceptionHeaderID,
                        CategoryID = RD.Test.CategoryID,
                        TestID = RD.TestID,
                        Price = RD.Price,
                        Result = RD.Result,
                        HasStar = RD.HasStar,
                        TestName = RD.Test.TestName
                    }).ToList();
        }
        public long GetTotalPrice(int receptionHeaderID)
        {
            long totalPrice = 0;
            var item = db.ReceptionDetails.Any(x => x.ReceptionHeaderID == receptionHeaderID);
            if (item)
            {
                totalPrice = (from RD in db.ReceptionDetails
                              where RD.ReceptionHeaderID == receptionHeaderID
                              select RD.Price).Sum();

                var receptionHeader = db.ReceptionHeaders.FirstOrDefault(x => x.ReceptionHeaderID == receptionHeaderID);
                receptionHeader.TotalPrice = totalPrice;
                db.SaveChanges();
            }
            return totalPrice;
        }

        public List<ReceptionDetailsListItem> GetReceptionHeaderItems(int ReceptionHeaderID)
        {
            var q = from RD in db.ReceptionDetails
                    where RD.ReceptionHeaderID == ReceptionHeaderID
                    select new ReceptionDetailsListItem
                    {
                        ReceptionDetailsID = RD.ReceptionDetailsID,
                        ReceptionHeaderID = RD.ReceptionHeaderID,
                        CategoryID = RD.Test.CategoryID,
                        TestID = RD.TestID,
                        Price = RD.Price,
                        Result = RD.Result,
                        HasStar = RD.HasStar,
                        TestName = RD.Test.TestName
                    };
            return q.ToList();
        }
        public List<ReceptionHeaderListItem> GetAll()
        {
            var q = db.ReceptionHeaders.Select(h => new ReceptionHeaderListItem

            {
                ReceptionHeaderID = h.ReceptionHeaderID,
                HeaderDate = h.HeaderDate,
                EmployeeID = h.EmployeeID,
                EmployeeFullName = h.Employee.FirstName + " " + h.Employee.LastName,
                PatientID = h.PatientID,
                PatientFullName = h.Patient.FirstName + " " + h.Patient.LastName,
                NationalCode = h.NationalCode,
                Mobile = h.Patient.Mobile,
                Age = h.Age,
                InsuranceTypeName = h.InsuranceType.InsuranceTypeName,
                DrName = h.DrName,
                TotalPrice = h.TotalPrice.HasValue ? h.TotalPrice : 0,
            }).ToList();
            return q;
        }
        public ReceptionDetail ExistTestInReceptionDetail(int ReceptionHeaderID, int TestID)
        {
            return db.ReceptionDetails.FirstOrDefault(x => x.ReceptionHeaderID == ReceptionHeaderID && x.TestID == TestID);
        }
        public bool ReceptionHeaderExist(int receptionHeaderID)
        {
            return db.ReceptionHeaders.Any(x => x.ReceptionHeaderID == receptionHeaderID);
        }

        public bool RemoveReceptionDetails(int ReceptionDetailsID)
        {
            bool result = false;
            try
            {
                var RD = db.ReceptionDetails.FirstOrDefault(x => x.ReceptionDetailsID == ReceptionDetailsID);
                db.ReceptionDetails.Remove(RD);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool RemoveReceptionHeader(int ReceptionHeaderID)
        {
            bool result = false;
            try
            {
                var RH = db.ReceptionHeaders.FirstOrDefault(x => x.ReceptionHeaderID == ReceptionHeaderID);
                List<ReceptionDetail> items = (from d in db.ReceptionDetails
                                               where d.ReceptionHeaderID == ReceptionHeaderID
                                               select d).ToList();

                if (items != null)
                {
                    foreach (var item in items)
                    {
                        db.ReceptionDetails.Remove(item);
                    }
                }
                db.ReceptionHeaders.Remove(RH);
                db.SaveChanges();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
        public bool UpdateReceptionDetails(ReceptionDetail OldReceptionDetails)
        {
            bool result = false;
            try
            {
                var RD = db.ReceptionDetails.FirstOrDefault(x => x.ReceptionDetailsID == OldReceptionDetails.ReceptionDetailsID);
                if (RD != null)
                {
                    RD.ReceptionHeaderID = OldReceptionDetails.ReceptionHeaderID;
                    RD.ReceptionDetailsID = OldReceptionDetails.ReceptionDetailsID;
                    if (OldReceptionDetails.TestID != -1)
                    {
                        RD.TestID = OldReceptionDetails.TestID;
                    }
                    RD.Price = OldReceptionDetails.Price;
                    RD.Result = OldReceptionDetails.Result;
                    RD.HasStar = OldReceptionDetails.HasStar;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("خطا در به روز رسانی اطلاعات:" + ex.Message);
            }
            return result;
        }
        public bool UpdateReceptionHeader(ReceptionHeader currentReceptionHeader)
        {
            bool result = false;
            try
            {
                var oldHeader = db.ReceptionHeaders.FirstOrDefault(x => x.ReceptionHeaderID == currentReceptionHeader.ReceptionHeaderID);

                oldHeader.HeaderDate = currentReceptionHeader.HeaderDate;
                oldHeader.DrName = currentReceptionHeader.DrName;
                oldHeader.InsuranceTypeID = currentReceptionHeader.InsuranceTypeID;
                oldHeader.TotalPrice = currentReceptionHeader.TotalPrice;
                oldHeader.Age = currentReceptionHeader.Age;
                db.SaveChanges();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public List<ReceptionHeaderListItem> Search(ReceptionHeaderSearchModel sm)
        {
            var q1 = from h in db.ReceptionHeaders select h;
            if (sm.FromDate != null)
            {
                q1 = q1.Where(x => x.HeaderDate >= sm.FromDate);
            }
            if (sm.ToDate != null)
            {
                q1 = q1.Where(x => x.HeaderDate <= sm.ToDate);
            }
            if (sm.PatientID != null)
            {
                q1 = q1.Where(x => x.PatientID == sm.PatientID);
            }
            if (sm.EmployeeID != null)
            {
                q1 = q1.Where(x => x.EmployeeID == sm.EmployeeID);
            }
            if (sm.ReceptionHeaderID != null)
            {
                q1 = q1.Where(x => x.ReceptionHeaderID == sm.ReceptionHeaderID);
            }
            var q2 = from h in q1
                     orderby h.HeaderDate descending
                     select new ReceptionHeaderListItem
                     {
                         ReceptionHeaderID = h.ReceptionHeaderID,
                         HeaderDate = h.HeaderDate,
                         EmployeeID = h.EmployeeID,
                         EmployeeFullName = h.Employee.FirstName + "  " + h.Employee.LastName,
                         PatientID = h.PatientID,
                         PatientFullName = h.Patient.FirstName + "  " + h.Patient.LastName,
                         NationalCode = h.NationalCode,
                         Mobile = h.Patient.Mobile,
                         Age = h.Age,
                         InsuranceTypeName = h.InsuranceType.InsuranceTypeName,
                         DrName = h.DrName,
                         TotalPrice = h.TotalPrice.HasValue ? h.TotalPrice : 0,
                         Information = "  آزمایش شماره:  " + h.ReceptionHeaderID + "   دکتر:  " + h.DrName + "  در تاریخ:  " + h.HeaderDate
                     };
            return q2.ToList();
        }
        //public bool ResultIsHazardous(int receptionDetailsID)
        //{
        //    bool result = false;
        //    var currentDetail = db.ReceptionDetails.FirstOrDefault(x => x.ReceptionDetailsID == receptionDetailsID);

        //    if (db.TestRanges.Any(x => x.TestID == currentDetail.TestID))
        //    {
        //        var hazardRange = db.TestRanges.FirstOrDefault(x => x.TestID == currentDetail.TestID && x.Hazard == true);
        //        if (hazardRange != null && currentDetail.Result >= hazardRange.FromValue && currentDetail.Result <= hazardRange.ToValue)
        //        {
        //            currentDetail.HasStar = true;
        //            db.SaveChanges();
        //            result = true;
        //        }
        //        else
        //        {
        //            currentDetail.HasStar = false;
        //            db.SaveChanges();
        //        }
        //    }
        //    return result;
        //}
        public bool SetHasStarByResult(int patientTestDetailID)
        {
            bool r = false;

            ReceptionDetail currentTestDetail = db.ReceptionDetails.FirstOrDefault(x => x.ReceptionDetailsID == patientTestDetailID);
            ReceptionHeader currentTestHeader = db.ReceptionHeaders.FirstOrDefault(x => x.ReceptionHeaderID == currentTestDetail.ReceptionHeaderID);
            Patient currentPatient = db.Patients.FirstOrDefault(x => x.PatientID == currentTestHeader.PatientID);

            double result = Convert.ToDouble(currentTestDetail.Result);
            int patientGender = Convert.ToBoolean(currentPatient.Gender) ? 1 : 0;
            int patientAge = Convert.ToInt32(currentTestHeader.Age);
            int testID = Convert.ToInt32(currentTestDetail.TestID);
            Test currentTest = db.Tests.FirstOrDefault(x => x.TestID == testID);

            int fromAge;
            int toAge;
            double fromValue;
            double toValue;
            int gender;
            List<TestRange> hazardTestRanges = (from TR in db.TestRanges
                                                where TR.TestID == currentTestDetail.TestID && TR.Hazard == true
                                                select TR).ToList();

            if (hazardTestRanges.Count > 0)
            {
                foreach (TestRange testRange in hazardTestRanges)
                {
                    fromAge = Convert.ToInt32(testRange.FromAge);
                    toAge = Convert.ToInt32(testRange.ToAge);
                    fromValue = Convert.ToDouble(testRange.FromValue);
                    toValue = Convert.ToDouble(testRange.ToValue);
                    gender = Convert.ToInt32(testRange.Gender);

                    bool isValueMatch = result >= fromValue && result <= toValue;
                    bool isGenderMatch = patientGender == gender;
                    bool isAgeMatch = patientAge >= fromAge && patientAge <= toAge;

                    if ((currentTest.GenderHasEffect && isGenderMatch && currentTest.AgeHasEffect && isAgeMatch) ||
                            ((currentTest.GenderHasEffect && isGenderMatch) && !currentTest.AgeHasEffect) ||
                            (!currentTest.GenderHasEffect && (currentTest.AgeHasEffect && isAgeMatch)) ||
                            (!currentTest.GenderHasEffect && !currentTest.AgeHasEffect))
                    {
                        if (isValueMatch) r = true;
                    }
                }
            }
            currentTestDetail.HasStar = r;
            db.SaveChanges();
            return r;
        }

    }
}

