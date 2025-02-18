using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraConMetodosYManejosDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Seleccione una operacion (+, -, *, /)");
                var operacion = Console.ReadLine();

                Console.WriteLine("Ingrese el primer numero:");
                var num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero:");
                var num2 = Convert.ToDouble(Console.ReadLine());

                var resultado = Calcular(num1, num2, operacion);

                Console.WriteLine($"El resultado es: {resultado}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }

        static double Calcular(double num1, double num2, string operacion)
        {
            var resultado = 0.0;
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 / num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }

            return resultado;
        }


    }
}
