using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnPaceRaceAdmin.Data
{
    [Table("Runner")]
    public class Runner
    {
        [Key]
        public int Id { get; set; }

        [Column("FirstName")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Required]
        public string LastName { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("City")]
        public string City { get; set; }

        [ForeignKey("States")]
        [Column("StateId")]
        public int? StateId { get; set; }


        [ForeignKey("Gender")]
        [Column("GenderId")]
        public int? GenderId { get; set; }

        [Column("Age")]
        public int? Age { get; set; }


        [Column("ZipCode")]
        public string Zipcode { get; set; }

        [ForeignKey("ClothingSize")]
        [Column("ClothingSizeId")]
        public int? ClothingSizeId { get; set; }

        public Gender Gender { get; set; }
        public State State { get; set; }

        public ClothingSize ClothingSize { get; set; }
    }
}
