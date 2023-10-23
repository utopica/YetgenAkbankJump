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
        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);

            //http codes
            if (id == Guid.Empty)
            {
                return BadRequest("Id cannot be empty!");
            }
            if(car is null)
            {
                return NotFound("The requested car with the given Id was not found!");
            }

            return Ok(car);

        }
    }
}
