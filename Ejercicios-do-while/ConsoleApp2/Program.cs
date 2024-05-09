//Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que
//ingrese un positivo.
class Program
{
    static void Main(String[] args)
    {
        double numero;
        do
        {
            Console.WriteLine("ingrese un numero positivo");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out  numero))
            {

                if (numero <= -1)
                {
                    Console.WriteLine("error");

                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido: ");
                numero = 0;
            }
        } while (numero <= -1);
        Console.WriteLine("has ingresado un numero positivo exitosamente");
    }
}
