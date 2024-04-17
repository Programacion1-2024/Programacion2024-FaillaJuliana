//El usuario ingresa un número N y se debe mostrar como resultado el factorial de dicho número.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero para saber su factorial: ");
        int factorial = 1;
        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int numero))
        {
            for (int i = numero ;i>1;i--) 
            {
                factorial += i;
            }
        }
        else 
        {
            Console.WriteLine("ERROR , Ingrese un numero para saber su factorial correcto: ");
        }
        Console.WriteLine($"el factorial es {factorial} ");
    }
}   