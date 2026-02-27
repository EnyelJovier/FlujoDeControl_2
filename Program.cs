namespace FlujoDeControl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estudiante, estatus;
            double n1, n2, n3, n4, promedio, suma;
            int cantidadestudiantes;
            string fila = "";

            Console.Write("Ingrese la cantidad de estudiantes : ");
            cantidadestudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidadestudiantes; i++)
            {
                Console.Write("\nIngrese el nombre del estudiante : ");
                estudiante = Console.ReadLine();

                Console.Write("Ingrese la nota 1 : ");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota 2 : ");
                n2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota 3 : ");
                n3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota 4 : ");
                n4 = Convert.ToDouble(Console.ReadLine());

                suma = n1 + n2 + n3 + n4;
                promedio = suma / 4;

                if (promedio >= 70)
                    estatus = "Aprobado";

                else
                    estatus = "Reprobado";

                
                fila += $"{estudiante}\t\t{n1}\t{n2}\t{n3}\t{n4}\t{promedio}\t\t{estatus}\n";
            }

            Console.WriteLine("\n------------------------------------------------------------------------");
            Console.WriteLine("Estudiantes\tNota1\tNota2\tNota3\tNota4\tPromedio\tEstatus");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine(fila);

            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
