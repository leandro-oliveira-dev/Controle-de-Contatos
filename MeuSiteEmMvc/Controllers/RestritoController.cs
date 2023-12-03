using MeuSiteEmMvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MeuSiteEmMvc.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
