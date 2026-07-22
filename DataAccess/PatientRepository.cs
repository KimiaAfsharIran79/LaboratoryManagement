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
    public class PatientRepository : IPatientRepository
    {
        private DomainModel.Models.LaboratoryContext db = new LaboratoryContext();

        public List<PatientListItem> Search(string Phrase)
        {
            return (from p in db.Patients
                    where p.FirstName.StartsWith(Phrase)
                                || p.LastName.StartsWith(Phrase)
                                || p.Mobile.StartsWith(Phrase)
                                || p.NationalCode.StartsWith(Phrase)
                                //|| p.Gender.Equals(Phrase)
                    select new PatientListItem
                    {
                        PatientID = p.PatientID,
                        PatientFullName = p.FirstName + "     " + p.LastName + "     " + p.NationalCode + "     " + p.Mobile + "     " + p.Address,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        NationalCode = p.NationalCode,
                        Mobile = p.Mobile,
                        Address = p.Address,
                        Gender = p.Gender ? "زن" : "مرد"
                    }).ToList();
        }

        public Patient Get(int PatientID)
        {
            return db.Patients.FirstOrDefault(x => x.PatientID == PatientID);
        }

        public List<PatientListItem> GetAll()
        {
            return (from p in db.Patients.OrderByDescending(x => x.PatientID).ToList()
                    select new PatientListItem
                    {
                        PatientID = p.PatientID,
                        PatientFullName = p.FirstName + "     " + p.LastName + "     " + p.NationalCode + "     " + p.Mobile + "     " + p.Address,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        NationalCode = p.NationalCode,
                        Mobile = p.Mobile,
                        Address = p.Address,
                        Gender = p.Gender ? "زن" : "مرد"
                    }).ToList();
        }

        public int Add(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
            return patient.PatientID;
        }

        public bool HasReceptionHeader(int PatientID)
        {
            return db.ReceptionHeaders.Any(x => x.PatientID == PatientID);
        }
        public bool ControlRepeatPatient(string NationalCode)
        {
            return db.Patients.Any(x => x.NationalCode == NationalCode);
        }

        public bool Remove(int PatientID)
        {
            bool result = false;
            try
            {
                var p = db.Patients.FirstOrDefault(x => x.PatientID == PatientID);
                db.Patients.Remove(p);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Patient patient)
        {
            bool result = false;
            try
            {
                var p = db.Patients.FirstOrDefault(x => x.PatientID == patient.PatientID);
                p.FirstName = patient.FirstName;
                p.LastName = patient.LastName;
                p.Gender = patient.Gender;
                p.Mobile = patient.Mobile;
                p.Address = patient.Address;
                p.NationalCode = patient.NationalCode;
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
