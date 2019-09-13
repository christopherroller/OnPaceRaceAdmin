using System;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
using OnPaceRaceAdmin.Models;
using OnPaceRaceAdmin.ViewModels;

namespace OnPaceRaceAdmin.Web.Controllers
{
    public class RunnersController : Controller
    {
        private ApplicationContext DbContext { get; set; }
        public RunnersController(ApplicationContext context)
        {
            DbContext = context;
        }

        // GET: Runners
        public IActionResult Index()
        {

            try
            {
                var runners = DbContext.Runners.Include(r=>r.Gender).Include(r=>r.State).Include(r=>r.StatusRunner).OrderBy(o=>o.FirstName).ThenBy(o=>o.LastName)
                    .Select(s=>new RunnerDTO {
                      FirstName = s.FirstName,
                      LastName = s.LastName,
                      Id = s.Id,
                      GenderId = s.GenderId,
                      Gender = s.Gender.Name,
                      Email = s.Email,
                      State = s.State.Name,
                      PhoneNumber = s.PhoneNumber,
                      StateId = s.StateId,
                      RunnerStatusId = s.RunnerStatusId,
                      RunnerStatusName = s.StatusRunner.Name

                    });
                return View(runners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: Runners/Details/5
        public IActionResult Details(int? id)
        {
            if(id != null)
            {
                var rvm = new DetailsRunnerViewModel(DbContext);
                rvm.Runner = rvm.GetRunner((int)id);
                rvm.RunnerNotes = rvm.GetRunnersNotes((int)id);
                rvm.RacePaces = rvm.GetRacePaces();
                rvm.RaceTypes = rvm.GetRaceTypes();
                rvm.RunnerRacePaces = rvm.GetRunnerRacesAndPaces((int)id);
                return View(rvm);
            }
            else
            {
                return StatusCode(401, "Runner not found");
            }
        }

        // GET: Runners/Create
        public IActionResult Create()
        {
            var rvm = new CreateRunnerViewModel(DbContext);
            rvm.InitModel();
            return View(rvm);
        }

        // POST: Runners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,PhoneNumber,StateId,Address,Zipcode,GenderId,ClothingSizeId,Age")] RunnerDTO runner)
        {
            if (ModelState.IsValid)
            {
                var entity = new Runner()
                {
                    StateId = runner.StateId,
                    Address = runner.Address,
                    City = runner.City,
                    FirstName = runner.FirstName,
                    LastName = runner.LastName,
                    Email = runner.Email,
                    PhoneNumber = runner.PhoneNumber,
                    Age = runner.Age,
                    ClothingSizeId = runner.ClothingSizeId,
                    GenderId = runner.GenderId,
                    Zipcode = runner.Zipcode,
                    RunnerStatusId = DbContext.StatusRunners.FirstOrDefault(s=>s.IsActive == true).Id
                };
                DbContext.Runners.Add(entity);
                await DbContext.SaveChangesAsync();
                runner.Id = entity.Id;
                return RedirectToAction(nameof(Details),new { runner.Id});
            }
            var rvm = new CreateRunnerViewModel(DbContext);
            rvm.InitModel();
            rvm.Runner = runner;
            return View(rvm);
        }

        // GET: Runners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var rvm = new EditRunnerViewModel(DbContext);
                rvm.InitModel((int)id);

                rvm.RacePaces = rvm.GetRacePaces();
                rvm.RaceTypes = rvm.GetRaceTypes();
                rvm.RunnerRaceTypes = rvm.GetRunnerRaceTypes(rvm.Runner.Id);
                return View(rvm);
            }
            else
            {
                return StatusCode(401, "Runner not found");
            }
        }

        // POST: Runners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,FirstName,LastName,Email,PhoneNumber,StateId,Address,Zipcode,GenderId,Address,City,StateId,Zipcode")]RunnerDTO runner)
        {
            if (runner.Id == 0 || runner.Id == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            if (ModelState.IsValid)
            {
                var entity = await DbContext.Runners.FindAsync(runner.Id);
                entity.StateId = runner.StateId;
                entity.Address = runner.Address;
                entity.City = runner.City;
                entity.FirstName = runner.FirstName;
                entity.LastName = runner.LastName;
                entity.Email = runner.Email;
                entity.PhoneNumber = runner.PhoneNumber;
                DbContext.Runners.Update(entity);
                await DbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { Id = runner.Id });
            }
            else
            {
                var rvm = new EditRunnerViewModel(DbContext);
                rvm.InitModel((int)runner.Id);
                return View();
            }

        }

        // GET: Runners/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var runner = DbContext.Runners.Find((int)id);
        
            if (runner == null)
            {
                return NotFound();
               
            }
            return View(runner);
        }

        // POST: Runners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var runner = await DbContext.Runners.FindAsync((int)id);
            if(runner != null)
            {
                DbContext.Remove(runner);
                await DbContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("AddNote")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNote(string RunnerNote, int RunnerId)
        {
            var runner = DbContext.Runners.Find(RunnerId);
            if(runner != null)
            {

                var note = new RunnerNote()
                {
                    Note = RunnerNote,
                    RunnerId = RunnerId,
                    DateAdded = DateTime.UtcNow
                };
                await DbContext.RunnerNotes.AddAsync(note);
                await DbContext.SaveChangesAsync();

                var notes = DbContext.RunnerNotes.Where(r => r.RunnerId == RunnerId).Select(s => new RunnerNoteDTO
                {
                    Note = s.Note,
                    DateAdded = s.DateAdded,
                    Id = s.Id
                });
                return View("_RunnerNotes",notes);
            }
            else
            {
                return Json(null);
            }
        }

        [HttpPost, ActionName("DeleteNote")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteNote(int NoteId)
        {
            var note = DbContext.RunnerNotes.Find(NoteId);
            DbContext.RunnerNotes.Remove(note);
            await DbContext.SaveChangesAsync();
            return Json(note.Id);
        }

        [HttpPost, ActionName("AddRacePaceAndRaceType")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRacePaceAndRaceType(int RunnerId, int RaceTypeId, int RacePaceFromId, int RacePaceToId)
        {
            if(RunnerId != null && RaceTypeId != null)
            {
                var entity = DbContext.RunnerToRacePace.AddAsync(new RunnerToRacePace
                {
                    RaceTypeId = RaceTypeId,
                    RunnerId = RunnerId,
                    RacePaceFromId = RacePaceFromId,
                    RacePaceToId = RacePaceToId,               
                });
                await DbContext.SaveChangesAsync();

                var racePaces = DbContext.RunnerToRacePace.Include(i => i.RacePaceFrom).Include(i => i.RacePaceTo).Include(i => i.RaceType).Where(w => w.RunnerId.Equals(RunnerId)).Select(s => new RunnerRaceTypeAndPace
                {
                    Id = s.Id,
                    RunnerId = s.RunnerId,
                    RaceTypeId = s.RaceTypeId,
                    RaceTypeName = s.RaceType.Name,
                    PaceTimeFrom = s.RacePaceFrom.Pace.ToString(),
                    PaceTimeTo = s.RacePaceTo.Pace.ToString()
                }).ToList();
                
                return View("_RaceLengthAndPaceSelector", racePaces);
            }
            else
            {
                return Json(null);
            }
        }
    }
}
