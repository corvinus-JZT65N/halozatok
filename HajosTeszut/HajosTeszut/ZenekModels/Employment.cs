using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszut.ZenekModels
{
    public partial class Employment
    {
        public Employment()
        {
            Instructors = new HashSet<Instructor>();
        }

        public string EmploymentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
