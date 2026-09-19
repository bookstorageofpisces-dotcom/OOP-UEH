using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal class HourlyEmployee : Employee
    {
        private double hours;
        private double wage;
        
        public HourlyEmployee(string firstName, string lastName, string socialsecuritynumber, double hours, double wage)
            : base(firstName, lastName, socialsecuritynumber)
        {
            this.hours = hours;
            this.wage = wage;
        }
        public override double earnings()
        {
            if (this.hours<=40)
            {
                return this.hours * this.wage;
            }
            else
            {
                return 40 * this.wage + (this.hours - 40) * this.wage * 1.5;
            }
        }
        public override string toString()
        {
            return $"Hourly Employee: {base.toString()} \n Hours Worked: {hours}, Hourly Wage: {wage}";
        }
    }
}
