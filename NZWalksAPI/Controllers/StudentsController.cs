using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksAPI.Controllers;

//https://localhost:portnumber/api/students
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    // GET: //localhost:portnumber/api/students
    [HttpGet]
    public IActionResult GetAllStudents()
    {
        string[] studentNames = new string[] { "Jon", "Bob", "Kal", "Mark", "David", "Emily" };

        return Ok(studentNames);

    }

}
