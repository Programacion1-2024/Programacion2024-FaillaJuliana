﻿using System;

namespace Diferencias_de_Cuadrados
{

    /*
        Consigna: 
            Encuentra la diferencia entre el cuadrado de la suma y la suma de los cuadrados de los primeros N números naturales.

            El cuadrado de la suma de los diez primeros números naturales es (1 + 2 +... + 10)² = 55² = 3025.

            La suma de los cuadrados de los diez primeros números naturales es 1² + 2² +... + 10² = 385.

            Por tanto, la diferencia entre el cuadrado de la suma de los primeros diez números naturales y la suma de los cuadrados de los primeros diez números naturales es 3025 - 385 = 2640.

            No se espera que usted mismo descubra una solución eficaz a este problema desde los primeros principios; Se permite, o incluso se fomenta, la investigación. Encontrar el mejor algoritmo para el problema es una habilidad clave en ingeniería de software.

            Este ejercicio requiere que procese una recopilación de datos. Puede simplificar su código utilizando LINQ (Language Integrated Query).

            TIPS: Función Math.Pow, LINQ
    */

    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            IEnumerable<int> numeros = Enumerable.Range(1, max);
            int suma=numeros.Sum();
            suma *= suma;
            return suma;
        }

        public static int CalculateSumOfSquares(int max)
        {
            IEnumerable<double> numeros = Enumerable.Range(1, max)
                                                    .Select(num => Math.Pow(num, 2));
            double sum = numeros.Sum();
            return (int)sum;
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            int squareOfSum = CalculateSquareOfSum(max);
            int sumOfSquares = CalculateSumOfSquares(max);
            int difference = squareOfSum - sumOfSquares;
            return difference;

        }
    }
}
