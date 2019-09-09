
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class RunnerNoteDTO
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Note Text")]
        [Required]
        public string Note { get; set; }
        public int RunnerId { get; set; }

        [Display(Name ="Date Added")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }


    }
}
