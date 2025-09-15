using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSite.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Category Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Nature")]
        public string Nature { get; set; }

        [Required(ErrorMessage = "Please enter the Salary")]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Please enter the Last Date to Apply")]
        public string LastDateToApply { get; set; }

        public string? Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
