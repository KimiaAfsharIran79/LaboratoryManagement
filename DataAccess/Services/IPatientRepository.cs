using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IPatientRepository
    {
        List<PatientListItem> Search(string Phrase);
        
        Patient Get(int PatientID);
        
        List<PatientListItem> GetAll();

        int Add(Patient patient);
        bool Remove(int PatientID);
        bool Update(Patient patient);
        bool HasReceptionHeader(int PatientID);
        bool ControlRepeatPatient(string NationalCode);
    }
}
