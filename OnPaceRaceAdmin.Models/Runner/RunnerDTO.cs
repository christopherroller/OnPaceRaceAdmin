using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnPaceRaceAdmin.Models
{
    public class RunnerDTO : IEntity<RunnerDTO, Runner>
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "State")]
        public int? StateId { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Display(Name = "Gender")]
        public int? GenderId { get; set; }

        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }

        [Display(Name = "Clothing Size")]
        public string ClothingSize{ get; set; }

        [Display(Name = "Clothing Size")]
        public int? ClothingSizeId { get; set; }

        [Display(Name = "Age")]
        [Range(18, 100, ErrorMessage = "Please enter valid Age")]
        public int? Age { get; set; }

        [Display(Name = "Runner Status")]
        public int RunnerStatusId { get; set; }

        [Display(Name = "Runner Status")]
        public string RunnerStatusName { get; set; }

        public RunnerDTO MapToDTO(Runner entity)
        {
            return new RunnerDTO()
            {
                Id = entity.Id,
                ClothingSizeId = entity.ClothingSizeId,
                Email = entity.Email,
                FirstName = entity.FirstName,
                GenderId = entity.GenderId,
                LastName = entity.LastName,
                PhoneNumber = entity.PhoneNumber,
                RunnerStatusId = entity.RunnerStatusId,
                StateId = entity.StateId,
                Zipcode = entity.Zipcode,
                Address = entity.Address,
                Age = entity.Age,
                City = entity.City,
            };
        }

        public Runner MapToEntity(RunnerDTO dto)
        {
            return new Runner()
            {
                Id = dto.Id,
                ClothingSizeId = dto.ClothingSizeId,
                Email = dto.Email,
                FirstName = dto.FirstName,
                GenderId = dto.GenderId,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                RunnerStatusId = dto.RunnerStatusId,
                StateId = dto.StateId,
                Zipcode = dto.Zipcode,
                Address = dto.Address,
                Age = dto.Age,
                City = dto.City,
            };
        }
    }
}
