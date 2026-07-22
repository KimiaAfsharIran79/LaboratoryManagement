using DataAccess.Services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InsuranceTypeRepository : IInsuranceTypeRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext();
        public int Add(InsuranceType insurancetype)
        {
            db.InsuranceTypes.Add(insurancetype);
            db.SaveChanges();
            return insurancetype.InsuranceTypeID;
        }

        public InsuranceType Get(int InsuranceTypeID)
        {
            return db.InsuranceTypes.FirstOrDefault(x => x.InsuranceTypeID == InsuranceTypeID);
        }        

        public List<InsuranceType> GetAll()
        {
            return db.InsuranceTypes.OrderByDescending(x => x.InsuranceTypeID).ToList();
        }

        public bool HasReceptionHeader(int InsuranceTypeID)
        {
            return db.ReceptionHeaders.Any(x => x.InsuranceTypeID == InsuranceTypeID);
        }

        public bool Remove(int InsuranceTypeID)
        {
            bool result = false;
            try
            {
                var ins = db.InsuranceTypes.FirstOrDefault(x => x.InsuranceTypeID == InsuranceTypeID);
                db.InsuranceTypes.Remove(ins);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(InsuranceType insurancetype)
        {
            bool result = false;
            try
            {
                var ins = db.InsuranceTypes.FirstOrDefault(x => x.InsuranceTypeID ==insurancetype.InsuranceTypeID);
                ins.InsuranceTypeName = insurancetype.InsuranceTypeName;
                ins.Description = insurancetype.Description;
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
