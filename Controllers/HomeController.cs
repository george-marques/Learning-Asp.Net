using Asp_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp_mvc.Controllers
{
    [Route("")]
    [Route("casa")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }
        
        [Route("privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
