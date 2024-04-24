// Para calcular el consumo total de un cliente
// cuántosproductos compró;
// el costo de cada uno de esos productos
//  al terminar informará el total adeudado por el cliente.

class Program
{
    static void Main(string[] args)
    {
        double costototal = 0;
        Console.Write(" Ingrese la cantidad de productos comprados : ");
        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
        {
            while (cantidad > 0)
            {
                Console.WriteLine("Ingrese el costo de cada producto: ");
                if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double costo))
                {
                    costototal += costo;
                    cantidad -= 1;
                }
                else 
                {
                    Console.WriteLine("ingrese un valor valido; ");
                }
            }

        }
        else
        {
            Console.WriteLine("ingrese un valor valido; ");
        }
        Console.WriteLine($"El cosot total de la compra es {costototal}");
    }
}