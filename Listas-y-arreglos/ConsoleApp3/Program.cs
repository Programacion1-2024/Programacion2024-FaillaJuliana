//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos
//números en una lista y luego mostrarlos en la consola.
class Program
{
    static void Main(string[] args)
    {
        List <int> numeros=new List <int> ();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("ingrese un numero");
            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int nuevo_numero))
            {
                numeros.Add(nuevo_numero);

            }
            else
            {
                Console.WriteLine("ingrese un numero correcto");
                i--;
            }
        }
        Console.WriteLine("Los números ingresados son:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}