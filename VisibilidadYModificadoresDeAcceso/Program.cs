namespace VisibilidadYModificadoresDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuenta = new CuentaBancaria(1000);

            cuenta.Depositar(500);
            Console.WriteLine($"Saldo despues del deposito: {cuenta.ObtenerSaldo()}");

            cuenta.Retirar(1200);
            Console.WriteLine($"Saldo despues del retiro: {cuenta.ObtenerSaldo()}");

        }
    }
}
