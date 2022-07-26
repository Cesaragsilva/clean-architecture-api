using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarServiceApplication _carServiceApplication;
        public CarController(ICarServiceApplication carServiceApplication)
        {
            _carServiceApplication = carServiceApplication;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CarInputModel carInputModel)
        {
            var car = await _carServiceApplication.CreateAsync(carInputModel);
            return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var car = await _carServiceApplication.GetByIdAsync(id);
            if(car is null)
                return NotFound();

            return Ok(car);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var car = await _carServiceApplication.GetAllAsync();
            if (car is null)
                return NotFound();

            return Ok(car);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var car = await _carServiceApplication.DeleteAsync(id);
            if (car is null)
                return NotFound();

            return Ok(car);
        }
    }
}
