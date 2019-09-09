using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    public class RacePace
    {
        [Key]
        public int Id { get; set; }

        [Column("Pace")]
        [Required]
        public DateTime Pace { get; set; }
    }
}
