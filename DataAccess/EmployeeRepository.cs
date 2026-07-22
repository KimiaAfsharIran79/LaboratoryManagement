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
    public class EmployeeRepository : IEmployeeRepository
    {
        public DomainModel.Models.LaboratoryContext db = new LaboratoryContext();
        public int Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee.EmployeeID;
        }

        public Employee Get(int EmployeeID)
        {
            return db.Employees.FirstOrDefault(x => x.EmployeeID == EmployeeID);
        }

        public List<Employee> GetAll()
        {
            return db.Employees.OrderByDescending(x => x.EmployeeID).ToList();
        }
        public List<EmployeeListItem> GetEmployee()
        {
            return (from e in db.Employees
                    select new EmployeeListItem
                    {
                        EmployeeID = e.EmployeeID,
                        EmployeeFullName = e.FirstName + "   " + e.LastName
                    }).ToList();                  
        }

        public bool ControlRepeatEmoloyee(string UserName)
        {
            return db.Employees.Any(x => x.UserName == UserName);
        }

        public Employee GetEmployeeByUserName(string UserName)
        {
            return db.Employees.FirstOrDefault(x => x.UserName == UserName);
        }

        public bool HasReceptionHeader(int EmployeeID)
        {
            return db.ReceptionHeaders.Any(x => x.EmployeeID == EmployeeID);
        }

        public bool Login(string UserName, string Password)
        {
            return db.Employees.Any(x => x.UserName == UserName && x.Password == Password & x.IsActive == true);
        }

        public bool Remove(int EmployeeID)
        {
            bool result = false;
            try
            {
                var emp = db.Employees.FirstOrDefault(x => x.EmployeeID == EmployeeID);
                db.Employees.Remove(emp);
                db.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Employee employee)
        {
            bool result = false;
            try
            {
                var emp = db.Employees.FirstOrDefault(x => x.EmployeeID == employee.EmployeeID);
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.UserName = employee.UserName;
                emp.Password = employee.Password;
                emp.IsActive = employee.IsActive;
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
