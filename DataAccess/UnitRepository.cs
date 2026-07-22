using DataAccess.Services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitRepository : IUnitRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext();
        public int Add(Unit unit)
        {
            db.Units.Add(unit);
            db.SaveChanges();
            return unit.UnitID;
        }

        public Unit Get(int UnitID)
        {
            return db.Units.FirstOrDefault(x=>x.UnitID == UnitID);
        }

        public List<Unit> GetAll()
        {
            return db.Units.OrderByDescending(x=>x.UnitID).ToList();
        }

        public bool HasTest(int UnitID)
        {
            return db.Tests.Any(x=>x.UnitID == UnitID);
        }

        public bool Remove(int UnitID)
        {
            bool result = false;
            try
            {
                var u = db.Units.FirstOrDefault(x => x.UnitID == UnitID);
                db.Units.Remove(u);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Unit unit)
        {
            bool result=false;
            try
            {
                var u = db.Units.FirstOrDefault(x => x.UnitID == unit.UnitID);
                u.UnitName = unit.UnitName;
                u.Description = unit.Description;
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result ;
        }
    }
}
