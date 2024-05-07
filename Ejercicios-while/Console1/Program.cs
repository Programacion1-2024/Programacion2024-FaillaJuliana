// El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0
//(cero).El sistema deberá informar la suma de los ingresados.
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese valores positivos para sumarlos, cuando desee parar, ingrese el 0: ");
        int suma = 0;
        int numero = 1;
        while (numero != 0)
        {
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
            {
                if (numero >= 0)
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("ingrese un valor positivo");

                }
            }
            else
            {
                Console.WriteLine("ingrese un valor correcto");
                numero = 1;
            }
        }
        Console.WriteLine($"La suma  da : {suma}");
    }
}