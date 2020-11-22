using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformation.DL
{
    public interface IEmployeeRepository
    {
        Employee getEmployeeByID(int employeeID);

        List<Employee> getAllEmployees();

    }
}
