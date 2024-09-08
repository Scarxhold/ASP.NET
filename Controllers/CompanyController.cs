using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly Company _company;
        private readonly string _validPassword = "1234";

        public CompanyController()
        {
            _company = new Company
            {
                Id = 1,
                Name = "Example Company",
                Address = "123 Main St, City, Country",
                Industry = "Technology"
            };
        }

        [HttpGet]
        public IActionResult GetCompany([FromQuery] string password)
        {
            if (password == _validPassword) 
            { 
                return Ok(_company);
            }
            else
            {
                return StatusCode(403, "Invalid password. Access denied.");
            }
        }
    }
}
