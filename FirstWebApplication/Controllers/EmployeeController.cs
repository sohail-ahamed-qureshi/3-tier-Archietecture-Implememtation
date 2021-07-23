using BuisnessLayer.Interfaces;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeBL Employee;
        public EmployeeController(IEmployeeBL Employee)
        {
            this.Employee = Employee;
        }
        
        [HttpGet]
        public ActionResult GetEmployee()
        {
            List<Employee> employees = this.Employee.GetEmployee();
            return this.Ok(new {Success = true, Message = "Get Employee Successful", Data = employees });

        } 
    }
}
