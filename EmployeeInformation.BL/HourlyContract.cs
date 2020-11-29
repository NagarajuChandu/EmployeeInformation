using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DL;
namespace EmployeeInformation.BL
{
   public class HourlyContract:Employee
    {
        public HourlyContract(int ID, string FirstName, string LastName, DateTime DOB,double Salary)
        {
            base.ID = ID;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.DOB = DOB;
            base.Salary = Salary;
        }
        
        public override double getCalculatedAnnualSalary()
        {
            return 120 * base.Salary * 12;
        }
    }
}
