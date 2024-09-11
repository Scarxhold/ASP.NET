using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly Company company;
        private readonly string Password = "1234";

        public CompanyController()
        {
            company = new Company
            {
                Id = 66,
                Name = "Company",
                Address = "123 Main St, Seoul, Korea",
                Industry = "Technology"
            };
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string password)
        {
            if (password == Password) 
            { 
                return Ok(company);
            }
            else
            {
                return StatusCode(403, "Invalid password. Access denied.");
            }
        }
    }
}
