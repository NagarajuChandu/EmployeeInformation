using System;
using EmployeeInformation.DL;
namespace EmployeeInformation.BL
{
    public class MonthlyContract: Employee
    {
        public override double getCalculatedAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
