using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Oktatok
    {
        public int? OktatoId { get; set; }
        public string Nev { get; set; }
        public string Titulus { get; set; }
        public int? Beosztás { get; set; }
        public int? Status { get; set; }
    }
}
