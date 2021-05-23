using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Erőforrásgazdák
    {
        public Erőforrásgazdák()
        {
            Erőforrásoks = new HashSet<Erőforrások>();
        }

        public byte ErőforrásgazdaId { get; set; }
        public string Név { get; set; }

        public virtual ICollection<Erőforrások> Erőforrásoks { get; set; }
    }
}
