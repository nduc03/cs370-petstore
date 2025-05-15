using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petstore
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Username { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        public List<Pet> AdoptedPets { get; set; } = [];
        public double Balance { get; set; } = 0.0;
    }
}
