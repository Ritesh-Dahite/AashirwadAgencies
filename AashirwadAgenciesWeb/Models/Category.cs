using System.ComponentModel.DataAnnotations;

namespace AashirwadAgenciesWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
