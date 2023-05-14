using Cars.DAL;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Cars.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()

        {
            List<BodyType> bodyTypes = await _context.BodyTypes.Include(b => b.Vehicles).ToListAsync();

            return View(bodyTypes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BodyType bodyType)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool result = await _context.BodyTypes
                .AnyAsync(b => b.Body.Trim().ToLower() == bodyType.Body.Trim().ToLower());
            if (result)
            {
                ModelState.AddModelError("Body", "Bu Adda Kateqoriya Artiq Movcuddur");
                return View();
            }
            await _context.BodyTypes.AddAsync(bodyType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
