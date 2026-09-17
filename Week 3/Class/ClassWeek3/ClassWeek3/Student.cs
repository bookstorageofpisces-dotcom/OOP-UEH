using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassWeek3
{
    internal class Student
    {
        private string Id { get; set ;}
        public string FullName { get; set; }
        public string Email { get; set; }
        private float gpa;
        public float GPA
        {
            get { return gpa; }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Student)) return false;
            Student s= (Student)obj;
            return this.Id.ToLower().Equals(s.Id.ToLower());
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public Student(string id, string fullName, string email)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Email = email;
            this.gpa = 0f;
        }
        /*public Student()
        {
            Id="no-id";
            FullName = "no-name";
            Email = "no-email";
            this.gpa = 0f;
        }*/
        public Student():this("no-id", "no-name", "no-email")
        {
            this.gpa= 0f;
        }
        public float TakeExam(Subject subject)
        {
            float result=subject.Result;
            float gpa=calculateGPA(result);
            return subject.Result;
        }
        private float calculateGPA(float result)
        {
            return 5f;
        }
    }
}
