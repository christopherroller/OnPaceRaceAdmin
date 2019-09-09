using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnPaceRaceAdmin.Data
{
    public class ClothingSize
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [ForeignKey("Gender")]
        [Column("GenderId")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }

    }
}
