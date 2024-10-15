Console.Write("Ingrese un número: ");
int numero;
if (!Int32.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
     if (numero % 2 == 0)
     {
        Console.WriteLine("El número es par");
     }
     else
     {
         Console.WriteLine("El número es impar");
     }

}
