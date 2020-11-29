using System;
using EmployeeInformation.DL;
namespace EmployeeInformation.BL
{
    public class MonthlyContract: Employee
    {
        public MonthlyContract(int ID, string FirstName, string LastName, DateTime DOB, double Salary)
        {
            base.ID = ID;
            base.FirstName = FirstName;
            base.LastName = LastName;
            base.DOB = DOB;
            base.Salary = Salary;
        }
        public override double getCalculatedAnnualSalary()
        {
            return base.Salary * 12;
        }
    }
}
