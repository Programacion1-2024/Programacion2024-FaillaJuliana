//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas.
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int[] notas = new int[5];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"ingrese una nota ");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int nota))
            {
                notas[i] = nota;
                suma += nota;
            }
            else
            {
                Console.WriteLine("ingrese un valor correcto");
                i--;
            }
        }
        double promedio = (double)suma / notas.Length;
        Console.WriteLine($"El promedio de las notas ingresadas es de: {promedio}");
    }
}