using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example
{
    //Client Class or Dependent Object
    //This is the Class that is going to consume the services provided by the IEmployeeDAL Class
    //That means it is the Dependent Class which Depending on the IEmployeeDAL Class
    internal class EmployeeBL
    {
        public List<Employee> GetAllEmployees(IEmployeeDAL employeeDAL)
        {
            return employeeDAL.SelectAllEmployees();
        }
       
    }
}
