using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
     
        [Required(ErrorMessage = "Required!!!")]
        [RegularExpression("^[a-zA-Z][a-zA-Z'\\s]+$", ErrorMessage = "Please do enter name with alphabetics!!!")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
