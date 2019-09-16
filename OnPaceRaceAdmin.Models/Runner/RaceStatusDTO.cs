using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class RaceStatusDTO : IEntity<RaceStatusDTO,RaceStatus>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCreated { get; set; }

        public bool IsScheduled { get; set; }

        public bool IsComplete { get; set; }

        public RaceStatusDTO MapToDTO(RaceStatus entity)
        {
            return new RaceStatusDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                IsComplete = entity.IsComplete,
                IsCreated = entity.IsCreated,
                IsScheduled = entity.IsScheduled
            };
        }

        public RaceStatus MapToEntity(RaceStatusDTO dto)
        {
            return new RaceStatus()
            {
                Id = dto.Id,
                Name = dto.Name,
                IsComplete = dto.IsComplete,
                IsCreated = dto.IsCreated,
                IsScheduled = dto.IsScheduled
            };
        }
    }
}
