using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Beosztasok
    {
        public int BeosztasId { get; set; }
        public string Beosztasnev { get; set; }
        public int? Elvart { get; set; }
    }
}
