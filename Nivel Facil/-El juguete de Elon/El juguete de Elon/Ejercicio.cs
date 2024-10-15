﻿using El_juguete_de_Elon;
using System;

namespace El_juguete_de_Elon
{
    /*
        Consigna: 
            En este ejercicio jugarás con un coche controlado a distancia y finalmente has ahorrado suficiente dinero para comprarlo.

            Los coches arrancan con las baterías llenas (100%). Cada vez que conduces el coche con el mando a distancia, recorre 20 metros y agota el uno por ciento de la batería.

            El automóvil controlado a distancia tiene una elegante pantalla LED que muestra dos bits de información:
                La distancia total que ha recorrido, mostrada como: "Distancia conducida: <METROS> metros".
                La carga restante de la batería, mostrada como: "Batería al <PORCENTAJE>%".

            Si la batería está al 0%, ya no podrá conducir el automóvil y la pantalla de la batería mostrará "Batería vacía".

            Tiene seis tareas, cada una de las cuales funcionará con instancias de automóviles controladas remotamente.

            Tarea 1: Compra un coche nuevo a control remoto
                Implemente el método ( estático ) RemoteControlCar.Comprar()para devolver una nueva instancia de automóvil controlado a distancia.
                    RemoteControlCar car = RemoteControlCar.Comprar();

            Tarea 2: Mostrar la distancia recorrida
                Implemente el método RemoteControlCar.MostrarDistancia() para devolver la distancia como se muestra en la pantalla LED.
                    var car = RemoteControlCar.Comprar();
                    car.MostrarDistancia();
                    // => "Distancia conducida: 0 metros"
    
            Tarea 3: Mostrar el porcentaje de batería
                Implemente el método RemoteControlCar.MostrarBateria() para devolver el porcentaje de batería como se muestra en la pantalla LED.
                    var car = RemoteControlCar.Comprar();
                    car.MostrarBateria();
                    // => "Batería al 100%"
                    
            Tarea 4: Actualizar el número de metros recorridos al conducir
                Implementar el método RemoteControlCar.Conducir() que actualiza la cantidad de metros recorridos.
                    var car = RemoteControlCar.Comprar();
                    car.Conducir();
                    car.Conducir();
                    car.MostrarDistancia();
                    // => "Distancia conducida: 40 metros"

            Tarea 5: Actualizar el porcentaje de batería al conducir
                Actualice el método RemoteControlCar.Conducir() para actualizar el porcentaje de batería.
                    var car = RemoteControlCar.Comprar();
                    car.Conducir();
                    car.Conducir();
                    car.MostrarBateria();
                    // => "Batería al 98%"

            Tarea 6: Evite conducir cuando la batería esté agotada
                Actualice el método RemoteControlCar.Conducir() para no aumentar la distancia recorrida ni disminuir el porcentaje de batería cuando la batería está agotada (al 0%)
                    var car = RemoteControlCar.Comprar();

                    // Se vacía la batería
                    // ...

                    car.MostrarDistancia();
                    // => "Distancia conducida: 2000 metros"

                    car.MostrarBateria();
                    // => "Batería vacíay"
     */
    using System;
    using System.Runtime.ConstrainedExecution;

    namespace El_juguete_de_Elon
    {
        /*
            Consigna: 
                En este ejercicio jugarás con un coche controlado a distancia y finalmente has ahorrado suficiente dinero para comprarlo.

                Los coches arrancan con las baterías llenas (100%). Cada vez que conduces el coche con el mando a distancia, recorre 20 metros y agota el uno por ciento de la batería.

                El automóvil controlado a distancia tiene una elegante pantalla LED que muestra dos bits de información:
                    La distancia total que ha recorrido, mostrada como: "Distancia conducida: <METROS> metros".
                    La carga restante de la batería, mostrada como: "Batería al <PORCENTAJE>%".

                Si la batería está al 0%, ya no podrá conducir el automóvil y la pantalla de la batería mostrará "Batería vacía".

                Tiene seis tareas, cada una de las cuales funcionará con instancias de automóviles controladas remotamente.

                Tarea 1: Compra un coche nuevo a control remoto
                    Implemente el método ( estático ) RemoteControlCar.Comprar()para devolver una nueva instancia de automóvil controlado a distancia.
                        RemoteControlCar car = RemoteControlCar.Comprar();

                Tarea 2: Mostrar la distancia recorrida
                    Implemente el método RemoteControlCar.MostrarDistancia() para devolver la distancia como se muestra en la pantalla LED.
                        var car = RemoteControlCar.Comprar();
                        car.MostrarDistancia();
                        // => "Distancia conducida: 0 metros"

                Tarea 3: Mostrar el porcentaje de batería
                    Implemente el método RemoteControlCar.MostrarBateria() para devolver el porcentaje de batería como se muestra en la pantalla LED.
                        var car = RemoteControlCar.Comprar();
                        car.MostrarBateria();
                        // => "Batería al 100%"

                Tarea 4: Actualizar el número de metros recorridos al conducir
                    Implementar el método RemoteControlCar.Conducir() que actualiza la cantidad de metros recorridos.
                        var car = RemoteControlCar.Comprar();
                        car.Conducir();
                        car.Conducir();
                        car.MostrarDistancia();
                        // => "Distancia conducida: 40 metros"

                Tarea 5: Actualizar el porcentaje de batería al conducir
                    Actualice el método RemoteControlCar.Conducir() para actualizar el porcentaje de batería.
                        var car = RemoteControlCar.Comprar();
                        car.Conducir();
                        car.Conducir();
                        car.MostrarBateria();
                        // => "Batería al 98%"

                Tarea 6: Evite conducir cuando la batería esté agotada
                    Actualice el método RemoteControlCar.Conducir() para no aumentar la distancia recorrida ni disminuir el porcentaje de batería cuando la batería está agotada (al 0%)
                        var car = RemoteControlCar.Comprar();

                        // Se vacía la batería
                        // ...

                        car.MostrarDistancia();
                        // => "Distancia conducida: 2000 metros"

                        car.MostrarBateria();
                        // => "Batería vacía"
         */

        class RemoteControlCar
        {
            private int distancia;
            private int bateria;
            //Tarea 1: Compra un coche nuevo a control remoto
            //       Implemente el método(estático ) RemoteControlCar.Comprar() para devolver una nueva instancia de automóvil controlado a distancia.
            //           RemoteControlCar car = RemoteControlCar.Comprar();
            public RemoteControlCar()
            {
                distancia = 0;
                bateria = 100;
            }
            public static RemoteControlCar Comprar()
            {
               return new RemoteControlCar();

            }
            //Tarea 2: Mostrar la distancia recorrida
            //        Implemente el método RemoteControlCar.MostrarDistancia() para devolver la distancia como se muestra en la pantalla LED.
            //            var car = RemoteControlCar.Comprar();
            //car.MostrarDistancia();
            //            // => "Distancia conducida: 0 metros"


            public string MostrarDistancia()
            {
                return $"Distancia conducida: {distancia} metros";
            }
            //Tarea 3: Mostrar el porcentaje de batería
            //      Implemente el método RemoteControlCar.MostrarBateria() para devolver el porcentaje de batería como se muestra en la pantalla LED.
            //          var car = RemoteControlCar.Comprar();
            //car.MostrarBateria();
            //            // => "Batería al 100%"

            public string MostrarBateria()
            {
                if (bateria == 0)
                {
                    return "Batería vacía";
                }
                return $"Batería al {bateria}%";
            }
            //Tarea 4: Actualizar el número de metros recorridos al conducir
            //        Implementar el método RemoteControlCar.Conducir() que actualiza la cantidad de metros recorridos.
            //            var car = RemoteControlCar.Comprar();
            //car.Conducir();
            //            car.Conducir();
            //            car.MostrarDistancia();
            //            // => "Distancia conducida: 40 metros"
            public void Conducir()
            {
                if (bateria > 0)
                {
                    distancia += 20;
                    bateria -= 1;
                }
            }
        }
        
    }
}


