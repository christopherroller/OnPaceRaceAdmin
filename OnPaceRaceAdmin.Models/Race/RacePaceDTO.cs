using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models.Races
{
    public class RacePaceDTO : IEntity<RacePaceDTO, RacePace>
    {
        public int Id { get; set; }

        [Required]
        public DateTime Pace { get; set; }

        public RacePaceDTO MapToDTO(RacePace entity)
        {
            return new RacePaceDTO()
            {
                Id = entity.Id,
                Pace = entity.Pace
            };
        }

        public RacePace MapToEntity(RacePaceDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
