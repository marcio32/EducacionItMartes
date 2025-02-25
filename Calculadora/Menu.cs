using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu
    {
        /// <summary>
        /// Metodo para mostrar el menu de operaciones
        /// </summary>
        /// <returns>Retorna el valor seleccionado</returns>
        protected static int MuestraMenu()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("          MENU DE OPERACIONES          ");
            Console.WriteLine("=======================================");
            Console.WriteLine("  1. Sumar");
            Console.WriteLine("  2. Restar");
            Console.WriteLine("  3. Multiplicar");
            Console.WriteLine("  4. Dividir");
            Console.WriteLine("  5. Salir");
            Console.WriteLine("=======================================");
            Console.WriteLine("Por favor, selecciona una opcion: ");

            if (int.TryParse(Console.ReadLine(), out var operacion))
            {
                return operacion;
            }
            else
            {
                Console.WriteLine("Por favor, selecciona una opcion valida");
                return MuestraMenu();
            }
        
        }

    }
}
