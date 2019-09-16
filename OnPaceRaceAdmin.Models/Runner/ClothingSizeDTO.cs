using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;

namespace OnPaceRaceAdmin.Models
{
    public class ClothingSizeDTO : IEntity<ClothingSizeDTO,ClothingSize>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ClothingSizeDTO MapToDTO(ClothingSize entity)
        {
            return new ClothingSizeDTO()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public ClothingSize MapToEntity(ClothingSizeDTO dto)
        {
            return new ClothingSize()
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }
    }
}
