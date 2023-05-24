using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookProjectWeb.Models;

    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1, 500, ErrorMessage = "Must be number in range between 1 & 500)")]
    public int Display { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }

