using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructoresYSobreescritura
{
     class Auto : Vehiculo
    {
        public string Modelo { get; set; }

        public Auto(string marca, string modelo) : base(marca)
        {
            Modelo = modelo;
        }


        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo un auto modelo {Modelo} y marca {Marca}");
        }
    }
}
