using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilidadYModificadoresDeAcceso
{
    class CuentaBancaria
    {
        //Solo se puede utilizar dentro de la clase CuentaBancaria
        private double Saldo { get; set; }
        //Se puede leer por fuera de la clase CuentaBancaria pero solo se puede cambiar su valor dentro de la clase CuentaBancaria
        public double SaldoPrivado { get; private set; }
        //Se puede utilizar en todas partes.
        public int Publico { get; set; }
        //Se puede utilizar solo cuando una clase hereda de CuentaBancaria.
        protected int Privado { get; set; }

        public CuentaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(double cantidad)
        {
            Saldo += cantidad;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= Saldo) {
                Saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }

        public double ObtenerSaldo()
        {
            return Saldo;
        }

    }
}
