using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly TPTContext _db;
        public PeopleController(TPTContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult AddTeacher([FromBody]Teacher teacher)
        {
            //this data will save in both tables(People and Teachers)
            _db.Teachers.Add(teacher);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody]Student student)
        {
            //this data will save in both tables(People and Students)
            _db.Students.Add(student);
            _db.SaveChanges();
            return Ok();
        }
    }
}
