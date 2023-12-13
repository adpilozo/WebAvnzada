using Pilozo_Andy_Prueba1;
using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 \n");
        int numero1 = 17;
        int numero2 = 21;
        int resultado;
        resultado = numero1 + numero2;
        Console.WriteLine("El resultado de la suma es: " + resultado + "\n");



        // EJERCICIO 2
        Console.WriteLine("EJERCICIO 2 \n");
        int edad = 18;
        if (edad > 17)
        {
            Console.WriteLine("La persona si es mayor de edad \n");
        }
        else
        {
            Console.WriteLine("La persona no es mayor de edad \n");
        }



        // EJERCICIO 3
        Console.WriteLine("EJERCICIO 3 \n");
        Estudiante estudiante1 = new Estudiante("Andy", 22, 17.3);
        estudiante1.MostrarInformacion();
        Console.WriteLine();


        //EJERCICIO 4
        Console.WriteLine("EJERCICIO 4 \n");
        EstudianteGraduado graduado1 = new EstudianteGraduado("Bryan",29,19,"Ing. Electromecanico");
        graduado1.MostrarInformacion();



    }
}