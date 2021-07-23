using BuisnessLayer.Interfaces;
using CommonLayer;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRL Employee;
        public EmployeeBL(IEmployeeRL Employee)
        {
            this.Employee = Employee;
        }

        public List<Employee> GetEmployee()
        {
            return this.Employee.GetEmployees();
        }
    }
}
