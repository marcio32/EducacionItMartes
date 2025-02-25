namespace Calculadora
{
    internal class Program : Calculadora
    {
        private static void Main(string[] args)
        {
            int num1, num2, operacion = 0;

            while (operacion != 5)
            {
                operacion = MuestraMenu();

                if (operacion == 5)
                {
                    Console.WriteLine("Gracias por usar la calculadora");
                    break;
                }

                Console.WriteLine("\nIngresa el primer numero: ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Por favor, ingrese un numero valido:");
                }

                Console.WriteLine("\nIngresa el segundo numero: ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Por favor, ingrese un numero valido");
                }

                Console.WriteLine(num2 == 0 && operacion == 4 ? "No se puede dividir entre cero": $"El resultado es: {Calcular(num1, num2, operacion)}\n");
                Console.WriteLine("Pulse enter para realziar una nueva operacion");
                Console.ReadLine(); 

            }
        }
    }
}
