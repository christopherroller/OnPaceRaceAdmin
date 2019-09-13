
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.Models.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnPaceRaceAdmin.ViewModels
{
    public class DetailsRunnerViewModel
    {

        private ApplicationContext _context { get; set; }
        public RunnerDTO Runner { get; set; }
        public IEnumerable<RunnerNoteDTO> RunnerNotes { get; set; }
        public List<SelectListItem> RaceTypes { get; set; }
        public List<SelectListItem> RacePaces { get; set; }
        public IEnumerable<RunnerRaceTypeAndPace> RunnerRacePaces { get; set; }

        public DetailsRunnerViewModel(ApplicationContext context)
        {
            _context = context;
        }

        public RunnerDTO GetRunner(int Id)
        {
            var entity = _context.Runners.Include(r => r.Gender).Include(r => r.State).Include(r => r.StatusRunner).Include(r => r.ClothingSize).SingleOrDefault(r => r.Id.Equals(Id));

            var runner = new RunnerDTO()
            {
                Address = entity.Address,
                City = entity.City,
                ClothingSize = entity.ClothingSize?.Name,
                Email = entity.Email,
                FirstName = entity.FirstName,
                Gender = entity.Gender?.Name,
                Id = entity.Id,
                LastName = entity.LastName,
                PhoneNumber = entity.PhoneNumber,
                State = entity.State?.Name,
                Zipcode = entity.Zipcode,
                Age = entity.Age,
                ClothingSizeId = entity.ClothingSizeId,
                GenderId = entity.GenderId,
                StateId = entity.StateId,
                RunnerStatusName = entity.StatusRunner.Name
            };

            return runner;
        }

        public IEnumerable<RunnerNoteDTO> GetRunnersNotes(int Id)
        {
            return _context.RunnerNotes.Where(rn => rn.RunnerId.Equals(Id)).Select(s=> new RunnerNoteDTO
            {
                DateAdded = s.DateAdded,
                Id = s.Id,
                Note = s.Note,
                RunnerId = s.RunnerId
            });
        }

        public IEnumerable<RunnerRaceTypeAndPace> GetRunnerRacesAndPaces(int Id)
        {
            return _context.RunnerToRacePace.Where(r => r.RunnerId == Id).Include(r => r.RaceType).Include(r => r.RacePaceFrom).Include(r => r.RacePaceTo)
                .Select(s => new RunnerRaceTypeAndPace
                {
                    Id = s.Id,
                    RaceTypeId = s.RaceTypeId,
                    RunnerId = s.RunnerId,
                    PaceTimeFrom = s.RacePaceFrom.Pace.ToString("hh:mm"),
                    PaceTimeTo = s.RacePaceTo.Pace.ToString("hh:mm"),
                    PaceTimeFromId = s.RacePaceFromId,
                    PaceTimeToId = s.RacePaceToId,
                    RaceTypeName = s.RaceType.Name              
                });
        }

        public List<SelectListItem> GetRaceTypes()
        {
            return _context.RaceTypes.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList();
        }

        public List<SelectListItem> GetRacePaces()
        {
            return _context.RacePaces.OrderBy(o => o.Pace).Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Pace.ToString() }).ToList();
        }
    }
}
