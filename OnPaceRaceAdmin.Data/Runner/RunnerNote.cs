
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    [Table("RunnerNote")]
    public class RunnerNote
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Note Text")]
        [Column("RunnerNote")]
        [Required]
        public string Note { get; set; }

        [ForeignKey("Runner")]
        public int RunnerId { get; set; }

        [Display(Name ="Date Added")]
        [Column("DateAdded")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }


    }
}
