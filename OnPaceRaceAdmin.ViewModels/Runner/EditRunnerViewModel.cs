using Microsoft.AspNetCore.Mvc.Rendering;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.ViewModels.HelperClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnPaceRaceAdmin.ViewModels
{
    public class EditRunnerViewModel
    {
        public Runner Runner { get; set; }

        public List<DdlDefault> Genders { get; set; } 
        public List<DdlDefault> States { get; set; }
        public List<RunnerNote> Notes { get; set; }


    }
}
