using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class RendelesTetel
    {
        public int Sorszam { get; set; }
        public string Termekkod { get; set; }
        public double? Egysegar { get; set; }
        public double Mennyiseg { get; set; }

        public virtual Rendele SorszamNavigation { get; set; }
        public virtual Termek TermekkodNavigation { get; set; }
    }
}
