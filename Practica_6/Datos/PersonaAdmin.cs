using Foundation.ObjectHydrator;
using Practica_6.Models;

namespace Practica_6.Datos
{
    public class PersonaAdmin
    {
        public IEnumerable<PersonaModel> Consultar()
        {
            var listado = new Hydrator<PersonaModel>().WithFirstName(n =>n.Nombre).WithLastName(n => n.Apellido).WithAmericanPhone(n => n.telefono);
            return listado.GetList(30).ToList();
        }
    }
}
