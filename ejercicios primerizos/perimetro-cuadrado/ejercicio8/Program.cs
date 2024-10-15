Console.Write("Ingrese un lado del triangulo: ");
float lado1, lado2, lado3 ;
if (!Single.TryParse(Console.ReadLine(), out lado1))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    Console.Write("Ingrese otro lado: ");
    if (!Single.TryParse(Console.ReadLine(), out lado2))
    {
        Console.WriteLine("Error, debe ingresar un número correcto");
    }
    else
    {
        Console.WriteLine("Ingrese otro lado: ");
        if (!Single.TryParse(Console.ReadLine(), out lado3))
        {
            Console.WriteLine("Error, debe ingresar un número correcto");
        }
        else
        {
            Console.WriteLine("El perimetro del cuadrado es " + lado1 + lado2 + lado3);
        }
    }
}

