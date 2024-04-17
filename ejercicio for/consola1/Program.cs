class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int suma = 0;
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine($"Valor {i}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                suma += numero;
            }
            else
            {
                Console.WriteLine("Entrada invalida. Por favor ingrese un numero valido");
                i--;
            }
        }
        float promedio = (float)suma / 8;
        Console.WriteLine($"El promedio de los 8 numero es {promedio}:");
    }
}
