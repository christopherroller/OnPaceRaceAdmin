using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    [Table("States")]
    public class State : IEntity
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
