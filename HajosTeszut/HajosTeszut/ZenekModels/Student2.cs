using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Student2
    {
        public int Id { get; set; }
        public string Neptun { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal? AverageGrade { get; set; }
        public bool IsActive { get; set; }
    }
}
