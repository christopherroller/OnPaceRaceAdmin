using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models.Races
{
    public class RacePaceDTO
    {
        public int Id { get; set; }

        [Required]
        public DateTime Pace { get; set; }
    }
}
