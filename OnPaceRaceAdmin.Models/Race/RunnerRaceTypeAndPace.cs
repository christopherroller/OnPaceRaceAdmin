using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using OnPaceRaceAdmin.Models.Races;
using OnPaceRaceAdmin.ViewModels.HelperClasses;

namespace OnPaceRaceAdmin.Models
{
    public class RunnerRaceTypeAndPace
    {
        public int Id { get; set; }
        public int RunnerId { get; set; }
        [Display(Name="Race Type")]
        public string RaceTypeName { get; set; }
        [Display(Name = "Race Type")]
        public int RaceTypeId { get; set; }
        [Display(Name = "Pace From (hh:mm)")]
        public string PaceTimeFrom { get; set; }
        [Display(Name = "Pace From (hh:mm)")]
        public int PaceTimeFromId { get; set; }
        [Display(Name = "Pace To (hh:mm)")]
        public string PaceTimeTo { get; set; }
        [Display(Name = "Pace To (hh:mm)")]
        public int PaceTimeToId { get; set; }
    }
}
