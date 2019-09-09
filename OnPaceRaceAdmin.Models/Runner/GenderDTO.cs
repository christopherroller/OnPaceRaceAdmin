﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnPaceRaceAdmin.Models
{
    public class GenderDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}