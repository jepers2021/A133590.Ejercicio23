using System;

namespace A133590.Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 23");
            Console.WriteLine("Programa que determina si una fecha ingresada es válida.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if(DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada es válida.");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }    

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
