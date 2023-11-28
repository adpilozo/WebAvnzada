using Foundation.ObjectHydrator;
using Microsoft.AspNetCore.Mvc;
using Practica_6.Models;
using System.Diagnostics;

namespace Practica_6.Controllers
{
    public class HomeController : Controller
    {
        private List<PersonaModel> ObtenerListaPersonas()
        {
            var listado = new Hydrator<PersonaModel>().WithFirstName(n => n.Nombre)
                                                     .WithLastName(n => n.Apellido)
                                                     .WithAmericanPhone(n => n.telefono);
            return listado.GetList(30).ToList();
        }

        public IActionResult Index()
        {
            var listaPersonas = ObtenerListaPersonas();
            return View(listaPersonas);
        }

        public IActionResult Editar(int id)
        {
            var listaPersonas = ObtenerListaPersonas();
            var persona = listaPersonas.FirstOrDefault(p => p.Id == id);

            if (persona == null)
            {
                return NotFound(); // Puedes manejar el caso donde la persona no se encuentra.
            }

            return View(persona);
        }

        [HttpPost]
        public IActionResult Editar(PersonaModel persona)
        {
            // Aquí deberías actualizar la persona en tu fuente de datos (base de datos, servicio, etc.)
            // Puedes utilizar un servicio de acceso a datos para realizar esta operación.

            // Después de actualizar, puedes redirigir a la acción Index o cualquier otra página que desees.
            return RedirectToAction("Index");
        }
    }
}