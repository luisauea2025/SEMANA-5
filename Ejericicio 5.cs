using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalisisPrecios
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Almacenar los precios en una lista
            List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

            // 2. Obtener el menor y el mayor usando System.Linq
            int precioMenor = precios.Min();
            int precioMayor = precios.Max();

            // 3. Mostrar los resultados por pantalla
            Console.WriteLine("--- Análisis de Precios ---");
            Console.WriteLine("Lista de precios: " + string.Join(", ", precios));
            Console.WriteLine($"El precio menor es: {precioMenor}");
            Console.WriteLine($"El precio mayor es: {precioMayor}");

            // Pausa para la terminal
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        } // Llave de cierre del Main
    } // Llave de cierre de la clase Program
} // Llave de cierre del namespace