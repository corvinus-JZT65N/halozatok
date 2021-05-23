using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Ugyfel
    {
        public Ugyfel()
        {
            Rendeles = new HashSet<Rendele>();
        }

        public string Login { get; set; }
        public string Email { get; set; }
        public string Nev { get; set; }
        public int? Szulev { get; set; }
        public string Nem { get; set; }
        public string Cim { get; set; }

        public virtual ICollection<Rendele> Rendeles { get; set; }
    }
}
