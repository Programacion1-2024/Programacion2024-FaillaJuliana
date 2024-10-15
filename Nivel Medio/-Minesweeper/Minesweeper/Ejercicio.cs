using System;

namespace Minesweeper
{

    /*
    Consigna:
        Buscaminas es un juego popular en el que el usuario tiene que encontrar las minas utilizando pistas numéricas que indican cuántas minas están directamente adyacentes (horizontal, vertical, diagonal) a un cuadrado.

        Instrucciones
        Tu tarea consiste en sumar la cantidad de minas a los cuadrados vacíos de un tablero de Buscaminas completo. El tablero en sí es un rectángulo compuesto de cuadrados que están vacíos ( ' ' ) o tienen una mina ( '*' ).

        En cada casilla vacía, cuente la cantidad de minas adyacentes (horizontal, vertical y diagonalmente). Si la casilla vacía no tiene minas adyacentes, déjela vacía. De lo contrario, reemplácela con el recuento de minas adyacentes.

        Por ejemplo, puede recibir un tablero de 5 x 4 como éste (los espacios vacíos se representan aquí con el carácter '·' para su visualización en pantalla):

            ·*·*·
            ··*··
            ··*··
            ·····

        Tu código debería transformarse en esto:

            1*3*1
            13*31
            ·2*2·
            ·111·
    */

    public static class Minesweeper
    {

        public static string[] Annotate(string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return Array.Empty<string>();
            }
            int rows = input.Length;
            int cols = input[0].Length;
            char[,] board = new char[rows, cols];

            // Copiar el tablero de entrada a un tablero de caracteres
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = input[i][j];
                }
            }

            // Función para contar minas alrededor de una celda
            int CountMines(int row, int col)
            {
                int count = 0;
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < rows && j >= 0 && j < cols && board[i, j] == '*')
                        {
                            count++;
                        }
                    }
                }
                return count;
            }

            // Recorre el tablero y actualiza las celdas vacías
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        int mines = CountMines(i, j);
                        if (mines > 0)
                        {
                            board[i, j] = (char)(mines + '0');  // Convierte el número a carácter
                        }
                    }
                }
            }

            // Convertir el tablero de vuelta a un arreglo de cadenas
            string[] result = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                result[i] = new string(Enumerable.Range(0, cols).Select(j => board[i, j]).ToArray());
            }

            return result;
        }


    }
}
