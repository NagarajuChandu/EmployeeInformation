using EmployeeInformation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeInformation.BusinessLayer
{
    public class EmployeeDetails : IEmployeeDetails
    {
        IEmployeeRepository employeeRepository;
        public Employee getEmployeeByID(int employeeID)
        {
            employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.getEmployeeByID(employeeID);

            EmployeeContractFactory employeeContractFactory = new EmployeeContractFactory();
            employee.Salary = (employeeContractFactory.getEmployeeByContractType(employee.ContractType)).getCalculatedAnnualSalary();

            return employee;
        }

        public List<Employee> getEmployees()
        {
            employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.getAllEmployees();
            EmployeeContractFactory employeeContractFactory = new EmployeeContractFactory();
            foreach (Employee employee in employees)
            {
                
                employee.Salary = (employeeContractFactory.getEmployeeByContractType(employee.ContractType)).getCalculatedAnnualSalary();

            }

            return employees;
        }
    }
}
