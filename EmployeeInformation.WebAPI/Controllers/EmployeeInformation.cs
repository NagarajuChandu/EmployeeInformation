using EmployeeInformation.BL;
using EmployeeInformation.DL;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeInformation.WebAPI.Controllers
{
    public class EmployeeInformationController : ApiController
    {
        IEmployeeDetails employeeDetails;

        public EmployeeInformationController()
        {
            employeeDetails = new EmployeeDetails();
        }
        // GET api/<controller>

        public List<Employee> GetAllEmployees()
        {
             return employeeDetails.getEmployees();
        }

        // GET api/<controller>/5
        public Employee GetEmployeeByID(int id)
        {
            return employeeDetails.getEmployeeByID(id);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}