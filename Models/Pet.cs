using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petstore
{
    [Table("pets")]
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        [Required]
        public required string ImageUri { get; set; }
        public User? AdoptedBy { get; set; } = null;
    }
}
