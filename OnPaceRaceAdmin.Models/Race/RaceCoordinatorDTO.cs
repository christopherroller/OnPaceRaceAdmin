
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    public class RaceCoordinatorDTO : IEntity<RaceCoordinatorDTO, RaceCoordinator>
    {
        public int Id{get;set;}


        public int RaceId { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public RaceCoordinatorDTO MapToDTO(RaceCoordinator entity)
        {
            return new RaceCoordinatorDTO()
            {
                Email = entity.Email,
                FirstName = entity.FirstName,
                Id = entity.Id,
                LastName =entity.LastName,
                PhoneNumber = entity.PhoneNumber,
                RaceId = entity.RaceId
            };           
        }

        public RaceCoordinator MapToEntity(RaceCoordinatorDTO dto)
        {
            return new RaceCoordinator()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                Id = dto.Id,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                RaceId = dto.RaceId
            };
        }
    }
}
