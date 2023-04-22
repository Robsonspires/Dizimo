using Dizimo.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Dizimo.Controllers
{
    [PaginaparaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
