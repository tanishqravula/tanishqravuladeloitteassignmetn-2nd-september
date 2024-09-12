using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;
using WebApplication6.Models;
using WebApplication6.Repositories;
using System.Diagnostics.Eventing.Reader;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        public IStudentService _service;
        public StudentsApiController(IStudentService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student obj = _service.GetStudentById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested employee details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost]
        public IActionResult Create(Student obj) { 
            _service.AddStudent(obj);
            return Ok(new {result="Student details added succesfully"});
        }
        [HttpPut]
        public IActionResult Update(Student obj) {
            if (obj != null)
            {
                _service.UpdateStudent(obj);
                return Ok(new { result = "Student details updated succesfully" });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Student obj= _service.GetStudentById(id);
            if (obj!= null)
            {
                _service.DeleteStudent(id);
                return Ok(new { result = "Student details deleted succesfully" });
            }
            else
            {
                return NotFound();
            }
        }
     
        }
    }
