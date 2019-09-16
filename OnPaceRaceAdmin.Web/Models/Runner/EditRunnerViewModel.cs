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
        public List<SelectListItem> RunnerStatuses { get; set; }

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
            RunnerStatuses = GetRunnerStatuses();
        }

        private async Task<RunnerDTO> GetRunner(int Id)
        {
            var entity =  await DbContext.Runners.FindAsync(Id);
            DbContext.Entry(entity).Reference(r => r.Gender);
            DbContext.Entry(entity).Reference(r => r.State);
            DbContext.Entry(entity).Reference(r => r.ClothingSize);
            DbContext.Entry(entity).Reference(r => r.StatusRunner);

            var runner = new RunnerDTO().MapToDTO(entity);
            runner.ClothingSize = entity.ClothingSize?.Name;
            runner.ClothingSizeId = entity.ClothingSizeId;
            runner.State = entity.State?.Name;
            runner.RunnerStatusName = entity.StatusRunner?.Name ?? DbContext.StatusRunners.FirstOrDefault(s=>s.IsActive == true).Name;             
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

        private List<SelectListItem> GetRunnerStatuses()
        { 
            return DbContext.StatusRunners.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }
    }
}
