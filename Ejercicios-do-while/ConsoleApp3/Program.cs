// Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de
//los números negativos ingresados.
class Program
{
    static void Main(String[] args)
    {
        double numero;
        int contador = 0;
        double suma = 0; 
        do
        {
            Console.WriteLine("ingrese un numero positivo");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
            {

                if (numero <= -1)
                {
                    Console.WriteLine("error");
                    contador *= 1;
                    suma += numero;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido: ");
                numero = 0;
            }


        } while (numero <= -1);
        double promedio = suma / contador;
        Console.WriteLine($"has ingresado un numero positivo exitosamente, el promedio de los numeros negativos es: {promedio}");
    }
}
