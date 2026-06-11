using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            if (id == 0)
                return NotFound();

            return Ok(new
            {
                Id = 1,
                Name = "Galaxy s23 ultra",
                CreationDate = DateTime.Now,
                CompanyName = "Samsung",
                Price = 12_300_00
            });
        }
    }
}
