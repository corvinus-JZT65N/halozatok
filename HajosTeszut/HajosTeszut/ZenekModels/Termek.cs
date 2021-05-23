using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Termek
    {
        public Termek()
        {
            RendelesTetels = new HashSet<RendelesTetel>();
        }

        public string Termekkod { get; set; }
        public string Megnevezes { get; set; }
        public int? KatId { get; set; }
        public double? Listaar { get; set; }
        public string Leiras { get; set; }
        public int? RaktarKod { get; set; }
        public double? Keszlet { get; set; }
        public string Megys { get; set; }
        public string Felvitte { get; set; }
        public DateTime? Felvitel { get; set; }

        public virtual Termekkategorium Kat { get; set; }
        public virtual Raktar RaktarKodNavigation { get; set; }
        public virtual ICollection<RendelesTetel> RendelesTetels { get; set; }
    }
}
