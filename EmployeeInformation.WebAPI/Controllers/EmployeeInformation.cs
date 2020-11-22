using EmployeeInformation.BL;
using EmployeeInformation.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeInformation.WebAPI.Controllers
{
    public class EmployeeInformation : ApiController
    {
        IEmployeeDetails employeeDetails;

        public EmployeeInformation()
        {
            employeeDetails = new EmployeeDetails();
        }
        // GET api/<controller>

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeDetails.getEmployees();
        }

        // GET api/<controller>/5
        public Employee GetEmployeeByID(string id)
        {
            return employeeDetails.getEmployeeByID(Convert.ToInt32(id));
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