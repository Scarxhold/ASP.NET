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

        // GET: api/company
        [HttpGet]
        public IActionResult GetCompany()
        {
            return Ok(_company);
        }
    }
}
