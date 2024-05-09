//Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir
//este ingreso hasta que el usuario ingrese la clave correcta: 667788.
class Program
{
    static void Main(String[] args)
    {
        int clave;
        do
        {
            Console.WriteLine("Ingrese su nombre de usuario: ");
            string usuario=Console.ReadLine();
            Console.WriteLine("Ingrese la clave: ");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out clave))
            {
                if (clave != 667788)
                {
                    Console.WriteLine("Ingrese la clave nuevamente: ");
                   
                }
            }
            else
            {
                Console.WriteLine("ingrese nuevamente la clave");
                clave = 0;
            }

        } while (clave != 667788);
        Console.WriteLine($"Ha ingresado exitosamente!!");
    }
}