using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee Get(int EmployeeID);
        int Add(Employee employee);
        bool Remove(int EmployeeID);
        bool Update(Employee employee);
        bool HasReceptionHeader(int EmployeeID);
        bool Login(string UserName, string Password);        
        Employee GetEmployeeByUserName(string UserName);
        bool ControlRepeatEmoloyee(string UserName);
    }
}
