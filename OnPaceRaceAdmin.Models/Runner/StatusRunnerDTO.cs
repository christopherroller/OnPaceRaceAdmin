using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class StatusRunnerDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }
 
        public bool IsActive { get; set; }

        public bool IsDisabled { get; set; }

        public bool IsBlacklisted { get; set; }
    }
}
