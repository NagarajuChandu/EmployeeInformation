using System;
using System.Collections.Generic;
using System.Text;
using EmployeeInformation.DataAccessLayer;
namespace EmployeeInformation.BusinessLayer
{
    public interface IEmployeeDetails
    {
        Employee getEmployeeByID(int employeeID);
        List<Employee> getEmployees();
    }
}
