using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCompany.Models;

namespace CarCompany.Controllers
{
    [Route("api/Car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarContext _context;

        public CarController(CarContext context)
        {
            _context = context;

            if (_context.Cars.Count() == 0)
            {
                // Create a new Car if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Cars.Add(new Car { CarId = 00001, Name = "Car 1", Company = "Company", User = "", NumberWheels = 4, Model = Enums.CarModels.Default, Colour = Enums.CarColours.Default });
                _context.SaveChanges();
    }
        }

        // GET: api/Car
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        // GET: api/Car/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCars(long id)
        {
            var Car = await _context.Cars.FindAsync(id);

            if (Car == null)
            {
                return NotFound();
            }

            return Car;
        }

        // POST: api/Car
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.CarId }, car);
        }
    }
}