using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DataAccessLayer;
namespace EmployeeInformation.BusinessLayer
{
   public class HourlyContract:Employee
    {
        public override double getCalculatedAnnualSalary()
        {
            return 120 * Salary * 12;
        }
    }
}
