// Se ingresa el código de producto (son 10 productos, codificados del 1 al 10),
// luego el precio
// la cantidad que hay del mismo.
// La carga finaliza cuando se ingresa un código = 0 ;
// al terminar indicar el código de producto que mayor cantidad tiene.
class Program
{
    static void Main(String[] args)
    {
        int codigo = 1;
        int maximacantidad = 0;
        int codigoMaxCantidad = 0;
        List <double> codigos = new List<double>();
        List <int> cantidades = new List<int>();
        while (codigo != 0)
        {
            Console.WriteLine("ingrese el codigo del producto (1 al 10) o 0 para salir");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
            {
                if (codigo >= 1 && codigo <= 10)
                {
                    codigos.Add(codigo);
                    Console.WriteLine("ingrese el precio del producto");
                    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double precio))
                    {
                        Console.WriteLine("ingrese la cantidad del producto");
                        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                        {
                            cantidades.Add(cantidad);
                            if (cantidad > maximacantidad)
                            {
                                maximacantidad = cantidad;
                                codigoMaxCantidad = codigo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                            codigos.Remove(codigo);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                        codigos.Remove(codigo); 
                    }
                }
                else if (codigo == 0)
                {
                    Console.WriteLine($"El producto con el codigo {codigoMaxCantidad} es el que tiene mayor cantidad: {maximacantidad}");

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
                codigo = 1;
            }
        }
        Console.WriteLine("lista de codigos");
        foreach (int numero in codigos)
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine("lista de cantidades");
        foreach (int numero in cantidades)
        {
            Console.WriteLine(numero);
        }
    }
}