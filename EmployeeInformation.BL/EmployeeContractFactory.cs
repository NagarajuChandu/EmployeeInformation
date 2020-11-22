using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DL;

namespace EmployeeInformation.BL
{
    public class EmployeeContractFactory
    {
        public Employee getEmployeeByContractType(ContractyTypeEnum employeeContract)
        {
            if(employeeContract == ContractyTypeEnum.Hourly)
            {
                return new HourlyContract();
            }
            else if(employeeContract == ContractyTypeEnum.Monthly)
            {
                return new MonthlyContract();
            }
            else
                return null;

        }
    }
}
