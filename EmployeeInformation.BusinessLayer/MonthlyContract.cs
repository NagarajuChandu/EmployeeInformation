using System;
using EmployeeInformation.DataAccessLayer;
namespace EmployeeInformation.BusinessLayer
{
    public class MonthlyContract: Employee
    {
        public override double getCalculatedAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
