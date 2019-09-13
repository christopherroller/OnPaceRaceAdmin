using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    [Table("RunnerToRacePace")]
    public class RunnerToRacePace
    {
        [Key]
        public int Id { get; set; }

        [Column("RunnerId")]
        [ForeignKey("Runner")]
        [Required]
        public int RunnerId { get; set; }

        public Runner Runner { get; set; }

        [Column("RaceTypeId")]
        [ForeignKey("RaceType")]
        [Required]
        public int RaceTypeId { get; set; }

        public RaceType RaceType { get; set; }

        [Column("RacePaceFromId")]
        [ForeignKey("RacePaceFromId")]
        [Required]
        public int RacePaceFromId { get; set; }

        public RacePace RacePaceFrom { get; set; }

        [Column("RacePaceToId")]
        [ForeignKey("RacePaceToId")]
        [Required]
        public int RacePaceToId { get; set; }

        public RacePace RacePaceTo { get; set; }


    }
}
