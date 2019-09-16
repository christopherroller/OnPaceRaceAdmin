using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using OnPaceRaceAdmin.Models.Races;
using OnPaceRaceAdmin.ViewModels.HelperClasses;

namespace OnPaceRaceAdmin.Models
{
    public class RunnerRaceTypeAndPace : IEntity<RunnerRaceTypeAndPace,RunnerToRacePace>
    {
        public int Id { get; set; }
        public int RunnerId { get; set; }
        [Display(Name="Race Type")]
        public string RaceTypeName { get; set; }
        [Display(Name = "Race Type")]
        public int RaceTypeId { get; set; }
        [Display(Name = "Pace From (hh:mm)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm}")]
        public string PaceTimeFrom { get; set; }
        [Display(Name = "Pace From (hh:mm)")]
        public int PaceTimeFromId { get; set; }
        [Display(Name = "Pace To (hh:mm)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm}")]
        public string PaceTimeTo { get; set; }
        [Display(Name = "Pace To (hh:mm)")]
        public int PaceTimeToId { get; set; }

        public RunnerRaceTypeAndPace MapToDTO(RunnerToRacePace entity)
        {
            return new RunnerRaceTypeAndPace()
            {
                Id = entity.Id,
                PaceTimeFromId = entity.RacePaceFromId,
                PaceTimeToId = entity.RacePaceToId,
                RunnerId = entity.RunnerId,
                RaceTypeId = entity.RaceTypeId,
            };
        }

        public RunnerToRacePace MapToEntity(RunnerRaceTypeAndPace dto)
        {
            return new RunnerToRacePace()
            {
                Id = dto.Id,
                RaceTypeId = dto.RaceTypeId,
                RunnerId = dto.RunnerId,
                RacePaceToId = dto.PaceTimeToId,
                RacePaceFromId = dto.PaceTimeFromId
            };
        }
    }
}
