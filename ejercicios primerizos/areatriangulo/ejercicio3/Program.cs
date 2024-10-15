using System.Formats.Asn1;

Console.Write("Ingrese un lado del triangulo: ");
float lado;
if (!Single.TryParse(Console.ReadLine(), out lado))
{
    Console.WriteLine("Error, debe ingresar un dato correcto");
}
else
{
    float area = lado * lado;
    Console.WriteLine("El area del triangulo es " + area);
}