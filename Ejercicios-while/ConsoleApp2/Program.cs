// Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese valores positivos para sumarlos, cuando desee parar, ingrese el 0: ");
        int suma = 0;
        int numero = 1;
        int contador = 0;
        while (numero != 0)
        {
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out numero))
            {
                if (numero > 0)
                {
                    suma += numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor correcto");
                    numero = 1;
                }
            }
        }
        double promedio = (double)suma / contador;
        Console.WriteLine($"La suma  da : {promedio}");
    }
}