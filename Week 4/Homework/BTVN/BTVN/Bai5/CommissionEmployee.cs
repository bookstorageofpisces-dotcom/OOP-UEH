using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class CommissionEmployee : Employee
    {
        private double grossSales;
        private double commissionRate;
        public CommissionEmployee(string firstName, string lastName, string socialsecuritynumber, double grossSales, double commissionRate)
            : base(firstName, lastName, socialsecuritynumber)
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }
        public override double earnings()
        {
            return grossSales * commissionRate;
        }
        public override string toString()
        {
            return $"Commission Employee: {base.toString()} \n Gross Sales: {grossSales}\n Commission Rate: {commissionRate}";
        }
    }
}
