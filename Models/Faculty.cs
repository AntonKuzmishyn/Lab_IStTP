using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyLabVar5
{
    public partial class Faculty
    {
        public Faculty()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        [Display(Name = "Факультет")]
        public string FacultyName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
