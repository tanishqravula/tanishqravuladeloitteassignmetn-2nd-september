using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        public SchoolDbContext _context;

        public StudentsApiController(SchoolDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            List<Student> students = _context.Students.ToList();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student obj = _context.Students.Find(id);

            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new { status = "Requested student details does not exists." });
            }
        }

        [HttpPost]
        public IActionResult CreateStudent(Student obj)
        {
            _context.Students.Add(obj);
            _context.SaveChanges();
            return Ok(new { status = "New student details added in server." });
        }

        [HttpPut]
        public IActionResult EditStudent(Student obj)
        {
            _context.Students.Update(obj);
            _context.SaveChanges();
            return Ok(new { status = "Student details updated in server." });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            Student obj = _context.Students.Find(id);

            if (obj != null)
            {
                _context.Students.Remove(obj);
                _context.SaveChanges();
                return Ok(new { status = "Student details are deleted from server." });
            }
            else
            {
                return NotFound(new { status = "Requested student details does not exists." });
            }
        }



    }
}
