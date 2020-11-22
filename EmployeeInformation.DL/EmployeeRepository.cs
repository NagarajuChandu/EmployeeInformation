using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformation.DL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> getAllEmployees()
        {
            EmployeeData employeeData = new EmployeeData();
            return employeeData.getEmployees();
        }

        public Employee getEmployeeByID(int employeeID)
        {
            EmployeeData employeeData = new EmployeeData();
            return employeeData.getEmployees().Find(a => a.ID == employeeID);
        }
    }
}
