using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        [Column("RaceName")]
        [Required]
        public string RaceName { get; set; }

        [Column("RaceDate")]
        [Required]
        public DateTime RaceDate { get; set; }

        [Column("RaceCity")]
        [Required]
        public string RaceCity { get; set; }

        [Column("RaceStateId")]
        [ForeignKey("State")]
        [Required]
        public int RaceStateId { get; set; }

        public State State { get; set; }

        [Column("RaceStatusId")]
        [ForeignKey("RaceStatus")]
        [Required]
        public int RaceStatusId { get; set; }

        public RaceStatus RaceStatus { get; set; }
    }
}
