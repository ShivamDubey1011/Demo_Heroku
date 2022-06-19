using Heroku_Demo.Models;
using System.Collections.Generic;

namespace Heroku_Demo.Data
{
    public interface IStudentData
    {
        public List<Student> GetAllStudents();
        public Student AddStudent(Student student);
    }
}
