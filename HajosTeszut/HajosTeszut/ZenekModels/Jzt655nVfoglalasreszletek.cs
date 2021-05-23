using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Jzt655nVfoglalasreszletek
    {
        public int FoglalásAzonosító { get; set; }
        public string Vendég { get; set; }
        public string Szállás { get; set; }
        public string Elhelyezkedés { get; set; }
        public DateTime Mettől { get; set; }
        public DateTime Meddig { get; set; }
        public string SzobákSzáma { get; set; }
    }
}
