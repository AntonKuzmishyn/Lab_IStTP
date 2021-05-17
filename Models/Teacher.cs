using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyLabVar5
{
    public partial class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [Display(Name = "Ім'я викладача")]
        public string Name { get; set; }

        public int FacultyId { get; set; }
        
        public int ChairId { get; set; }
        
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [Display(Name = "Кафедра")]
        public virtual Chair Chair { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [Display(Name = "Факультет")]
        public virtual Faculty Faculty { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім!")]
        [Display(Name = "Предмет")]
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
