
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace OnPaceRaceAdmin.ViewModels
{
    public class DetailsRunnerViewModel
    {

        private ApplicationContext _context { get; set; }
        public RunnerDTO Runner { get; set; }
        public IEnumerable<RunnerNoteDTO> RunnerNotes { get; set; }

        public DetailsRunnerViewModel(ApplicationContext context)
        {
            _context = context;
        }

        public RunnerDTO GetRunner(int Id)
        {
            var entity = _context.Runners.SingleOrDefault(r => r.Id.Equals(Id));
            _context.Entry(entity).Reference(r => r.Gender);
            _context.Entry(entity).Reference(r => r.State);
            _context.Entry(entity).Reference(r => r.ClothingSize);

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
                StateId = entity.StateId
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
    }
}
