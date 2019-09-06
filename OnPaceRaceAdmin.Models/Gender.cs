using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    [Table("Gender")]
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }
    }
}
