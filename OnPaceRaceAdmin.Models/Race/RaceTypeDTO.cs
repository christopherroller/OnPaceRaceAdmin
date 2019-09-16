using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnPaceRaceAdmin.Models.Races
{
    public class RaceTypeDTO : IEntity<RaceTypeDTO,RaceType>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public RaceTypeDTO MapToDTO(RaceType entity)
        {
            return new RaceTypeDTO()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public RaceType MapToEntity(RaceTypeDTO dto)
        {
            return new RaceType()
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }
    }
}
