//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza una lista para almacenar las notas.
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<double> notas = new List<double>();
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("ingrese una nota");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double nueva_nota))
            {
                notas.Add(nueva_nota);
                sum += (nueva_nota);
            }
            else
            {
                Console.WriteLine("ingrese un numero correcto");
                i--;
            }

        }
        double promedio = sum / 5 ;
        Console.WriteLine($"El promedio de las notas ingresadas es:{promedio}");
    }
}