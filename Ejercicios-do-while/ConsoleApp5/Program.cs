// Siguiendo con el ejercicio anterior, al ingresar uno mayor a 3 cifras se mostrará el
//promedio de los ingresados.
class Program
{
    static void Main(String[] args)
    {
        double numero;
        double suma = 0;
        int contador = 0;
        do
        {
            Console.WriteLine("ingrese un numero positivo de 3 cifras");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
            {

                if (numero < 100)
                {
                    Console.WriteLine("error");
                    suma += numero;
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido: ");
                numero = 0;
            }


        } while (numero < 100);
        double promedio = suma / contador;
        Console.WriteLine($"has ingresado un numero de 3 cifras exitosamente, el promedio de los datos incorrectos es de: {promedio}");
    }
}