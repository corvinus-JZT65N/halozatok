using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Rendele
    {
        public Rendele()
        {
            RendelesTetels = new HashSet<RendelesTetel>();
        }

        public int Sorszam { get; set; }
        public string Login { get; set; }
        public DateTime? RendDatum { get; set; }
        public DateTime? SzallDatum { get; set; }
        public string SzallCim { get; set; }
        public string SzallMod { get; set; }
        public string FizMod { get; set; }
        public string SzamlaCim { get; set; }

        public virtual Ugyfel LoginNavigation { get; set; }
        public virtual ICollection<RendelesTetel> RendelesTetels { get; set; }
    }
}
