using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EmployeeInformation.DL
{
    public class EmployeeData
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> getEmployees()
        {
            employees.Add(new Employee { ID = 1001, FirstName = "Andrew", LastName = "Hemlton", DOB = Convert.ToDateTime(DateTime.ParseExact("01/20/1995","MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 60, ContractType = (ContractyTypeEnum)ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1002, FirstName = "Andy", LastName = "Haffman", DOB = Convert.ToDateTime(DateTime.ParseExact("12/22/1998", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 460, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1003, FirstName = "Jhon", LastName = "Hell", DOB = Convert.ToDateTime(DateTime.ParseExact("11/02/1997", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 50, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1004, FirstName = "Frank", LastName = "Deburn", DOB = Convert.ToDateTime(DateTime.ParseExact("10/25/1996", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 450, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1005, FirstName = "Bob", LastName = "Rehil", DOB = Convert.ToDateTime(DateTime.ParseExact("02/28/1975", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 65, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1006, FirstName = "Nikolus", LastName = "Nilo", DOB = Convert.ToDateTime(DateTime.ParseExact("09/29/1978", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 465, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1007, FirstName = "Mark", LastName = "Hemmery", DOB = Convert.ToDateTime(DateTime.ParseExact("08/28/1986", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 56, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1008, FirstName = "Eileen", LastName = "C", DOB = Convert.ToDateTime(DateTime.ParseExact("07/27/1965", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 560, ContractType = ContractyTypeEnum.Monthly });
            employees.Add(new Employee { ID = 1009, FirstName = "Amy", LastName = "Merkus", DOB = Convert.ToDateTime(DateTime.ParseExact("06/26/1975", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 68, ContractType = ContractyTypeEnum.Hourly });
            employees.Add(new Employee { ID = 1010, FirstName = "Carol", LastName = "Derun", DOB = Convert.ToDateTime(DateTime.ParseExact("05/25/1955", "MM/dd/yyyy", CultureInfo.InvariantCulture)), Salary = 668, ContractType = ContractyTypeEnum.Monthly });
            return employees;
        }
    }
}
