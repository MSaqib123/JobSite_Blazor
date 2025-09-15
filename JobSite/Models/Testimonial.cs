using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSite.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Category Name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Occupation")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Please enter the Review")]
        public string Review { get; set; }

        public string? Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
