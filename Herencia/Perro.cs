using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    /// <summary>
    /// Clase Perro que hereda de Animal
    /// </summary>
    class Perro : Animal
    {
        // Constructor
        public Perro(string nombre) : base(nombre) 
        {
            
        }

        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} esta ladrando.");
        }
    }
}
