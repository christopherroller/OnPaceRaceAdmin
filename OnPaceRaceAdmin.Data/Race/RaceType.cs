using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    public class RaceType
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

    }
}
