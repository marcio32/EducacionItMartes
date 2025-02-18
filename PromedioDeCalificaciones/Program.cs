namespace PromedioDeCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calificaciones = new List<double>();
            var entrada = "";

            Console.WriteLine("Ingrese las calificaciones de los alumnos. Para terminar, escriba fin.");

            while ((entrada = Console.ReadLine()) != "fin")
            {
                try
                {
                    calificaciones.Add(Convert.ToDouble(entrada));
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            if (calificaciones.Count > 0)
            {
                var promedio = CalcularPromedio(calificaciones);
                Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }

        }

        static double CalcularPromedio(List<double> calificaciones)
        {
            var suma = 0.0;

            foreach (var calificacion in calificaciones)
            {
                suma += calificacion;
            }

            return suma / calificaciones.Count;
        }
    }
}
