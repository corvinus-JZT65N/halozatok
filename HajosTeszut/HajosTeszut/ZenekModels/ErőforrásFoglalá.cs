using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class ErőforrásFoglalá
    {
        public int FoglalásId { get; set; }
        public short ErőforrásFk { get; set; }
        public int ProjektFk { get; set; }
        public byte FoglalásMértéke { get; set; }
        public DateTime FoglalásKezdete { get; set; }
        public DateTime FoglalásVége { get; set; }
        public bool Lezárva { get; set; }

        public virtual Erőforrások ErőforrásFkNavigation { get; set; }
        public virtual Projektek ProjektFkNavigation { get; set; }
    }
}
