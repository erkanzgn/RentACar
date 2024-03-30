using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
    }
}
