using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograma
{
    /*
        Consigna: 
            Determina si una palabra o frase es un isograma.

            Un isograma (también conocido como "palabra sin patrón") es una palabra o frase sin una letra repetida; sin embargo, se permite que aparezcan espacios y guiones varias veces.

            Ejemplos de isogramas:

            lumberjacks
            background
            downstream
            six-year-old

            La palabra isogramas, sin embargo, no es un isograma porque la s se repite.

            TIPS: Funciones ToCharArray, IndexOf y LastIndexOf de la clase String
                  dividir la cadena de caracteres en lineas
     
     
     */

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower().Replace(",","").Replace(".","").Replace(" ","").Replace("_","").Replace("-","");
            if (string.IsNullOrEmpty(word))
            {
                return true; 
            }
            
            char[] arr=word.ToCharArray();
 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    
                    if (arr[i] == arr[j] )
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }
    }
    
}