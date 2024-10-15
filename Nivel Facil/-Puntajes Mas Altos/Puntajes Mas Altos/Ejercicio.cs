using System;
using System.Collections.Generic;
using System.Linq;

namespace Puntajes_Mas_Altos
{
    /*
       Consigna: 
           Administre la lista de puntuaciones más altas de un jugador.

           Tu tarea es crear un componente de puntuación alta del clásico juego Frogger, uno de los juegos más vendidos y adictivos de todos los tiempos, 
            y un clásico de la era arcade.
           Su tarea es escribir métodos que devuelvan la puntuación más alta de la lista, la última puntuación agregada y las tres puntuaciones más altas.
   */

    public class HighScores
    {
        private readonly List<int> _scores;

        public HighScores(List<int> list)
        {
            _scores = new List<int>(list);
        }

        public List<int> Scores()
        {
            return new List<int>(_scores);
        }

        public int Latest()
        {
            return _scores.Last();
        }

        public int PersonalBest()
        {
            return _scores.Max();
        }

        public List<int> PersonalTopThree()
        {
            return _scores.OrderByDescending(score => score)
                      .Take(3)
                      .ToList();
        }
    }
}
