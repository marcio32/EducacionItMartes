using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    /// <summary>
    /// Clase Gato que hereda de Animal
    /// </summary>
    class Gato : Animal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Ingresar Nombre del gato</param>
        public Gato(string nombre) : base(nombre)
        {
            
        }

        /// <summary>
        /// Metodo que simula el maullido de un gato
        /// </summary>
        public void Maullar()
        {
            Console.WriteLine($"{Nombre} esta maullando.");
        }
    }
}
