class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un nombre de persona, cuando ingrese un espacio vacio, se informara cuadtos nombres ha ingresado: ");
        int contador = 0;
        string nombre = "x";
        while ()
        {
            Console.WriteLine("Nombre: ");
            contador++;
            if (string.IsNullOrEmpty(nombre) || double.TryParse(nombre, out _))
            {
                break;
            }
        }
        Console.WriteLine($"Has ingresado {contador - 1} nombre: ");
    }
}