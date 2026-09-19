using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class SalariedEmployee : Employee
    {
        private double weeklySalary;
        public SalariedEmployee(string firstName, string lastName, string socialsecuritynumber, double weeklySalary)
            : base(firstName, lastName, socialsecuritynumber)
        {
            this.weeklySalary = weeklySalary;
        }
        public override double earnings()
        {
            return weeklySalary;
        }
        public override string toString()
        {
            return $"Salaried Employee: {base.toString()} \n Weekly Salary: {weeklySalary}";
        }

    }
}
