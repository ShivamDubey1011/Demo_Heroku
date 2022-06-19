using Heroku_Demo.Models;
using System.Collections.Generic;

namespace Heroku_Demo.Data
{
    public class StudentData : IStudentData
    {
        List<Student> students = new List<Student>();

        public Student AddStudent(Student student)
        {
            students.Add(student);
            return student;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
