//  El usuario ingresa un número entero positivo N y se deben mostrar todos los números enteros
//  positivos pares desde 0 (incluido) hasta N.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero positivo y se mostraran todos los numeros enteros positivos pares desde el 0 hasta el elegido");
        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int entero))
        {
            for (int i =0; i<=entero; i +=2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada incorrecta ");
        }
    }
}
        
