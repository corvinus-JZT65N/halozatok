using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Projektek
    {
        public Projektek()
        {
            ErőforrásFoglalás = new HashSet<ErőforrásFoglalá>();
        }

        public int ProjektId { get; set; }
        public string Név { get; set; }
        public byte RendszerFk { get; set; }
        public string MenedzserNév { get; set; }

        public virtual Rendszerek RendszerFkNavigation { get; set; }
        public virtual ICollection<ErőforrásFoglalá> ErőforrásFoglalás { get; set; }
    }
}
