using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using OnPaceRaceAdmin.Models.Races;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    public class RaceDTO : IEntity<RaceDTO,Race>
    {
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

        public IEnumerable<RaceTypeDTO> RaceTypes { get; set; }
        public RaceDTO()
        {

        }
        public RaceDTO MapToDTO(Race race)
        {
            return new RaceDTO()
            {
                Id = race.Id,
                RaceCity = race.RaceCity,
                RaceDate = race.RaceDate,
                RaceName = race.RaceName,
                RaceStateId = race.RaceStateId,
                RaceStatusId = race.RaceStatusId,
            };
        }

        public Race MapToEntity(RaceDTO race)
        {
            return new Race()
            {
                Id = race.Id,
                RaceName = race.RaceName,
                RaceDate = race.RaceDate,
                RaceCity = race.RaceCity,
                RaceStatusId = race.RaceStatusId,
                RaceStateId = race.RaceStateId
            };
        }
    }
}
