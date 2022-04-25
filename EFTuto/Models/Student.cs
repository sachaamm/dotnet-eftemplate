using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFTuto.Models
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
