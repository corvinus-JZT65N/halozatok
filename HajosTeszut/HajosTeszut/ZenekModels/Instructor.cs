using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Instructor
    {
        public Instructor()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int InstructorSk { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string EmploymentFk { get; set; }
        public short StatusFk { get; set; }

        public virtual Employment EmploymentFkNavigation { get; set; }
        public virtual Status StatusFkNavigation { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
