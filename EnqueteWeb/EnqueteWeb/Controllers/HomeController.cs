using EnqueteWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Responder(Resposta resposta)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AdicionarResposta(resposta);
                return View("Obrigado");
            }
            else
            {
                return View(resposta);
            }
        }

        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }
    }
}
