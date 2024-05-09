// 1 - Ordenar palabras alfabéticamente
//El usuario ingresará una lista de palabras. El programa debe guardar, ordenar estas
//palabras alfabéticamente y mostrarlas en la consola.
class Program
{
    static void Main(string[] args)
    {
        List<string> palabras = new List<string>();
        string? palabra = "a";
        while (!string.IsNullOrWhiteSpace(palabra))
        {
            if (double.TryParse(palabra, out _) && !string.IsNullOrWhiteSpace(palabra))
            {
                palabras.Remove(palabra);
                Console.Write("Ingrese un dato correcto.");
                palabra = "a";
            }
            else
            {
                Console.WriteLine("ingrese una palabra, ingrese enter para finalizar");
                palabra = Console.ReadLine();
                palabras.Add (palabra);
            }
        }
          palabras.Sort();
          foreach (string i in palabras)
          {
               Console.WriteLine(i);
          }

    }
}