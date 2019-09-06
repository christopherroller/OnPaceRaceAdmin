using OnPaceRaceAdmin.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{
    [Table("Runner")]
    public class Runner : IEntity
    {
        [Key]
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

        [ForeignKey("States")]
        public int? StateId { get; set; }


        [ForeignKey("Gender")]
        public int? GenderId { get; set; }

        public string Zipcode { get; set; }


        public Gender Gender { get; set; }
        public State State { get; set; }
    }
}
