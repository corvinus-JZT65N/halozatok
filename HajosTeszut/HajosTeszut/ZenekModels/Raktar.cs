using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Raktar
    {
        public Raktar()
        {
            Termeks = new HashSet<Termek>();
        }

        public int RaktarKod { get; set; }
        public string RaktarNev { get; set; }
        public string RaktarCim { get; set; }

        public virtual ICollection<Termek> Termeks { get; set; }
    }
}
