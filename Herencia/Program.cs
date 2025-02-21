namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Gato = new Gato("Pepe");
            var Perro = new Perro("Firulais");

            Perro.Ladrar();
            Perro.Comer();
            
            Gato.Maullar();
            Gato.Comer();

        }
    }
}
