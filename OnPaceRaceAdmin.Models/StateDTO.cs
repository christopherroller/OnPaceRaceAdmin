using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models

{
    public class StateDTO : IEntity<StateDTO, State>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(45,ErrorMessage ="State name limited to 45 characters.")]
        public string Name { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "Abbreviation limited to 2 characters.")]
        public string Abbreviation { get; set; }

        public StateDTO MapToDTO(State entity)
        {
            return new StateDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Abbreviation = entity.Abbreviation
            };
        }

        public State MapToEntity(StateDTO dto)
        {
            return new State()
            {
                Id = dto.Id,
                Name = dto.Name,
                Abbreviation = dto.Abbreviation
            };
        }
    }
}
