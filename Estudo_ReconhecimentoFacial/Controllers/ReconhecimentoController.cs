using Microsoft.AspNetCore.Mvc;

namespace Estudo_ReconhecimentoFacial.Controllers
{
    public class ReconhecimentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}