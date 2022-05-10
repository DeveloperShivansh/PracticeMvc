using Microsoft.AspNetCore.Mvc;
using PracticeMvc.Models;
using System.Diagnostics;
using PracticeMvc.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PracticeMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext Context, ILogger<HomeController> logger)
        {
            _context = Context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult UploadProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadProject(SimpleProjectViewModel m)
        {
            if(m.Files == null)
            {
                Console.WriteLine("No Files Found In Model");
            }
            else
            {
                Console.WriteLine("Files Count: ", m.Files.Count);
            }
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model State is Found To be Valid");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}