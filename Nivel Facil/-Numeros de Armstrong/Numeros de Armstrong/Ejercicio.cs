using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Numeros_de_Armstrong
{
    /*
        Consigna: 
            Un número de Armstrong es un número que es la suma de sus propios dígitos, cada uno elevado a la potencia del número de dígitos.

            Por ejemplo:
                9 es un número de Armstrong, porque9 = 9^1 = 9
                10 no es un número de Armstrong, porque10 != 1^2 + 0^2 = 1
                153 es un número de Armstrong porque:153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
                154 no es un número de Armstrong porque:154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

            Escribe un código para determinar si un número es un número de Armstrong.
    */

    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number)
        {
            char[] digitos = number.ToString().ToCharArray();
            int[] digitosComoInt = new int[digitos.Length];
            int numeroDigitos = digitosComoInt.Length;
            int suma = 0;
            for (int i = 0; i < digitos.Length; i++)
            {
                digitosComoInt[i] = (int)char.GetNumericValue(digitos[i]);
                
            }
            foreach (int digito in digitosComoInt)
            {
                suma += (int)Math.Pow(digito, numeroDigitos);
            }
            if (suma == number)
            {
               return true;
            }
            else
            {
                return false;         
            }
        }
    }
}
