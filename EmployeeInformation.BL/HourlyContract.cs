using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DL;
namespace EmployeeInformation.BL
{
   public class HourlyContract:Employee
    {
        public override double getCalculatedAnnualSalary()
        {
            return 120 * Salary * 12;
        }
    }
}
