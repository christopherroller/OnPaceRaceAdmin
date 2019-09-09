using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Data;
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
                var runners = DbContext.Runners.Include(r=>r.Gender).Include(r=>r.State).OrderBy(o=>o.FirstName).ThenBy(o=>o.LastName).ToList();
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
            return View();
        }

        // POST: Runners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber,StateId,Address,Zipcode,GenderId")] Runner runner)
        {
            if (ModelState.IsValid)
            {
                await DbContext.Runners.AddAsync(runner);
                await DbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Details),new { runner.Id});
            }
            return View(runner);
        }

        // GET: Runners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var rvm = new EditRunnerViewModel(DbContext);
                rvm.Runner = await rvm.GetRunner((int)id);
                rvm.States = rvm.GetStates();
                rvm.Genders = rvm.GetGenders();
                rvm.ClothingSizes = rvm.GetClothingSizes(rvm.Runner.GenderId);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,StateId,Address,Zipcode,GenderId")]Runner runner)
        {
            if (id != runner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                DbContext.Runners.Update(runner);                     
            }
            return View(runner);
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
                return Content(note.Note);
            }
            else
            {
                return Json(null);
            }
 
  
        }
    }
}
