using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.ViewModels.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnPaceRaceAdmin.ViewModels
{
    public class CreateRunnerViewModel
    {
        private ApplicationContext DbContext { get; set; }
        public RunnerDTO Runner { get; set; }
        public List<SelectListItem> Genders { get; set; } 
        public List<SelectListItem> States { get; set; }
        public List<SelectListItem> ClothingSizes { get; set; }
        public List<SelectListItem> RaceTypes { get; set; }
        public List<RunnerRaceTypeAndPace> RunnerRaceTypes { get; set; }
        public List<SelectListItem> RacePaces { get; set; }

        public CreateRunnerViewModel(ApplicationContext context)
        {
            DbContext = context;
        }

        public void InitModel()
        {
            this.Genders = GetGenders();
            this.States = GetStates();
            this.ClothingSizes = GetClothingSizes();
            this.RaceTypes = GetRaceTypes();
            this.RacePaces = GetRacePaces();
        }

        private List<SelectListItem> GetGenders()
        {
            return DbContext.Genders.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetStates()
        {
            return DbContext.States.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetClothingSizes()
        {
            return DbContext.ClothingSizes.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetRaceTypes()
        { 
            return DbContext.RaceTypes.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetRacePaces()
        {
            return DbContext.RacePaces.OrderBy(o=>o.Pace).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Pace.ToString() }).ToList();
        }

        private List<RunnerRaceTypeAndPace> GetRunnerRaceTypes(int RunnerId)
        {
            return DbContext.RunnerToRacePace.Include(i=> i.RacePaceFrom).Include(i => i.RacePaceTo).Include(i=>i.RaceType).Where(w=>w.RunnerId.Equals(RunnerId)).Select(s => new RunnerRaceTypeAndPace
            {
                Id = s.Id,
                RunnerId = s.RunnerId,
                RaceTypeId = s.RaceTypeId,
                RaceTypeName = s.RaceType.Name,
                PaceTimeFrom = s.RacePaceFrom.Pace.ToString(),
                PaceTimeTo = s.RacePaceTo.Pace.ToString()
            }).ToList();
        }

    }
}
