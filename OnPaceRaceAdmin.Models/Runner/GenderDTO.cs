
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnPaceRaceAdmin.Models
{
    public class GenderDTO : IEntity<GenderDTO, Gender>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public GenderDTO MapToDTO(Gender entity)
        {
            return new GenderDTO()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public Gender MapToEntity(GenderDTO dto)
        {
            return new Gender()
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }
    }
}
