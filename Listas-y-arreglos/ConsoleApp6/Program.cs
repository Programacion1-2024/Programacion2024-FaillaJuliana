// 2- Filtrar números pares en una lista
//El usuario ingresará números enteros uno por uno.
//El programa debe solicitar al usuario que ingrese los números hasta que ingrese el número 0 para finalizar.
//Luego, debe mostrar losnúmeros ingresados de mayor a menor en la consola.
//Si se ingresa un valor no válido, se mostrará un mensaje de error.
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int numero = 1;
        while (numero != 0)
        {
            Console.WriteLine("ingrese un numero entero, para finalizar, ingrese 0");
            if (int.TryParse(Console.ReadLine()?.Replace(".",","), out numero))
            {
                if (numero == 0)
                {}
                else
                {
                    numeros.Add(numero);
                }
            }
            else
            {
                Console.WriteLine("error");
                numero = 1;
            }
        }
        List<int> numerospares = new List<int>();
        foreach (int i in numeros)
        {
            if ( i % 2 == 0)
            {
                numerospares.Add(i);
            }
        }
        Console.WriteLine("lista de numeros pares ordenados de mayor a menor:");
        numerospares.Sort();
        numerospares.Reverse();
        foreach (int i in numerospares)
        {
           Console.WriteLine($"{i}");
        }
    }
}