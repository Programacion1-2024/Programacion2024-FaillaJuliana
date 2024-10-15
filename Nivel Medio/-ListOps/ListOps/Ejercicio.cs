using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListOps
{
    /*
    Consigna:
        Implementar operaciones de lista básicas.

        En los lenguajes funcionales, las operaciones con listas como length, map y reduceson muy comunes. Implemente una serie de operaciones con listas básicas, sin utilizar funciones existentes.

        El número preciso y los nombres de las operaciones que se implementarán dependerán de la pista para evitar conflictos con los nombres existentes, pero las operaciones generales que implementará incluyen:


        Tenga en cuenta que el orden en el que se pasan los argumentos a las funciones de pliegue (foldl, foldr) es significativo.

        Los métodos Foldly Foldr son funciones "fold", un concepto muy conocido en el mundo de la programación funcional, pero menos conocido en el mundo orientado a objetos. Si desea obtener más información, consulte esta página de fold: https://en.wikipedia.org/wiki/Fold_(higher-order_function).
    */

    public static class ListOps
    {
        //length(dada una lista, devuelve el número total de elementos que contiene);

        public static int Length<T>(List<T> input)
        {
            int respuesta = 0;
            foreach (T item in input)
            {
                respuesta++;
            }
            return respuesta;
        }
        // reverse(ada una lista, devuelve una lista con todos los elementos originales, pero en orden inverso).
        public static List<T> Reverse<T>(List<T> input)
        {
            List<T> reversed = new List<T>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                reversed.Add(input[i]);
            }

            return reversed;
        }
        //map(dada una función y una lista, devuelve la lista de los resultados de la aplicación function(item) a todos los elementos);

        public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
        {
            List<TOut> result = new List<TOut>();
            foreach (TIn item in input)
            {
                result.Add(map(item));
            }
            return result;
        }
        //filter(dado un predicado y una lista, devuelve la lista de todos los elementos para los que predicate(item) es Verdadero);

        public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in input)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        //foldl(dada una función, una lista y un acumulador inicial, pliegue (reduzca) cada elemento en el acumulador desde la izquierda);

        public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
        {
            TOut accumulator = start;
            foreach (TIn item in input)
            {
                accumulator = func(accumulator, item);
            }
            return accumulator;
        }

        //foldr(dada una función, una lista y un acumulador inicial, pliegue (reduzca) cada elemento en el acumulador desde la derecha);

        public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
        {
            TOut accumulator = start;
            for (int i = input.Count - 1; i >= 0; i--)
            {
                accumulator = func(input[i], accumulator);
            }
            return accumulator;
        }

        //concatenate(dada una serie de listas, combine todos los elementos de todas las listas en una lista aplanada);
        public static List<T> Concat<T>(List<List<T>> input)
        {
            List<T> result = new List<T>();
            foreach (List<T> list in input)
            {
                foreach (T item in list)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        // append(dadas dos listas, agregue todos los elementos de la segunda lista al final de la primera lista);

        public static List<T> Append<T>(List<T> left, List<T> right)
        {
            List<T> result = new List<T>(left);
            result.AddRange(right);
            return result;
        }

    }
}
