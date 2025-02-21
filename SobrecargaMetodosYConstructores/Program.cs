namespace SobrecargaMetodosYConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Sumar(1,1,1);

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
