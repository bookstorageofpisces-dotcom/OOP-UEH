using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWeek1
{
    public class Student
    {
        private string Name;
        private int Age;
        private int GPA;
        private string Gender;

        public Student(string Name, int Age, string Gender, int GPA)
        {
            this.Name = Name;
            this.Age = Age;
            this.GPA = GPA;
            this.Gender = Gender;
        }

        public string GetInform()
        {
            return "Name: " + Name + ", Age: " + Age + ", Gender: " + Gender + ", GPA: " + GPA;
        }
    }
}