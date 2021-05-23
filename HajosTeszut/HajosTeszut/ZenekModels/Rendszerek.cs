using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Rendszerek
    {
        public Rendszerek()
        {
            Projekteks = new HashSet<Projektek>();
        }

        public byte RendszerId { get; set; }
        public string Név { get; set; }

        public virtual ICollection<Projektek> Projekteks { get; set; }
    }
}
