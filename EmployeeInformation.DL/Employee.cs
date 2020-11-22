using System;

namespace EmployeeInformation.DL
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double Salary { get; set; }
        public ContractyTypeEnum ContractType { get; set; }

        public virtual double getCalculatedAnnualSalary()
        {
            return Salary;
        }
    }
}
