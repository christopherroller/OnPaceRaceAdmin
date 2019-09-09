using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnPaceRaceAdmin.Data
{
    [Table("States")]
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        [MaxLength(45,ErrorMessage ="State name limited to 45 characters.")]
        public string Name { get; set; }

        [Column("Abbreviation")]
        [Required]
        [MaxLength(2, ErrorMessage = "Abbreviation limited to 2 characters.")]
        public string Abbreviation { get; set; }
    }
}
