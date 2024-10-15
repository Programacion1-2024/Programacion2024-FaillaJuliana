﻿using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Reporte_de_Partido_de_Futbol_Americano
{
    /*
       Consigna: 
           Está desarrollando un sistema para ayudar al personal del sitio web de un club de fútbol a informar sobre los partidos. 
    Este sistema es capaz de analizar diferentes aspectos del partido, tanto dentro como fuera del campo, y convertirlos en un flujo de acontecimientos.

           Tarea 1: Descripciones de salida de los jugadores según su número de camiseta.
            El equipo sólo juega con una formación 4-3-3 y nunca estuvo de acuerdo con el cambio de reglas de 1965 que permitía sustituciones, mucho menos plantillas ampliadas.

            Las descripciones de los jugadores son las siguientes:
                    1 -> "goalie"
                    2 -> "left back"
                    3 & 4 "center back"
                    5 -> "right back"
                    6, 7 & 8 -> "midfielder"
                    9 -> "left wing"
                    10 -> "striker"
                    11 -> "right wing"
            
            Implemente el método PlayAnalyzer.AnalyzeOnField() estático para generar una descripción del jugador según su número de camiseta.
                    PlayAnalyzer.AnalyzeOnField(10);
                    // => "striker"

           Tarea 2: Generar una alerta si se encuentra un número de camiseta desconocido
              Modifique el método PlayAnalyzer.AnalyzeOnField() para lanzar un ArgumentOutOfRangeException cuando se procesa un número de camiseta fuera del rango 1-11.

           Tarea 3: Ampliar la cobertura para incluir actividades fuera del campo
              Implementar el método PlayAnalyzer.AnalyzeOffField() para generar descripciones de actividades y personajes en el campo de juego. Este método recibe diferentes tipos de datos que deben analizarse y convertirse en texto apropiado para ayudar a los periodistas.

              Para empezar, cubriremos datos sobre el estadio:
                    El número actual de seguidores en el estadio (cualquiera int)
                    Anuncios realizados a través del sistema de megafonía del estadio (cualquiera string)

              No se deben procesar tipos de datos desconocidos, por lo que si el método recibe datos de un tipo diferente, se debe lanzar un ArgumentException.

                    PlayAnalyzer.AnalyzeOffField(5000);
                    // => "There are 5000 supporters at the match."

                    PlayAnalyzer.AnalyzeOffField("5 minutes to go!");
                    // => "5 minutes to go!"

                    PlayAnalyzer.AnalyzeOffField(0.5);
                    // => throws ArgumentException

           Tarea 4: Informe de incidencias durante el partido
              Modifique el método PlayAnalyzer.AnalyzeOffField() para generar descripciones de los incidentes que ocurren durante el partido.

              Los incidentes pueden ser cualquier subclase del tipo Incident y contendrán una descripción del incidente. Las lesiones (Injury) son un tipo especial de incidente porque provocan que el partido se detenga, por lo que deben tratarse de manera diferente.

                    PlayAnalyzer.AnalyzeOffField(new Foul());
                    // => "The referee deemed a foul."

                    PlayAnalyzer.AnalyzeOffField(new Injury(8));
                    // => "Oh no! Player 8 is injured. Medics are on the field."

           Tarea 5: Informe sobre los directivos del club
              Modifica el método PlayAnalyzer.AnalyzeOffField() para mencionar a los directivos del club presentes durante el partido.

              Los directivos son instancias del tipo Manager y tienen un nombre y el nombre del club que dirigen. Es posible que el club del entrenador sea desconocido, en cuyo caso se establecerá en null. Si no se conoce el club de un entrenador, no debe formar parte de la descripción.

                    PlayAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null));
                    // => "José Mário dos Santos Mourinho Félix"

                    PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool"));
                    // => "Jürgen Klopp (Liverpool)"
    */

    public static class PlayAnalyzer
    {
        //Tarea 1: Descripciones de salida de los jugadores según su número de camiseta.
        //  Las descripciones de los jugadores son las siguientes:
        //            1 -> "goalie"
        //            2 -> "left back"
        //            3 & 4 "center back"
        //            5 -> "right back"
        //            6, 7 & 8 -> "midfielder"
        //            9 -> "left wing"
        //            10 -> "striker"
        //            11 -> "right wing"
        //Implemente el método PlayAnalyzer.AnalyzeOnField() estático para generar una descripción del jugador según su número de camiseta.
        //          PlayAnalyzer.AnalyzeOnField(10);
        //// => "striker"
        /// Tarea 2: Generar una alerta si se encuentra un número de camiseta desconocido
        //Modifique el método PlayAnalyzer.AnalyzeOnField() para lanzar un ArgumentOutOfRangeException cuando se procesa un número de camiseta fuera del rango 1-11.
        
        public static string AnalyzeOnField(int shirtNum)
        {
            if (shirtNum < 1 || shirtNum > 11)
            {
                throw new ArgumentOutOfRangeException();
            }
            return shirtNum switch
            {
                1 => "goalie",
                2 => "left back",
                3 or 4 => "center back",
                5 => "right back",
                6 or 7 or 8 => "midfielder",
                9 => "left wing",
                10 => "striker",
                11 => "right wing",
            };

        }
        //Tarea 3: Ampliar la cobertura para incluir actividades fuera del campo
        //     Implementar el método PlayAnalyzer.AnalyzeOffField() para generar descripciones de actividades y personajes en el campo de juego.Este método recibe diferentes tipos de datos que deben analizarse y convertirse en texto apropiado para ayudar a los periodistas.

        //     Para empezar, cubriremos datos sobre el estadio:

        //           El número actual de seguidores en el estadio (cualquiera int)
        //            Anuncios realizados a través del sistema de megafonía del estadio(cualquiera string)

        //      No se deben procesar tipos de datos desconocidos, por lo que si el método recibe datos de un tipo diferente, se debe lanzar un ArgumentException.

        //            PlayAnalyzer.AnalyzeOffField(5000);
        //            // => "There are 5000 supporters at the match."

        //            PlayAnalyzer.AnalyzeOffField("5 minutes to go!");
        //            // => "5 minutes to go!"

        //            PlayAnalyzer.AnalyzeOffField(0.5);
        //            // => throws ArgumentException
        //Tarea 4: Informe de incidencias durante el partido
        //      Modifique el método PlayAnalyzer.AnalyzeOffField() para generar descripciones de los incidentes que ocurren durante el partido.

        //      Los incidentes pueden ser cualquier subclase del tipo Incident y contendrán una descripción del incidente.Las lesiones(Injury) son un tipo especial de incidente porque provocan que el partido se detenga, por lo que deben tratarse de manera diferente.

        //            PlayAnalyzer.AnalyzeOffField(new Foul());
        //            // => "The referee deemed a foul."

        //            PlayAnalyzer.AnalyzeOffField(new Injury(8));
        //            // => "Oh no! Player 8 is injured. Medics are on the field."
        //Tarea 5: Informe sobre los directivos del club
        //      Modifica el método PlayAnalyzer.AnalyzeOffField() para mencionar a los directivos del club presentes durante el partido.

        //      Los directivos son instancias del tipo Manager y tienen un nombre y el nombre del club que dirigen.Es posible que el club del entrenador sea desconocido, en cuyo caso se establecerá en null. Si no se conoce el club de un entrenador, no debe formar parte de la descripción.

        //            PlayAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null));
        //            // => "José Mário dos Santos Mourinho Félix"

        //            PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool"));
        //            // => "Jürgen Klopp (Liverpool)"
        public static string AnalyzeOffField(object report)
        {
            return report switch
            {
                int supporters => $"There are {supporters} supporters at the match.",
                string announcement => announcement,
                Incident incident => incident switch
                {
                    Foul => "The referee deemed a foul.",
                    Injury injury => $"Oh no! Player {injury.player} is injured. Medics are on the field.",
                    Manager manager  => manager.Club == null? manager.Name: $"{manager.Name} ({manager.Club})",
                    _ => throw new ArgumentException("Unsupported data type")
                },
            };
        }
    }

}
