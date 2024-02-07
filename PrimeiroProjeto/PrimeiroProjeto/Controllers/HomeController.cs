using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(int? id)
        {
            return View(id);
        }
    }
}
