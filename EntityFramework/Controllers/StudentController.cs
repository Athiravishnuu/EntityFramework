using EntityFramework.Db;
using EntityFramework.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public String say()
        {
            return "hai";
        }

        [HttpPost("AddStudent")]
        public void AddStudent(Student studentobj)
        {
            DemoDbContext demoDbContext = new DemoDbContext();
            demoDbContext.Students.Add(studentobj);
            demoDbContext.SaveChanges();

        }
        [HttpGet]
        public List<Student> GetStudents() 
        { 
            DemoDbContext demoDbContext=new DemoDbContext();
            List<Student> studentsList =demoDbContext.Students.ToList();
            return studentsList;
        }
    }   
}
