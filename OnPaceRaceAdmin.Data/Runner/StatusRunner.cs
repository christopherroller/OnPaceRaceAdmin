using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    [Table("StatusRunner")]
    public class StatusRunner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Required]
        [Column("IsDisabled")]
        public bool IsDisabled { get; set; }

        [Required]
        [Column("IsBlacklisted")]
        public bool IsBlacklisted { get; set; }
    }
}
