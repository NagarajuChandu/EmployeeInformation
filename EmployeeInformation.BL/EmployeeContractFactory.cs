using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DL;

namespace EmployeeInformation.BL
{
    public class EmployeeContractFactory
    {
        public Employee getEmployeeByContractType(Employee employee)
        {
            if(employee.ContractType == ContractyTypeEnum.Hourly)
            {
                return new HourlyContract(employee.ID, employee.FirstName, employee.LastName, employee.DOB, employee.Salary);
            }
            else if(employee.ContractType == ContractyTypeEnum.Monthly)
            {
                return new MonthlyContract(employee.ID, employee.FirstName, employee.LastName, employee.DOB, employee.Salary);
            }
            else
                return null;

        }
    }
}
