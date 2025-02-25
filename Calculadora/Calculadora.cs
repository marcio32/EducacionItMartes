using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora : Menu
    {

        protected static int Calcular(int num1, int num2, int opcion)
        {
            return opcion switch
            {
                1 => num1 + num2,
                2 => num1 + num2,
                3 => num1 * num2,
                4 => num1 / num2,
                _ => 0
            };
        }
    }
}
