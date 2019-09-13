using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    [Table("StatusRace")]
    public class RaceStatus
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [Column("IsCreated")]
        [Required]
        public bool IsCreated { get; set; }

        [Column("IsScheduled")]
        [Required]
        public bool IsScheduled { get; set; }

        [Column("IsComplete")]
        [Required]
        public bool IsComplete { get; set; }
    }
}
