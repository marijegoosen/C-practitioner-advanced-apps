using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWedding.Data;
using MyWedding.Models;
using MyWedding.Models.Enums;


namespace MyWedding.Controllers
{
    public class AdminController : Controller
        //[Authorize]
    {
        private readonly ApplicationDbContext _dbContext;

       public AdminController(ApplicationDbContext dbContext)
       {
           _dbContext = dbContext;
       }

        // Custom methods here
        //returns an Index View
        public IActionResult Index()
        {
            return View(_dbContext.Guests.ToList());
        }

        //called from a form
        [HttpPost]
        public IActionResult AddGuest([FromForm] string code, string name)
        {
            var guest = new Guest();
            guest.Code = code;
            guest.Name = name;
            _dbContext.Guests.Add(guest);
            _dbContext.SaveChanges();

            return View("Index", _dbContext.Guests.ToList());
        }

        //to delete quests
        [HttpPost]
        public IActionResult DeleteGuest([FromForm] int id)
        {
            var guest = _dbContext.Guests.FirstOrDefault(x => x.Id == id);
            _dbContext.Guests.Remove(guest);
            _dbContext.SaveChanges();
            return View("Index", _dbContext.Guests.ToList());
        }

        //to edit quests
        public IActionResult Edit(int id)
        {
            var guest = _dbContext.Guests.FirstOrDefault(x => x.Id == id);
            return View(guest);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] int id, string name, string code, bool? isAttending, EMealType mealType, string comments)
        {
            var guest = _dbContext.Guests.FirstOrDefault(x => x.Id == id);
            guest.Name = name;
            guest.Code = code;
            if (isAttending != null)
            {
                guest.IsAttending = (bool)isAttending;
            }
            guest.MealType = mealType;
            guest.Comments = comments;
            guest.HasResponded = true;

            _dbContext.Guests.Update(guest);
            _dbContext.SaveChanges();

            return View("Index", _dbContext.Guests.ToList());
        }
    }
}
