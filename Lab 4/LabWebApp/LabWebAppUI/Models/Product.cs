using System.ComponentModel.DataAnnotations;

namespace LabWebAppUI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
   

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; } // Added [DisplayFormat] attribute to format as currency
    }
}
