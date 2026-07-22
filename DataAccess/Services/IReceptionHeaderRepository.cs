using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IReceptionHeaderRepository
    {
        int RegisterReceptionHeader(ReceptionHeader receptionHeader);

        int RegisterReceptionDetails(ReceptionDetail receptionDetail);
        ReceptionHeader Get(int ReceptionHeaderID);
        ReceptionHeaderListItem GetReceptionHeaderItemByID(int receptionHeaderID);

        ReceptionDetail GetReceptionDetail(int ReceptionDetailsID);
        List<ReceptionDetailsListItem> GetReceptionDetailsByID(int receptionHeaderID);
        
        List<ReceptionDetailsListItem> GetReceptionHeaderItems(int ReceptionHeaderID);
        long GetTotalPrice(int ReceptionDetailsID);
        List<ReceptionHeaderListItem> GetAll();
        ReceptionDetail ExistTestInReceptionDetail(int ReceptionHeaderID, int TestID);
        bool ReceptionHeaderExist(int receptionHeaderID);

        bool RemoveReceptionDetails(int ReceptionDetailsID);
        bool RemoveReceptionHeader(int ReceptionHeaderID);

        bool UpdateReceptionDetails(ReceptionDetail OldReceptionDetail);
        bool UpdateReceptionHeader(ReceptionHeader currentReceptionHeader);
                
        List<DomainModel.ViewModel.ReceptionHeaderListItem> Search(DomainModel.ViewModel.ReceptionHeaderSearchModel sm);        
    }
}
