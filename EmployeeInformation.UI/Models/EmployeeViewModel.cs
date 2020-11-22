using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.UI.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double Salary { get; set; }
        public ContractyTypeEnum ContractType { get; set; }
    }
}