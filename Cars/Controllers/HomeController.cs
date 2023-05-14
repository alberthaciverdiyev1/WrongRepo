using Cars.DAL;
using Cars.Models;
using Cars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Vehicles> vehicles = _context.Vehicles.Include(p => p.Images).ToList();
            ViewData["Vehicles"]=vehicles;

            return View();
        }

   
        public IActionResult Detail(int? Id)
        {



            if (Id == null || Id < 1) return BadRequest();
    
            var vehicles = _context.Vehicles
        .Include(p => p.VehicleTags).ThenInclude(v=>v.Tags)
        .Include(t => t.Images)
        .Include(b=>b.BodyType)
        .Include(c=>c.VehicleColors).ThenInclude(v=>v.Colors)

        .FirstOrDefault(v => v.Id == Id);
         if (vehicles == null) return NotFound();


            
            return View(vehicles);
        }


    }
}
