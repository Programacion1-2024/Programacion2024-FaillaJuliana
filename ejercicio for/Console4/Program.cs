class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese ocho numeros: ");
        int max = int.MinValue;
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine($"Numero {i}");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero > max)
                {
                    max = numero;
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Por favor ingrese un numero valido");
                i--;
            }
        }
        Console.WriteLine($"El numero mayor de los 8 numero es {max}:");
    }
}