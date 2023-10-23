using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YetgenAkbankJump.WebApi.Data;

namespace YetgenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            //Gets all the cars
            var cars = CarsContext.LuxuryCars.ToList();
            return Ok(cars);

            //if the operaction successfull(Ok()) return cars. 

        }
    }
}
