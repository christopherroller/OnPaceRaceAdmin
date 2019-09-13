using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    public class RaceDTO
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Race Name")]
        [Required]
        public string RaceName { get; set; }

        [Display(Name = "Race Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public DateTime RaceDate { get; set; }

        [Display(Name ="City")]
        [Required]
        public string RaceCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public int RaceStateId { get; set; }

        [Required]
        [Display(Name = "State")]
        public string StateName { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int RaceStatusId { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string RaceStatusName { get; set; }
    }
}
