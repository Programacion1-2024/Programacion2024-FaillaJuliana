Console.Write("Ingrese un número: ");
float numero;
if (!Single.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    if (numero >= 0)
    {
        Console.WriteLine("El numero es positivo ");
    }
    else
    {
        Console.WriteLine("El numero es negativo ");
    }
}
