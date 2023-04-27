using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
