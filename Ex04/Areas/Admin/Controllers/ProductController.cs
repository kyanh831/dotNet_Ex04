using Ex04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ex04.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class ProductController(ApplicationDbContext context) : Controller
    {       
        // GET: Products
        [Route("")]
        public async Task<IActionResult> Index()
        {
            return View(await context.Products.ToListAsync());
        }
    }
}
