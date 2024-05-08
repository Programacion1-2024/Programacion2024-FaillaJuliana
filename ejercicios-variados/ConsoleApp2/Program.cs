// Retomando el ejercicio 1 ; al finalizar la carga de productos,
// se ingresan las ventas que hubo por cada código, puede haber más de 1 venta por cada articulo.
// El ingreso finaliza al colocar un código en 0. 
//Informar al final los que tienen una cantidad (o/sea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0.
class Program
{
    static void Main(String[] args)
    {
        int codigo = 1;
        List<double> codigos = new List<double>();
        List<int> cantidades = new List<int>();
        Console.WriteLine("Registro de stock por codigos");
        while (codigo != 0)
        {
            Console.WriteLine("ingrese el codigo del producto (1 al 10) o 0 para salir");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
            {
                if (codigo >= 1 && codigo <= 10)
                {
                    codigos.Add(codigo);

                    Console.WriteLine("ingrese la cantidad del producto");
                    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                    {
                        cantidades.Add(cantidad);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        codigos.Remove(codigo);
                    }

                }
                else if (codigo == 0)
                {
                    foreach (int i in cantidades)
                    {
                        Console.WriteLine($"stock: {i}");

                    }
                    codigo = 1;
                    Console.WriteLine("Ventas");
                    while (codigo != 0)
                    {
                        Console.WriteLine("ingrese el codigo del producto entre el 1 al 10 o 0 para salir, esto restara las unidades en stock");
                        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out codigo))
                        {
                            if (codigo >= 1 && codigo <= 10)
                            {
                                codigo--;
                                Console.WriteLine("ingrese la cantidad de productos vendidos");
                                if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int cantidad))
                                {
                                    cantidades[codigo] -= cantidad;
                                    codigo = 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                    foreach (int i in cantidades)
                    {
                        Console.WriteLine($"stock: {i}");

                    }

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
    }
        

}