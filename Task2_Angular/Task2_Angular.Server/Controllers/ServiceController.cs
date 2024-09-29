using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task2_Angular.Server.Models;

namespace Task2_Angular.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly MyDbContext _db;

        public ServiceController(MyDbContext db)
        {
            _db = db;
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("getAllServices")]
        public IActionResult GetAllServices()
        {
            var services = _db.Services.ToList();
            return Ok(services);
        }
    }
}
