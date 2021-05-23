using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Termekkategorium
    {
        public Termekkategorium()
        {
            InverseSzuloKatNavigation = new HashSet<Termekkategorium>();
            Termeks = new HashSet<Termek>();
        }

        public int KatId { get; set; }
        public string KatNev { get; set; }
        public int? SzuloKat { get; set; }

        public virtual Termekkategorium SzuloKatNavigation { get; set; }
        public virtual ICollection<Termekkategorium> InverseSzuloKatNavigation { get; set; }
        public virtual ICollection<Termek> Termeks { get; set; }
    }
}
