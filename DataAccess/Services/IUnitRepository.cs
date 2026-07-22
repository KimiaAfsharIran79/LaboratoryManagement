using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IUnitRepository
    {
        List<Unit> GetAll();
        Unit Get(int UnitID);
        int Add(Unit unit);
        bool Remove(int UnitID);
        bool Update(Unit unit);
        bool HasTest(int TestID);
    }
}
