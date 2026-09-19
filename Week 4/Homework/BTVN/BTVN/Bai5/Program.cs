using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Doe", "123-45-6789", 1000);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane", "Smith", "987-65-4321", 20, 40);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Bob", "Johnson", "111-22-3333", 5000, 0.1);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Alice", "Williams", "444-55-6666", 3000, 0.05, 500);
            EmployeeList employeeList = new EmployeeList();
            employeeList.AddEmployee(salariedEmployee);
            employeeList.AddEmployee(hourlyEmployee);
            employeeList.AddEmployee(commissionEmployee);
            employeeList.AddEmployee(basePlusCommissionEmployee);
            employeeList.PrintAllEmployees();
        }
    }
}
