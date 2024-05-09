// Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese
//un número mayor a 3 cifras. Mostrar la suma total de todos los ingresados antes del
//corte.
class Program
{
    static void Main(String[] args)
    {
        double numero;
        double suma = 0;
        do
        {
            Console.WriteLine("ingrese un numero positivo de 3 cifras");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
            {

                if (numero < 100)
                {
                    Console.WriteLine("error");
                    suma += numero;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido: ");
                numero = 0;
            }


        } while (numero < 100);
        Console.WriteLine($"has ingresado un numero de 3 cifras exitosamente, la suma de los datos incorrectos es de: {suma}");
    }
}