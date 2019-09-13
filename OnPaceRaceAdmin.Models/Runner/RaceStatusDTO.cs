using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnPaceRaceAdmin.Models
{

    public class RaceStatus
    {
 
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCreated { get; set; }

        public bool IsScheduled { get; set; }

        public bool IsComplete { get; set; }
    }
}
