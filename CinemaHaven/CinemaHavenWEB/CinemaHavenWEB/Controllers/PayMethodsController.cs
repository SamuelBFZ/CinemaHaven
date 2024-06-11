using Microsoft.AspNetCore.Mvc;

namespace CinemaHavenWEB.Controllers
{
    public class PayMethodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
