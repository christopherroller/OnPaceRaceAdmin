using OnPaceRaceAdmin.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnPaceRaceAdmin.Models
{
    public class ClothingSizeDTO : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
