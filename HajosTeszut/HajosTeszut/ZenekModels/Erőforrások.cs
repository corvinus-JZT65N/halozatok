using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Erőforrások
    {
        public Erőforrások()
        {
            ErőforrásFoglalás = new HashSet<ErőforrásFoglalá>();
        }

        public short ErőforrásId { get; set; }
        public string Név { get; set; }
        public byte ErőforrásgazdaFk { get; set; }

        public virtual Erőforrásgazdák ErőforrásgazdaFkNavigation { get; set; }
        public virtual ICollection<ErőforrásFoglalá> ErőforrásFoglalás { get; set; }
    }
}
