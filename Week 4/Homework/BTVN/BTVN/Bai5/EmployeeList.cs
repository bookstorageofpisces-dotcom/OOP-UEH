using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class EmployeeList
    {
        List<Employee> EmployeesList;
        public EmployeeList()
        {
            EmployeesList = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            EmployeesList.Add(employee);
        }
        public void PrintAllEmployees()
        {
            foreach (Employee employee in EmployeesList)
            {
                Console.WriteLine(employee.toString() + "\n" + employee.earnings());
            }
        }
    }
}

