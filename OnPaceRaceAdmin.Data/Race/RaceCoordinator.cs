using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    [Table("RaceCoordinator")]
    public class RaceCoordinator
    {   [Key]
        public int Id{get;set;}

        [ForeignKey("Race")]
        [Column("RaceId")]
        public int RaceId { get; set; }
        public Race Race { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
