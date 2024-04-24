// El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre
//vacío, sin datos; el sistema informará cuántos nombres de han ingresado.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un nombre de persona. Cuando ingrese un espacio vacío, se informará cuántos nombres ha ingresado:");
        int contador = 0;
        string nombre = "a";
        while (!string.IsNullOrWhiteSpace(nombre))
        {
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            if (double.TryParse(nombre, out _))
            {
                Console.Write("Ingrese un dato correcto.");
            }
            else
            {
                contador++;
            }
        }  
        Console.WriteLine($"Has ingresado {contador} nombres.");
    }
}
