using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructoresYSobreescritura
{
    class Vehiculo
    {
        public string Marca { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public virtual void Conducir()
        {
            Console.WriteLine($"Conduciendo un vehiculo de marca {Marca}");
        }
    }
}
