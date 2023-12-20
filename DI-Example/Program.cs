using System;
using System.Collections.Generic;

namespace DI_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Instance of EmployeeBL and Inject the Dependency Object as an Argument to the Constructor
            EmployeeBL employeeBL = new EmployeeBL();

          
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}