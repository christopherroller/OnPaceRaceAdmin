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
    public class EditRunnerViewModel
    {
        private ApplicationContext DbContext { get; set; }
        public RunnerDTO Runner { get; set; }
        public List<SelectListItem> Genders { get; set; } 
        public List<SelectListItem> States { get; set; }
        public List<SelectListItem> ClothingSizes { get; set; }
        public List<SelectListItem> RaceTypes { get; set; }
        public List<RunnerRaceTypeAndPace> RunnerRaceTypes { get; set; }
        public List<SelectListItem> RacePaces { get; set; }

        public EditRunnerViewModel(ApplicationContext context)
        {
            DbContext = context;
        }

        public async Task InitModel(int Id)
        {
            Runner = await GetRunner(Id);
            Genders = GetGenders();
            States = GetStates();
            ClothingSizes = GetClothingSizes(Runner.GenderId);
        }

        private async Task<RunnerDTO> GetRunner(int Id)
        {
            var entity =  await DbContext.Runners.FindAsync(Id);
            DbContext.Entry(entity).Reference(r => r.Gender);
            DbContext.Entry(entity).Reference(r => r.State);
            DbContext.Entry(entity).Reference(r => r.ClothingSize);

            var runner = new RunnerDTO()
            {
                Address = entity.Address,
                City = entity.City,
                ClothingSize = entity.ClothingSize?.Name,
                ClothingSizeId = entity.ClothingSizeId,
                Email = entity.Email,
                FirstName = entity.FirstName,
                Gender = entity.Gender?.Name,
                GenderId = entity.GenderId,
                Id = entity.Id,
                LastName = entity.LastName,
                PhoneNumber = entity.PhoneNumber,
                State = entity.State?.Name,
                StateId = entity.StateId,
                Zipcode = entity.Zipcode,
                Age = entity.Age
                
            };
            return runner;
        }

        private List<SelectListItem> GetGenders()
        {
            return DbContext.Genders.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetStates()
        {
            return DbContext.States.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        private List<SelectListItem> GetClothingSizes(int? genderId)
        {
            if (genderId != null)
            {
                return DbContext.ClothingSizes.Where(w=>w.GenderId.Equals(genderId)).OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
            }
            else
            {
                return DbContext.ClothingSizes.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
            }
        }

        public List<SelectListItem> GetRaceTypes()
        { 
            return DbContext.RaceTypes.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        public List<SelectListItem> GetRacePaces()
        {
            return DbContext.RacePaces.OrderBy(o=>o.Pace).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Pace.ToString() }).ToList();
        }

        public List<RunnerRaceTypeAndPace> GetRunnerRaceTypes(int RunnerId)
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
