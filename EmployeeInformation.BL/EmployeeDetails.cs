using EmployeeInformation.DL;
using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeInformation.BL
{
    public class EmployeeDetails : IEmployeeDetails
    {
        IEmployeeRepository employeeRepository;
        public Employee getEmployeeByID(int employeeID)
        {
            employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.getEmployeeByID(employeeID);
            if (employee == null)
                return null;
            EmployeeContractFactory employeeContractFactory = new EmployeeContractFactory();
            employee.Salary = (employeeContractFactory.getEmployeeByContractType(employee)).getCalculatedAnnualSalary();

            return employee;
        }

        public List<Employee> getEmployees()
        {
            employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.getAllEmployees();
            EmployeeContractFactory employeeContractFactory = new EmployeeContractFactory();
            foreach (Employee employee in employees)
            {
                
                employee.Salary = (employeeContractFactory.getEmployeeByContractType(employee)).getCalculatedAnnualSalary();

            }

            return employees;
        }
    }
}
