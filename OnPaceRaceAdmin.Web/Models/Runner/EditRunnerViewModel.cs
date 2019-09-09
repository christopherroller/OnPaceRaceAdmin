using Microsoft.AspNetCore.Mvc.Rendering;
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

        public EditRunnerViewModel(ApplicationContext context)
        {
            DbContext = context;
        }



        public async Task<RunnerDTO> GetRunner(int Id)
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

        public List<SelectListItem> GetGenders()
        {
            return DbContext.Genders.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        public List<SelectListItem> GetStates()
        {
            return DbContext.States.OrderBy(o => o.Name).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        public List<SelectListItem> GetClothingSizes(int? genderId)
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

    }
}
