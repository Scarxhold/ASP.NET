using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomNumberController : ControllerBase
    {
        private readonly Random _random;

        public RandomNumberController()
        {
            _random = new Random();
        }

        [HttpGet]
        public IActionResult GetRandomNumber()
        {
            int randomNumber = _random.Next(0, 101);
            return Ok(randomNumber);
        }
    }
}
