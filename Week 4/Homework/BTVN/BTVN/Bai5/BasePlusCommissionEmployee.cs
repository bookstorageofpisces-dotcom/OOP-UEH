using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class BasePlusCommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;
        private double baseSalary;
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialsecuritynumber, double grossSales, double commissionRate, double baseSalary)
            : base(firstName, lastName, socialsecuritynumber)
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
            this.baseSalary = baseSalary;
        }
        public override double earnings()
        {
            return baseSalary + grossSales * commissionRate;
        }
        public override string toString()
        {
            return $"Base Plus Commission Employee: {base.toString()} \n Gross Sales: {grossSales}\n Commission Rate: {commissionRate}\n Base Salary: {baseSalary}";
        }
    }
}
