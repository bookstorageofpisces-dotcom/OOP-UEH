using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWeek3
{
    internal class Classes
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        private List<Student> students;
        public Classes(string ClassID, string ClassName)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            students = new List<Student>();
        }
        /*public Classes(string ClassID, string ClassName, List<Student> students)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            this.students = students;
        }//Aggregation*/
        public bool AddNewStudent(Student student)
        {
            if (students.Contains(student))//phải có equals và gethashcode trong student để so sánh
            {
                return false;
            }
            students.Add(student);
            return true;
        }
        public Student GetStudentByID(string studentID)
        {
            Student st = new Student(studentID, "","");//quan tâm id (vì hashcode-equals)
            int index = students.IndexOf(st);//vị trí của student trong list students
            if (index == -1)
            {
                return null; //ko có
            }
            return students[index];
        }
        //lấy danh sách sinh viên
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public List<Student> GetStudentWithGPAGE(float gpalimit) 
        {
            List<Student> result= new List<Student>();
            foreach (var s in students) 
            {
                if (s.GPA >= gpalimit)
                {
                    result.Add(s);
                }
            }
            return result.Count > 0 ? result : null;
        }
        public Student UpdateStudent(string id, Student newstudent)
        {
           Student? st=GetStudentByID(id);
            //ko có thì làm sao cập nhật?
            if (st != null) return null;
            st = newstudent;
            return newstudent;
        }
        public Student? DeleteById(string id)
        {
            Student? student = GetStudentByID(id);
            if (student == null) return null;
            students.Remove(student);
            return student;
        }

    }
}
