using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosYConstructores
{
    /// <summary>
    /// Clase que representa una calculadora
    /// </summary>
    class Calculadora
    {

        #region Constructores

        /// <summary>
        /// Constructor de la clase vacio
        /// </summary>
        public Calculadora()
        {
            
        }

        /// <summary>
        /// Constructor de la clase con dos parametros
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        public Calculadora(int a, int b)
        {
            
        }

        /// <summary>
        /// Constructor de la clase con dos parametros decimales
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        public Calculadora(double a, double b)
        {
            
        }

        /// <summary>
        /// Constructor de la clase con tres parametros
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <param name="c">Tercer numero a sumar</param>
        public Calculadora(int a, int b, int c)
        {
            
        }

        #endregion

        #region Funciones

        /// <summary>
        /// Metodo que suma dos numeros enteros
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <returns>Retorna la sumatoria entre A y B</returns>
        public int Sumar(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Metodo que suma dos numeros decimales
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <returns>Retorna la sumatoria entre A y B</returns>
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Metodo que suma tres numeros enteros
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <param name="c">Tercer numero a sumar</param>
        /// <returns>Retorna la sumatoria entre A, B, C/returns>
        public int Sumar (int a, int b , int c)
        {
            return a + b + c;
        }

        #endregion
    }
}
