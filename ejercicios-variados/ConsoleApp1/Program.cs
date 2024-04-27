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
        while (codigo != 0 && codigo >1 && codigo < 10)
        {
            Console.WriteLine("ingrese el codigo del producto (1 al 10) o 0 para salir");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
            {
                if (codigo > 1 && codigo < 10)
                {              
                    Console.WriteLine("ingrese el precio del producto");
                    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double precio))
                    {
                        Console.WriteLine("ingrese la cantidad del producto");
                        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                        {
                            if (cantidad > maximacantidad)
                            {
                                maximacantidad = cantidad;
                                codigoMaxCantidad = codigo;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una cantidad correcto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un codigo correcto entre el 1 al 10");
                    }
                else
                {
                    Console.WriteLine("ingrese un precio correcto");
                }

            }
            else
            {
                 Console.WriteLine("Ingrese un codigo correcto entre el 1 al 10");
                codigo = 1;
            }
        }
    }
}