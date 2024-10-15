Console.Write("Ingrese un número: ");
float numero1, numero2, numero3;
if (!Single.TryParse(Console.ReadLine(), out numero1))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.Write("Ingrese otro número: ");
    if (!Single.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }
    else
    {
        Console.WriteLine("Ingrese otro numero: ");
        if (!Single.TryParse(Console.ReadLine(), out numero3))
        {
            Console.WriteLine("Error, debe ingresar un número correcto");
        }
        else
        {
            Console.WriteLine("el promedio de los tres numeros es " + (numero1 + numero1 + numero2 + numero3) / 3);
        }
    }
}