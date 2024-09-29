using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task2_Angular.Server.Models;

namespace Task2_Angular.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubserviceController : ControllerBase
    {
        private readonly MyDbContext _db;

        public SubserviceController(MyDbContext db)
        {
            _db = db;
        }
        /////////////////////////////////////////////////////////////////////////////
        [HttpGet("GetSubServicesbyServiceID")]
        public IActionResult GetSubServicesbyServiceID(int id)
        {
            var SubService = _db.SubServices.Where(x => x.ServiceId == id).ToList();
            return Ok(SubService);
        }
        /////////////////////////////////////////////////////////////////////////////
        [HttpGet("GetSubServicesbyID")]
        public IActionResult GetSubServicesbyID(int id)
        {
            var SubService = _db.SubServices.Where(x => x.SubServiceId == id).ToList();
            return Ok(SubService);
        }
    }
}
