﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte_de_Partido_de_Futbol_Americano
{
    public class Manager :Incident
    {
        public string Name { get; }
        public string? Club { get; }

        public Manager(string name, string? club)
        {
            this.Name = name;
            this.Club = club;
        }
    }

    public class Incident 
    {

        public virtual string GetDescription() => "An incident happened.";
    }

    public class Foul : Incident
    {
        public override string GetDescription() => "The referee deemed a foul.";
    }

    public class Injury : Incident
    {
        internal object player;

        public Injury(int player)
        {
            this.player = player;
        }

        public override string GetDescription() => $"Player {player} is injured.";
    }
}
