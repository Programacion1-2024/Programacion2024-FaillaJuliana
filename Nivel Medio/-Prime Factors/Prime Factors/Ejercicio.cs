﻿using System;

namespace Prime_Factors
{
    /*
    Consigna:
        Calcular los factores primos de un número natural dado.

        Un número primo sólo es divisible de manera uniforme por sí mismo y 1.

        Tenga en cuenta que 1 no es un número primo.

        Ejemplo
            ¿Cuales son los factores primos de 60?

            Nuestro primer divisor es 2. 2 cabe en 60, quedando 30.
            2 entra en 30, quedando 15.
            2 no cabe limpiamente en 15. Así que pasemos a nuestro próximo divisor, 3.
            3 entra limpiamente en 15, quedando 5.
            3 no entra limpiamente en 5. El siguiente factor posible es 4.
            4 no entra limpiamente en 5. El siguiente factor posible es 5.
            El 5 entra limpiamente en el 5.
            Nos quedamos solo con 1, así que ya hemos terminado.

            Nuestros divisores exitosos en ese cálculo representan la lista de factores primos de 60: 2, 2, 3 y 5.

        Puedes comprobarlo tú mismo:

            2 * 2 * 3 * 5
            = 4 * 15
            = 60

        ¡Éxito!
    */

    public static class PrimeFactors
    {
        public static long[] Factors(long number)
        {
            long[] primos = new long[number];
            int index = 0;

            long i = 2;
            while (number > 1)
            {
                if (number % i == 0)
                {
                    primos[index] = i;
                    index++;
                    number /= i;
                }
                else
                {
                    i++;
                }
            }

            long[] resultado = new long[index];
            for (int j = 0; j < index; j++)
            {
                resultado[j] = primos[j];
            }

            return resultado;
        }
    }

}
