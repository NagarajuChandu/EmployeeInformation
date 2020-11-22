using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DL;
namespace EmployeeInformation.BL
{
    public interface IEmployeeDetails
    {
        Employee getEmployeeByID(int employeeID);
        List<Employee> getEmployees();
    }
}
