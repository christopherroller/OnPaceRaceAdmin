using OnPaceRaceAdmin.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnPaceRaceAdmin.Models
{
    public class RunnerDTO : IEntity
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
    }
}
