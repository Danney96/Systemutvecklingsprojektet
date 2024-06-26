﻿using Entiteter.Enums;
using Entiteter.Personer;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteter.Tjänster
{
    public class GruppLektion
    {
        public string ID { get; set; }
        public string LektionsTillfälle { get; set; }

        public virtual IList<Elev> Deltagare { get; set; } = new List<Elev>();

        public double Pris { get; set; }

        public Svårighetsgrad Svårighetsgrad { get; set; }

        [ForeignKey("Personal")]
        public int? Lärare { get; set; }
        public virtual Personal Personal { get; set; } = null!;
        [ForeignKey("MasterBokning")]
        public int? BokningsNr { get; set; }
        public virtual MasterBokning? MasterBokning { get; set; }

        public GruppLektion() { }
    }
}
