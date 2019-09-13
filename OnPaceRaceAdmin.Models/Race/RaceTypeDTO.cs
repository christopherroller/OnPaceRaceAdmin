using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models.Races
{
    public class RaceTypeDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
