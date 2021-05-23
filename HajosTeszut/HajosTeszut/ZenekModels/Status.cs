using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Status
    {
        public Status()
        {
            Instructors = new HashSet<Instructor>();
        }

        public short StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
