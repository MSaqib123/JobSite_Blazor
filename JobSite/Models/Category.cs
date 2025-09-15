using System.ComponentModel.DataAnnotations;

namespace JobSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Category Name")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the Description e.g remote-job")]
        public string slug { get; set; }
    }
}
