
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de unidades compradas:");
        double totalcosto = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Compra {i} - Ingrese la cantidad de unidades compradas : ");
            if (int.TryParse(Console.ReadLine()?.Replace(".",","), out int unidades))
            {
                Console.Write($"Compra {i} - Costo unitario: ");
                if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double costo))
                {
                    totalcosto += unidades * costo;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                i--;
            }
        }
        Console.WriteLine($"La suma de las 5 compras es: {totalcosto}");
    }
}