using System.Diagnostics.CodeAnalysis;

namespace CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultado = 0.0;
            var error = false;

            Console.WriteLine("Seleccione una operacion (+, -, *, /)");
            var operacion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer numero:");
            var num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:" );
            var num2 = Convert.ToDouble(Console.ReadLine());

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
                    error = true;
                    break;
            }

            //if(operacion == "+")
            //{
            //    resultado = num1 + num2;
            //}
            //else if(operacion == "-")
            //{
            //    resultado = num1 - num2;
            //}
            //else if(operacion == "*")
            //{
            //    resultado = num1 * num2;

            //}
            //else if (operacion == "/")
            //{
            //    resultado = num1 / num2;
            //}

            if(error)
            {
                Console.WriteLine("Operacion no valida.");
            }
            else
            {
                Console.WriteLine($"El resultado es: {resultado}");
            }

        }
    }
}
