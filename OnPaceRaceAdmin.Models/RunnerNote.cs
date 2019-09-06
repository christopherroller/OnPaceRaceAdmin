using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    [Table("RunnerNote")]
    public class RunnerNote : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Note Text")]
        [Column("RunnerNote")]
        [Required]
        public string Note { get; set; }

        [ForeignKey("Runner")]
        public int RunnerId { get; set; }


    }
}
