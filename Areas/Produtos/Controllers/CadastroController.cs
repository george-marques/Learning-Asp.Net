using Microsoft.AspNetCore.Mvc;

namespace Asp_mvc.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
