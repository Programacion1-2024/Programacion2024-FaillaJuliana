// Retomando el ejercicio 1 ; al finalizar la carga de productos,
// se ingresan las ventas que hubo por cada código, puede haber más de 1 venta por cada articulo.
// El ingreso finaliza al colocar un código en 0. 
//Informar al final los que tienen una cantidad (o/sea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0.
class Program
{
    static void Main(String[] args)
    {
        int codigo = 1;
        while (codigo != 0)
        {
            Console.WriteLine("ingrese el codigo del producto (1 al 10) o 0 para salir");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
            {
                if (codigo >= 1 && codigo <= 10)
                {
                    Console.WriteLine("ingrese el precio del producto");
                    if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double precio))
                    {
                        Console.WriteLine("ingrese la cantidad del producto");
                        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una cantidad correcto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un precio");
                    }
                }
                else
                {
                    Console.WriteLine("ingrese un codigo correcto entre el 1 y 10");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un codigo correcto entre el 1 al 10");
                codigo = 1;
            }
        }
        while (codigo != 0)
        {
            Console.WriteLine("Ventas");
            Console.WriteLine("ingrese el codigo del producto entre el 1 al 10 o 0 para salir");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
            {
                if (codigo >= 1 && codigo <= 10)
                {
                    Console.WriteLine("ingrese la cantidad vendida del producto");
                    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Ingrese una cantidad correcto");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un codigo entre el 1 y 10");
                }
            }
            else 
            {
                Console.WriteLine("Ingrese un codigo valido entre el 1 al 10");
            }
        }
    }
}