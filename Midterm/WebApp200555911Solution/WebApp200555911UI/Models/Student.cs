using System.ComponentModel.DataAnnotations;
namespace WebApp200555911UI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(255)]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
