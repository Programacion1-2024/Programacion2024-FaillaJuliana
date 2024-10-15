Console.Write("Ingrese un número: ");
int numero1, numero2;
if (!Int32.TryParse(Console.ReadLine(), out numero1))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.Write("Ingrese otro número: ");
    if (!Int32.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }
    else
    {
        if (numero1 == numero2)
        {
            Console.WriteLine("Los numeros on iguales");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"{numero2} es mayor que {numero1}");
        }
        else
        {
            Console.WriteLine($"{numero1} es mayor que {numero2}");
        }
    }
}
