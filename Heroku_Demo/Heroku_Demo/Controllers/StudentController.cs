using Heroku_Demo.Data;
using Heroku_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heroku_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentData _studentData;
        public StudentController(IStudentData studentData)
        {
            _studentData = studentData;
        }
        [Route("GetAllStudent")]
        [HttpGet]
        public ActionResult GetAllStudent()
        {
            return Ok(_studentData.GetAllStudents());
        }

        [Route("AddStudent")]
        [HttpPost]
        public ActionResult AddStudent([FromBody]Student student)
        {
            _studentData.AddStudent(student);
            return Ok(student);
        }
    }
}
