using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace BTVN
{
    public class Student
    {
        private string name;
        private double score;
        private static int totalStudents = 0;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudents++;
        }

        public string GetName()
        {
            return name;
        }
        public double GetScore()
        {
            return score;
        }
        public bool IsPassed()
        {
           if (score >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetClassification()
        {
            if (score >= 8)
            {
                return "Excellent";
            }
            else if (score >= 6.5)
            {
                return "Good";
            }
            else if (score >= 5)
            {
                return "Average";
            }
            else
            {
                return "Weak";
            }
        }
        public static int GetTotalStudent()
        {
            return totalStudents;
        }
        public static string FindTopStudent(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                return null;
            }
            Student top = students[0];
            foreach (Student student in students)
            {
                if (student.score > top.score)
                {
                    top = student;
                }
            }
            return top.name;
        }
        public static double CalculateAverageScore(Student[] students)
        {             
            if (students == null || students.Length == 0)
            {
                return 0;
            }
            double totalScore = 0;
            foreach (Student student in students)
            {
                totalScore += student.score;
            }
            return totalScore / students.Length;
        }
    }
}