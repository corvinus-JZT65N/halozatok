﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class UjaenbVszoba
    {
        public int SzobaId { get; set; }
        public string SzobaSzama { get; set; }
        public int Ferohely { get; set; }
        public int? Potagy { get; set; }
        public string Klimas { get; set; }
        public int? SzallasFk { get; set; }
        public string SzallasNev { get; set; }
        public string Hely { get; set; }
        public int? CsillagokSzama { get; set; }
    }
}
