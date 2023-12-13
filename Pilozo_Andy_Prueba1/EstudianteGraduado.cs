using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilozo_Andy_Prueba1
{
    internal class EstudianteGraduado : Estudiante
    {
        public string titulo { get; set; } 
        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo ) : base(nombre, edad, calificacion)
        {
            this.titulo = titulo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Título: " + this.titulo);
        }
    }
}
