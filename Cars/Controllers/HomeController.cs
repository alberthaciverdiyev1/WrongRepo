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
            List<Vehicles> vehicles=_context.Vehicles.Include(p=>p.Images.Where(pi=>pi.IsPrimary!=null)).ToList();
            HomeVM homeVM = new HomeVM { 
            Vehicles = vehicles

            };


            return View(homeVM);
        }

        public IActionResult Product(int? Id)
        {
            if (Id == null || Id < 1) return BadRequest();
            Vehicles product = _context.Vehicles.Include(p => p.VehicleTags).Include(t=>t.Images).First(x => x.Id == Id);
            if (product == null) return NotFound();


            return View(product);
        }

    }
}
