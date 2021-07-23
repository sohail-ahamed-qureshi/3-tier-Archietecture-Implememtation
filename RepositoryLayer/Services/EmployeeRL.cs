using CommonLayer;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ name = "Mayur", age = 25, phoneNumber = 12314}
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
