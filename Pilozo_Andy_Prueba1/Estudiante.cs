using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilozo_Andy_Prueba1
{
    internal class Estudiante
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double calificacion { get; set; }

        public Estudiante(string nombre, int edad, double calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificacion = calificacion;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.nombre + " \nEdad: " + this.edad + " \nCalificacion: " + this.calificacion);
        }
    }
}
