﻿// Para calcular el total de una factura, el usuario ingresará pares de datos Costo
//unitario y cantidad comprada; cuando se ingrese costo 0 finaliza el ingreso de datos;
//informar el total adeudado.
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        double costo = 1;
        while (costo != 0)
        {
            Console.Write("Ingrese costo unitario y cantidad comprada para calcular el total (al ingresar un 0 en el costo se dara el monto final: ");
            Console.Write("Costo unitario: ");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out costo))
            {
                if (costo == 0)
                {
                    Console.WriteLine($"El total de la compra es: {total}");

                }
                else
                {
                    Console.Write(" Ingrese la cantidad de unidades compradas : ");
                    if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int unidades))
                    {
                        total += unidades * costo;
                    }
                }
            }
            else
            {
                Console.Write("dato invalido");
                costo = 1;
            }
        }

    }
}