using Microsoft.AspNetCore.Mvc;
using Practica_6.Datos;

namespace Practica_6.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View(new PersonaAdmin().Consultar());
        }
    }
}
