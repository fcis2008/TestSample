using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace TestSampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<Student> _logger;

        public StudentController(ILogger<Student> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("ReceiveStudentDetails")]
        public async void ReceiveStudentDetails(Student student)
        {
            string json = JsonSerializer.Serialize(student);
            await System.IO.File.WriteAllTextAsync(@"D:\newJson.json", json);
            _logger.LogInformation("Success");
        }
    }
}