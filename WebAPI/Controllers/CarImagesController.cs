using Business.Abstract;
using Entites.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int id)
        {
            var result = _carImageService.GetByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //[HttpPost("upload")]
        //public async Task<IActionResult> UploadPhoto(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return BadRequest("Lütfen bir dosya seçin.");

        //    var filePath = Path.Combine("wwwwroot/images", Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    return Ok();
        //}

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] int carId)
        { 
            CarImage carImage = new() { CarId = carId };
            var result = _carImageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] int id)
        {
            CarImage oldCarImage = _carImageService.GetById(id).Data;
            var result = _carImageService.Update(file, oldCarImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
