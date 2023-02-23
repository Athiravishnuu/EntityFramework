using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EntityFramework.Model
{
    public class Student
    {
         
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Phonenumber { get; set; }
        public virtual Address? Address { get; set; }

    }
}

