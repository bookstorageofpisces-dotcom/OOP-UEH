using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN.Bai5
{
    internal abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string socialsecuritynumber;
        protected Employee(string firstName, string lastName, string socialsecuritynumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialsecuritynumber = socialsecuritynumber;
        }
        public abstract double earnings();
        public virtual string toString()
        {
            return $"First Name: {firstName}, Last Name: {lastName} \n Social Security Number: {socialsecuritynumber}";
        }
    }
}
