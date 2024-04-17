//El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más. 
using System.Net.Http.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del cliente y su gasto total: ");
        double gastomayor = 0;
        string clientemayor = "";
        for (double i = 1; i <= 5; i++)
        {
                Console.WriteLine("Ingrese el nombre del cliente: "); 
                string cliente = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(cliente) || double.TryParse(cliente, out _))
                {
                   Console.WriteLine("Dato incorrecto, ingrese el nombre del cliente: ");
                   i--;
                }
                else
                {
                     Console.WriteLine("Ingrese su gasto total: ");
                    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double gasto))
                    {
                        if (gasto > gastomayor)
                        {
                            gastomayor = gasto;
                            clientemayor=cliente;
                        }
                    }
                    else 
                    {
                         Console.WriteLine($"ERROR, ingrese nuevamente el gasto total: ");
                          i--;
                    }
                }
        }
        Console.WriteLine($"El cliente que tiene el mayor gasto es {clientemayor}");

    }
}