using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformation.DataAccessLayer
{
    public class EmployeeData
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> getEmployees()
        {
            employees.Add(new Employee { ID = 1001, FirstName = "Andrew", LastName = "Hemlton", DOB = Convert.ToDateTime("01/20/1995"), Salary = 60, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1002, FirstName = "Andy", LastName = "Haffman", DOB = Convert.ToDateTime("12/22/1998"), Salary = 460, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1003, FirstName = "Jhon", LastName = "Hell", DOB = Convert.ToDateTime("11/02/1997"), Salary = 50, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1004, FirstName = "Frank", LastName = "Deburn", DOB = Convert.ToDateTime("10/25/1996"), Salary = 450, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1005, FirstName = "Bob", LastName = "Rehil", DOB = Convert.ToDateTime("02/28/1975"), Salary = 65, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1006, FirstName = "Nikolus", LastName = "Nilo", DOB = Convert.ToDateTime("09/29/1978"), Salary = 465, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1007, FirstName = "Mark", LastName = "Hemmery", DOB = Convert.ToDateTime("08/28/1986"), Salary = 56, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1008, FirstName = "Eileen", LastName = "C", DOB = Convert.ToDateTime("07/27/1965"), Salary = 560, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1009, FirstName = "Amy", LastName = "Merkus", DOB = Convert.ToDateTime("06/26/1975"), Salary = 68, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1010, FirstName = "Carol", LastName = "Derun", DOB = Convert.ToDateTime("05/25/1955"), Salary = 668, ContractType = ContractyTypeEnum.Monthly });
            return employees;
        }
    }
}
