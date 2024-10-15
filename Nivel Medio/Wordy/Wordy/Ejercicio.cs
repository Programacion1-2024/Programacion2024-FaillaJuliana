using System;
using System.Text.RegularExpressions;

namespace Wordy
{
    /*
    Consigna:
        Instrucciones
        Analizar y evaluar problemas matemáticos simples y devolver la respuesta como un número entero.

        Iteración 0 — Números
            Los problemas sin operaciones simplemente se evalúan al número dado.

                What is 5?
                    Se evalúa como 5.

        Iteración 1 — Adición
            Sumar dos números juntos.

                What is 5 plus 13?
                    Se evalúa como 18.

            Manejar números grandes y números negativos.

        Iteración 2: Resta, multiplicación y división
            Ahora, realiza las otras tres operaciones.

                What is 7 minus 5?
                    2

                What is 6 multiplied by 4?
                    24

                What is 25 divided by 5?
                    5

        Iteración 3: Operaciones múltiples
            Manejar un conjunto de operaciones, en secuencia.

            Dado que se trata de problemas verbales, evalúe la expresión de izquierda a derecha, ignorando el orden típico de operaciones.

                What is 5 plus 13 plus 6?
                    24

                What is 3 plus 2 multiplied by 3?
                    15 (es decir, no 9)

        Iteración 4: Errores
            El analizador debe rechazar:

            Operaciones no admitidas ("What is 52 cubed?")

            Preguntas no matemáticas ("Who is the President of the United States?")

            Problemas de palabras con sintaxis no válida ("What is 1 plus plus 2?")
    */

    public static class Wordy
    {

        public static int Answer(string question)
        {
            string cleanedQuestion = question.Replace("What is", "").Replace("?", "").Trim();
            string[] tokens = cleanedQuestion.Split(' ');

            // Verificar si el primer token es un número válido
            if (!int.TryParse(tokens[0], out int result))
            {
                throw new ArgumentException("Sintaxis no válida: el primer valor debe ser un número.");
            }

            // Iteración 1, 2 y 3: Operaciones
            for (int i = 1; i < tokens.Length; i += 2)
            {
                string operation = tokens[i];

                // Verificar si el token actual es una operación válida
                if (operation != "plus" && operation != "minus" && operation != "multiplied" && operation != "divided")
                {
                    throw new ArgumentException($"Sintaxis no válida: '{operation}' no es una operación reconocida.");
                }

                // Asegurarse de que haya un token después de la operación
                if (i + 1 >= tokens.Length)
                {
                    throw new ArgumentException("Sintaxis no válida: falta un operando después de la operación.");
                }

                int nextNumber;

                // Para manejar "multiplied by" y "divided by"
                if (operation == "multiplied" || operation == "divided")
                {
                    if (tokens[i + 1] != "by" || !int.TryParse(tokens[i + 2], out nextNumber))
                    {
                        throw new ArgumentException("Sintaxis no válida.");
                    }

                    operation = $"{operation} by"; // Combinar en "multiplied by" o "divided by"
                    i++; // Saltar el "by"
                }
                else
                {
                    // Verificar si el siguiente token es un número, considerando posibles números negativos
                    if (tokens[i + 1] == "-" && i + 2 < tokens.Length && int.TryParse(tokens[i + 2], out nextNumber))
                    {
                        nextNumber = -nextNumber;
                        i++; // Saltar el número negativo ya procesado
                    }
                    else if (!int.TryParse(tokens[i + 1], out nextNumber))
                    {
                        throw new ArgumentException("Sintaxis no válida: se esperaba un número después de la operación.");
                    }
                }

                result = operation switch
                {
                    "plus" => result + nextNumber,
                    "minus" => result - nextNumber,
                    "multiplied by" => result * nextNumber,
                    "divided by" => result / nextNumber,
                    _ => throw new ArgumentException("Operación no soportada.")
                };
            }

            return result;
        }
    }

   
}
