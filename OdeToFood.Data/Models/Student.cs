using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
        public Gender Gender { get; set; }

        public string Password { get; set; }
    }

    public enum Gender
    {
        [Required, Display(Name = "Male")]
        male,
        [Required, Display(Name = "Female")]
        female,
        [Required, Display(Name = "Non Binary")]
        nonBinary,
        [Required, Display(Name = "unknown")]
        unknown
    }
}
