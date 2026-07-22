using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IInsuranceTypeRepository
    {
        List<InsuranceType> GetAll();
        InsuranceType Get(int InsuranceTypeID);
        int Add(InsuranceType insurancetype);
        bool Remove(int InsuranceTypeID);
        bool Update(InsuranceType insurancetype);
        bool HasReceptionHeader(int InsuranceTypeID);
    }
}
