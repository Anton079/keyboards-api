using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace keyboards_api.Keyboards.Models
{
    [Table("keyboard")]
    public class Keyboard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("model")]
        public string model { get; set; }

        [Required]
        [Column("Price")]
        public int Price { get; set; }
    }
}
