using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class StatusRunnerDTO : IEntity<StatusRunnerDTO,StatusRunner>
    {

        public int Id { get; set; }

        public string Name { get; set; }
 
        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public bool IsBlacklisted { get; set; }

        public StatusRunnerDTO MapToDTO(StatusRunner entity)
        {
            return new StatusRunnerDTO()
            {
                Id = entity.Id,
                IsActive = entity.IsActive,
                IsBlacklisted = entity.IsBlacklisted,
                IsDisabled = entity.IsDisabled,
                Name = entity.Name
            };
        }

        public StatusRunner MapToEntity(StatusRunnerDTO dto)
        {
            return new StatusRunner()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                IsBlacklisted = dto.IsBlacklisted,
                IsDisabled = dto.IsDisabled,
                Name = dto.Name
            };
        }
    }
}
